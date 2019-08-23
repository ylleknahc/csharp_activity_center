using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private BeltExamContext dbContext;

        public HomeController(BeltExamContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("users")]
        public IActionResult Register(LoginRegViewModel modelData)
        {
            User user = modelData.RegUser;

            if (ModelState.IsValid)
            {
                if (dbContext.users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("RegUser.Email", "Email is already in use");
                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                dbContext.Add(user);
                dbContext.SaveChanges();

                var GetNewUser = dbContext.users.FirstOrDefault(u => u.UserId == user.UserId);
                HttpContext.Session.SetInt32("UserId", GetNewUser.UserId);

                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult LoginUser(LoginRegViewModel modelData)
        {
            LoginUser user = modelData.LogUser;

            if (ModelState.IsValid)
            {
                var GetUser = dbContext.users.FirstOrDefault(u => u.Email == user.Email);
                if (GetUser == null)
                {
                    ModelState.AddModelError("LogUser.Email", "Invalid email");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, GetUser.Password, user.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("LogUser.Password", "Password is incorrect");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("UserId", GetUser.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        public User FetchAuthorizedUser()
        {
            int userId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));
            User user = dbContext.users.Include(u => u.HangoutsCreated).Include(u => u.HangoutsAsParticipants).FirstOrDefault(u => u.UserId == userId);
            return user;
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpGet("home")]
        public IActionResult Dashboard()
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            User user = FetchAuthorizedUser();
            List<Hangout> hangouts = dbContext.hangouts.Include(h => h.Creator).Include(h => h.HangoutParticipants).ThenInclude(h => h.Participant).OrderBy(h => h.Date).ToList();
            List<Hangout> pastHangouts = hangouts.Where(h => Convert.ToDateTime(h.Date).Subtract(DateTime.Now).TotalDays < 0 && Convert.ToDateTime(h.Time).Subtract(DateTime.Now).TotalMinutes < 0).ToList();
            if (pastHangouts.Count > 0)
            {
                foreach (var pastHang in pastHangouts)
                {
                    Console.WriteLine("***************");
                    Console.WriteLine(pastHang.Date);
                }
            }
            hangouts = hangouts.Except(pastHangouts).ToList();
            HangoutUserViewModel modelData = new HangoutUserViewModel();
            modelData.User = user;
            modelData.Hangouts = hangouts;
            return View("Dashboard", modelData);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpPost("create")]
        public IActionResult CreateHangout(HangoutUserViewModel formData)
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            User user = FetchAuthorizedUser();
            Hangout hangout = formData.Hangout;
            if (ModelState.IsValid)
            {
                hangout.CreatorId = user.UserId;
                dbContext.Add(hangout);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("New");
        }

        [HttpGet("activity/{hangoutId}")]
        public IActionResult Show(int hangoutId)
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            User user = FetchAuthorizedUser();
            Hangout hangout = dbContext.hangouts.Include(h => h.Creator).Include(h => h.HangoutParticipants).ThenInclude(h => h.Participant).FirstOrDefault(h => h.HangoutId == hangoutId);

            HangoutUserViewModel modelData = new HangoutUserViewModel();
            modelData.Hangout = hangout;
            modelData.User = user;
            return View("Show", modelData);
        }

        [HttpGet("activity/{hangoutId}/delete")]
        public IActionResult Delete(int hangoutId)
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            Hangout hangout = dbContext.hangouts.FirstOrDefault(h => h.HangoutId == hangoutId);
            dbContext.hangouts.Remove(hangout);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("activity/{hangoutId}/join")]
        public IActionResult Join(int hangoutId)
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            User user = FetchAuthorizedUser();
            // Hangout hangout = dbContext.hangouts.Include(h => h.Creator).Include(h => h.HangoutParticipants).ThenInclude(h => h.Participant).FirstOrDefault(h => h.HangoutId == hangoutId);
            Hangout hangout = dbContext.hangouts.FirstOrDefault(h => h.HangoutId == hangoutId);
            if (user.HangoutsAsParticipants.Any(h => h.HangoutId == hangoutId))
            {
                Console.WriteLine("**********user is already participating*****");
                return RedirectToAction("Dashboard");
            }

            HangoutParticipants newHangPart = new HangoutParticipants();

            newHangPart.ParticipantId = user.UserId;
            newHangPart.HangoutId = hangoutId;
            dbContext.Add(newHangPart);
            dbContext.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("activity/{hangoutId}/leave")]
        public IActionResult Leave(int hangoutId)
        {
            if (FetchAuthorizedUser() == null)
            {
                return RedirectToAction("Index");
            }
            User user = FetchAuthorizedUser();
            List<HangoutParticipants> hangoutPart = dbContext.hangoutParticipants.Where(h => h.HangoutId == hangoutId && h.ParticipantId == user.UserId).ToList();

            if (user.HangoutsAsParticipants.Any(h => h.HangoutId == hangoutId))
            {
                dbContext.hangoutParticipants.Remove(hangoutPart[0]);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }
    }
}

#pragma checksum "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb513d61e139e11ec69aab8c2ca1535b76e8264"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 1 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb513d61e139e11ec69aab8c2ca1535b76e8264", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HangoutUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Show.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary inline join-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(85, 258, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e82645796", async() => {
                BeginContext(91, 199, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Belt Exam Show</title>\n    ");
                EndContext();
                BeginContext(290, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aeb513d61e139e11ec69aab8c2ca1535b76e82646383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(335, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(343, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(344, 2168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e82648475", async() => {
                BeginContext(350, 576, true);
                WriteLiteral(@"
    <div class=""container"">
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <div class=""collapse navbar-collapse"" id=""navbarNav"">
            <h1>Dojo Activity Center</h1>
            <ul id=""nav"" class=""navbar-nav"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""/home"">Home</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""/logout"">Logout</a>
                </li>
            </ul>
        </div>
        </nav>
        <h3 class=""inline"">");
                EndContext();
                BeginContext(927, 19, false);
#line 28 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                      Write(Model.Hangout.Title);

#line default
#line hidden
                EndContext();
                BeginContext(946, 6, true);
                WriteLiteral("</h3>\n");
                EndContext();
#line 29 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
         if (Model.Hangout.CreatorId == Model.User.UserId)
        {

#line default
#line hidden
                BeginContext(1021, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(1033, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e826410082", async() => {
                    BeginContext(1165, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hangoutId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 31 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                                                                                    WriteLiteral(Model.Hangout.HangoutId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hangoutId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1175, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 32 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 35 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
             if (Model.Hangout.HangoutParticipants.Count > 0)
            {
                

#line default
#line hidden
#line 37 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                 if (Model.Hangout.HangoutParticipants.Any(h => h.Participant.UserId == Model.User.UserId))
                {

#line default
#line hidden
                BeginContext(1411, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1431, 140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e826413550", async() => {
                    BeginContext(1562, 5, true);
                    WriteLiteral("Leave");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hangoutId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 39 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                                                                                           WriteLiteral(Model.Hangout.HangoutId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hangoutId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1571, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 40 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1629, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1649, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e826416620", async() => {
                    BeginContext(1779, 4, true);
                    WriteLiteral("Join");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hangoutId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 43 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                                                                                          WriteLiteral(Model.Hangout.HangoutId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hangoutId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1787, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 44 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                }

#line default
#line hidden
#line 44 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                 
            }
            else
            {

#line default
#line hidden
                BeginContext(1851, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1867, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb513d61e139e11ec69aab8c2ca1535b76e826419806", async() => {
                    BeginContext(1997, 4, true);
                    WriteLiteral("Join");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-hangoutId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 48 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                                                                                      WriteLiteral(Model.Hangout.HangoutId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-hangoutId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["hangoutId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2005, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 49 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
            }

#line default
#line hidden
#line 49 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
             
        }

#line default
#line hidden
                BeginContext(2030, 74, true);
                WriteLiteral("        <div class=\"activity-details\">\n            <h5>Event Coordinator: ");
                EndContext();
                BeginContext(2105, 31, false);
#line 52 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                              Write(Model.Hangout.Creator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2136, 55, true);
                WriteLiteral("</h5>\n            <h5>Description:</h5>\n            <p>");
                EndContext();
                BeginContext(2192, 25, false);
#line 54 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
          Write(Model.Hangout.Description);

#line default
#line hidden
                EndContext();
                BeginContext(2217, 56, true);
                WriteLiteral("</p>\n            <h5>Participants</h5>\n            <ul>\n");
                EndContext();
#line 57 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                 foreach (var hangparticipant in Model.Hangout.HangoutParticipants)
                {

#line default
#line hidden
                BeginContext(2375, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(2400, 37, false);
#line 59 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                   Write(hangparticipant.Participant.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(2437, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 60 "/Users/kelly/Desktop/CD/C#/BeltExam/Views/Home/Show.cshtml"
                }

#line default
#line hidden
                BeginContext(2461, 44, true);
                WriteLiteral("            </ul>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2512, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HangoutUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

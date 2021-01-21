#pragma checksum "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf66e75df2780853084e1edf9a208b19b3d1e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Stories), @"mvc.1.0.view", @"/Views/Home/Stories.cshtml")]
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
#nullable restore
#line 1 "E:\Projects\BodiesPilates\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BodiesPilates\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf66e75df2780853084e1edf9a208b19b3d1e7b", @"/Views/Home/Stories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Stories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.StoriesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container section-header\">\r\n    <h2>What My Amazing Clients Say</h2>\r\n</div>\r\n");
#nullable restore
#line 6 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container feedbacks-container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
           
            string bg_css = "bg-red";
            string name_css = Model.ShowFullStories ? "right-bottom" : "align-bottom";
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
         foreach (var story in Model.Stories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"feedback-item-wrapper\"");
            BeginWriteAttribute("class", " class=\"", 465, "\"", 503, 3);
            WriteAttributeValue("", 473, "col-md-4", 473, 8, true);
            WriteAttributeValue(" ", 481, "feedback-item", 482, 14, true);
#nullable restore
#line 15 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
WriteAttributeValue(" ", 495, bg_css, 496, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"feedback-content\">\r\n                    <span>\r\n                        <em>\r\n                            <span>");
#nullable restore
#line 19 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
                                   if (Model.ShowFullStories)
                                Html.Raw(story.FullStory);
                            else
                                Html.Raw(story.ShortStory);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </em>\r\n                        <br />\r\n                        <strong");
            BeginWriteAttribute("class", " class=\"", 962, "\"", 979, 1);
#nullable restore
#line 26 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
WriteAttributeValue("", 970, name_css, 970, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
                                             Write(story.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "E:\Projects\BodiesPilates\Web\Views\Home\Stories.cshtml"
            if (bg_css == "bg-red")
                bg_css = "bg-blue";
            else
                bg_css = "bg-red";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"section-header\">\r\n        <a class=\"action-button black-reverse-button\" href=\"/success-stories\">READ MORE STORIES</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.StoriesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

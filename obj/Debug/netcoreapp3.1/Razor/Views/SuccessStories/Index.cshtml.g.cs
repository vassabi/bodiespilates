#pragma checksum "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "decf5aaa50997bec3d7ba3f91f37aefca42b53db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuccessStories_Index), @"mvc.1.0.view", @"/Views/SuccessStories/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decf5aaa50997bec3d7ba3f91f37aefca42b53db", @"/Views/SuccessStories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_SuccessStories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.StoriesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
  
    ViewData["Title"] = "Success Stories";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""white-big-copy-section bg-orange section-content"">
    <h1>
        Success Stories
    </h1>
    <p>What my amazing clients say</p>
</div>
<div class=""container section-header"">
</div>
<div class=""container feedbacks-container"">
    <div class=""row"">
");
#nullable restore
#line 16 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
          
            string bg_css = "bg-red";
            string name_css = Model.ShowFullStories ? "right-bottom" : "align-bottom";
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
         foreach (var story in Model.Stories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"feedback-item-wrapper\"");
            BeginWriteAttribute("class", " class=\"", 614, "\"", 643, 2);
            WriteAttributeValue("", 622, "feedback-item", 622, 13, true);
#nullable restore
#line 22 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
WriteAttributeValue(" ", 635, bg_css, 636, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"feedback-content\">\r\n                    <span>\r\n");
#nullable restore
#line 25 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                         if (Model.ShowFullStories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <em>");
#nullable restore
#line 27 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                           Write(story.FullStory);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</em>\r\n");
#nullable restore
#line 28 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <em>");
#nullable restore
#line 31 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                           Write(story.ShortStory);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</em>\r\n");
#nullable restore
#line 32 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                    <br />\r\n                    <h2 class=\"right-bottom\">");
#nullable restore
#line 35 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
                                        Write(story.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "E:\Projects\BodiesPilates\Web\Views\SuccessStories\Index.cshtml"
            if (bg_css == "bg-red")
                bg_css = "bg-blue";
            else
                bg_css = "bg-red";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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

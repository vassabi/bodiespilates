#pragma checksum "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46af4b9e4e70a1500307a73914a98fac695bded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminArea_EditUser), @"mvc.1.0.view", @"/Views/AdminArea/EditUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46af4b9e4e70a1500307a73914a98fac695bded", @"/Views/AdminArea/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminArea_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.AdminAreaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/AdminArea/AdminToolbar.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
  
    ViewData["Title"] = "Admin Area (Edit User)";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"white-big-copy-section bg-orange section-content\">\r\n        <h1>\r\n            Admin Area (Users)\r\n        </h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a46af4b9e4e70a1500307a73914a98fac695bded3738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
#nullable restore
#line 14 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
     using (Html.BeginForm("SaveUser", "AdminArea", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-card-full\">\r\n            <div class=\"form-card-inner\">\r\n                <div class=\"form-group\"><h3>Update ");
#nullable restore
#line 18 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                                              Write(Html.DisplayFor(m => m.UserModel.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s details</h3></div>\r\n                <div class=\"form-row mb-4\">\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 21 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserModel.User.FirstName, new { @class = "form-control", @placeholder = "First name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 24 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserModel.User.LastName, new { @class = "form-control", @placeholder = "Last name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group""><small>Leave these fields blank if you do not want to reset user's password</small></div>
                <div class=""form-row mb-4"">
                    <div class=""col"">
                        ");
#nullable restore
#line 30 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserModel.User.Password, new { @class = "form-control", @placeholder = "New password", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 33 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserModel.User.RepeatPassword, new { @class = "form-control", @placeholder = "Repeat password", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-row mb-4\">\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 38 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.TextBoxFor(m => m.UserModel.User.Email, new { @class = "form-control", @placeholder = "Email address" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 41 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.DropDownListFor(m => m.UserModel.User.RoleId, new SelectList(ViewBag.RolesList.Items, "ID", "Name"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-row mb-4\">\r\n                    <div class=\"col\">\r\n                        ");
#nullable restore
#line 46 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
                   Write(Html.HiddenFor(m => m.UserModel.User.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n                    </div>\r\n                    <div class=\"col\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "E:\Projects\BodiesPilates\Web\Views\AdminArea\EditUser.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.AdminAreaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

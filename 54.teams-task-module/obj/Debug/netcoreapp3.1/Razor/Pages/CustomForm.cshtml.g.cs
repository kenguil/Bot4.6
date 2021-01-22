#pragma checksum "D:\Programming\Git\Bot4.6\54.teams-task-module\Pages\CustomForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819763802f35d50b05a6c6461d521e324db93814"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CustomForm), @"mvc.1.0.razor-page", @"/Pages/CustomForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819763802f35d50b05a6c6461d521e324db93814", @"/Pages/CustomForm.cshtml")]
    public class Pages_CustomForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Programming\Git\Bot4.6\54.teams-task-module\Pages\CustomForm.cshtml"
  
    ViewData["Title"] = "CustomForm";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819763802f35d50b05a6c6461d521e324db938142921", async() => {
                WriteLiteral("\r\n    <style>\r\n        body {\r\n            margin: 0;\r\n            padding-left: 4px;\r\n            padding-right: 4px;\r\n        }\r\n    </style>\r\n    <title>Microsoft Teams Task Module Tester - Custom Form</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "819763802f35d50b05a6c6461d521e324db938144115", async() => {
                WriteLiteral(@"
    <script>
        microsoftTeams.initialize();
        function validateForm() {
            var customerInfo = {
                name: document.forms[""customerForm""][""name""].value,
                email: document.forms[""customerForm""][""email""].value,
                favoriteBook: document.forms[""customerForm""][""favoriteBook""].value
            }
            microsoftTeams.tasks.submitTask(customerInfo, """);
#nullable restore
#line 28 "D:\Programming\Git\Bot4.6\54.teams-task-module\Pages\CustomForm.cshtml"
                                                      Write(Model.MicrosoftAppId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
            return true;
        }
    </script>
    <div class=""surface theme-light"">
        <div class=""panel"">
            <div class=""font-semibold font-title"">Enter new customer information:</div>
            <form method=""POST"" id=""customerForm"" onSubmit=""return validateForm()"">
                <div>
                    <div class=""form-group form-field-input"" style=""margin-bottom: 10px; margin-top: 10px;""></div><label for=""name"">Name: </label><input class=""form-control input-field"" id=""name"" type=""text"" placeholder=""first and last"" name=""name"" tabindex=""1"" autofocus>
                    <div class=""form-group form-field-input"" style=""margin-bottom: 10px;""></div><label for=""email"">Email: </label><input class=""form-control input-field"" id=""email"" type=""email"" placeholder=""name@email.com"" name=""email"" tabindex=""2"">
                    <div class=""form-group form-field-input"" style=""margin-bottom: 10px;""></div><label for=""favoriteBook"">Favorite book: </label><input class=""form-control input");
                WriteLiteral(@"-field"" id=""favoriteBook"" type=""text"" placeholder=""title of book"" name=""favoriteBook"" tabindex=""3"">
                    <div class=""form-group form-field-input"" style=""margin-bottom: 10px;""></div><label for=""pw"">Password: </label><input class=""form-control input-field"" id=""pw"" type=""password"" name=""password"" tabindex=""4"">
                    <div class=""form-group form-field-input"" style=""margin-bottom: 10px;""></div><label for=""pw2"">Confirm password: </label><input class=""form-control input-field"" id=""pw2"" type=""password"" name=""confirmPassword"" style=""margin-bottom: 10px;"" tabindex=""4"">
                    <button class=""btn button-primary"" type=""submit"" tabindex=""5"">Sign up</button>
                </div>
            </form>
        </div>
    </div>
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microsoft.BotBuilderSamples.Pages.CustomFormModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Microsoft.BotBuilderSamples.Pages.CustomFormModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Microsoft.BotBuilderSamples.Pages.CustomFormModel>)PageContext?.ViewData;
        public Microsoft.BotBuilderSamples.Pages.CustomFormModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

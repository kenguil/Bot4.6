#pragma checksum "D:\Programming\Git\BotBuilder-Samples\samples\csharp_dotnetcore\54.teams-task-module\Pages\YouTube.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bcb765983d9a0007adcc2e6c963b65c916b9a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_YouTube), @"mvc.1.0.razor-page", @"/Pages/YouTube.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bcb765983d9a0007adcc2e6c963b65c916b9a1f", @"/Pages/YouTube.cshtml")]
    public class Pages_YouTube : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programming\Git\BotBuilder-Samples\samples\csharp_dotnetcore\54.teams-task-module\Pages\YouTube.cshtml"
  
    ViewData["Title"] = "YouTube";
    Layout = "~/Pages/Shared/_EmbedPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<iframe width=\"1000\" height=\"700\" src=\"https://www.youtube.com/embed/r9WQPSaLnaU\" frameborder=\"0\" allow=\"autoplay; encrypted-media\" allowfullscreen=\"allowfullscreen\"></iframe>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_YouTube> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_YouTube> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_YouTube>)PageContext?.ViewData;
        public Pages_YouTube Model => ViewData.Model;
    }
}
#pragma warning restore 1591

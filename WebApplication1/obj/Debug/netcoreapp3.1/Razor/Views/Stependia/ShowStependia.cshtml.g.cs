#pragma checksum "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d639354c5a697c22b5c2aa936dc18077fa7b15d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stependia_ShowStependia), @"mvc.1.0.view", @"/Views/Stependia/ShowStependia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d639354c5a697c22b5c2aa936dc18077fa7b15d", @"/Views/Stependia/ShowStependia.cshtml")]
    public class Views_Stependia_ShowStependia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Storege.Entity.Stependia>>
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
#line 2 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d639354c5a697c22b5c2aa936dc18077fa7b15d3003", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowStependia</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d639354c5a697c22b5c2aa936dc18077fa7b15d4070", async() => {
                WriteLiteral("\r\n    <h1>Stependias</h1>\r\n    <div>\r\n");
#nullable restore
#line 16 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Stependia</label>\r\n");
#nullable restore
#line 20 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
       Write(item.Kek);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 394, "\"", 436, 2);
                WriteAttributeValue("", 401, "/Stependia/UpdateStependia/", 401, 27, true);
#nullable restore
#line 21 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
WriteAttributeValue("", 428, item.Id, 428, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 464, "\"", 503, 2);
                WriteAttributeValue("", 471, "/Stependia/DelStependia/", 471, 24, true);
#nullable restore
#line 22 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
WriteAttributeValue("", 495, item.Id, 495, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Del</a><br />\r\n");
#nullable restore
#line 23 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
         using (Html.BeginForm("AddStependia", "Stependia"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <input type=\"submit\" value=\"add\" />\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
#nullable restore
#line 31 "C:\Users\Алексей\source\repos\WebApplication1\Views\Stependia\ShowStependia.cshtml"
   Write(Html.ActionLink("Nazad", "ShowStudent", "Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Storege.Entity.Stependia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
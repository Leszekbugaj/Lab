#pragma checksum "C:\Users\crast\Documents\GitHub\Lab\NewBrandingStyle.Web\Views\Shared\Components\ItemList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52fff425e75033d130b47b0825e37c7772dcc75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ItemList_Index), @"mvc.1.0.view", @"/Views/Shared/Components/ItemList/Index.cshtml")]
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
#line 1 "C:\Users\crast\Documents\GitHub\Lab\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crast\Documents\GitHub\Lab\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\crast\Documents\GitHub\Lab\NewBrandingStyle.Web\Views\Shared\Components\ItemList\Index.cshtml"
using NewBrandingStyle.Web.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52fff425e75033d130b47b0825e37c7772dcc75", @"/Views/Shared/Components/ItemList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f0e01d906794e7d20db596d96f08e9d5ca555d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ItemList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>Latest item added: ");
#nullable restore
#line 3 "C:\Users\crast\Documents\GitHub\Lab\NewBrandingStyle.Web\Views\Shared\Components\ItemList\Index.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
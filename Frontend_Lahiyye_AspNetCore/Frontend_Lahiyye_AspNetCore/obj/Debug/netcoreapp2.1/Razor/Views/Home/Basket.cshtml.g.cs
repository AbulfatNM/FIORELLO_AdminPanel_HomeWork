#pragma checksum "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38d23a16cd39a1b939c9e001d0a40c4f98c12656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Basket), @"mvc.1.0.view", @"/Views/Home/Basket.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Basket.cshtml", typeof(AspNetCore.Views_Home_Basket))]
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
#line 1 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\_ViewImports.cshtml"
using Frontend_Lahiyye_AspNetCore.Models;

#line default
#line hidden
#line 2 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\_ViewImports.cshtml"
using Frontend_Lahiyye_AspNetCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38d23a16cd39a1b939c9e001d0a40c4f98c12656", @"/Views/Home/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233f4d300768616b1581b8586a764ad48b65ebe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px; height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
      
        ViewData["Title"] = "Basket";
    

#line default
#line hidden
            BeginContext(93, 1333, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">

           
            <div class=""col-lg-12 card_hover"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Basket Product</h4>
                        <div class=""table-responsive"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>
                                            Image
                                        </th>
                                        <th>
                                            Product Name
                                        </th>
                                        <th>
                                            Price
                                        </th>
                                        <th>
                                           Count
                 ");
            WriteLiteral(@"                       </th>
                                        <th>
                                            Remove product
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 36 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                     foreach (BasketProductVM Prod in Model)
                                    {

#line default
#line hidden
            BeginContext(1543, 145, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"py-1\">\r\n                                            ");
            EndContext();
            BeginContext(1688, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76a220ca63dc4e62975fcf1bca779001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1732, "~/images/", 1732, 9, true);
#line 40 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
AddHtmlAttributeValue("", 1741, Prod.Image, 1741, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1768, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1908, 10, false);
#line 43 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                       Write(Prod.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 140, true);
            WriteLiteral(";\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2059, 10, false);
#line 46 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                       Write(Prod.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2069, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2209, 10, false);
#line 49 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                       Write(Prod.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2219, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2358, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc9e359143d6452ab095683191a45f73", async() => {
                BeginContext(2466, 6, true);
                WriteLiteral("Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                                                                           WriteLiteral(Prod.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2476, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Abulfat\Desktop\FIORELLO_AdminPanel_HomeWork\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Home\Basket.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2607, 216, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

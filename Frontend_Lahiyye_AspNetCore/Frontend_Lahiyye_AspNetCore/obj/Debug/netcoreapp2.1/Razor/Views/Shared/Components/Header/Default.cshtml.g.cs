#pragma checksum "C:\Users\Abulfat\Desktop\p507-13-06-2020-viewcomponent-pagination-AbulfatNM\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d83338d446a63e69e60d5c204adffe8c776fa07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Header/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Header_Default))]
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
#line 1 "C:\Users\Abulfat\Desktop\p507-13-06-2020-viewcomponent-pagination-AbulfatNM\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\_ViewImports.cshtml"
using Frontend_Lahiyye_AspNetCore.Models;

#line default
#line hidden
#line 2 "C:\Users\Abulfat\Desktop\p507-13-06-2020-viewcomponent-pagination-AbulfatNM\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\_ViewImports.cshtml"
using Frontend_Lahiyye_AspNetCore.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d83338d446a63e69e60d5c204adffe8c776fa07", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233f4d300768616b1581b8586a764ad48b65ebe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 215, true);
            WriteLiteral("<header id=\"Navbar\">\r\n    <div class=\"container containerPosetion\">\r\n        <div class=\"row mt-5\">\r\n            <div class=\"col-lg-12 colFlex\">\r\n                <div class=\"logo\">\r\n                    <a href=\"#\"> ");
            EndContext();
            BeginContext(227, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5dbfe5b90d7d4918ba4315f0312a72d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 237, "~/images/", 237, 9, true);
#line 7 "C:\Users\Abulfat\Desktop\p507-13-06-2020-viewcomponent-pagination-AbulfatNM\Frontend_Lahiyye_AspNetCore\Frontend_Lahiyye_AspNetCore\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 246, Model.Logo, 246, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(267, 1731, true);
            WriteLiteral(@"</a>
                </div>
                <div class=""menu mt-2"">
                    <ul>
                        <li class=""home"">
                            <a href=""#"">Home</a>
                            <div class=""homeMenu color invisible"">
                                <ul>
                                    <li><a href=""#"">Main Home</a></li>
                                    <li><a href=""#"">Grid Home</a></li>
                                    <li><a href=""#"">Flower Shop</a></li>
                                    <li><a href=""#"">Animated Slider</a></li>
                                    <li><a href=""#"">Metro Showcase</a></li>
                                    <li><a href=""#"">Carousel Showcase</a></li>
                                    <li><a href=""#"">Landing</a></li>
                                </ul>
                            </div>
                        </li>
                        <li id=""Pages"">
                            <a href=""#"">Pages</a>
       ");
            WriteLiteral(@"                     <div class=""pagesMenu color invisible"">
                                <ul>
                                    <li><a href=""#"">About Us</a></li>
                                    <li><a href=""#"">FAQ Page</a></li>
                                    <li><a href=""#"">Contact Us</a></li>
                                </ul>
                            </div>
                        </li>
                        <li id=""Shop"">
                            <a href=""#"">Shop</a>
                            <div class=""shopMenu color"">
                                <ul>
                                    <h4>Product Types</h4>
                                    <li>");
            EndContext();
            BeginContext(1998, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421cc6543ad54cfe8427219872242bb2", async() => {
                BeginContext(2045, 11, true);
                WriteLiteral("All Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2060, 11827, true);
            WriteLiteral(@"</li>
                                    <li><a href=""#"">Grouped Product</a></li>
                                    <li><a href=""#"">Variable Product</a></li>
                                    <li><a href=""#"">Virtual Product</a></li>
                                    <li><a href=""#"">External Product</a></li>
                                    <li><a href=""#"">Downloadable Product</a></li>
                                    <li><a href=""#"">On Sale Product</a></li>
                                    <li><a href=""#"">Out of Stock Product</a></li>
                                    <li><a href=""#"">New Product</a></li>
                                </ul>
                                <ul>
                                    <h4>Shop Pages</h4>
                                    <li><a href=""#"">My Account</a></li>
                                    <li><a href=""#"">Cart</a></li>
                                    <li><a href=""#"">Checkout</a></li>
                                    <li>");
            WriteLiteral(@"<a href=""#"">Orders</a></li>
                                    <li><a href=""#"">Downloads</a></li>
                                </ul>
                                <ul>
                                    <h4>Shop Types</h4>
                                    <li><a href=""#"">Product List</a></li>
                                    <li><a href=""#"">Without Sidebar</a></li>
                                    <li><a href=""#"">With Category Filter</a></li>
                                    <li><a href=""#"">With Ordering Filter</a></li>
                                    <li><a href=""#"">Shop Carousel</a></li>
                                    <li><a href=""#"">Product Categories</a></li>
                                    <li><a href=""#"">Single Category</a></li>
                                </ul>
                                <ul>
                                    <h4>Shop Layouts</h4>
                                    <li><a href=""#"">Two Columns Grid</a></li>
                    ");
            WriteLiteral(@"                <li><a href=""#"">Three Columns Grid</a></li>
                                    <li><a href=""#"">Four Columns Grid</a></li>
                                    <li><a href=""#"">Five Columns Wide</a></li>
                                    <li><a href=""#"">Six Columns Wide</a></li>
                                    <li><a href=""#"">Product Categories</a></li>
                                </ul>
                            </div>
                        </li>
                        <li id=""Portfolio"">
                            <a href=""#"">Portfolio</a>
                            <div class=""portfolioMenu color invisible"">
                                <ul>
                                    <li><a href=""#"">Standard</a></li>
                                    <li><a href=""#"">Gallery</a></li>
                                    <li><a href=""#"">Masonry</a></li>
                                    <li id=""portfolioLayouts"">
                                        <a href=""#""");
            WriteLiteral(@">
                                            Portfolio Layouts<i class=""fas fa-angle-right ml-2""></i>
                                        </a>
                                        <div class=""portfolioLayouts invisible "">
                                            <ul>
                                                <li><a href=""#"">Two Columns Grid</a></li>
                                                <li><a href=""#"">Three Columns Grid</a></li>
                                                <li><a href=""#"">Four Columns</a></li>
                                                <li><a href=""#"">Four Columns Grid</a></li>
                                                <li><a href=""#"">Five Columns Wide</a></li>
                                            </ul>
                                        </div>
                                    </li>
                                    <li id=""portfolioSingle"">
                                        <a href=""#"">
                          ");
            WriteLiteral(@"                  Portfolio Single <i class=""fas fa-angle-right ml-3""></i>
                                        </a>
                                        <div class=""portfolioSingle color invisible"">
                                            <ul>
                                                <li><a href=""#"">Small Images</a></liclass=""d-none"">
                                                <li><a href=""#"">Small Slider</a></li>
                                                <li><a href=""#"">Big Images</a></li>
                                                <li><a href=""#"">Big Slider</a></li>
                                                <li><a href=""#"">Gallery</a></li>
                                            </ul>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <li id=""Blog"">
                            <a href=""");
            WriteLiteral(@"#"">Blog</a>
                            <div class=""blogMenu color  invisible"">
                                <ul>
                                    <li><a href=""#"">Masonry</a></li>
                                    <li><a href=""#"">Standard</a></li>
                                    <li id=""PostTypes"">
                                        <a href=""#"">
                                            Post Types <i class=""fas fa-angle-right ml-2""></i>
                                        </a>
                                        <div class=""postTypes invisible"">
                                            <ul>
                                                <li><a href=""#"">Standard</a></li>
                                                <li><a href=""#"">Gallery</a></li>
                                                <li><a href=""#"">Link</a></li>
                                                <li><a href=""#"">Quote</a></li>
                                                <li><a href=""");
            WriteLiteral(@"#"">Audio</a></li>
                                                <li><a href=""#"">Video</a></li>
                                            </ul>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <li id=""Elements"">
                            <a href=""#"">Elements</a>
                            <div class=""elementsMenu color invisible"">
                                <ul>
                                    <li id=""Classic"">
                                        <a href=""#"">
                                            Classic <i class=""fas fa-angle-right ml-5""></i>
                                        </a>
                                        <div class=""classicMenu color invisible"">
                                            <ul>
                                                <li><a href=""#"">Accordions</a></li>
   ");
            WriteLiteral(@"                                             <li><a href=""#"">Tabs</a></li>
                                                <li><a href=""#"">Buttons</a></li>
                                                <li><a href=""#"">Video Button</a></li>
                                                <li><a href=""#"">Contact Form</a></li>
                                                <li><a href=""#"">Buttons</a></li>

                                            </ul>
                                        </div>
                                    </li>
                                    <li id=""Infographic"">
                                        <a href=""#"">
                                            Infographic <i class=""fas fa-angle-right ml-2""></i>
                                        </a>
                                        <div class=""infographicMenu color invisible"">
                                            <ul>
                                                <li><a href=""#"">Blog List");
            WriteLiteral(@"</a></li>
                                                <li><a href=""#"">Counters</a></li>
                                                <li><a href=""#"">Countdown</a></li>
                                                <li><a href=""#"">Google Maps</a></li>
                                                <li><a href=""#"">Progress Bar</a></li>
                                                <li><a href=""#"">Pie Charts</a></li>

                                            </ul>
                                        </div>
                                    </li>
                                    <li id=""Interactive"">
                                        <a href=""#"">
                                            Interactive <i class=""fas fa-angle-right ml-3""></i>
                                        </a>
                                        <div class=""interactiveMenu color invisible"">
                                            <ul>
                                                <li");
            WriteLiteral(@"><a href=""#"">Image Gallery</a></li>
                                                <li><a href=""#"">Testimonials</a></li>
                                                <li><a href=""#"">Team</a></li>
                                                <li><a href=""#"">Banner</a></li>
                                                <li><a href=""#"">Shop List</a></li>
                                                <li><a href=""#"">Portfolio List</a></li>
                                            </ul>
                                        </div>
                                    </li>
                                    <li id=""Typography"">
                                        <a href=""#"">
                                            Typography <i class=""fas fa-angle-right ml-2""></i>
                                        </a>
                                        <div class=""typographyMenu color invisible"">
                                            <ul>
                                   ");
            WriteLiteral(@"             <li><a href=""#"">Headings</a></li>
                                                <li><a href=""#"">Columns</a></li>
                                                <li><a href=""#"">Section Title</a></li>
                                                <li><a href=""#"">Blockquote</a></li>
                                                <li><a href=""#"">Dropcaps</a></li>
                                                <li><a href=""#"">Highlights</a></li>
                                                <li><a href=""#"">Separators</a></li>
                                                <li><a href=""#"">Custom Font</a></li>
                                            </ul>
                                    </li>
                                </ul>
                            </div>
                </div>
                <div class=""iconsSearch mt-2"">
                    <ul class=""p-0"" id=""search"">
                        <li class=>
                            <a href=""#""><i class=""fas ");
            WriteLiteral(@"fa-search""></i></a>
                        </li>
                        <li>
                            <a href=""#""><i class=""fas fa-shopping-cart""></i> <sup>0</sup> <span>CART($0)</span> </a>

                        </li>
                    </ul>

                    <div class=""search invisible"">
                        <input type=""text"" placeholder=""search"">
                        <button><i class=""fas fa-search""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>

</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; }
    }
}
#pragma warning restore 1591

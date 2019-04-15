#pragma checksum "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\NestableList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2122b6cd7b6a4b285d0c09707f309b0415a618c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_NestableList), @"mvc.1.0.view", @"/Views/Miscellaneous/NestableList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/NestableList.cshtml", typeof(AspNetCore.Views_Miscellaneous_NestableList))]
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
#line 1 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2122b6cd7b6a4b285d0c09707f309b0415a618c1", @"/Views/Miscellaneous/NestableList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_NestableList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/nestable/jquery.nestable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\NestableList.cshtml"
  
    ViewData["Title"] = "NestableList";

#line default
#line hidden
            BeginContext(50, 219, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Nestable list</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 269, "\"", 316, 1);
#line 11 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\NestableList.cshtml"
WriteAttributeValue("", 276, Url.Action("Dashboard_1", "Dashboards"), 276, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 8029, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Tables</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Nestable list</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div id=""nestable-menu"">
                <button type=""button"" data-action=""expand-all"" class=""btn btn-white btn-sm"">Expand All</button>
                <button type=""button"" data-action=""collapse-all"" class=""btn btn-white btn-sm"">Collapse All</button>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Nestable basic list</h5>
                </div>
                <div class=""ibox-content"">

                    <p clas");
            WriteLiteral(@"s=""m-b-lg"">
                        <strong>Nestable</strong> is an interactive hierarchical list. You can drag and drop to rearrange the order. It works well on touch-screens.
                    </p>

                    <div class=""dd"" id=""nestable"">
                        <ol class=""dd-list"">
                            <li class=""dd-item"" data-id=""1"">
                                <div class=""dd-handle"">1 - Lorem ipsum</div>
                            </li>
                            <li class=""dd-item"" data-id=""2"">
                                <div class=""dd-handle"">2 - Dolor sit</div>
                                <ol class=""dd-list"">
                                    <li class=""dd-item"" data-id=""3"">
                                        <div class=""dd-handle"">3 - Adipiscing elit</div>
                                    </li>
                                    <li class=""dd-item"" data-id=""4"">
                                        <div class=""dd-handle"">4 - Nonummy nibh");
            WriteLiteral(@"</div>
                                    </li>
                                </ol>
                            </li>
                            <li class=""dd-item"" data-id=""5"">
                                <div class=""dd-handle"">5 - Consectetuer</div>
                                <ol class=""dd-list"">
                                    <li class=""dd-item"" data-id=""6"">
                                        <div class=""dd-handle"">6 - Aliquam erat</div>
                                    </li>
                                    <li class=""dd-item"" data-id=""7"">
                                        <div class=""dd-handle"">7 - Veniam quis</div>
                                    </li>
                                </ol>
                            </li>
                            <li class=""dd-item"" data-id=""8"">
                                <div class=""dd-handle"">8 - Tation ullamcorper</div>
                            </li>
                            <li class=""dd-item"" d");
            WriteLiteral(@"ata-id=""9"">
                                <div class=""dd-handle"">9 - Ea commodo</div>
                            </li>
                        </ol>
                    </div>
                    <div class=""m-t-md"">
                        <h5>Serialised Output</h5>
                    </div>
                    <textarea id=""nestable-output"" class=""form-control""></textarea>

                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Nestable custom theme list</h5>
                </div>
                <div class=""ibox-content"">

                    <p class=""m-b-lg"">
                        Each list you can customize by standard css styles. Each element is responsive so you can add to it any other element to improve functionality of list.
                    </p>

                    <div class=""dd"" id=""nestable2"">
                        <ol class=""dd-l");
            WriteLiteral(@"ist"">
                            <li class=""dd-item"" data-id=""1"">
                                <div class=""dd-handle"">
                                    <span class=""label label-info""><i class=""fa fa-users""></i></span> Cras ornare tristique.
                                </div>
                                <ol class=""dd-list"">
                                    <li class=""dd-item"" data-id=""2"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 12:00 pm </span>
                                            <span class=""label label-info""><i class=""fa fa-cog""></i></span> Vivamus vestibulum nulla nec ante.
                                        </div>
                                    </li>
                                    <li class=""dd-item"" data-id=""3"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 11:00 pm </sp");
            WriteLiteral(@"an>
                                            <span class=""label label-info""><i class=""fa fa-bolt""></i></span> Nunc dignissim risus id metus.
                                        </div>
                                    </li>
                                    <li class=""dd-item"" data-id=""4"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 11:00 pm </span>
                                            <span class=""label label-info""><i class=""fa fa-laptop""></i></span> Vestibulum commodo
                                        </div>
                                    </li>
                                </ol>
                            </li>

                            <li class=""dd-item"" data-id=""5"">
                                <div class=""dd-handle"">
                                    <span class=""label label-warning""><i class=""fa fa-users""></i></span> Integer vitae libero.
                  ");
            WriteLiteral(@"              </div>
                                <ol class=""dd-list"">
                                    <li class=""dd-item"" data-id=""6"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 15:00 pm </span>
                                            <span class=""label label-warning""><i class=""fa fa-users""></i></span> Nam convallis pellentesque nisl.
                                        </div>
                                    </li>
                                    <li class=""dd-item"" data-id=""7"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 16:00 pm </span>
                                            <span class=""label label-warning""><i class=""fa fa-bomb""></i></span> Vivamus molestie gravida turpis
                                        </div>
                                    </li>
                          ");
            WriteLiteral(@"          <li class=""dd-item"" data-id=""8"">
                                        <div class=""dd-handle"">
                                            <span class=""float-right""> 21:00 pm </span>
                                            <span class=""label label-warning""><i class=""fa fa-child""></i></span> Ut aliquam sollicitudin leo.
                                        </div>
                                    </li>
                                </ol>
                            </li>
                        </ol>
                    </div>
                    <div class=""m-t-md"">
                        <h5>Serialised Output</h5>
                    </div>
                    <textarea id=""nestable2-output"" class=""form-control""></textarea>


                </div>

            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8364, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8370, 139, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eae93b0502e64372a4e1cc3c61e3650f", async() => {
                    BeginContext(8422, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(8432, 57, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8ced2c0dc3f4b778a1c047ab3604e9a", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(8489, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8509, 1487, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            var updateOutput = function (e) {
                var list = e.length ? e : $(e.target),
                    output = list.data('output');
                if (window.JSON) {
                    output.val(window.JSON.stringify(list.nestable('serialize')));//, null, 2));
                } else {
                    output.val('JSON browser support required for this demo.');
                }
            };
            // activate Nestable for list 1
            $('#nestable').nestable({
                group: 1
            }).on('change', updateOutput);

            // activate Nestable for list 2
            $('#nestable2').nestable({
                group: 1
            }).on('change', updateOutput);

            // output initial serialised data
            updateOutput($('#nestable').data('output', $('#nestable-output')));
            updateOutput($('#nestable2').data('output', $('#nestable2");
                WriteLiteral(@"-output')));

            $('#nestable-menu').on('click', function (e) {
                var target = $(e.target),
                    action = target.data('action');
                if (action === 'expand-all') {
                    $('.dd').nestable('expandAll');
                }
                if (action === 'collapse-all') {
                    $('.dd').nestable('collapseAll');
                }
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(9999, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\AppViews\FileManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785167529ea35ad1f0bde46bbb4531ed5cffadc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AppViews_FileManager), @"mvc.1.0.view", @"/Views/AppViews/FileManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AppViews/FileManager.cshtml", typeof(AspNetCore.Views_AppViews_FileManager))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"785167529ea35ad1f0bde46bbb4531ed5cffadc6", @"/Views/AppViews/FileManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_AppViews_FileManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\AppViews\FileManager.cshtml"
  
    ViewData["Title"] = "FileManager";

#line default
#line hidden
            BeginContext(49, 217, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-9\">\r\n        <h2>File Manager</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 266, "\"", 313, 1);
#line 11 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\AppViews\FileManager.cshtml"
WriteAttributeValue("", 273, Url.Action("Dashboard_1", "Dashboards"), 273, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(314, 3603, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                App Views
            </li>
            <li class=""active breadcrumb-item"">
                <strong>File Manager</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox "">
                <div class=""ibox-content"">
                    <div class=""file-manager"">
                        <h5>Show:</h5>
                        <a href=""#"" class=""file-control active"">Ale</a>
                        <a href=""#"" class=""file-control"">Documents</a>
                        <a href=""#"" class=""file-control"">Audio</a>
                        <a href=""#"" class=""file-control"">Images</a>
                        <div class=""hr-line-dashed""></div>
                        <button class=""btn btn-primary btn-block"">Upload Files</button>
                        <div class=""hr-line-dashed""></div>
      ");
            WriteLiteral(@"                  <h5>Folders</h5>
                        <ul class=""folder-list"" style=""padding: 0"">
                            <li><a href=""""><i class=""fa fa-folder""></i> Files</a></li>
                            <li><a href=""""><i class=""fa fa-folder""></i> Pictures</a></li>
                            <li><a href=""""><i class=""fa fa-folder""></i> Web pages</a></li>
                            <li><a href=""""><i class=""fa fa-folder""></i> Illustrations</a></li>
                            <li><a href=""""><i class=""fa fa-folder""></i> Films</a></li>
                            <li><a href=""""><i class=""fa fa-folder""></i> Books</a></li>
                        </ul>
                        <h5 class=""tag-title"">Tags</h5>
                        <ul class=""tag-list"" style=""padding: 0"">
                            <li><a href="""">Family</a></li>
                            <li><a href="""">Work</a></li>
                            <li><a href="""">Home</a></li>
                            <li><a href="""">Chi");
            WriteLiteral(@"ldren</a></li>
                            <li><a href="""">Holidays</a></li>
                            <li><a href="""">Music</a></li>
                            <li><a href="""">Photography</a></li>
                            <li><a href="""">Film</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-file""></i>
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
    ");
            WriteLiteral(@"                                <br />
                                    <small>Added: Jan 11, 2014</small>
                                </div>
                            </a>
                        </div>

                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(3917, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcc4abc9dbe54742aa2e30cb9ad1b666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3974, 687, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Italy street.jpg
                                    <br />
                                    <small>Added: Jan 6, 2014</small>
                                </div>
                            </a>

                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(4661, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e8a56459dee43fa86f2c3ab57327514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4718, 1394, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    My feel.png
                                    <br />
                                    <small>Added: Jan 7, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-music""></i>
                                </div>
                                <div class=""file-name"">
                                    Michal Jackson.mp3
                                    <br />
                                    <small>Added: Jan 22, 2014</small>
                                </div>
       ");
            WriteLiteral(@"                     </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(6112, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4be5b3a4683e451f9c121dedf407c7a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6169, 2852, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
                                    <br />
                                    <small>Added: Fab 11, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""img-fluid fa fa-film""></i>
                                </div>
                                <div class=""file-name"">
                                    Monica's birthday.mpg4
                                    <br />
                                    <small>Added: Fab 18, 2014</small>
                           ");
            WriteLiteral(@"     </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <a href=""#"">
                            <div class=""file"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-bar-chart-o""></i>
                                </div>
                                <div class=""file-name"">
                                    Annual report 2014.xls
                                    <br />
                                    <small>Added: Fab 22, 2014</small>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>
");
            WriteLiteral(@"
                                <div class=""icon"">
                                    <i class=""fa fa-file""></i>
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
                                    <br />
                                    <small>Added: Jan 11, 2014</small>
                                </div>
                            </a>
                        </div>

                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(9021, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "556bbcc29c1745899d9afafb3f96f442", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9078, 687, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Italy street.jpg
                                    <br />
                                    <small>Added: Jan 6, 2014</small>
                                </div>
                            </a>

                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(9765, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ccb021afc2114c109d05b845317a260e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9822, 1394, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    My feel.png
                                    <br />
                                    <small>Added: Jan 7, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-music""></i>
                                </div>
                                <div class=""file-name"">
                                    Michal Jackson.mp3
                                    <br />
                                    <small>Added: Jan 22, 2014</small>
                                </div>
       ");
            WriteLiteral(@"                     </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(11216, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76c176e9572046cd8b032805a4390c4b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11273, 2852, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
                                    <br />
                                    <small>Added: Fab 11, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""img-fluid fa fa-film""></i>
                                </div>
                                <div class=""file-name"">
                                    Monica's birthday.mpg4
                                    <br />
                                    <small>Added: Fab 18, 2014</small>
                           ");
            WriteLiteral(@"     </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <a href=""#"">
                            <div class=""file"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-bar-chart-o""></i>
                                </div>
                                <div class=""file-name"">
                                    Annual report 2014.xls
                                    <br />
                                    <small>Added: Fab 22, 2014</small>
                                </div>
                            </div>
                        </a>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>
");
            WriteLiteral(@"
                                <div class=""icon"">
                                    <i class=""fa fa-file""></i>
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
                                    <br />
                                    <small>Added: Jan 11, 2014</small>
                                </div>
                            </a>
                        </div>

                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(14125, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f69faf364e64e43b89d49977793b05e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14182, 687, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Italy street.jpg
                                    <br />
                                    <small>Added: Jan 6, 2014</small>
                                </div>
                            </a>

                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(14869, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ef1c0e11410489984f38c2b57f61d5d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14926, 1394, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    My feel.png
                                    <br />
                                    <small>Added: Jan 7, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-music""></i>
                                </div>
                                <div class=""file-name"">
                                    Michal Jackson.mp3
                                    <br />
                                    <small>Added: Jan 22, 2014</small>
                                </div>
       ");
            WriteLiteral(@"                     </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(16320, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6047341ee75c459ba024ac1ba6e7cdbc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(16377, 1939, true);
            WriteLiteral(@"
                                </div>
                                <div class=""file-name"">
                                    Document_2014.doc
                                    <br />
                                    <small>Added: Fab 11, 2014</small>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <div class=""file"">
                            <a href=""#"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""img-fluid fa fa-film""></i>
                                </div>
                                <div class=""file-name"">
                                    Monica's birthday.mpg4
                                    <br />
                                    <small>Added: Fab 18, 2014</small>
                           ");
            WriteLiteral(@"     </div>
                            </a>
                        </div>
                    </div>
                    <div class=""file-box"">
                        <a href=""#"">
                            <div class=""file"">
                                <span class=""corner""></span>

                                <div class=""icon"">
                                    <i class=""fa fa-bar-chart-o""></i>
                                </div>
                                <div class=""file-name"">
                                    Annual report 2014.xls
                                    <br />
                                    <small>Added: Fab 22, 2014</small>
                                </div>
                            </div>
                        </a>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(18334, 225, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n       $(document).ready(function () {\r\n\r\n            $(\'.file-box\').each(function () {\r\n                animationHover(this, \'pulse\');\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
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

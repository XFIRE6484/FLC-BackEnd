#pragma checksum "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb9d9b8371e912341ab72cc61c3cfc9d9b15d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mailbox_EmailView), @"mvc.1.0.view", @"/Views/Mailbox/EmailView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mailbox/EmailView.cshtml", typeof(AspNetCore.Views_Mailbox_EmailView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb9d9b8371e912341ab72cc61c3cfc9d9b15d1d", @"/Views/Mailbox/EmailView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Mailbox_EmailView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/p2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
  
    ViewData["Title"] = "EmailView";

#line default
#line hidden
            BeginContext(47, 310, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""ibox "">
                <div class=""ibox-content mailbox-content"">
                    <div class=""file-manager"">
                        <a class=""btn btn-block btn-primary compose-mail""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 357, "\"", 402, 1);
#line 12 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 364, Url.Action("ComposeEmail", "Mailbox"), 364, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(403, 225, true);
            WriteLiteral(">Compose Mail</a>\r\n                        <div class=\"space-25\"></div>\r\n                        <h5>Folders</h5>\r\n                        <ul class=\"folder-list m-b-md\" style=\"padding: 0\">\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 628, "\"", 666, 1);
#line 16 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 635, Url.Action("Inbox", "Mailbox"), 635, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(667, 138, true);
            WriteLiteral("> <i class=\"fa fa-inbox \"></i> Inbox <span class=\"label label-warning float-right\">16</span> </a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 805, "\"", 843, 1);
#line 17 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 812, Url.Action("Inbox", "Mailbox"), 812, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 89, true);
            WriteLiteral("> <i class=\"fa fa-envelope-o\"></i> Send Mail</a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 933, "\"", 971, 1);
#line 18 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 940, Url.Action("Inbox", "Mailbox"), 940, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(972, 90, true);
            WriteLiteral("> <i class=\"fa fa-certificate\"></i> Important</a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1062, "\"", 1100, 1);
#line 19 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 1069, Url.Action("Inbox", "Mailbox"), 1069, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1101, 141, true);
            WriteLiteral("> <i class=\"fa fa-file-text-o\"></i> Drafts <span class=\"label label-danger float-right\">2</span></a></li>\r\n                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1242, "\"", 1280, 1);
#line 20 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 1249, Url.Action("Inbox", "Mailbox"), 1249, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1281, 1911, true);
            WriteLiteral(@"> <i class=""fa fa-trash-o""></i> Trash</a></li>
                        </ul>
                        <h5>Categories</h5>
                        <ul class=""category-list"" style=""padding: 0"">
                            <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> Work </a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Documents</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Social</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Advertising</a></li>
                            <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Clients</a></li>
                        </ul>

                        <h5 class=""tag-title"">Labels</h5>
                        <ul class=""tag-list"" style=""padding: 0"">
                            <li><a href=""""><i class=""fa fa-tag""></i> Family</a></li>
                            <li><a href=""""><i class=""fa fa-tag"">");
            WriteLiteral(@"</i> Work</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Home</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Children</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Holidays</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Music</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Photography</a></li>
                            <li><a href=""""><i class=""fa fa-tag""></i> Film</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-9 animated fadeInRight"">
            <div class=""mail-box-header"">
                <div class=""float-right tooltip-demo"">
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3192, "\"", 3237, 1);
#line 50 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 3199, Url.Action("ComposeEmail", "Mailbox"), 3199, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3238, 306, true);
            WriteLiteral(@" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Reply""><i class=""fa fa-reply""></i> Reply</a>
                    <a href=""#"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Print email""><i class=""fa fa-print""></i> </a>
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3544, "\"", 3582, 1);
#line 52 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 3551, Url.Action("Inbox", "Mailbox"), 3551, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3583, 3814, true);
            WriteLiteral(@" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to trash""><i class=""fa fa-trash-o""></i> </a>
                </div>
                <h2>
                    View Message
                </h2>
                <div class=""mail-tools tooltip-demo m-t-md"">


                    <h3>
                        <span class=""font-normal"">Subject: </span>Aldus PageMaker including versions of Lorem Ipsum.
                    </h3>
                    <h5>
                        <span class=""float-right font-normal"">10:15AM 02 FEB 2014</span>
                        <span class=""font-normal"">From: </span>alex.smith@corporation.com
                    </h5>
                </div>
            </div>
            <div class=""mail-box"">


                <div class=""mail-body"">
                    <p>
                        Hello Jonathan!
                        <br />
                        <br />
                        Lorem Ipsum is simply dummy text of the ");
            WriteLiteral(@"printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer
                        took a galley of type and scrambled it to make a type <strong>specimen book.</strong>It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. It has survived not only five centuries, but also the leap into electronic typesetting, remaining
                        essentially unchanged.
                    </p>
                    <p>
                        It was popularised in the 1960s with the release <a href=""#"" class=""text-navy"">Letraset sheets</a>  containing Lorem Ipsum passages, and more recently with desktop publishing software
                        like Aldus PageMaker including versions of Lorem Ipsum.
                    </p>
                    <p>
                        There ");
            WriteLiteral(@"are many variations of passages of <strong>Lorem Ipsum</strong>Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of.
                    </p>
                </div>
                <div class=""mail-attachment"">
                    <p>
                        <span><i class=""fa fa-paperclip""></i> 2 attachments - </span>
                        <a href=""#"">Download all</a>
                        |
                        <a href=""#"">View all images</a>
                    </p>

                    <div class=""attachment"">
                        <div class=""file-box"">
                            <div class=""file"">
                                <a href=""#"">
                                    <span class=""corner""></span>

                                    <div class=""icon"">
                                        <i class=""fa fa-file""></i>
     ");
            WriteLiteral(@"                               </div>
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
            BeginContext(7397, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b6b896affad34a6a865560f1afbec6d4", async() => {
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
            BeginContext(7454, 747, true);
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
            BeginContext(8201, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121786c9d5b242e1bd2c975883520407", async() => {
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
            BeginContext(8258, 655, true);
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
                        <div class=""clearfix""></div>
                    </div>
                </div>
                <div class=""mail-body text-right tooltip-demo"">
                    <a class=""btn btn-sm btn-white""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8913, "\"", 8958, 1);
#line 152 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 8920, Url.Action("ComposeEmail", "Mailbox"), 8920, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8959, 91, true);
            WriteLiteral("><i class=\"fa fa-reply\"></i> Reply</a>\r\n                    <a class=\"btn btn-sm btn-white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9050, "\"", 9095, 1);
#line 153 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Mailbox\EmailView.cshtml"
WriteAttributeValue("", 9057, Url.Action("ComposeEmail", "Mailbox"), 9057, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9096, 559, true);
            WriteLiteral(@"><i class=""fa fa-arrow-right""></i> Forward</a>
                    <button title="""" data-placement=""top"" data-toggle=""tooltip"" type=""button"" data-original-title=""Print"" class=""btn btn-sm btn-white""><i class=""fa fa-print""></i> Print</button>
                    <button title="""" data-placement=""top"" data-toggle=""tooltip"" data-original-title=""Trash"" class=""btn btn-sm btn-white""><i class=""fa fa-trash-o""></i> Remove</button>
                </div>
                <div class=""clearfix""></div>


            </div>
        </div>
    </div>
</div>

");
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

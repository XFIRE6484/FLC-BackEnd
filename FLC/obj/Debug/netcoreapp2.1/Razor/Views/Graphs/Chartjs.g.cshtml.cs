#pragma checksum "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Graphs\Chartjs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be8efd5a9ef43630778005c9ef051ddebba5bdc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graphs_Chartjs), @"mvc.1.0.view", @"/Views/Graphs/Chartjs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Graphs/Chartjs.cshtml", typeof(AspNetCore.Views_Graphs_Chartjs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8efd5a9ef43630778005c9ef051ddebba5bdc2", @"/Views/Graphs/Chartjs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Graphs_Chartjs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chartJs/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Graphs\Chartjs.cshtml"
  
    ViewData["Title"] = "Charjs";

#line default
#line hidden
            BeginContext(42, 214, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Chart.js</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 256, "\"", 303, 1);
#line 10 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Graphs\Chartjs.cshtml"
WriteAttributeValue("", 263, Url.Action("Dashboard_1", "Dashboards"), 263, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(304, 2675, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Graphs</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Chart</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>
                        Line Chart Example
                        <small>With custom colors.</small>
                    </h5>
                    <div ibox-tools></div>
                </div>
                <div class=""ibox-content"">
                    <div>
                        <canvas id=""lineChart"" height=""140""></canvas>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
       ");
            WriteLiteral(@"         <div class=""ibox-title"">
                    <h5>Bar Chart Example</h5>
                </div>
                <div class=""ibox-content"">
                    <div>
                        <canvas id=""barChart"" height=""140""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Polar Area</h5>
                </div>
                <div class=""ibox-content"">
                    <div class=""text-center"">
                        <canvas id=""polarChart"" height=""140""></canvas>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Pie </h5>
                </div>
                <div class=""ibox-content"">
                    ");
            WriteLiteral(@"<div>
                        <canvas id=""doughnutChart"" height=""140""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Radar Chart Example</h5>
                </div>
                <div class=""ibox-content"">
                    <div>
                        <canvas id=""radarChart""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2997, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3005, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e7a3648fcc04b00a16d7380135527f9", async() => {
                    BeginContext(3057, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(3067, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c84d5f2b9d248d59b22977257436f19", async() => {
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
                    BeginContext(3117, 6, true);
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
                BeginContext(3137, 4691, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {


            var lineData = {
                labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July""],
                datasets: [

                    {
                        label: ""Data 1"",
                        backgroundColor: 'rgba(26,179,148,0.5)',
                        borderColor: ""rgba(26,179,148,0.7)"",
                        pointBackgroundColor: ""rgba(26,179,148,1)"",
                        pointBorderColor: ""#fff"",
                        data: [28, 48, 40, 19, 86, 27, 90]
                    }, {
                        label: ""Data 2"",
                        backgroundColor: 'rgba(220, 220, 220, 0.5)',
                        pointBorderColor: ""#fff"",
                        data: [65, 59, 80, 81, 56, 55, 40]
                    }
                ]
            };

            var lineOptions = {
                responsive: true
            };


            var c");
                WriteLiteral(@"tx = document.getElementById(""lineChart"").getContext(""2d"");
            new Chart(ctx, { type: 'line', data: lineData, options: lineOptions });

            var barData = {
                labels: [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July""],
                datasets: [
                    {
                        label: ""Data 1"",
                        backgroundColor: 'rgba(220, 220, 220, 0.5)',
                        pointBorderColor: ""#fff"",
                        data: [65, 59, 80, 81, 56, 55, 40]
                    },
                    {
                        label: ""Data 2"",
                        backgroundColor: 'rgba(26,179,148,0.5)',
                        borderColor: ""rgba(26,179,148,0.7)"",
                        pointBackgroundColor: ""rgba(26,179,148,1)"",
                        pointBorderColor: ""#fff"",
                        data: [28, 48, 40, 19, 86, 27, 90]
                    }
                ]
            };

            var barOptio");
                WriteLiteral(@"ns = {
                responsive: true
            };


            var ctx2 = document.getElementById(""barChart"").getContext(""2d"");
            new Chart(ctx2, { type: 'bar', data: barData, options: barOptions });

            var polarData = {
                datasets: [{
                    data: [
                        300, 140, 200
                    ],
                    backgroundColor: [
                        ""#a3e1d4"", ""#dedede"", ""#b5b8cf""
                    ],
                    label: [
                        ""My Radar chart""
                    ]
                }],
                labels: [
                    ""App"", ""Software"", ""Laptop""
                ]
            };

            var polarOptions = {
                segmentStrokeWidth: 2,
                responsive: true

            };

            var ctx3 = document.getElementById(""polarChart"").getContext(""2d"");
            new Chart(ctx3, { type: 'polarArea', data: polarData, options: polarOptions ");
                WriteLiteral(@"});

            var doughnutData = {
                labels: [""App"", ""Software"", ""Laptop""],
                datasets: [{
                    data: [300, 50, 100],
                    backgroundColor: [""#a3e1d4"", ""#dedede"", ""#b5b8cf""]
                }]
            };


            var doughnutOptions = {
                responsive: true
            };


            var ctx4 = document.getElementById(""doughnutChart"").getContext(""2d"");
            new Chart(ctx4, { type: 'doughnut', data: doughnutData, options: doughnutOptions });


            var radarData = {
                labels: [""Eating"", ""Drinking"", ""Sleeping"", ""Designing"", ""Coding"", ""Cycling"", ""Running""],
                datasets: [
                    {
                        label: ""My First dataset"",
                        backgroundColor: ""rgba(220,220,220,0.2)"",
                        borderColor: ""rgba(220,220,220,1)"",
                        data: [65, 59, 90, 81, 56, 55, 40]
                    },
             ");
                WriteLiteral(@"       {
                        label: ""My Second dataset"",
                        backgroundColor: ""rgba(26,179,148,0.2)"",
                        borderColor: ""rgba(26,179,148,1)"",
                        data: [28, 48, 40, 19, 96, 27, 100]
                    }
                ]
            };

            var radarOptions = {
                responsive: true
            };

            var ctx5 = document.getElementById(""radarChart"").getContext(""2d"");
            new Chart(ctx5, { type: 'radar', data: radarData, options: radarOptions });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(7831, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
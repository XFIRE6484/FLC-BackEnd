#pragma checksum "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\GoogleMaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da780563cdd128780c31c99b3733f51944bcc204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_GoogleMaps), @"mvc.1.0.view", @"/Views/Miscellaneous/GoogleMaps.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/GoogleMaps.cshtml", typeof(AspNetCore.Views_Miscellaneous_GoogleMaps))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da780563cdd128780c31c99b3733f51944bcc204", @"/Views/Miscellaneous/GoogleMaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_GoogleMaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\GoogleMaps.cshtml"
  
    ViewData["Title"] = "GoogleMaps";

#line default
#line hidden
            BeginContext(48, 217, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Google Maps</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 265, "\"", 312, 1);
#line 11 "C:\Users\EdgardOrellana\Proyectos\FLC\FLC\Views\Miscellaneous\GoogleMaps.cshtml"
WriteAttributeValue("", 272, Url.Action("Dashboard_1", "Dashboards"), 272, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(313, 2929, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Miscellaneous</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Google Maps</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">

    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Google Maps Basic example</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        With google maps <a href=""https://developers.google.com/maps/documentation/javascript/reference#MapOptions"">API</a> You can easy customize your map.
                    </p>
                    <div class=""google-map"" id=""map1""></div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
        ");
            WriteLiteral(@"    <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Custom theme 1</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        This is a custom theme for Google map.
                    </p>
                    <div class=""google-map"" id=""map2""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Map Type</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        You can also change a map type.
                    </p>
                    <div class=""google-map"" id=""map3""></div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <");
            WriteLiteral(@"h5>Custom theme 2</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        This is a custom theme for Google map.
                    </p>
                    <div class=""google-map"" id=""map4""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Street View</h5>
                </div>
                <div class=""ibox-content"">
                    <p>
                        You can also initial turn on Street View in Google maps.
                    </p>
                    <div class=""google-map"" id=""pano"" style=""height: 500px""></div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3260, 6213, true);
                WriteLiteral(@"
    <!--
     You need to include this script on any page that has a Google Map.
     When using Google Maps on your own site you MUST signup for your own API key at:
     https://developers.google.com/maps/documentation/javascript/tutorial#api_key
     After your sign up replace the key in the URL below..
    -->

    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDQTpXj82d8UpCi97wzo_nKXL7nYrd4G70""></script>

    <script type=""text/javascript"">
        // When the window has finished loading google map
        google.maps.event.addDomListener(window, 'load', init);

        function init() {
            // Options for Google map
            // More info see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
            var mapOptions1 = {
                zoom: 11,
                center: new google.maps.LatLng(40.6700, -73.9400),
                // Style for Google Maps
                styles: [{ ""featureType"": ""water"", ""stylers"": [{ ""satur");
                WriteLiteral(@"ation"": 43 }, { ""lightness"": -11 }, { ""hue"": ""#0088ff"" }] }, { ""featureType"": ""road"", ""elementType"": ""geometry.fill"", ""stylers"": [{ ""hue"": ""#ff0000"" }, { ""saturation"": -100 }, { ""lightness"": 99 }] }, { ""featureType"": ""road"", ""elementType"": ""geometry.stroke"", ""stylers"": [{ ""color"": ""#808080"" }, { ""lightness"": 54 }] }, { ""featureType"": ""landscape.man_made"", ""elementType"": ""geometry.fill"", ""stylers"": [{ ""color"": ""#ece2d9"" }] }, { ""featureType"": ""poi.park"", ""elementType"": ""geometry.fill"", ""stylers"": [{ ""color"": ""#ccdca1"" }] }, { ""featureType"": ""road"", ""elementType"": ""labels.text.fill"", ""stylers"": [{ ""color"": ""#767676"" }] }, { ""featureType"": ""road"", ""elementType"": ""labels.text.stroke"", ""stylers"": [{ ""color"": ""#ffffff"" }] }, { ""featureType"": ""poi"", ""stylers"": [{ ""visibility"": ""off"" }] }, { ""featureType"": ""landscape.natural"", ""elementType"": ""geometry.fill"", ""stylers"": [{ ""visibility"": ""on"" }, { ""color"": ""#b8cb93"" }] }, { ""featureType"": ""poi.park"", ""stylers"": [{ ""visibility"": ""on"" }] }, { ""featureType"": ""poi.sports_c");
                WriteLiteral(@"omplex"", ""stylers"": [{ ""visibility"": ""on"" }] }, { ""featureType"": ""poi.medical"", ""stylers"": [{ ""visibility"": ""on"" }] }, { ""featureType"": ""poi.business"", ""stylers"": [{ ""visibility"": ""simplified"" }] }]
            };

            var mapOptions2 = {
                zoom: 11,
                center: new google.maps.LatLng(40.6700, -73.9400),
                // Style for Google Maps
                styles: [{ ""featureType"": ""all"", ""elementType"": ""all"", ""stylers"": [{ ""invert_lightness"": true }, { ""saturation"": 10 }, { ""lightness"": 30 }, { ""gamma"": 0.5 }, { ""hue"": ""#435158"" }] }]
            };

            var mapOptions3 = {
                center: new google.maps.LatLng(36.964645, -122.01523),
                zoom: 18,
                mapTypeId: google.maps.MapTypeId.SATELLITE,
                // Style for Google Maps
                styles: [{ ""featureType"": ""road"", ""elementType"": ""geometry"", ""stylers"": [{ ""visibility"": ""off"" }] }, { ""featureType"": ""poi"", ""elementType"": ""geometry"", ""stylers"": [{ """);
                WriteLiteral(@"visibility"": ""off"" }] }, { ""featureType"": ""landscape"", ""elementType"": ""geometry"", ""stylers"": [{ ""color"": ""#fffffa"" }] }, { ""featureType"": ""water"", ""stylers"": [{ ""lightness"": 50 }] }, { ""featureType"": ""road"", ""elementType"": ""labels"", ""stylers"": [{ ""visibility"": ""off"" }] }, { ""featureType"": ""transit"", ""stylers"": [{ ""visibility"": ""off"" }] }, { ""featureType"": ""administrative"", ""elementType"": ""geometry"", ""stylers"": [{ ""lightness"": 40 }] }]
            };

            var mapOptions4 = {
                zoom: 11,
                center: new google.maps.LatLng(40.6700, -73.9400),
                // Style for Google Maps
                styles: [{ ""stylers"": [{ ""hue"": ""#18a689"" }, { ""visibility"": ""on"" }, { ""invert_lightness"": true }, { ""saturation"": 40 }, { ""lightness"": 10 }] }]
            };

            var fenway = new google.maps.LatLng(42.345573, -71.098326);
            var mapOptions5 = {
                zoom: 14,
                center: fenway,
                // Style for Google Maps
        ");
                WriteLiteral(@"        styles: [{ featureType: ""landscape"", stylers: [{ saturation: -100 }, { lightness: 65 }, { visibility: ""on"" }] }, { featureType: ""poi"", stylers: [{ saturation: -100 }, { lightness: 51 }, { visibility: ""simplified"" }] }, { featureType: ""road.highway"", stylers: [{ saturation: -100 }, { visibility: ""simplified"" }] }, { featureType: ""road.arterial"", stylers: [{ saturation: -100 }, { lightness: 30 }, { visibility: ""on"" }] }, { featureType: ""road.local"", stylers: [{ saturation: -100 }, { lightness: 40 }, { visibility: ""on"" }] }, { featureType: ""transit"", stylers: [{ saturation: -100 }, { visibility: ""simplified"" }] }, { featureType: ""administrative.province"", stylers: [{ visibility: ""off"" }]/**/ }, { featureType: ""administrative.locality"", stylers: [{ visibility: ""off"" }] }, { featureType: ""administrative.neighborhood"", stylers: [{ visibility: ""on"" }]/**/ }, { featureType: ""water"", elementType: ""labels"", stylers: [{ visibility: ""on"" }, { lightness: -25 }, { saturation: -100 }] }, { featureType: ""water"", elem");
                WriteLiteral(@"entType: ""geometry"", stylers: [{ hue: ""#ffff00"" }, { lightness: -25 }, { saturation: -97 }] }]
            };

            var panoramaOptions = {
                position: fenway,
                pov: {
                    heading: 10,
                    pitch: 10
                }
            };
            var panorama = new google.maps.StreetViewPanorama(document.getElementById('pano'), panoramaOptions);

            // Get all html elements for map
            var mapElement1 = document.getElementById('map1');
            var mapElement2 = document.getElementById('map2');
            var mapElement3 = document.getElementById('map3');
            var mapElement4 = document.getElementById('map4');

            // Create the Google Map using elements
            var map1 = new google.maps.Map(mapElement1, mapOptions1);
            var map2 = new google.maps.Map(mapElement2, mapOptions2);
            var map3 = new google.maps.Map(mapElement3, mapOptions3);
            var map4 = new g");
                WriteLiteral("oogle.maps.Map(mapElement4, mapOptions4);\r\n        }\r\n    </script>\r\n");
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

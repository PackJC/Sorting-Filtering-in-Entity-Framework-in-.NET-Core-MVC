#pragma checksum "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb073478e7755f956c4b7b8752feb44dbab28e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Details), @"mvc.1.0.view", @"/Views/Restaurants/Details.cshtml")]
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
#line 1 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\_ViewImports.cshtml"
using ETSUEats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\_ViewImports.cshtml"
using ETSUEats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb073478e7755f956c4b7b8752feb44dbab28e9", @"/Views/Restaurants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dd68ca55534613e330ed51704cfe29176228204", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETSUEats.Model.Restaurants>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
  
    ViewData["Title"] = "ETSUEats";
    var item = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 9 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Covid Policies\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 17 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
              
                string builtCovidPolicies = "";
                var covidPolicy = item.Covid19.FirstOrDefault();
                if (covidPolicy != null)
                {
                    string demarc = ", ";
                    if (covidPolicy.TakeOut)
                    {
                        builtCovidPolicies += "takeout";
                    }
                    if (covidPolicy.LimitSeating)
                    {
                        if (builtCovidPolicies.Length != 0) builtCovidPolicies += demarc;
                        builtCovidPolicies += "limited seating";
                    }
                    if (covidPolicy.IndoorDining)
                    {
                        if (builtCovidPolicies.Length != 0) builtCovidPolicies += demarc;
                        builtCovidPolicies += "indoor dining";
                    }
                    if (covidPolicy.Curbside)
                    {
                        if (builtCovidPolicies.Length != 0) builtCovidPolicies += demarc;
                        builtCovidPolicies += "curbside";
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 44 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(builtCovidPolicies);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuisines));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cuisines));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Establishment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Establishment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            ");
#nullable restore
#line 69 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 69 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.StateCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
                                                                                         Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 78 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LocalityVerbose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.LocalityVerbose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Links\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3053, "\"", 3100, 1);
#nullable restore
#line 87 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
WriteAttributeValue("", 3060, Html.DisplayFor(model => model.MenuUrl), 3060, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Menu</a><br />\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3132, "\"", 3175, 1);
#nullable restore
#line 88 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
WriteAttributeValue("", 3139, Html.DisplayFor(model => model.Url), 3139, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Website</a>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 103 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.PriceRange));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 109 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Timings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 112 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Timings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 115 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AggregateRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 118 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.AggregateRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 121 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RatingText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 124 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.RatingText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 127 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CityNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 130 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.CityNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 133 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuisine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 136 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cuisine.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb073478e7755f956c4b7b8752feb44dbab28e917323", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\ECHO\Documents\GitHub\etsuhciproj\etsueats\Views\Restaurants\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb073478e7755f956c4b7b8752feb44dbab28e919472", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETSUEats.Model.Restaurants> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61bddbee12c53f255be37c3c76c48345da77953753675a9733a293a81d8d3906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Team), @"mvc.1.0.razor-page", @"/Pages/Teams/Team.cshtml")]
namespace League.Pages.Teams
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"61bddbee12c53f255be37c3c76c48345da77953753675a9733a293a81d8d3906", @"/Pages/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5f088290de2bf8b800def2262432c5928f679871215bc838aec033500e74ff67", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Teams_Team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Players/Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
  
  ViewData["Title"] = "NFL Team - " + @Html.DisplayFor(model => model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n  <h1 class=\"display-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 189, "\"", 235, 3);
            WriteAttributeValue("", 195, "/image/nfl/logo/", 195, 16, true);
#nullable restore
#line 10 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 211, Model.Team.TeamId, 211, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 231, ".png", 231, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 11 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
Write(Model.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </h1>\r\n</div>\r\n\r\n<div class=\"d-flex justify-content-between pb-2\">\r\n  <div>\r\n  <div>");
#nullable restore
#line 18 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
  Write(Model.Team.Division.ConferenceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                      Write(Model.Team.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  <div>Record: ");
#nullable restore
#line 19 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
          Write(Model.Team.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                          Write(Model.Team.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 19 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                           Write(Model.Team.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  <hr/>\r\n  <div>");
#nullable restore
#line 21 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
  Write(Model.Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Stadium</div>\r\n  <div>Capacity: ");
#nullable restore
#line 22 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
            Write(Model.Team.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  <hr/>\r\n  <div>");
#nullable restore
#line 24 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
  Write(Model.Team.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  <div class=\"pb-2\">");
#nullable restore
#line 25 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
               Write(Model.Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 25 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                 Write(Model.Team.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                                   Write(Model.Team.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  <img");
            BeginWriteAttribute("src", " src=\"", 734, "\"", 783, 3);
            WriteAttributeValue("", 740, "/image/nfl/stadium/", 740, 19, true);
#nullable restore
#line 26 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 759, Model.Team.TeamId, 759, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 779, ".jpg", 779, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n  </div>\r\n  <img");
            BeginWriteAttribute("src", " src=\"", 803, "\"", 852, 3);
            WriteAttributeValue("", 809, "/image/nfl/seating/", 809, 19, true);
#nullable restore
#line 28 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 828, Model.Team.TeamId, 828, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 848, ".png", 848, 4, true);
            EndWriteAttribute();
            WriteLiteral(@">
</div>

<section class=""grid container"">
  <div class=""d-flex bg-primary text-white"">
  <div class=""p-1"" style=""flex:0 0 10%"">Number</div>
  <div class=""p-1"" style=""flex:0 0 25%"">Name</div>
  <div class=""p-1"" style=""flex:0 0 10%"">Position</div>
  <div class=""p-1"" style=""flex:0 0 20%"">Experience</div>
  <div class=""p-1"" style=""flex:0 0 25%"">College</div>
  <div class=""p-1"" style=""flex:0 0 10%"">Depth</div>
  </div>

");
#nullable restore
#line 41 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
   foreach (Player Player in Model.Team.Players) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61bddbee12c53f255be37c3c76c48345da77953753675a9733a293a81d8d39069449", async() => {
                WriteLiteral("\r\n      <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 43 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n      <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 44 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n      <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 45 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n      <div class=\"p-1\" style=\"flex:0 0 20%\">");
#nullable restore
#line 46 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n      <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 47 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.College);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n      <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 48 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                       Write(Player.Depth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 1352, Player.Depth == 1 ? "d-flex starter" : "d-flex", 1352, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
                                                                                               WriteLiteral(Player.PlayerId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Teams\Team.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel>)PageContext?.ViewData;
        public TeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88e893889bc3ccf957d54203f2535e2f3e5724e7ff757980ad57d30ccd8ff8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Players.Pages_Players_Player), @"mvc.1.0.razor-page", @"/Pages/Players/Player.cshtml")]
namespace League.Pages.Players
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"88e893889bc3ccf957d54203f2535e2f3e5724e7ff757980ad57d30ccd8ff8e6", @"/Pages/Players/Player.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5f088290de2bf8b800def2262432c5928f679871215bc838aec033500e74ff67", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Players_Player : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
  
  ViewData["Title"] = "NFL Player - " + @Html.DisplayFor(model => model.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n  <h1 class=\"display-4\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 195, "\"", 243, 3);
            WriteAttributeValue("", 201, "/image/nfl/logo/", 201, 16, true);
#nullable restore
#line 10 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
WriteAttributeValue("", 217, Model.Player.TeamId, 217, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 239, ".png", 239, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 11 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
Write(Html.DisplayFor(model => model.Player.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
Write(Html.DisplayFor(model => model.Player.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </h1>\r\n</div>\r\n\r\n<div>");
#nullable restore
#line 16 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
Write(Model.Player.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Rating: ");
#nullable restore
#line 18 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
        Write(Model.Player.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Rank: ");
#nullable restore
#line 19 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
      Write(Model.Player.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Depth: ");
#nullable restore
#line 20 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
       Write(Model.Player.Depth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Experience: ");
#nullable restore
#line 22 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
            Write(Model.Player.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>College: ");
#nullable restore
#line 23 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
         Write(Model.Player.College);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Draft: ");
#nullable restore
#line 24 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
       Write(Model.Player.DraftYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
                                 Write(Model.Player.DraftRound);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
                                                            Write(Model.Player.DraftPick);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr/>\r\n<div>Height: ");
#nullable restore
#line 26 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
        Write(Model.Player.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Weight: ");
#nullable restore
#line 27 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
        Write(Model.Player.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Age ");
#nullable restore
#line 28 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
    Write(Model.Player.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Birthday: ");
#nullable restore
#line 29 "C:\Users\Ahmad\Desktop\Uni\Projects\C#\League\Pages\Players\Player.cshtml"
          Write(Model.Player.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlayerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PlayerModel>)PageContext?.ViewData;
        public PlayerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "573c4c81e51c787bdd65833d9657beec42f663a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\_ViewImports.cshtml"
using Liftoff_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\_ViewImports.cshtml"
using Liftoff_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"573c4c81e51c787bdd65833d9657beec42f663a5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b5151d305418ed0f32ac43cce57c953d0ce2b4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TeamStats", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTeam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome To World Cup Bracket Maker</h1>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573c4c81e51c787bdd65833d9657beec42f663a55824", async() => {
                WriteLiteral("\r\n        <input type=\"text\" name=\"searchItem\" required/>\r\n        <span class=\"text-danger\">");
#nullable restore
#line 12 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                             Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <input type=\"submit\" value=\"submit\" />\r\n        \r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 440, "\"", 460, 1);
#nullable restore
#line 18 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 448, ViewBag.pos, 448, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <h1>World Cup Teams</h1>
            <table class=""table table-dark table-striped"">
               <thead>
                   <tr>
                        <th>
                  
                       </th>
                        <th>
                           Team Name
                       </th>
                   </tr>
               </thead>
               <tbody>
");
#nullable restore
#line 32 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                         foreach (var row in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                             if (row.Name_en != "--")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> <img");
            BeginWriteAttribute("src", " src=\"", 1113, "\"", 1128, 1);
#nullable restore
#line 37 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 1119, row.Flag, 1119, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573c4c81e51c787bdd65833d9657beec42f663a510087", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-secondary\" name=\"teamId\"");
                BeginWriteAttribute("value", " value=\"", 1398, "\"", 1413, 1);
#nullable restore
#line 40 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 1406, row.Id, 1406, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                                                                                                                     Write(row.Name_en);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 43 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                                     if(ViewBag.user != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573c4c81e51c787bdd65833d9657beec42f663a513299", async() => {
                WriteLiteral("\r\n                                                <button class=\"btn-success\" type=\"submit\" name=\"selectedFav\"");
                BeginWriteAttribute("value", " value=\"", 1899, "\"", 1914, 1);
#nullable restore
#line 47 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 1907, row.Id, 1907, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                <img src=""https://www.psd-dude.com/tutorials/resources-images/star-symbol/star-clipart.png"" width=""50"" height=""50""/>
                                                </button>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 52 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("               </tbody>\r\n           </table>\r\n       </div>\r\n   <div class=\"float-right\">\r\n");
#nullable restore
#line 61 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
       if (ViewBag.user != null)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"          <h1>Favorite Teams</h1>
            <table class=""table table-dark table-striped"">
              <thead>
                  <tr>
                      <th></th>
                      <th>Team Name</th>
                  </tr>
              </thead>
              <tbody>
");
#nullable restore
#line 72 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                       foreach(var row in Model)
                      {
                          

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                           for(int i = 0; i < ViewBag.fav.Count; i++)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n");
#nullable restore
#line 77 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                               if (row.Id == ViewBag.fav[i].TeamId)
                              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <td><img");
            BeginWriteAttribute("src", " src=\"", 3157, "\"", 3172, 1);
#nullable restore
#line 79 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3163, row.Flag, 3163, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                                  <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573c4c81e51c787bdd65833d9657beec42f663a518896", async() => {
                WriteLiteral("\r\n                                            <button class=\"btn btn-secondary\" type=\"submit\" name=\"teamId\"");
                BeginWriteAttribute("value", " value=\"", 3439, "\"", 3454, 1);
#nullable restore
#line 82 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3447, row.Id, 3447, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                                                                                                                     Write(row.Name_en);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                  </td>\r\n                                  <td>\r\n                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573c4c81e51c787bdd65833d9657beec42f663a521772", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" name=\"selectedFav\"");
                BeginWriteAttribute("value", " value=\"", 3800, "\"", 3815, 1);
#nullable restore
#line 87 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3808, row.Id, 3808, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn-danger"">
                                                <img src=""https://www.psd-dude.com/tutorials/resources-images/star-symbol/star-clipart.png"" width=""50"" height=""50"" />
                                            </button>
                                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                  </td>\r\n");
#nullable restore
#line 92 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                                    break;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 95 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
                           
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </tbody>\r\n          </table>\r\n");
#nullable restore
#line 99 "C:\Users\zkrem\Documents\LaunchCodeCamp\Lift Off\Liftoff-Project\Liftoff Project\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

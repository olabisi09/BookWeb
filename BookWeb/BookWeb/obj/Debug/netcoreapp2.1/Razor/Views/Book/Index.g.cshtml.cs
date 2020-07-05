#pragma checksum "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80fa92e6e382c514336deff732e973ac424d6671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80fa92e6e382c514336deff732e973ac424d6671", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-neutral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
            BeginContext(84, 911, true);
            WriteLiteral(@"
<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">Tables</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item""><a href=""#"">Tables</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Tables</li>
                        </ol>
                    </nav>
                </div>
                <div class=""col-lg-6 col-5 text-right"">
                    ");
            EndContext();
            BeginContext(995, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bcd9f61d68b459eafed4d1ba4367e1a", async() => {
                BeginContext(1071, 8, true);
                WriteLiteral("New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1083, 1711, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container-fluid mt--6"">
    
    <!-- Dark table -->
    <div class=""row"">
        <div class=""col"">
            <div class=""card bg-default shadow"">
                <div class=""card-header bg-transparent border-0"">
                    <h3 class=""text-white mb-0"">Authors</h3>
                </div>
                <div class=""table-responsive"">
                    <table class=""table align-items-center table-dark table-flush"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"" class=""sort"" data-sort=""name"">Id</th>
                                <th scope=""col"" class=""sort"" data-sort=""budget"">Title</th>
                                <th scope=""col"" class=""sort"" data-sort=""status"">Author Id</th>
                                <th scope=""col"" class=""sort"" data-sort=""status"">Genre Id</th>
                              ");
            WriteLiteral(@"  <th scope=""col"" class=""sort"" data-sort=""status"">ISBN</th>
                                <th scope=""col"" class=""sort"" data-sort=""status"">Year Published</th>
                                <th scope=""col"" class=""sort"" data-sort=""status"">Rating</th>
                                <th scope=""col"" class=""sort"" data-sort=""status"">Summary</th>
                                <th scope=""col"">Created By</th>
                                <th scope=""col"" class=""sort"" data-sort=""completion"">Date Created</th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        <tbody class=""list"">
");
            EndContext();
#line 55 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                             foreach (var book in Model)
                            {

#line default
#line hidden
            BeginContext(2883, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2962, 7, false);
#line 58 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2969, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3017, 10, false);
#line 59 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3027, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3075, 13, false);
#line 60 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.AuthorId);

#line default
#line hidden
            EndContext();
            BeginContext(3088, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3136, 12, false);
#line 61 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.GenreID);

#line default
#line hidden
            EndContext();
            BeginContext(3148, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3196, 9, false);
#line 62 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(3205, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3253, 16, false);
#line 63 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.YearPublish);

#line default
#line hidden
            EndContext();
            BeginContext(3269, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3317, 11, false);
#line 64 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(3328, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3376, 12, false);
#line 65 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(3388, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3436, 14, false);
#line 66 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(3450, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3498, 16, false);
#line 67 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                   Write(book.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(3514, 608, true);
            WriteLiteral(@"</td>
                                    <td class=""text-right"">
                                        <div class=""dropdown"">
                                            <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                                <i class=""fas fa-ellipsis-v""></i>
                                            </a>
                                            <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                                ");
            EndContext();
            BeginContext(4122, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf415497de740e2bd247bf62beeee34", async() => {
                BeginContext(4189, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                                                                             WriteLiteral(book.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4197, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4247, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "493d2a785bc24d8ab50a37025f3fffcf", async() => {
                BeginContext(4398, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                                                                                               WriteLiteral(book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 12, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4325, "return", 4325, 6, true);
            AddHtmlAttributeValue(" ", 4331, "confirm(\'Are", 4332, 13, true);
            AddHtmlAttributeValue(" ", 4344, "you", 4345, 4, true);
            AddHtmlAttributeValue(" ", 4348, "sure", 4349, 5, true);
            AddHtmlAttributeValue(" ", 4353, "you", 4354, 4, true);
            AddHtmlAttributeValue(" ", 4357, "want", 4358, 5, true);
            AddHtmlAttributeValue(" ", 4362, "to", 4363, 3, true);
            AddHtmlAttributeValue(" ", 4365, "delete", 4366, 7, true);
            AddHtmlAttributeValue(" ", 4372, "the", 4373, 4, true);
            AddHtmlAttributeValue(" ", 4376, "book", 4377, 5, true);
#line 75 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
AddHtmlAttributeValue(" ", 4381, book.Title, 4382, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4393, "?\')", 4393, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4408, 184, true);
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\DELL\source\repos\BookWeb\BookWeb\Views\Book\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4623, 144, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
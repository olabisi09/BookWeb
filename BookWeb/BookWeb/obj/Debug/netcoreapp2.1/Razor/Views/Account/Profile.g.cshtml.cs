#pragma checksum "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91db121df50f0505cd75132bb653ec8e172e35e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
#line 1 "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\Account\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\Account\Profile.cshtml"
using BookWeb.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91db121df50f0505cd75132bb653ec8e172e35e7", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(167, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(196, 909, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da942510a813405fb4f5a46dc02834bf", async() => {
                BeginContext(202, 698, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content=""Start your development with a Dashboard for Bootstrap 4."">
    <meta name=""author"" content=""Creative Tim"">
    <title>Argon Dashboard - Free Dashboard for Bootstrap 4</title>
    <!-- Favicon -->
    <link rel=""icon"" href=""../assets/img/brand/favicon.png"" type=""image/png"">
    <!-- Fonts -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"">
    <!-- Icons -->
    <link rel=""stylesheet"" href=""../assets/vendor/nucleo/css/nucleo.css"" type=""text/css"">
    <link rel=""stylesheet""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 900, "\"", 970, 3);
                WriteAttributeValue("", 907, "../assets/vendor/", 907, 17, true);
                WriteAttributeValue("", 924, "@", 924, 1, true);
                WriteAttributeValue("", 926, "fortawesome/fontawesome-free/css/all.min.css", 926, 44, true);
                EndWriteAttribute();
                BeginContext(971, 127, true);
                WriteLiteral(" type=\"text/css\">\r\n    <!-- Argon CSS -->\r\n    <link rel=\"stylesheet\" href=\"../assets/css/argon.css?v=1.2.0\" type=\"text/css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1109, 13186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24a43d0b89144ef7aa3e916db39da528", async() => {
                BeginContext(1115, 733, true);
                WriteLiteral(@"
    <!-- Sidenav -->
    <!-- Main content -->
    <div class=""main-content"" id=""panel"">
        <!-- Topnav -->
        <!-- Header -->
        <!-- Header -->
        <div class=""header pb-6 d-flex align-items-center"" style=""min-height: 500px; background-image: url(../assets/img/theme/profile-cover.jpg); background-size: cover; background-position: center top;"">
            <!-- Mask -->
            <span class=""mask bg-gradient-default opacity-8""></span>
            <!-- Header container -->
            <div class=""container-fluid d-flex align-items-center"">
                <div class=""row"">
                    <div class=""col-lg-7 col-md-10"">
                        <h1 class=""display-2 text-white"">Hello ");
                EndContext();
                BeginContext(1849, 29, false);
#line 40 "C:\Users\DELL\BookWeb\BookWeb\BookWeb\Views\Account\Profile.cshtml"
                                                          Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
                BeginContext(1878, 4442, true);
                WriteLiteral(@"</h1>
                        <p class=""text-white mt-0 mb-5"">This is your profile page. You can see the progress you've made with your work and manage your projects or assigned tasks</p>
                        <a href=""#!"" class=""btn btn-neutral"">Edit profile</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- Page content -->
        <div class=""container-fluid mt--6"">
            <div class=""row"">
                <div class=""col-xl-4 order-xl-2"">
                    <div class=""card card-profile"">
                        <img src=""../assets/img/theme/img-1-1000x600.jpg"" alt=""Image placeholder"" class=""card-img-top"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-3 order-lg-2"">
                                <div class=""card-profile-image"">
                                    <a href=""#"">
                                        <img src=""../assets/img/theme/team-4.jpg"" class=""r");
                WriteLiteral(@"ounded-circle"">
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class=""card-header text-center border-0 pt-8 pt-md-4 pb-0 pb-md-4"">
                            <div class=""d-flex justify-content-between"">
                                <a href=""#"" class=""btn btn-sm btn-info  mr-4 "">Connect</a>
                                <a href=""#"" class=""btn btn-sm btn-default float-right"">Message</a>
                            </div>
                        </div>
                        <div class=""card-body pt-0"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""card-profile-stats d-flex justify-content-center"">
                                        <div>
                                            <span class=""heading"">22</span>
                                            <span");
                WriteLiteral(@" class=""description"">Friends</span>
                                        </div>
                                        <div>
                                            <span class=""heading"">10</span>
                                            <span class=""description"">Photos</span>
                                        </div>
                                        <div>
                                            <span class=""heading"">89</span>
                                            <span class=""description"">Comments</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""text-center"">
                                <h5 class=""h3"">
                                    Jessica Jones<span class=""font-weight-light"">, 27</span>
                                </h5>
                                <div class=""h5 font-weight-300"">
");
                WriteLiteral(@"                                    <i class=""ni location_pin mr-2""></i>Bucharest, Romania
                                </div>
                                <div class=""h5 mt-4"">
                                    <i class=""ni business_briefcase-24 mr-2""></i>Solution Manager - Creative Tim Officer
                                </div>
                                <div>
                                    <i class=""ni education_hat mr-2""></i>University of Computer Science
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-8 order-xl-1"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""row align-items-center"">
                                <div class=""col-8"">
                                    <h3 class=""mb-0"">Edit profile </h3>
                                </div");
                WriteLiteral(@">
                                <div class=""col-4 text-right"">
                                    <a href=""#!"" class=""btn btn-sm btn-primary"">Settings</a>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            ");
                EndContext();
                BeginContext(6320, 5678, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92885bf7e1714ef7af02029f47983f15", async() => {
                    BeginContext(6326, 5665, true);
                    WriteLiteral(@"
                                <h6 class=""heading-small text-muted mb-4"">User information</h6>
                                <div class=""pl-lg-4"">
                                    <div class=""row"">
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-username"">Username</label>
                                                <input type=""text"" id=""input-username"" class=""form-control"" placeholder=""Username"" value=""lucky.jesse"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-email"">Email address</label>
                                                <i");
                    WriteLiteral(@"nput type=""email"" id=""input-email"" class=""form-control"" placeholder=""jesse@example.com"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-first-name"">First name</label>
                                                <input type=""text"" id=""input-first-name"" class=""form-control"" placeholder=""First name"" value=""Lucky"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""inpu");
                    WriteLiteral(@"t-last-name"">Last name</label>
                                                <input type=""text"" id=""input-last-name"" class=""form-control"" placeholder=""Last name"" value=""Jesse"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <hr class=""my-4"" />
                                <!-- Address -->
                                <h6 class=""heading-small text-muted mb-4"">Contact information</h6>
                                <div class=""pl-lg-4"">
                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-address"">Address</label>
                                                <input id=""input-address"" class=""form-contro");
                    WriteLiteral(@"l"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-4"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-city"">City</label>
                                                <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-country""");
                    WriteLiteral(@">Country</label>
                                                <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""form-group"">
                                                <label class=""form-control-label"" for=""input-country"">Postal code</label>
                                                <input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <hr class=""my-4"" />
                                <!-- Description -->
                                <h6 class=""heading-small text-mu");
                    WriteLiteral(@"ted mb-4"">About me</h6>
                                <div class=""pl-lg-4"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">About Me</label>
                                        <textarea rows=""4"" class=""form-control"" placeholder=""A few words about you ..."">A beautiful Dashboard for Bootstrap 4. It is Free and Open Source.</textarea>
                                    </div>
                                </div>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11998, 2290, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <!-- Footer -->
            <footer class=""footer pt-0"">
                <div class=""row align-items-center justify-content-lg-between"">
                    <div class=""col-lg-6"">
                        <div class=""copyright text-center  text-lg-left  text-muted"">
                            &copy; 2020 <a href=""https://www.creative-tim.com"" class=""font-weight-bold ml-1"" target=""_blank"">Creative Tim</a>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <ul class=""nav nav-footer justify-content-center justify-content-lg-end"">
                            <li class=""nav-item"">
                                <a href=""https://www.creative-tim.com"" class=""nav-link"" target=""_blank"">Creative Tim</a>
                            </li>
                            <li class=""nav-item"">
                              ");
                WriteLiteral(@"  <a href=""https://www.creative-tim.com/presentation"" class=""nav-link"" target=""_blank"">About Us</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""http://blog.creative-tim.com"" class=""nav-link"" target=""_blank"">Blog</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""https://github.com/creativetimofficial/argon-dashboard/blob/master/LICENSE.md"" class=""nav-link"" target=""_blank"">MIT License</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </footer>
        </div>
    </div>
    <!-- Argon Scripts -->
    <!-- Core -->
    <script src=""../assets/vendor/jquery/dist/jquery.min.js""></script>
    <script src=""../assets/vendor/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""../assets/vendor/js-cookie/js.cookie.js""></script>
    <script src=""../as");
                WriteLiteral("sets/vendor/jquery.scrollbar/jquery.scrollbar.min.js\"></script>\r\n    <script src=\"../assets/vendor/jquery-scroll-lock/dist/jquery-scrollLock.min.js\"></script>\r\n    <!-- Argon JS -->\r\n    <script src=\"../assets/js/argon.js?v=1.2.0\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14295, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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

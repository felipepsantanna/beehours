#pragma checksum "C:\Users\felipepsantanna\Documents\GitHub\Beehours\Web\Pages\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cfbae6cef8acbfb726d5cafd5680074dbccf5bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Cadastro), @"mvc.1.0.razor-page", @"/Pages/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cadastro.cshtml", typeof(AspNetCore.Pages_Cadastro), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cfbae6cef8acbfb726d5cafd5680074dbccf5bd", @"/Pages/Cadastro.cshtml")]
    public class Pages_Cadastro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\felipepsantanna\Documents\GitHub\Beehours\Web\Pages\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 1981, true);
            WriteLiteral(@"
        <section class=""signup"">

                <div class=""signup-content"">
                    <form method=""POST"" id=""signup-form"" class=""signup-form"">
                        <h2 class=""form-title"">Create account</h2>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-input"" name=""name"" id=""name"" placeholder=""Nome"" />
                        </div>
                        <div class=""form-group"">
                            <input type=""email"" class=""form-input"" name=""email"" id=""email"" placeholder=""email"" />
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-input"" name=""password"" id=""password"" placeholder=""password"" />
                            <span toggle=""#password"" class=""zmdi zmdi-eye field-icon toggle-password""></span>
                        </div>
                        <div class=""form-group"">
                            <input ty");
            WriteLiteral(@"pe=""password"" class=""form-input"" name=""re_password"" id=""re_password"" placeholder=""Repeat password"" />
                        </div>
                        <div class=""form-group"">
                            <input type=""checkbox"" name=""agree-term"" id=""agree-term"" class=""agree-term"" />
                            <label for=""agree-term"" class=""label-agree-term""><span><span></span></span>I agree all statements in  <a href=""#"" class=""term-service"">Terms of service</a></label>
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" name=""submit"" id=""submit"" class=""form-submit"" value=""Cadastre-se"" />
                        </div>
                    </form>
                    <p class=""loginhere"">
                        Já tem uma conta ? <a href=""#"" class=""loginhere-link"">Entre aqui</a>
                    </p>
                </div>
        </section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Pages.CadastroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Pages.CadastroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Web.Pages.CadastroModel>)PageContext?.ViewData;
        public Web.Pages.CadastroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

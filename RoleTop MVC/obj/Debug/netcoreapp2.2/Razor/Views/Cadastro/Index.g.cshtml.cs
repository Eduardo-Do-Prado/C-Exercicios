#pragma checksum "C:\Users\40205836844\Desktop\Exercicios\RoleTop MVC\Views\Cadastro\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d749bfc85c1fb463f20b6acd73bf54e71006b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Index), @"mvc.1.0.view", @"/Views/Cadastro/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/Index.cshtml", typeof(AspNetCore.Views_Cadastro_Index))]
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
#line 1 "C:\Users\40205836844\Desktop\Exercicios\RoleTop MVC\Views\_ViewImports.cshtml"
using RoleTop_MVC;

#line default
#line hidden
#line 2 "C:\Users\40205836844\Desktop\Exercicios\RoleTop MVC\Views\_ViewImports.cshtml"
using RoleTop_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d749bfc85c1fb463f20b6acd73bf54e71006b5", @"/Views/Cadastro/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f57814a752edb5b847849fefe467cf1e82eff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 86, true);
            WriteLiteral("<main>\n<div class=\"section-container\">\n    <div class=\"content\">\n        \n            ");
            EndContext();
            BeginContext(86, 2382, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d749bfc85c1fb463f20b6acd73bf54e71006b53727", async() => {
                BeginContext(159, 2230, true);
                WriteLiteral(@"

                <section id=""Cadastro""> 

                        <h1>Cadastro</h1>

                <section id=""usuario"">
                <label for=""usuario"">Usuario</label>
                <br />
                <input type=""text"" name=""usuario"">
                </section>

                <section id=""nome"">
                <label>Nome</label>
                <br />
                <input id=""nome"" name=""nome"" type=""text"" maxlength=""20"" minlength=""1"" placeholder=""Nome completo"" >
                </section>

                <section id=""email"">
                <label>E-mail</label>
                <br />
                <input id=""email"" name=""email"" type=""email"" maxlength=""20"" minlength=""1"" placeholder=""E-mail"">
                </section>

                <section id=""telefone"">
                <label>Telefone</label>
                <br />
                <input id=""telefone"" name=""telefone"" type=""number"" maxlength=""20"" minlength=""1"" placeholder=""Telefone"" maxlength=""3"" />
                </section>

");
                WriteLiteral(@"                <section id=""cpf"">
                <label>CPF</label>
                <br />
                <input id=""CPF"" name=""cpf""  type=""number"" maxlength=""20"" minlength=""1"" placeholder=""CPF ou CNPJ"" />
                </section>

                <section id=""Data"">
                <label>Data de Nascimento</label>
                <br />
                <input id=""date"" name=""dataNascimento""  type=""date"" placeholder=""Data de nascimento"" />
                </section>
                
                <section id=""senha"">
                <label>Senha</label>
                <br />
                <input id=""senha"" name=""senha""  type=""password"" maxlength=""20"" minlength=""1""placeholder=""Senha"" />
                </section>
                <section id=""termos"">
                    
                    <label><input type=""checkbox"" checked=""checked"" name=""Termos""> Li e concordo com os termos de uso.</label></section>
                        
                    <section id=""enviar-cadastro"">
                   ");
                WriteLiteral("         <p><input type=\"submit\" value=\"Finalizar cadastro\" />Cadastrar</p>\n                            </section>\n                \n                <div id=\"loga\">\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2389, "\'", 2427, 1);
#line 61 "C:\Users\40205836844\Desktop\Exercicios\RoleTop MVC\Views\Cadastro\Index.cshtml"
WriteAttributeValue("", 2396, Url.Action("Login", "Cliente"), 2396, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2428, 33, true);
                WriteLiteral("> Ir para Login</a> \n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 5 "C:\Users\40205836844\Desktop\Exercicios\RoleTop MVC\Views\Cadastro\Index.cshtml"
AddHtmlAttributeValue("", 114, Url.Action("CadastrarCliente", "Cadastro"), 114, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2468, 52, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n</section>\n</main>");
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

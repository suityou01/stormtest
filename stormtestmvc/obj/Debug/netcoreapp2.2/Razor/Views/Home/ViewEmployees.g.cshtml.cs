#pragma checksum "/app/Views/Home/ViewEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6234ae87f254d19813206817f4c3012c126f86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEmployees), @"mvc.1.0.view", @"/Views/Home/ViewEmployees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewEmployees.cshtml", typeof(AspNetCore.Views_Home_ViewEmployees))]
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
#line 1 "/app/Views/_ViewImports.cshtml"
using stormtestmvc;

#line default
#line hidden
#line 2 "/app/Views/_ViewImports.cshtml"
using stormtestmvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6234ae87f254d19813206817f4c3012c126f86", @"/Views/Home/ViewEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"226ed69937253d1a65dbe4187708ba6c7a4f48c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/app/Views/Home/ViewEmployees.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(50, 24, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(74, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6234ae87f254d19813206817f4c3012c126f863319", async() => {
                BeginContext(80, 93, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>View Employees</title>\n");
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
            BeginContext(180, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(181, 4120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6234ae87f254d19813206817f4c3012c126f864575", async() => {
                BeginContext(187, 2214, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row border-0"">
            <div class=""col"">
                <div class=""card text-center"">
                    <div class=""card-header"">
                        Employees
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-hover"" id='employeeTable'>
                            <thead>
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">First</th>
                                    <th scope=""col"">Last</th>
                                    <th scope=""col"">Email</th>
                                    <th scope=""col"">Identifier</th>
                                    <th scope=""col"">Created Date</th>
                                    <th scope=""col"">isDeleted</th>
                                </tr>
                            </thead>
                            <tbody>
                   ");
                WriteLiteral(@"         </tbody>
                        </table>
                    </div>
                    <div class=""card-footer text-muted"">
                        <div id='pagination'></div>
                        <nav aria-label=""..."">
                            <ul class=""pagination pagination-sm float-right"">
                                <li class=""page-item"" id=""page1""><a class=""page-link"" href=""/home/viewemployees?pageNumber=1"">1</a></li>
                                <li class=""page-item"" id=""page2""><a class=""page-link"" href=""/home/viewemployees?pageNumber=2"">2</a></li>
                                <li class=""page-item"" id=""page3""><a class=""page-link"" href=""/home/viewemployees?pageNumber=3"">3</a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <template id='rowtemplate'>
        <tr>
            <th scope=""row"">Id</th>
            <td>First Name</td>
            <td>Last Name</t");
                WriteLiteral("d>\n            <td>Email Address</td>\n            <td>Identifier</td>\n            <td>Created Date</td>\n            <td>Is Deleted</td>\n        </tr>\n    </template>\n");
                EndContext();
                DefineSection("scripts", async() => {
                    BeginContext(2419, 1873, true);
                    WriteLiteral(@"
    <script>
        const urlParams = new URLSearchParams(window.location.search);
        const pageNumber = urlParams.get('pageNumber');
        
        fetch('employees', {
                method: 'GET',
                headers: { 
                    'Content-Type' : 'application/json',
                    'Authorization' : 'Bearer:' + localStorage.getItem('currentUser').toString()
                }
            })
                .then(response => response.json())
                .then(employees => {
                    var tableBody = document.getElementById('employeeTable').getElementsByTagName('tbody')[0];
                    [...employees].forEach((item)=>{
                        empRow=document.getElementById(""rowtemplate"");
                        var clon = empRow.content.cloneNode(true);
                        clon.firstElementChild.getElementsByTagName('th')[0].innerHTML = ""<a href='/home/employee?id="" + item.id + ""'>"" + item.id + ""</a>"";
                        clon.firstElementChild.getEle");
                    WriteLiteral(@"mentsByTagName('td')[0].innerText = item.first_Name;
                        clon.firstElementChild.getElementsByTagName('td')[1].innerText = item.last_Name;
                        clon.firstElementChild.getElementsByTagName('td')[2].innerText = item.email;
                        clon.firstElementChild.getElementsByTagName('td')[3].innerText = item.identifier;
                        clon.firstElementChild.getElementsByTagName('td')[4].innerText = moment(item.createdDate).format('DD/MM/YYYY');
                        clon.firstElementChild.getElementsByTagName('td')[5].innerText = item.isDeleted;
                        tableBody.appendChild(clon);
                    });
                })
    </script>
    <script>
        $(document).ready(function(){
            $('#page' + pageNumber).addClass('active');
        });
    </script>
");
                    EndContext();
                }
                );
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
            BeginContext(4301, 9, true);
            WriteLiteral("\n</html>\n");
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

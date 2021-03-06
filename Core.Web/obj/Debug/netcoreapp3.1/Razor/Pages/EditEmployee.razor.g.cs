#pragma checksum "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f44fae5e9b62adeeacc9dab345b633a5d9102a74"
// <auto-generated/>
#pragma warning disable 1591
namespace Core.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Core.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Core.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\EmployeeManagment\Core.Web\_Imports.razor"
using Core.RazorTemplate;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "section__content");
            __builder.AddAttribute(2, "style", "direction:ltr");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                              editEmployeeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<label for=\"FirstName\">FirstName</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "FirstName");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                           editEmployeeModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editEmployeeModel.FirstName = __value, editEmployeeModel.FirstName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editEmployeeModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.AddMarkupContent(33, "<label for=\"LastName\">LastName</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "LastName");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                          editEmployeeModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editEmployeeModel.LastName = __value, editEmployeeModel.LastName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editEmployeeModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.AddMarkupContent(45, "<label for=\"Email\">Email</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "Email");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                       editEmployeeModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editEmployeeModel.Email = __value, editEmployeeModel.Email))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editEmployeeModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.AddMarkupContent(57, "<label for=\"DepartmentId\">Department</label>\r\n                    ");
                __Blazor.Core.Web.Pages.EditEmployee.TypeInference.CreateCustomSelectList_0(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 24 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                   editEmployeeModel.DepartmentId

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editEmployeeModel.DepartmentId = __value, editEmployeeModel.DepartmentId)), 62, () => editEmployeeModel.DepartmentId, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n");
#nullable restore
#line 25 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                         foreach (var item in Departments)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(65, "                            ");
                    __builder3.OpenElement(66, "option");
                    __builder3.AddAttribute(67, "value", 
#nullable restore
#line 27 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                            item.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(68, 
#nullable restore
#line 27 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                                item.DeparmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n");
#nullable restore
#line 28 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(70, "                    ");
                }
                );
                __builder2.AddMarkupContent(71, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.AddMarkupContent(76, "<label for=\"DepartmentId\">Gender</label>\r\n                    ");
                __Blazor.Core.Web.Pages.EditEmployee.TypeInference.CreateInputSelect_1(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 33 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                              editEmployeeModel.Gender

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editEmployeeModel.Gender = __value, editEmployeeModel.Gender)), 81, () => editEmployeeModel.Gender, 82, (__builder3) => {
                    __builder3.AddMarkupContent(83, "\r\n");
#nullable restore
#line 34 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                         foreach (var item in Enum.GetValues(typeof( Core.Model.Gender)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(84, "                            ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 36 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                            item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(87, 
#nullable restore
#line 36 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                                                   item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n");
#nullable restore
#line 37 "E:\Blazor\EmployeeManagment\Core.Web\Pages\EditEmployee.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(89, "                    ");
                }
                );
                __builder2.AddMarkupContent(90, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.AddMarkupContent(92, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Core.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomSelectList_0<IValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, IValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<IValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<IValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Core.RazorTemplate.CustomSelectList<IValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Novorfay\server\Pages\EditApplicationUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1a5b7e3bbfe29c6d70ee2ad57291ca168104353"
// <auto-generated/>
#pragma warning disable 1591
namespace NovorfayProductCatalogue.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Novorfay\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Novorfay\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Novorfay\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Novorfay\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Novorfay\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Novorfay\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Novorfay\server\_Imports.razor"
using NovorfayProductCatalogue.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using NovorfayProductCatalogue.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using NovorfayProductCatalogue.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-application-user/{Id}")]
    public partial class EditApplicationUser : NovorfayProductCatalogue.Pages.EditApplicationUserComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<ApplicationUser>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApplicationUser>(
#nullable restore
#line 18 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                           user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                            user != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#nullable restore
#line 18 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                                                    Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Component", "UserName");
                    __builder3.AddAttribute(19, "style", "width: 100%");
                    __builder3.AddAttribute(20, "Text", "User Name");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddAttribute(27, "Name", "UserName");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                                  user.UserName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.UserName = __value, user.UserName))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.UserName));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                    __builder3.AddAttribute(38, "Component", "Email");
                    __builder3.AddAttribute(39, "style", "width: 100%");
                    __builder3.AddAttribute(40, "Text", "Email");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(44);
                    __builder3.AddAttribute(45, "style", "width: 100%");
                    __builder3.AddAttribute(46, "Name", "Email");
                    __builder3.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                  user.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(53, "class", "row");
                    __builder3.OpenElement(54, "div");
                    __builder3.AddAttribute(55, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(56);
                    __builder3.AddAttribute(57, "Component", "RoleNames");
                    __builder3.AddAttribute(58, "style", "width: 100%");
                    __builder3.AddAttribute(59, "Text", "Roles");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\n              ");
                    __builder3.OpenElement(61, "div");
                    __builder3.AddAttribute(62, "class", "col-md-9");
                    __Blazor.NovorfayProductCatalogue.Pages.EditApplicationUser.TypeInference.CreateRadzenDropDown_0(__builder3, 63, 64, 
#nullable restore
#line 46 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                       roles

#line default
#line hidden
#nullable disable
                    , 65, 
#nullable restore
#line 46 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                        true

#line default
#line hidden
#nullable disable
                    , 66, "width: 100%", 67, "Name", 68, "Name", 69, "RoleNames", 70, 
#nullable restore
#line 46 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                                                                     user.RoleNames

#line default
#line hidden
#nullable disable
                    , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.RoleNames = __value, user.RoleNames)), 72, () => user.RoleNames);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(79);
                    __builder3.AddAttribute(80, "Component", "Password");
                    __builder3.AddAttribute(81, "style", "width: 100%");
                    __builder3.AddAttribute(82, "Text", "Password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\n              ");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(86);
                    __builder3.AddAttribute(87, "style", "width: 100%");
                    __builder3.AddAttribute(88, "Name", "Password");
                    __builder3.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                   user.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\n            ");
                    __builder3.OpenElement(93, "div");
                    __builder3.AddAttribute(94, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(95, "class", "row");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(98);
                    __builder3.AddAttribute(99, "Component", "ConfirmPassword");
                    __builder3.AddAttribute(100, "style", "width: 100%");
                    __builder3.AddAttribute(101, "Text", "Confirm password");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n              ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(105);
                    __builder3.AddAttribute(106, "style", "width: 100%");
                    __builder3.AddAttribute(107, "Name", "ConfirmPassword");
                    __builder3.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                   user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(111, "\n            ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "row");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(116);
                    __builder3.AddAttribute(117, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 72 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 72 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "Icon", "save");
                    __builder3.AddAttribute(120, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(121, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(122);
                    __builder3.AddAttribute(123, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 74 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "Text", "Cancel");
                    __builder3.AddAttribute(125, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Novorfay\server\Pages\EditApplicationUser.razor"
                                                                                    Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.NovorfayProductCatalogue.Pages.EditApplicationUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Multiple", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

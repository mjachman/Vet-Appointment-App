#pragma checksum "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa3b0847f6153cb4b5505778aadad8d961275d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_VetAppointmentList), @"mvc.1.0.view", @"/Views/Appointment/VetAppointmentList.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\_ViewImports.cshtml"
using VetAppointment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\_ViewImports.cshtml"
using VetAppointment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa3b0847f6153cb4b5505778aadad8d961275d7", @"/Views/Appointment/VetAppointmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780a22457cf630240fc7e2415b721d2005da3b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_VetAppointmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VetAppointment.Models.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
  
    ViewData["Title"] = "VetAppointmentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Moje wizyty</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Klient\r\n            </th>\r\n");
            WriteLiteral("            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        <td>\r\n            ");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Client.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
                                                        Write(Html.DisplayFor(modelItem => item.Client.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" [");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => item.Client.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\r\n            tel: ");
#nullable restore
#line 34 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
            Write(Html.DisplayFor(modelItem => item.Client.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n          \r\n            <td>\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aa3b0847f6153cb4b5505778aadad8d961275d76518", async() => {
                WriteLiteral("Odwołaj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
                                         WriteLiteral(item.AppointmentID);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\VetAppointment\VetAppointment\Views\Appointment\VetAppointmentList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VetAppointment.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
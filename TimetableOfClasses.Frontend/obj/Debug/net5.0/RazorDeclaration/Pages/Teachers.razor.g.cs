// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TimetableOfClasses.Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using TimetableOfClasses.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/_Imports.razor"
using TimetableOfClasses.Frontend.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/teachers")]
    public partial class Teachers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/Pages/Teachers.razor"
       
    private Teacher[] data;

    protected override async Task OnInitializedAsync()
    {
        data = await Http.GetFromJsonAsync<Teacher[]>("sample-data/teachers.json");
    }

    public class Teacher
    {
        public string id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string patronymic { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

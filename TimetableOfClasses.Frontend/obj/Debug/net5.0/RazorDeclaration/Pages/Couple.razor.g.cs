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
    [Microsoft.AspNetCore.Components.RouteAttribute("/couple")]
    public partial class Couple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/yaroslav/Desktop/LabaDotNet/TimeTableApp/TimetableOfClasses.Frontend/Pages/Couple.razor"
           
private CoupleType[] data;

    protected override async Task OnInitializedAsync()
    {
        data = await Http.GetFromJsonAsync<CoupleType[]>("sample-data/couples.json");
    }

    public class CoupleType
    {

        public string id { get; set; }

        public int coupleNum { get; set; }

        public string beginTime { get; set; }

        public string endTime { get; set; }

    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

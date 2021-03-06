#pragma checksum "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6fbb187fd1456a0fae5a022b43e93e404399104"
// <auto-generated/>
#pragma warning disable 1591
namespace GetBroswerTimeZone
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public class UTCToLocal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
#nullable restore
#line 3 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
 if (Pattern != "")
{
    

#line default
#line hidden
#nullable disable
            builder.AddContent(0, 
#nullable restore
#line 5 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
     Result.ToString(Pattern)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
                             
}
else
{
    

#line default
#line hidden
#nullable disable
            builder.AddContent(1, 
#nullable restore
#line 9 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
     Result

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
           
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\jbomh\source\repos\TownControl\GetBroswerTimeZone\UTCToLocal.razor"
       
    [Parameter] public DateTime Date { get; set; }
    [Parameter] public string Pattern { get; set; } = "";
    private bool HasRendered { get; set; }
    private DateTime Result { get; set; }

    protected async override Task OnAfterRenderAsync()
    {
        if(!HasRendered)
        {
            var localTimezone = await TimeZoneJSInterop.GetTimeZoneAsync(js);
            localTimezone = localTimezone.Replace(":3", ".5");
            localTimezone = localTimezone.Replace(":", ".");
            Result = Date.AddHours(Convert.ToDouble(localTimezone));
            StateHasChanged();
            HasRendered = true;
        }
        
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591

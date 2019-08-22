using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace GetBroswerTimeZone
{
    public class TimeZoneJSInterop
    {
        public static Task<string> GetTimeZoneAsync(IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<string>("GetBroswerTimeZone.Get");
        }
    }
}

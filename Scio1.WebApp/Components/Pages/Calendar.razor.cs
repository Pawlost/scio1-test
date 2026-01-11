using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Scio1.WebApp.Components.Pages
{
    /*
    public partial class Calendar
    {
        public List<FullCalendarEventWrapper> Events { get; set; } = new()
    {
        new FullCalendarEventWrapper { Title = "Meeting", Start = "2026-01-15" },
        new FullCalendarEventWrapper { Title = "Conference", Start = "2026-01-18", End = "2026-01-20" }
    };

        private string CalendarId = "calendarId";

        [Inject] private IJSRuntime JSRuntime { get; set; }

        public class FullCalendarEventWrapper
        {
            public string Title { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
            public string ClassName { get; set; }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("initializeCalendar", CalendarId, Events);
            }
        }
    }*/
}

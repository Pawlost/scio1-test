window.initializeCalendar = (elementId, events) => {
    const calendarEl = document.getElementById(elementId);

    const calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
         events: events 
      });

    calendar.render();
};
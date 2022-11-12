using System;

namespace MauiPerpetualCalendar.Models
{
    public class CalendarGroup : List<CalendarModel>
    {
        public int CalendarNumber { get; set; }
        public string Years { get; set; }
        public CalendarGroup(int calendarnumber, List<CalendarModel> calendars) : base(calendars)
        {
            CalendarNumber = calendarnumber;
        }
    }
}

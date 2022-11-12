using MauiPerpetualCalendar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPerpetualCalendar.ViewModels
{
    public class YearsGroupedViewModel
    {
        public List<CalendarGroup> Calendars { get; set; } = new List<CalendarGroup>();
        PerpetualCalendar PerpetualCalendar { get; set; } = new PerpetualCalendar();
        public YearsGroupedViewModel()
        {
            Calendars.Add(new CalendarGroup(1, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[1].ToList() }
            }));
            Calendars.Add(new CalendarGroup(2, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[2].ToList() }
            }));
            Calendars.Add(new CalendarGroup(3, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[3].ToList() }
            }));
            Calendars.Add(new CalendarGroup(4, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[4].ToList() }
            }));
            Calendars.Add(new CalendarGroup(5, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[5].ToList() }
            }));
            Calendars.Add(new CalendarGroup(6, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[6].ToList() }
            }));
            Calendars.Add(new CalendarGroup(7, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[7].ToList() }
            }));
            Calendars.Add(new CalendarGroup(8, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[8].ToList() }
            }));
            Calendars.Add(new CalendarGroup(9, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[9].ToList() }
            }));
            Calendars.Add(new CalendarGroup(10, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[10].ToList() }
            }));
            Calendars.Add(new CalendarGroup(11, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[11].ToList() }
            }));
            Calendars.Add(new CalendarGroup(12, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[12].ToList() }
            }));
            Calendars.Add(new CalendarGroup(13, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[13].ToList() }
            }));
            Calendars.Add(new CalendarGroup(14, new List<CalendarModel>
            {
                new CalendarModel() { Years = PerpetualCalendar.YearList[14].ToList() }
            }));
        }
    }
}

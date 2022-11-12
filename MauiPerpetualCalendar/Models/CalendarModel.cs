using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPerpetualCalendar.Models
{
    public class CalendarModel
    {
        public List<int> Years { get; set; }
        public string YearString { get; set; }
        public override string ToString()
        {
            foreach (var item in Years)
            {
                YearString += item;
            }
            return YearString;
        }
    }
}

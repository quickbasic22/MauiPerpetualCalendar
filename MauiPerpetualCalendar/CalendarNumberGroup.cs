namespace MauiPerpetualCalendar
{
    public class CalendarNumberGroup
    {
        public static PerpetualCalendar Calendar2 { get; set; }
        public PerpetualCalendar Calendar { get; set; }
        public string YearGroup { get; set; }
        public string YearGroup2 { get; set; }
        public List<int> Years { get; set; }
        public static List<int> Years2 { get; set; }
        public CalendarNumberGroup()
        {
            Calendar = new PerpetualCalendar();
            Years = new List<int>();
        }
        static CalendarNumberGroup()
        {
            Calendar2 = new PerpetualCalendar();
            Years2 = new List<int>();
        }
        public static List<int> getYearsStatic(int year)
        {
            int[] listYears = new int[53];
            var yrslist = Calendar2.YearList[year];
            foreach ( var yrs in yrslist )
            {
                Years2.Add(yrs);
            }
            return Years2;
        }

        public List<int> getYears(int year)
        {
            int[] listYears = new int[53];
            var yrslist = Calendar.YearList[year];
            foreach (var yrs in yrslist)
            {
                Years.Add(yrs);
            }
            return Years;
        }
    }

    
}

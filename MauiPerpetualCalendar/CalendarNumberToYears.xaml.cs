using System.Collections.ObjectModel;

namespace MauiPerpetualCalendar;

public partial class CalendarNumberToYears : ContentPage
{
	PerpetualCalendar calendar;

    public ObservableCollection<int> Years { get; set; } 
	public CalendarNumberToYears()
	{
		InitializeComponent();
		calendar = new PerpetualCalendar();
		Years = new ObservableCollection<int>
		{
		   1973,
		   1979,
		   1991,
		   2007,
		   2022
		};
		BindingContext = this;
	}

	private void ListYearsButton_Clicked(object sender, EventArgs e)
	{
		Years.Clear();
		Console.Beep();
		int calnum = int.Parse(CalendarNumberEntry.Text);
		var yearsforCalendar = calendar.YearList[calnum];
		foreach (int year in yearsforCalendar)
		{
			Years.Add(year);
		}

    }
}
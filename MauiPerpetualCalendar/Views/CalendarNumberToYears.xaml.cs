using System.Collections.ObjectModel;
using MauiPerpetualCalendar.Models;

namespace MauiPerpetualCalendar.Views;

public partial class CalendarNumberToYears : ContentPage
{
	readonly PerpetualCalendar calendar;

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
		int calnum = int.Parse(CalendarNumberEntry.Text);
		var yearsforCalendar = calendar.YearList[calnum];
		foreach (int year in yearsforCalendar)
		{
			Years.Add(year);
		}

    }
}
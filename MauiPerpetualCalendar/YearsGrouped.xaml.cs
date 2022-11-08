using System.Collections.ObjectModel;

namespace MauiPerpetualCalendar;

public partial class YearsGrouped : ContentPage
{
	public PerpetualCalendar PerpetualCalendar { get; set; }
	public ObservableCollection<CalendarNumberGroup> Years { get; set; }
	public string[] YearNames = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen" };

	public YearsGrouped()
	{
		InitializeComponent();
		PerpetualCalendar = new PerpetualCalendar();
		CalendarNumberGroup calGroup = new CalendarNumberGroup();
		int cnt = 0;
		List<List<int>> yearCollectionStore = new List<List<int>>();
		yearCollectionStore.Add(PerpetualCalendar.Year1);
		yearCollectionStore.Add(PerpetualCalendar.Year2);
		yearCollectionStore.Add(PerpetualCalendar.Year3);
		yearCollectionStore.Add(PerpetualCalendar.Year4);
		yearCollectionStore.Add(PerpetualCalendar.Year5);
		yearCollectionStore.Add(PerpetualCalendar.Year6);
		yearCollectionStore.Add(PerpetualCalendar.Year7);
		yearCollectionStore.Add(PerpetualCalendar.Year8);
		yearCollectionStore.Add(PerpetualCalendar.Year9);
	    yearCollectionStore.Add(PerpetualCalendar.Year10);
		yearCollectionStore.Add(PerpetualCalendar.Year11);
		yearCollectionStore.Add(PerpetualCalendar.Year12);
		yearCollectionStore.Add(PerpetualCalendar.Year13);
		yearCollectionStore.Add(PerpetualCalendar.Year14);
	   
		foreach (string name in YearNames)
		{
			calGroup.YearGroup = YearNames[cnt];
			calGroup.Years = yearCollectionStore[cnt];
			cnt++;
			Years.Add(calGroup); 
        }
				
	}

	


}
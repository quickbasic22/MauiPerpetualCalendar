using System.Collections.ObjectModel;
using MauiPerpetualCalendar.Models;

namespace MauiPerpetualCalendar.Views;

public partial class MainPage : ContentPage
{
    public ObservableCollection<int> CalendarNumber { get; set; }
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        PerpetualCalendar calendar = new PerpetualCalendar();
        int year = int.Parse(entryNumber.Text);

        //Debug.WriteLine(calendar.YearList.Count);
        //Debug.WriteLine(calendar.YearList.Values.Count);

        int calendarN = 0;
        foreach (var kv in calendar.YearList)
        {
            calendarN++;
            foreach (var num in kv.Value)
            {
                if (num == year)
                AnswerLabel.Text = $"Calendar number {calendarN} has {year}";
            }
        }

    }
}


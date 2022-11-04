using System.Diagnostics;
using System.Linq;

namespace MauiPerpetualCalendar;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        PerpetualCalendar calendar = new PerpetualCalendar();
        int year = int.Parse(entryNumber.Text);

        Debug.WriteLine(calendar.YearList.Count);
        Debug.WriteLine(calendar.YearList.Values.Count);

        int CalNumber = 0;

        foreach (KeyValuePair<int, int[]> item in calendar.YearList)
        {
            CalNumber++;
            foreach (int val in item.Value)
            {
                if (val == year)
                {
                    Debug.WriteLine($"Calendar number is {CalNumber}");
                    break;
                }
            }
        }

    }
}


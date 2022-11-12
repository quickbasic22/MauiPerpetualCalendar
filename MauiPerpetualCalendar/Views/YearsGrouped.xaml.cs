using System.Collections.ObjectModel;
using MauiPerpetualCalendar.Models;
using MauiPerpetualCalendar.ViewModels;

namespace MauiPerpetualCalendar.Views;

public partial class YearsGrouped : ContentPage
{
	public YearsGrouped()
	{
		InitializeComponent();
		BindingContext = new YearsGroupedViewModel();
	}
}
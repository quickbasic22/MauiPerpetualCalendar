using MauiPerpetualCalendar.Models;
using System.Diagnostics;

namespace MauiPerpetualCalendar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
}

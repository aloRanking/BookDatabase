﻿using BookDatabase.Views;
namespace BookDatabase;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddOrUpdateBookPage), typeof(AddOrUpdateBookPage));
		Routing.RegisterRoute(nameof(BookDetailsPage), typeof(BookDetailsPage));
	}
}

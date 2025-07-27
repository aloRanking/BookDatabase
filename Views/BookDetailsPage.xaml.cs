
using BookDatabase.ViewModels;

namespace BookDatabase.Views;

public partial class BookDetailsPage : ContentPage
{
	public BookDetailsPage(BookDetailsPageViewmodel bookDetailsPageViewmodel)
	{
		InitializeComponent();
		BindingContext = bookDetailsPageViewmodel;
	}

	protected override void OnAppearing()
{
    base.OnAppearing();

    if (BindingContext is BookDetailsPageViewmodel vm)
    {
        vm.ReloadBookCommand.Execute(null);
    }
}
}
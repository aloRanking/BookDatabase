
using BookDatabase.ViewModels;

namespace BookDatabase.Views;

public partial class BookDetailsPage : ContentPage
{
	public BookDetailsPage(BookDetailsPageViewmodel bookDetailsPageViewmodel)
	{
		InitializeComponent();
		BindingContext = bookDetailsPageViewmodel;
	}
}
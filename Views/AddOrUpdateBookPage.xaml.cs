using BookDatabase.ViewModels;

namespace BookDatabase.Views;

public partial class AddOrUpdateBookPage : ContentPage
{
    public AddOrUpdateBookPage(AddOrUpdateBookPageViewmodel addOrUpdateBookPageViewmodel)
    {
        InitializeComponent();
        BindingContext = addOrUpdateBookPageViewmodel;
    }
}
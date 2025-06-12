using CommunityToolkit.Mvvm.ComponentModel;
using BookDatabase.Models;

namespace BookDatabase.ViewModels
{
    [QueryProperty(nameof(BookModel), "ViewBookDetails")]
    public partial class BookDetailsPageViewmodel : AddBookBaseViewModel
    {
        [ObservableProperty]
        private Book _bookModel;
    }
}
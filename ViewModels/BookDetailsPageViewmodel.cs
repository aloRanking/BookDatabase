using CommunityToolkit.Mvvm.ComponentModel;
using BookDatabase.Models;
using BookDatabase.DataServices;
using CommunityToolkit.Mvvm.Input;
using BookDatabase.Views;

namespace BookDatabase.ViewModels
{
    [QueryProperty(nameof(BookModel), "ViewBookDetails")]


    public partial class BookDetailsPageViewmodel : AddBookBaseViewModel
    {
        [ObservableProperty]
        private Book _bookModel;
        private readonly IBookService bookService;
        public BookDetailsPageViewmodel(IBookService bookService)
        {
            this.bookService = bookService;

        }


[RelayCommand]
        private async Task UpdateBookData(Book bookToBeUpdated)
        {

            //get full description
            var desc = await bookService.GetBookAsync(bookToBeUpdated.Id);
            var navigationParameter = new Dictionary<string, object>();
            navigationParameter.Add("UpdateBookData", desc);
            await Shell.Current.GoToAsync(nameof(AddOrUpdateBookPage), navigationParameter);

        }
    }
}
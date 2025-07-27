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

        private int _bookId;
         private bool _isFirstLoad = true;
        private readonly IBookService bookService;
        public BookDetailsPageViewmodel(IBookService bookService)
        {
            this.bookService = bookService;

        }

        partial void OnBookModelChanged(Book value)
        {
            if (value is not null)
                _bookId = value.Id;
        }

        [RelayCommand]


        public async Task ReloadBook()
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;
                return;
            }

            if (_bookId > 0)
            {
                BookModel = await bookService.GetBookAsync(_bookId);
            }
        }




        [RelayCommand]
        private async Task LoadBookFromDatabase(Book bookToBeUpdated)
        {
            BookModel = await bookService.GetBookAsync(bookToBeUpdated.Id);
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
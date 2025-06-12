using CommunityToolkit.Mvvm.ComponentModel;
namespace BookDatabase.ViewModels
{
    public partial class AddBookBaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;
    }
}
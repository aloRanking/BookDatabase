using BookDatabase.DataServices;
using BookDatabase.ViewModels;
using BookDatabase.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;


namespace BookDatabase;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
         builder
        .UseMauiApp<App>()
        .UseMauiCommunityToolkit() // 👈 Must be right after UseMauiApp
        .ConfigureSyncfusionCore()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        builder.Services.AddTransient<IBookService, BookService>();
        builder.Services.AddTransient<AddOrUpdateBookPage>();
        builder.Services.AddTransient<AddOrUpdateBookPageViewmodel>();
        builder.Services.AddTransient<BooklistHomePageViewmodel>();
        builder.Services.AddTransient<BooklistHomePage>();
        builder.Services.AddTransient<BookDetailsPageViewmodel>();
        builder.Services.AddTransient<BookDetailsPage>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
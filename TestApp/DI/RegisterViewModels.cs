using System;
namespace TestApp.DI
{
    public static class RegisterViewModels
    {

        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder mauiAppBuilder)

        {
            mauiAppBuilder.Services.AddSingleton<ViewModels.FirstPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.SecondPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Tab1ViewModel>();


            return mauiAppBuilder;
        }
    }
}


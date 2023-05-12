using System;
using TestApp.Views;
namespace TestApp.DI
{
    public static class RegisterViews
    {
        public static MauiAppBuilder ConfigureViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<FirstPage>();
            mauiAppBuilder.Services.AddTransient<SecondPage>();
            mauiAppBuilder.Services.AddTransient<Tab1>();

            return mauiAppBuilder;
        }
    }
}


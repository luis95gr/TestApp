using System;
using Android.Net;
using Mopups.Interfaces;
using Mopups.Services;
using Supabase;
using Supabase.Interfaces;
using TestApp.Interfaces;
using TestApp.Services;

namespace TestApp.DI
{
    public static class RegisterServices
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder mauiAppBuilder)

        {
            //mauiAppBuilder.Services.AddSingleton<IApiService, ApiService>();

            //var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            //var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");
            var options = new SupabaseOptions
            {
                AutoRefreshToken = true,
                AutoConnectRealtime = true,
                SessionHandler = new DefaultSupabaseSessionHandler()
            };

            //mauiAppBuilder.Services.AddSingleton(provider => new Supabase.Client(url, key, options));
            //mauiAppBuilder.Services.AddSingleton<IDataService, DataService>();
            mauiAppBuilder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);

            return mauiAppBuilder;
        }
    }
}


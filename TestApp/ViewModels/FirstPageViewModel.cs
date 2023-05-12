using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Database;
using TestApp.Interfaces;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public partial class FirstPageViewModel : ObservableObject
    {
        #region AnP
        public ObservableCollection<Fruit> FruitsCollection { get; set; } = new();
        string url = App.Current.Resources["UrlAPI"].ToString();
        FirebaseClient firebaseClient;
        private readonly IDataService _dataService;
        [ObservableProperty]
        private bool isRefreshing;
        #endregion

        #region Constructor
        public FirstPageViewModel()
        {
            //firebaseClient = new FirebaseClient(url);
            //_dataService = dataService;

            Load();

        }
        #endregion

        #region Commands
        [RelayCommand]
        private void RemainingItemsThresholdReached()
        {

        }
        [RelayCommand]
        private void Refresh()
        {
            IsRefreshing = true;
            Load();
            IsRefreshing = false;
        }
        #endregion

        #region Methods
        private void Load()
        {

            //var session = await supabase.Auth.SignUp(email, password);
            FruitsCollection.Clear();
            firebaseClient = new FirebaseClient("https://test-db-fc04c-default-rtdb.firebaseio.com/");
            try
            {
                var result = firebaseClient.Child("fruits").AsObservable<Fruit>().Subscribe((item) =>
                {
                    if (item.Object != null)
                    {
                        FruitsCollection.Add(item.Object);
                    }
                });
            }
            catch (FirebaseException fireException)
            {
                Debug.Print(fireException.Message);
            }

        }
        #endregion

    }
}


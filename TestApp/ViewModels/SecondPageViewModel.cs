using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public partial class SecondPageViewModel : ObservableObject
    {
        #region AnP

        public ObservableCollection<Event> Events { get; set; } = new();
        #endregion

        #region Constructor
        public SecondPageViewModel()
        {
            LoadEvents();
        }
        #endregion

        #region Commands
        [RelayCommand]
        void Tapped(Object obj)
        {

        }
        #endregion

        #region Methods
        private void LoadEvents()
        {
            Events.Add(new Event()
            {
                EventName = "Prueba",
                From = new DateTime(2023,02,12),
                To = new DateTime(2023,02,13),
                Notes = "Se llevará a cabo el jueves"
            });

            Events.Add(new Event()
            {
                EventName = "Prueba 2",
                From = new DateTime(2023, 02, 12),
                To = new DateTime(2023, 02, 12),
                Notes = "Se llevará a cabo el jueves",
                IsAllDay = true
            });
            Events.Add(new Event()
            {
                EventName = "ASUETO (NO HAY CLASES - NO HAY ESTANCIA)",
                Location = "Hola",
                From = new DateTime(2023, 02, 20,15,10,20),
                To = new DateTime(2023, 02, 20,17,10,20),
                Notes = "Se llevará a cabo el jueves",
                IsAllDay = true,
                Background = new SolidColorBrush(Color.FromArgb("#00928A"))
            });
        }
        #endregion

    }
}


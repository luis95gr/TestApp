using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestApp.ViewModels
{
	public partial class Tab1ViewModel : ObservableObject
	{
		#region AnP
		[ObservableProperty]
		private string label1;
		#endregion
		public Tab1ViewModel()
		{
			Label1 = "Tab 1 binded";
		}
	}
}


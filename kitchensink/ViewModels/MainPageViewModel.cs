using mymodule.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kitchensink.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
			GoCommand = new DelegateCommand(Go);
		}

		public DelegateCommand GoCommand { get; private set; }

		async void Go()
		{
			await NavigationService.NavigateAsync("NavigationPage/ViewA");
		}
	}
}

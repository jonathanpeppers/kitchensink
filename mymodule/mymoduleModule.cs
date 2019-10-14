using Prism.Ioc;
using Prism.Modularity;
using mymodule.Views;
using mymodule.ViewModels;

namespace mymodule
{
	public class mymoduleModule : IModule
	{
		public void OnInitialized(IContainerProvider containerProvider)
		{

		}

		public void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
		}
	}
}

using NavigationTree.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace NavigationTree
{
    public class NavigationTreeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionMan = containerProvider.Resolve<IRegionManager>();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
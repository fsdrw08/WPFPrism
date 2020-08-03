using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPrismModels;

namespace NavigationTree.ViewModels
{
    internal static class TreeViewItemCreator
    {
        internal static TreeViewItemViewModel Create(WPFPrismData appData)
        {
            var rootNode = new TreeViewItemViewModel(appData.Student);
            var pyhsicalClass = new TreeViewItemViewModel("physical measurement");
            rootNode.Children.Add(pyhsicalClass);

            foreach (var item in appData.Physicals)
            {
                var child = new TreeViewItemViewModel(item);
                pyhsicalClass.Children.Add(child);
            }

            var testPointClass = new TreeViewItemViewModel("measure result");
            rootNode.Children.Add(testPointClass);

            foreach (var item in appData.TestPoints)
            {
                var child = new TreeViewItemViewModel(item);
                testPointClass.Children.Add(child);
            }

            return rootNode;
        }
    }
}

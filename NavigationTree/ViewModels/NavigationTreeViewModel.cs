using Prism.Commands;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using WPFPrismModels;

namespace NavigationTree.ViewModels
{
    public class NavigationTreeViewModel : BindableBase, System.IDisposable
    {
        /// <summary>
        /// get TreeViewItem
        /// </summary>
        public ReadOnlyReactiveCollection<TreeViewItemViewModel> TreeNodes { get; }

        private WPFPrismData appData = null;

        private TreeViewItemViewModel rootNode = null;

        private System.Reactive.Disposables.CompositeDisposable _disposables
            = new System.Reactive.Disposables.CompositeDisposable();

        /// <summary>Constructor</summary>
        /// <param name="data">app data object (inject from Unity)</param>
        public NavigationTreeViewModel(WPFPrismData data)
        {
            this.appData = data;
            this.rootNode = TreeViewItemCreator.Create(this.appData);

            var col = new System.Collections.ObjectModel.ObservableCollection<TreeViewItemViewModel>();
            col.Add(this.rootNode);
            this.TreeNodes = col.ToReadOnlyReactiveCollection()
                .AddTo(this._disposables);
        }

        void System.IDisposable.Dispose()
        {
            this._disposables.Dispose();
        }
    }
}

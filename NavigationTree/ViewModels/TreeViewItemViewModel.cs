﻿using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPrismModels;

namespace NavigationTree.ViewModels
{
    public class TreeViewItemViewModel : BindableBase, IDisposable
    {
		/// <summary>Gets the text of the TreeViewItem</summary>
		public ReadOnlyReactivePropertySlim<string> ItemText { get; }

		/// <summary>Gets the child node</summary>
		public ReactiveCollection<TreeViewItemViewModel> Children { get; }

		/// <summary>Gets the source data for the TreeViewItem.</summary>
		public object SourceData { get; } = null;

		/// <summary>List of ReactiveProperty for Dispose</summary>
		private System.Reactive.Disposables.CompositeDisposable _disposables
			= new System.Reactive.Disposables.CompositeDisposable();

		/// <summary>Constructor</summary>
		/// <param name="treeItem">An object that represents the source data for the TreeViewItem.</param>
		public TreeViewItemViewModel(object treeItem)
		{
			this.Children = new ReactiveCollection<TreeViewItemViewModel>()
				.AddTo(this._disposables);

			this.SourceData = treeItem;
			switch (this.SourceData)
			{
				case PersonalModel p:
					this.ItemText = p.ObserveProperty(x => x.Name)
						.ToReadOnlyReactivePropertySlim()
						.AddTo(this._disposables);
					break;
				case PhysicalModel ph:
					this.ItemText = ph.ObserveProperty(x => x.MeasureDate)
						.Select(d => d.HasValue ? d.Value.ToString("yyy年MM月dd日") : "New measurements")
						.ToReadOnlyReactivePropertySlim()
						.AddTo(this._disposables);
					break;
				case TestPointModel t:
					this.ItemText = t.ObserveProperty(x => x.TestDate)
						.ToReadOnlyReactivePropertySlim()
						.AddTo(this._disposables);
					break;
				case string s:
					this.ItemText = this.ObserveProperty(x => x.SourceData)
						.Select(v => v as string)
						.ToReadOnlyReactivePropertySlim()
						.AddTo(this._disposables);
					break;
			}
		}

		/// <summary>Destroys the object.</summary>
		void IDisposable.Dispose() { this._disposables.Dispose(); }
	}
}
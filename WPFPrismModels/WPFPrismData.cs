using System;
using System.Collections.Generic;
using System.Text;

namespace WPFPrismModels
{
    [System.Runtime.Serialization.DataContract]
    public class WPFPrismData
    {
		/// <summary>Get and set student information.</summary>
		[System.Runtime.Serialization.DataMember]
		public PersonalModel Student { get; set; } = new PersonalModel();

		/// <summary>Get physical measurement data.</summary>
		[System.Runtime.Serialization.DataMember]
		public System.Collections.ObjectModel.ObservableCollection<PhysicalModel> Physicals { get; private set; }
			= new System.Collections.ObjectModel.ObservableCollection<PhysicalModel>();

		/// <summary>Get test result data.</summary>
		[System.Runtime.Serialization.DataMember]
		public System.Collections.ObjectModel.ObservableCollection<TestPointModel> TestPoints { get; private set; }
			= new System.Collections.ObjectModel.ObservableCollection<TestPointModel>();
	}
}

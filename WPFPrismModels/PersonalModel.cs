using System;


namespace WPFPrismModels
{
    [System.Runtime.Serialization.DataContract]
    public class PersonalModel : Prism.Mvvm.BindableBase
    {
		private string _personName = string.Empty;

		[System.Runtime.Serialization.DataMember]
		public string Name
		{
			get { return _personName; }
			set { SetProperty(ref _personName, value); }
		}

		private string _classNum = string.Empty;

		[System.Runtime.Serialization.DataMember]
		public string ClassNumber
		{
			get { return _classNum; }
			set { SetProperty(ref _classNum, value); }
		}

		private string _gender = string.Empty;

		[System.Runtime.Serialization.DataMember]
		public string Gender
		{
			get { return _gender; }
			set { SetProperty(ref _gender, value); }
		}
	}
}

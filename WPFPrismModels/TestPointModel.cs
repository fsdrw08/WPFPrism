using System;
using System.Collections.Generic;
using System.Text;

namespace WPFPrismModels
{
	[System.Runtime.Serialization.DataContract]
	public class TestPointModel : Prism.Mvvm.BindableBase
	{
		/// <summary>試験結果のIDを取得・設定します。</summary>
		public int Id { get; set; } = 0;

		private string _testDate = string.Empty;
		/// <summary>試験日を取得・設定します。</summary>
		[System.Runtime.Serialization.DataMember]
		public string TestDate
		{
			get { return _testDate; }
			set { SetProperty(ref _testDate, value); }
		}

		private int _languageScore = 0;
		/// <summary>国語の得点を取得・設定します。</summary>
		[System.Runtime.Serialization.DataMember]
		public int LanguageScore
		{
			get { return _languageScore; }
			set
			{
				SetProperty(ref _languageScore, value);
				this._calcAverage();
			}
		}

		private int _mathScore = 0;
		/// <summary>数学の得点を取得・設定します。</summary>
		[System.Runtime.Serialization.DataMember]
		public int MathematicsScore
		{
			get { return _mathScore; }
			set
			{
				SetProperty(ref _mathScore, value);
				this._calcAverage();
			}
		}

		private int _engScore = 0;
		/// <summary>英語の得点を取得・設定します。</summary>
		[System.Runtime.Serialization.DataMember]
		public int EnglishScore
		{
			get { return _engScore; }
			set
			{
				SetProperty(ref _engScore, value);
				this._calcAverage();
			}
		}

		/// <summary>平均点を計算します。</summary>
		private void _calcAverage()
		{
			this.Average = (this._languageScore + this._mathScore + this._engScore) / 3;
		}

		private double _average = 0;
		/// <summary>平均点を取得します。</summary>
		[System.Runtime.Serialization.DataMember]
		public double Average
		{
			get { return _average; }
			private set { SetProperty(ref _average, value); }
		}
	}
}

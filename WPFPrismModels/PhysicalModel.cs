using System;
using System.Collections.Generic;
using System.Text;

namespace WPFPrismModels
{
    [System.Runtime.Serialization.DataContract]
    public class PhysicalModel : Prism.Mvvm.BindableBase
    {
        public int Id { get; set; } = 0;

        private DateTime? _measureDate = null;

        [System.Runtime.Serialization.DataMember]
        public DateTime? MeasureDate
        {
            get { return _measureDate; }
            set { SetProperty(ref _measureDate, value); }
        }

        private double _height = 0;

        [System.Runtime.Serialization.DataMember]
        public double Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

		private double _weight = 0;
		
		[System.Runtime.Serialization.DataMember]
		public double Weight
		{
			get { return _weight; }
			set
			{
				SetProperty(ref _weight, value);
				this._calcBmi();
			}
		}

		private void _calcBmi()
		{
			if (this.Height == 0) { return; }

			this._bmi = Math.Round(this._weight / Math.Pow((this._height / 100), 2),
								  1,
								  MidpointRounding.AwayFromZero);
		}

		private double _bmi = 0;
		
		[System.Runtime.Serialization.DataMember]
		public double Bmi
		{
			get { return _bmi; }
			private set { SetProperty(ref _bmi, value); }
		}
	}
}

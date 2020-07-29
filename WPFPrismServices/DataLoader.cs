using System;
using WPFPrismModels;

namespace WPFPrismServices
{
    public static class DataLoader
    {
		/// <summary>Load the data</summary>
		/// <param name="dataFilePath">A string that represents the full path of the data file.</param>
		/// <returns>represent WPFPrismData</returns>
		public static WPFPrismData Load(string dataFilePath)
		{
			if (dataFilePath == string.Empty) 
			{ 
				return DataLoader.createNewTestData(); 
			}
			return DataLoader.loadFromFile(dataFilePath);
		}

		/// <summary>Create new test data.</summary>
		/// <returns>represent WPFPrismData</returns>
		private static WPFPrismData createNewTestData()
		{
			var appData = new WPFPrismData();
			appData.Student.Name = "New Students";
			appData.Student.ClassNumber = "Class student belongs to";
			appData.Student.Gender = "Male";

			appData.Physicals.Add(new PhysicalModel() { Id = 1 });
			appData.TestPoints.Add(new TestPointModel()
			{
				Id = 1,
				TestDate = "New test date"
			});

			return appData;
		}

		/// <summary>Load the data</summary>
		/// <param name="dataFilePath">A string that represents the full path of the data file.</param>
		/// <returns>represent WPFPrismData</returns>
		private static WPFPrismData loadFromFile(string dataFilePath) { return new WPFPrismData(); }
	}
}

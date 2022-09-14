﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file VSalesPersonSalesByFiscalYearsTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="VSalesPersonSalesByFiscalYears"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VSalesPersonSalesByFiscalYearsTest
    {
    	// the VSalesPersonSalesByFiscalYears instance used to test the repository.
		private VSalesPersonSalesByFiscalYears mock;

		// the VList<VSalesPersonSalesByFiscalYears> instance used to test the repository.
		private VList<VSalesPersonSalesByFiscalYears> mockCollection;

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VSalesPersonSalesByFiscalYears Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }

    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {
			System.Console.WriteLine();
			System.Console.WriteLine();
        }

		/// <summary>
		/// Selects a page of VSalesPersonSalesByFiscalYears objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VSalesPersonSalesByFiscalYearsProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VSalesPersonSalesByFiscalYearsProvider.GetPaged():");
			System.Console.WriteLine(mockCollection);
		}

		/// <summary>
		/// Searches some VSalesPersonSalesByFiscalYears objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VSalesPersonSalesByFiscalYearsProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

			System.Console.WriteLine("DataRepository.VSalesPersonSalesByFiscalYearsProvider.Find():");
			System.Console.WriteLine(mockCollection);

		}
		 //Find


		#region Serialization tests

		/// <summary>
		/// Serialize the mock VSalesPersonSalesByFiscalYears entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VSalesPersonSalesByFiscalYears.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VSalesPersonSalesByFiscalYears));
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName);
			mySerializer.Serialize(myWriter, mock);
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");
		}

		/// <summary>
		/// Deserialize the mock VSalesPersonSalesByFiscalYears entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VSalesPersonSalesByFiscalYears.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VSalesPersonSalesByFiscalYears));
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open);
			mock = (VSalesPersonSalesByFiscalYears) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a VSalesPersonSalesByFiscalYears collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VSalesPersonSalesByFiscalYearsCollection.xml";

			VList<VSalesPersonSalesByFiscalYears> mockCollection = new VList<VSalesPersonSalesByFiscalYears>();
			mockCollection.Add(mock);

			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VSalesPersonSalesByFiscalYears>));
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName);
			mySerializer.Serialize(myWriter, mockCollection);
			myWriter.Close();

			System.Console.WriteLine("VList<VSalesPersonSalesByFiscalYears> correctly serialized to a temporary file.");
		}


		/// <summary>
		/// Deserialize a VSalesPersonSalesByFiscalYears collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VSalesPersonSalesByFiscalYearsCollection.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VSalesPersonSalesByFiscalYears>));
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open);
			VList<VSalesPersonSalesByFiscalYears> mockCollection = (VList<VSalesPersonSalesByFiscalYears>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VSalesPersonSalesByFiscalYears> correctly deserialized from a temporary file.");
		}
		#endregion

		#region Mock Instance
		///<summary>
		///  Returns a Typed VSalesPersonSalesByFiscalYears Entity with mock values.
		///</summary>
		static public VSalesPersonSalesByFiscalYears CreateMockInstance()
		{
			VSalesPersonSalesByFiscalYears mock = new VSalesPersonSalesByFiscalYears();

			mock.SalesPersonId = TestUtility.Instance.RandomNumber();
			mock.FullName = TestUtility.Instance.RandomString(75, false);;
			mock.Title = TestUtility.Instance.RandomString(24, false);;
			mock.SalesTerritory = TestUtility.Instance.RandomString(24, false);;
			mock.SafeName2002 = TestUtility.Instance.RandomShort();
			mock.SafeName2003 = TestUtility.Instance.RandomShort();
			mock.SafeName2004 = TestUtility.Instance.RandomShort();
		   return (VSalesPersonSalesByFiscalYears)mock;
		}


		#endregion
    }
}

﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file VEmployeeDepartmentHistoryTest.cs instead.
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
    /// Provides tests for the and <see cref="VEmployeeDepartmentHistory"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VEmployeeDepartmentHistoryTest
    {
    	// the VEmployeeDepartmentHistory instance used to test the repository.
		private VEmployeeDepartmentHistory mock;

		// the VList<VEmployeeDepartmentHistory> instance used to test the repository.
		private VList<VEmployeeDepartmentHistory> mockCollection;

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VEmployeeDepartmentHistory Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Selects a page of VEmployeeDepartmentHistory objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VEmployeeDepartmentHistoryProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VEmployeeDepartmentHistoryProvider.GetPaged():");
			System.Console.WriteLine(mockCollection);
		}

		/// <summary>
		/// Searches some VEmployeeDepartmentHistory objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VEmployeeDepartmentHistoryProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

			System.Console.WriteLine("DataRepository.VEmployeeDepartmentHistoryProvider.Find():");
			System.Console.WriteLine(mockCollection);

		}
		 //Find


		#region Serialization tests

		/// <summary>
		/// Serialize the mock VEmployeeDepartmentHistory entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VEmployeeDepartmentHistory.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VEmployeeDepartmentHistory));
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName);
			mySerializer.Serialize(myWriter, mock);
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");
		}

		/// <summary>
		/// Deserialize the mock VEmployeeDepartmentHistory entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VEmployeeDepartmentHistory.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VEmployeeDepartmentHistory));
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open);
			mock = (VEmployeeDepartmentHistory) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a VEmployeeDepartmentHistory collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VEmployeeDepartmentHistoryCollection.xml";

			VList<VEmployeeDepartmentHistory> mockCollection = new VList<VEmployeeDepartmentHistory>();
			mockCollection.Add(mock);

			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VEmployeeDepartmentHistory>));
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName);
			mySerializer.Serialize(myWriter, mockCollection);
			myWriter.Close();

			System.Console.WriteLine("VList<VEmployeeDepartmentHistory> correctly serialized to a temporary file.");
		}


		/// <summary>
		/// Deserialize a VEmployeeDepartmentHistory collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VEmployeeDepartmentHistoryCollection.xml";

			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VEmployeeDepartmentHistory>));
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open);
			VList<VEmployeeDepartmentHistory> mockCollection = (VList<VEmployeeDepartmentHistory>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VEmployeeDepartmentHistory> correctly deserialized from a temporary file.");
		}
		#endregion

		#region Mock Instance
		///<summary>
		///  Returns a Typed VEmployeeDepartmentHistory Entity with mock values.
		///</summary>
		static public VEmployeeDepartmentHistory CreateMockInstance()
		{
			VEmployeeDepartmentHistory mock = new VEmployeeDepartmentHistory();

			mock.EmployeeId = TestUtility.Instance.RandomNumber();
			mock.Title = TestUtility.Instance.RandomString(8, false);;
			mock.FirstName = TestUtility.Instance.RandomString(24, false);;
			mock.MiddleName = TestUtility.Instance.RandomString(24, false);;
			mock.LastName = TestUtility.Instance.RandomString(24, false);;
			mock.Suffix = TestUtility.Instance.RandomString(10, false);;
			mock.Shift = TestUtility.Instance.RandomString(24, false);;
			mock.Department = TestUtility.Instance.RandomString(24, false);;
			mock.GroupName = TestUtility.Instance.RandomString(24, false);;
			mock.StartDate = TestUtility.Instance.RandomDateTime();
			mock.EndDate = TestUtility.Instance.RandomDateTime();
		   return (VEmployeeDepartmentHistory)mock;
		}


		#endregion
    }
}

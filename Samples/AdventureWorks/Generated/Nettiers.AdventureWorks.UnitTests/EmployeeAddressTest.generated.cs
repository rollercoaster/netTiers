﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file EmployeeAddressTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;

#endregion

namespace Nettiers.AdventureWorks.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="EmployeeAddress"/> objects (entity, collection and repository).
    /// </summary>
   public partial class EmployeeAddressTest
    {
    	// the EmployeeAddress instance used to test the repository.
		protected EmployeeAddress mock;

		// the TList<EmployeeAddress> instance used to test the repository.
		protected TList<EmployeeAddress> mockCollection;

		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}
			return transactionManager;
		}

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static public void Init_Generated()
        {
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the EmployeeAddress Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }

    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }




		/// <summary>
		/// Selects all EmployeeAddress objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.EmployeeAddressProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.EmployeeAddressProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.EmployeeAddressProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all EmployeeAddress children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.EmployeeAddressProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.EmployeeAddressProvider.DeepLoading += new EntityProviderBaseCore<EmployeeAddress, EmployeeAddressKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.EmployeeAddressProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("EmployeeAddress instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.EmployeeAddressProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}




		#region Serialization tests

		/// <summary>
		/// Serialize the mock EmployeeAddress entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_EmployeeAddress.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock EmployeeAddress entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_EmployeeAddress.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<EmployeeAddress>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a EmployeeAddress collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_EmployeeAddressCollection.xml");

				mock = CreateMockInstance(tm);
				TList<EmployeeAddress> mockCollection = new TList<EmployeeAddress>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<EmployeeAddress> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a EmployeeAddress collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_EmployeeAddressCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<EmployeeAddress>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<EmployeeAddress> mockCollection = (TList<EmployeeAddress>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<EmployeeAddress> correctly deserialized from a temporary file.");
		}
		#endregion




		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);

				EmployeeAddress entity = mock.Copy() as EmployeeAddress;
				entity = (EmployeeAddress)mock.Clone();
				Assert.IsTrue(EmployeeAddress.ValueEquals(entity, mock), "Clone is not working");
			}
		}

		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				EmployeeAddress mock = CreateMockInstance(tm);
				bool result = DataRepository.EmployeeAddressProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				EmployeeAddressQuery query = new EmployeeAddressQuery();

				query.AppendEquals(EmployeeAddressColumn.EmployeeId, mock.EmployeeId.ToString());
				query.AppendEquals(EmployeeAddressColumn.AddressId, mock.AddressId.ToString());
				query.AppendEquals(EmployeeAddressColumn.Rowguid, mock.Rowguid.ToString());
				query.AppendEquals(EmployeeAddressColumn.ModifiedDate, mock.ModifiedDate.ToString());

				TList<EmployeeAddress> results = DataRepository.EmployeeAddressProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed EmployeeAddress Entity with mock values.
		///</summary>
		static public EmployeeAddress CreateMockInstance_Generated(TransactionManager tm)
		{
			EmployeeAddress mock = new EmployeeAddress();

			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			//OneToOneRelationship
			Address mockAddressByAddressId = AddressTest.CreateMockInstance(tm);
			DataRepository.AddressProvider.Insert(tm, mockAddressByAddressId);
			mock.AddressId = mockAddressByAddressId.AddressId;
			//OneToOneRelationship
			Employee mockEmployeeByEmployeeId = EmployeeTest.CreateMockInstance(tm);
			DataRepository.EmployeeProvider.Insert(tm, mockEmployeeByEmployeeId);
			mock.EmployeeId = mockEmployeeByEmployeeId.EmployeeId;

			// create a temporary collection and add the item to it
			TList<EmployeeAddress> tempMockCollection = new TList<EmployeeAddress>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (EmployeeAddress)mock;
		}


		///<summary>
		///  Update the Typed EmployeeAddress Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, EmployeeAddress mock)
		{
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			//OneToOneRelationship
			Address mockAddressByAddressId = AddressTest.CreateMockInstance(tm);
			DataRepository.AddressProvider.Insert(tm, mockAddressByAddressId);
			mock.AddressId = mockAddressByAddressId.AddressId;

			//OneToOneRelationship
			Employee mockEmployeeByEmployeeId = EmployeeTest.CreateMockInstance(tm);
			DataRepository.EmployeeProvider.Insert(tm, mockEmployeeByEmployeeId);
			mock.EmployeeId = mockEmployeeByEmployeeId.EmployeeId;

		}
		#endregion
    }
}

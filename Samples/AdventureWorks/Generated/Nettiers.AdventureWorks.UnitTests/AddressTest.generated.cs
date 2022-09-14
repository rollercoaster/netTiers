﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file AddressTest.cs instead.
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
    /// Provides tests for the and <see cref="Address"/> objects (entity, collection and repository).
    /// </summary>
   public partial class AddressTest
    {
    	// the Address instance used to test the repository.
		protected Address mock;

		// the TList<Address> instance used to test the repository.
		protected TList<Address> mockCollection;

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
			System.Console.WriteLine("-- Testing the Address Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock Address entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.AddressProvider.Insert(tm, mock), "Insert failed");

				System.Console.WriteLine("DataRepository.AddressProvider.Insert(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Selects all Address objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.AddressProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.AddressProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.AddressProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all Address children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.AddressProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.AddressProvider.DeepLoading += new EntityProviderBaseCore<Address, AddressKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.AddressProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("Address instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.AddressProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		/// <summary>
		/// Updates a mock Address entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Address mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.AddressProvider.Insert(tm, mock), "Insert failed");

				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.AddressProvider.Update(tm, mock), "Update failed.");

				System.Console.WriteLine("DataRepository.AddressProvider.Update(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Delete the mock Address entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (Address)CreateMockInstance(tm);
				DataRepository.AddressProvider.Insert(tm, mock);

				Assert.IsTrue(DataRepository.AddressProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.AddressProvider.Delete(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		#region Serialization tests

		/// <summary>
		/// Serialize the mock Address entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Address.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock Address entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_Address.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<Address>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a Address collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_AddressCollection.xml");

				mock = CreateMockInstance(tm);
				TList<Address> mockCollection = new TList<Address>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<Address> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a Address collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_AddressCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<Address>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<Address> mockCollection = (TList<Address>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<Address> correctly deserialized from a temporary file.");
		}
		#endregion



		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Address entity = CreateMockInstance(tm);
				bool result = DataRepository.AddressProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");

			}
		}


		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				Address entity = CreateMockInstance(tm);
				bool result = DataRepository.AddressProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");


				Address t0 = DataRepository.AddressProvider.GetByRowguid(tm, entity.Rowguid);
				Address t1 = DataRepository.AddressProvider.GetByAddressLine1AddressLine2CityStateProvinceIdPostalCode(tm, entity.AddressLine1, entity.AddressLine2, entity.City, entity.StateProvinceId, entity.PostalCode);
				TList<Address> t2 = DataRepository.AddressProvider.GetByStateProvinceId(tm, entity.StateProvinceId);
				Address t3 = DataRepository.AddressProvider.GetByAddressId(tm, entity.AddressId);
			}
		}

		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);

				Address entity = mock.Copy() as Address;
				entity = (Address)mock.Clone();
				Assert.IsTrue(Address.ValueEquals(entity, mock), "Clone is not working");
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
				Address mock = CreateMockInstance(tm);
				bool result = DataRepository.AddressProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				AddressQuery query = new AddressQuery();

				query.AppendEquals(AddressColumn.AddressId, mock.AddressId.ToString());
				query.AppendEquals(AddressColumn.AddressLine1, mock.AddressLine1.ToString());
				if(mock.AddressLine2 != null)
					query.AppendEquals(AddressColumn.AddressLine2, mock.AddressLine2.ToString());
				query.AppendEquals(AddressColumn.City, mock.City.ToString());
				query.AppendEquals(AddressColumn.StateProvinceId, mock.StateProvinceId.ToString());
				query.AppendEquals(AddressColumn.PostalCode, mock.PostalCode.ToString());
				query.AppendEquals(AddressColumn.Rowguid, mock.Rowguid.ToString());
				query.AppendEquals(AddressColumn.ModifiedDate, mock.ModifiedDate.ToString());

				TList<Address> results = DataRepository.AddressProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed Address Entity with mock values.
		///</summary>
		static public Address CreateMockInstance_Generated(TransactionManager tm)
		{
			Address mock = new Address();

			mock.AddressLine1 = TestUtility.Instance.RandomString(29, false);;
			mock.AddressLine2 = TestUtility.Instance.RandomString(29, false);;
			mock.City = TestUtility.Instance.RandomString(14, false);;
			mock.PostalCode = TestUtility.Instance.RandomString(6, false);;
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			int count0 = 0;
			TList<StateProvince> _collection0 = DataRepository.StateProvinceProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.StateProvinceId = _collection0[0].StateProvinceId;

			}

			// create a temporary collection and add the item to it
			TList<Address> tempMockCollection = new TList<Address>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (Address)mock;
		}


		///<summary>
		///  Update the Typed Address Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, Address mock)
		{
			mock.AddressLine1 = TestUtility.Instance.RandomString(29, false);;
			mock.AddressLine2 = TestUtility.Instance.RandomString(29, false);;
			mock.City = TestUtility.Instance.RandomString(14, false);;
			mock.PostalCode = TestUtility.Instance.RandomString(6, false);;
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			int count0 = 0;
			TList<StateProvince> _collection0 = DataRepository.StateProvinceProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.StateProvinceId = _collection0[0].StateProvinceId;
			}
		}
		#endregion
    }
}

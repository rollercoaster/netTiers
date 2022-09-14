﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file CountryRegionTest.cs instead.
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
    /// Provides tests for the and <see cref="CountryRegion"/> objects (entity, collection and repository).
    /// </summary>
   public partial class CountryRegionTest
    {
    	// the CountryRegion instance used to test the repository.
		protected CountryRegion mock;

		// the TList<CountryRegion> instance used to test the repository.
		protected TList<CountryRegion> mockCollection;

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
			System.Console.WriteLine("-- Testing the CountryRegion Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock CountryRegion entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CountryRegionProvider.Insert(tm, mock), "Insert failed");

				System.Console.WriteLine("DataRepository.CountryRegionProvider.Insert(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Selects all CountryRegion objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.CountryRegionProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.CountryRegionProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.CountryRegionProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all CountryRegion children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.CountryRegionProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.CountryRegionProvider.DeepLoading += new EntityProviderBaseCore<CountryRegion, CountryRegionKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.CountryRegionProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("CountryRegion instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.CountryRegionProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		/// <summary>
		/// Updates a mock CountryRegion entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CountryRegion mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CountryRegionProvider.Insert(tm, mock), "Insert failed");

				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.CountryRegionProvider.Update(tm, mock), "Update failed.");

				System.Console.WriteLine("DataRepository.CountryRegionProvider.Update(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Delete the mock CountryRegion entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (CountryRegion)CreateMockInstance(tm);
				DataRepository.CountryRegionProvider.Insert(tm, mock);

				Assert.IsTrue(DataRepository.CountryRegionProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.CountryRegionProvider.Delete(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		#region Serialization tests

		/// <summary>
		/// Serialize the mock CountryRegion entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CountryRegion.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock CountryRegion entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CountryRegion.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<CountryRegion>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a CountryRegion collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CountryRegionCollection.xml");

				mock = CreateMockInstance(tm);
				TList<CountryRegion> mockCollection = new TList<CountryRegion>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<CountryRegion> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a CountryRegion collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CountryRegionCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<CountryRegion>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<CountryRegion> mockCollection = (TList<CountryRegion>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<CountryRegion> correctly deserialized from a temporary file.");
		}
		#endregion



		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CountryRegion entity = CreateMockInstance(tm);
				bool result = DataRepository.CountryRegionProvider.Insert(tm, entity);

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
				CountryRegion entity = CreateMockInstance(tm);
				bool result = DataRepository.CountryRegionProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");


				CountryRegion t0 = DataRepository.CountryRegionProvider.GetByName(tm, entity.Name);
				CountryRegion t1 = DataRepository.CountryRegionProvider.GetByCountryRegionCode(tm, entity.CountryRegionCode);
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

				CountryRegion entity = mock.Copy() as CountryRegion;
				entity = (CountryRegion)mock.Clone();
				Assert.IsTrue(CountryRegion.ValueEquals(entity, mock), "Clone is not working");
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
				CountryRegion mock = CreateMockInstance(tm);
				bool result = DataRepository.CountryRegionProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				CountryRegionQuery query = new CountryRegionQuery();

				query.AppendEquals(CountryRegionColumn.CountryRegionCode, mock.CountryRegionCode.ToString());
				query.AppendEquals(CountryRegionColumn.Name, mock.Name.ToString());
				query.AppendEquals(CountryRegionColumn.ModifiedDate, mock.ModifiedDate.ToString());

				TList<CountryRegion> results = DataRepository.CountryRegionProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed CountryRegion Entity with mock values.
		///</summary>
		static public CountryRegion CreateMockInstance_Generated(TransactionManager tm)
		{
			CountryRegion mock = new CountryRegion();

			mock.CountryRegionCode = TestUtility.Instance.RandomString(3, false);;
			mock.Name = TestUtility.Instance.RandomString(24, false);;
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();


			// create a temporary collection and add the item to it
			TList<CountryRegion> tempMockCollection = new TList<CountryRegion>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (CountryRegion)mock;
		}


		///<summary>
		///  Update the Typed CountryRegion Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, CountryRegion mock)
		{
			mock.Name = TestUtility.Instance.RandomString(24, false);;
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

		}
		#endregion
    }
}

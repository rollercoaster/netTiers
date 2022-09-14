﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file ProductCostHistoryTest.cs instead.
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
    /// Provides tests for the and <see cref="ProductCostHistory"/> objects (entity, collection and repository).
    /// </summary>
   public partial class ProductCostHistoryTest
    {
    	// the ProductCostHistory instance used to test the repository.
		protected ProductCostHistory mock;

		// the TList<ProductCostHistory> instance used to test the repository.
		protected TList<ProductCostHistory> mockCollection;

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
			System.Console.WriteLine("-- Testing the ProductCostHistory Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock ProductCostHistory entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ProductCostHistoryProvider.Insert(tm, mock), "Insert failed");

				System.Console.WriteLine("DataRepository.ProductCostHistoryProvider.Insert(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Selects all ProductCostHistory objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.ProductCostHistoryProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.ProductCostHistoryProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.ProductCostHistoryProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all ProductCostHistory children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.ProductCostHistoryProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.ProductCostHistoryProvider.DeepLoading += new EntityProviderBaseCore<ProductCostHistory, ProductCostHistoryKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.ProductCostHistoryProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("ProductCostHistory instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.ProductCostHistoryProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		/// <summary>
		/// Updates a mock ProductCostHistory entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ProductCostHistory mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.ProductCostHistoryProvider.Insert(tm, mock), "Insert failed");

				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.ProductCostHistoryProvider.Update(tm, mock), "Update failed.");

				System.Console.WriteLine("DataRepository.ProductCostHistoryProvider.Update(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Delete the mock ProductCostHistory entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (ProductCostHistory)CreateMockInstance(tm);
				DataRepository.ProductCostHistoryProvider.Insert(tm, mock);

				Assert.IsTrue(DataRepository.ProductCostHistoryProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.ProductCostHistoryProvider.Delete(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		#region Serialization tests

		/// <summary>
		/// Serialize the mock ProductCostHistory entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ProductCostHistory.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock ProductCostHistory entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ProductCostHistory.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<ProductCostHistory>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a ProductCostHistory collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ProductCostHistoryCollection.xml");

				mock = CreateMockInstance(tm);
				TList<ProductCostHistory> mockCollection = new TList<ProductCostHistory>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<ProductCostHistory> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a ProductCostHistory collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_ProductCostHistoryCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<ProductCostHistory>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<ProductCostHistory> mockCollection = (TList<ProductCostHistory>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<ProductCostHistory> correctly deserialized from a temporary file.");
		}
		#endregion



		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ProductCostHistory entity = CreateMockInstance(tm);
				bool result = DataRepository.ProductCostHistoryProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");

				TList<ProductCostHistory> t0 = DataRepository.ProductCostHistoryProvider.GetByProductId(tm, entity.ProductId, 0, 10);
			}
		}


		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				ProductCostHistory entity = CreateMockInstance(tm);
				bool result = DataRepository.ProductCostHistoryProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");


				ProductCostHistory t0 = DataRepository.ProductCostHistoryProvider.GetByProductIdStartDate(tm, entity.ProductId, entity.StartDate);
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

				ProductCostHistory entity = mock.Copy() as ProductCostHistory;
				entity = (ProductCostHistory)mock.Clone();
				Assert.IsTrue(ProductCostHistory.ValueEquals(entity, mock), "Clone is not working");
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
				ProductCostHistory mock = CreateMockInstance(tm);
				bool result = DataRepository.ProductCostHistoryProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				ProductCostHistoryQuery query = new ProductCostHistoryQuery();

				query.AppendEquals(ProductCostHistoryColumn.ProductId, mock.ProductId.ToString());
				query.AppendEquals(ProductCostHistoryColumn.StartDate, mock.StartDate.ToString());
				if(mock.EndDate != null)
					query.AppendEquals(ProductCostHistoryColumn.EndDate, mock.EndDate.ToString());
				query.AppendEquals(ProductCostHistoryColumn.StandardCost, mock.StandardCost.ToString());
				query.AppendEquals(ProductCostHistoryColumn.ModifiedDate, mock.ModifiedDate.ToString());

				TList<ProductCostHistory> results = DataRepository.ProductCostHistoryProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed ProductCostHistory Entity with mock values.
		///</summary>
		static public ProductCostHistory CreateMockInstance_Generated(TransactionManager tm)
		{
			ProductCostHistory mock = new ProductCostHistory();

			mock.StartDate = TestUtility.Instance.RandomDateTime();
			mock.EndDate = TestUtility.Instance.RandomDateTime();
			mock.StandardCost = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			//OneToOneRelationship
			Product mockProductByProductId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductId);
			mock.ProductId = mockProductByProductId.ProductId;

			// create a temporary collection and add the item to it
			TList<ProductCostHistory> tempMockCollection = new TList<ProductCostHistory>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (ProductCostHistory)mock;
		}


		///<summary>
		///  Update the Typed ProductCostHistory Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, ProductCostHistory mock)
		{
			mock.EndDate = TestUtility.Instance.RandomDateTime();
			mock.StandardCost = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

			//OneToOneRelationship
			Product mockProductByProductId = ProductTest.CreateMockInstance(tm);
			DataRepository.ProductProvider.Insert(tm, mockProductByProductId);
			mock.ProductId = mockProductByProductId.ProductId;

		}
		#endregion
    }
}

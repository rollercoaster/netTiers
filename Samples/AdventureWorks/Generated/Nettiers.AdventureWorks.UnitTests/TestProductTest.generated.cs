﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file TestProductTest.cs instead.
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
    /// Provides tests for the and <see cref="TestProduct"/> objects (entity, collection and repository).
    /// </summary>
   public partial class TestProductTest
    {
    	// the TestProduct instance used to test the repository.
		private TestProduct mock;

		// the TList<TestProduct> instance used to test the repository.
		private TList<TestProduct> mockCollection;

		private static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
			}
			return transactionManager;
		}

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static public void Init_Generated()
        {
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the TestProduct Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock TestProduct entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TestProductProvider.Insert(tm, mock), "Insert failed");

				System.Console.WriteLine("DataRepository.TestProductProvider.Insert(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Selects all TestProduct objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.TestProductProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.TestProductProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.TestProductProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all TestProduct children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.TestProductProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.TestProductProvider.DeepLoading += new EntityProviderBaseCore<TestProduct, TestProductKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.TestProductProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("TestProduct instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.TestProductProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		/// <summary>
		/// Updates a mock TestProduct entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TestProduct mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.TestProductProvider.Insert(tm, mock), "Insert failed");

				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.TestProductProvider.Update(tm, mock), "Update failed.");

				System.Console.WriteLine("DataRepository.TestProductProvider.Update(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Delete the mock TestProduct entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (TestProduct)CreateMockInstance(tm);
				DataRepository.TestProductProvider.Insert(tm, mock);

				Assert.IsTrue(DataRepository.TestProductProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.TestProductProvider.Delete(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		#region Serialization tests

		/// <summary>
		/// Serialize the mock TestProduct entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TestProduct.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock TestProduct entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TestProduct.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<TestProduct>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a TestProduct collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TestProductCollection.xml");

				mock = CreateMockInstance(tm);
				TList<TestProduct> mockCollection = new TList<TestProduct>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<TestProduct> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a TestProduct collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_TestProductCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<TestProduct>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<TestProduct> mockCollection = (TList<TestProduct>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<TestProduct> correctly deserialized from a temporary file.");
		}
		#endregion



		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				TestProduct entity = CreateMockInstance(tm);
				bool result = DataRepository.TestProductProvider.Insert(tm, entity);

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
				TestProduct entity = CreateMockInstance(tm);
				bool result = DataRepository.TestProductProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");


				TestProduct t0 = DataRepository.TestProductProvider.GetByProductId(tm, entity.ProductId);
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

				TestProduct entity = mock.Copy() as TestProduct;
				entity = (TestProduct)mock.Clone();
				Assert.IsTrue(TestProduct.ValueEquals(entity, mock), "Clone is not working");
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
				TestProduct mock = CreateMockInstance(tm);
				bool result = DataRepository.TestProductProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				TestProductQuery query = new TestProductQuery();

				if(mock.ProductTypeId != null)
					query.AppendEquals(TestProductColumn.ProductTypeId, mock.ProductTypeId.ToString());
				if(mock.DownloadId != null)
					query.AppendEquals(TestProductColumn.DownloadId, mock.DownloadId.ToString());
				if(mock.ManufacturerId != null)
					query.AppendEquals(TestProductColumn.ManufacturerId, mock.ManufacturerId.ToString());
				if(mock.BrandName != null)
					query.AppendEquals(TestProductColumn.BrandName, mock.BrandName.ToString());
				if(mock.ProductName != null)
					query.AppendEquals(TestProductColumn.ProductName, mock.ProductName.ToString());
				if(mock.ProductCode != null)
					query.AppendEquals(TestProductColumn.ProductCode, mock.ProductCode.ToString());
				if(mock.UniqueIdentifier != null)
					query.AppendEquals(TestProductColumn.UniqueIdentifier, mock.UniqueIdentifier.ToString());
				if(mock.TypeName != null)
					query.AppendEquals(TestProductColumn.TypeName, mock.TypeName.ToString());
				if(mock.ModelName != null)
					query.AppendEquals(TestProductColumn.ModelName, mock.ModelName.ToString());
				if(mock.DisplayName != null)
					query.AppendEquals(TestProductColumn.DisplayName, mock.DisplayName.ToString());
				if(mock.ProductLink != null)
					query.AppendEquals(TestProductColumn.ProductLink, mock.ProductLink.ToString());
				if(mock.ConnectorCode != null)
					query.AppendEquals(TestProductColumn.ConnectorCode, mock.ConnectorCode.ToString());
				if(mock.BaseId != null)
					query.AppendEquals(TestProductColumn.BaseId, mock.BaseId.ToString());
				if(mock.OrgProductId != null)
					query.AppendEquals(TestProductColumn.OrgProductId, mock.OrgProductId.ToString());
				if(mock.ImageFileType != null)
					query.AppendEquals(TestProductColumn.ImageFileType, mock.ImageFileType.ToString());
				if(mock.FullImageFileType != null)
					query.AppendEquals(TestProductColumn.FullImageFileType, mock.FullImageFileType.ToString());
				if(mock.Status != null)
					query.AppendEquals(TestProductColumn.Status, mock.Status.ToString());
				if(mock.AddedBy != null)
					query.AppendEquals(TestProductColumn.AddedBy, mock.AddedBy.ToString());
				if(mock.AddedDate != null)
					query.AppendEquals(TestProductColumn.AddedDate, mock.AddedDate.ToString());
				if(mock.UpdatedBy != null)
					query.AppendEquals(TestProductColumn.UpdatedBy, mock.UpdatedBy.ToString());
				if(mock.UpdatedDate != null)
					query.AppendEquals(TestProductColumn.UpdatedDate, mock.UpdatedDate.ToString());

				TList<TestProduct> results = DataRepository.TestProductProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed TestProduct Entity with mock values.
		///</summary>
		static public TestProduct CreateMockInstance_Generated(TransactionManager tm)
		{
			TestProduct mock = new TestProduct();

			mock.ProductTypeId = TestUtility.Instance.RandomNumber();
			mock.DownloadId = TestUtility.Instance.RandomNumber();
			mock.ManufacturerId = TestUtility.Instance.RandomNumber();
			mock.BrandName = TestUtility.Instance.RandomString(249, false);;
			mock.ProductName = TestUtility.Instance.RandomString(249, false);;
			mock.ProductCode = TestUtility.Instance.RandomString(49, false);;
			mock.UniqueIdentifier = TestUtility.Instance.RandomString(249, false);;
			mock.TypeName = TestUtility.Instance.RandomString(24, false);;
			mock.ModelName = TestUtility.Instance.RandomString(74, false);;
			mock.DisplayName = TestUtility.Instance.RandomString(74, false);;
			mock.ProductLink = TestUtility.Instance.RandomString(499, false);;
			mock.ConnectorCode = TestUtility.Instance.RandomString(499, false);;
			mock.BaseId = TestUtility.Instance.RandomNumber();
			mock.OrgProductId = TestUtility.Instance.RandomNumber();
			mock.ImageFileType = TestUtility.Instance.RandomString(1, false);;
			mock.FullImageFileType = TestUtility.Instance.RandomString(1, false);;
			mock.Status = TestUtility.Instance.RandomString(1, false);;
			mock.AddedBy = TestUtility.Instance.RandomNumber();
			mock.AddedDate = TestUtility.Instance.RandomDateTime();
			mock.UpdatedBy = TestUtility.Instance.RandomNumber();
			mock.UpdatedDate = TestUtility.Instance.RandomDateTime();


			// create a temporary collection and add the item to it
			TList<TestProduct> tempMockCollection = new TList<TestProduct>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (TestProduct)mock;
		}


		///<summary>
		///  Update the Typed TestProduct Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, TestProduct mock)
		{
			mock.ProductTypeId = TestUtility.Instance.RandomNumber();
			mock.DownloadId = TestUtility.Instance.RandomNumber();
			mock.ManufacturerId = TestUtility.Instance.RandomNumber();
			mock.BrandName = TestUtility.Instance.RandomString(249, false);;
			mock.ProductName = TestUtility.Instance.RandomString(249, false);;
			mock.ProductCode = TestUtility.Instance.RandomString(49, false);;
			mock.UniqueIdentifier = TestUtility.Instance.RandomString(249, false);;
			mock.TypeName = TestUtility.Instance.RandomString(24, false);;
			mock.ModelName = TestUtility.Instance.RandomString(74, false);;
			mock.DisplayName = TestUtility.Instance.RandomString(74, false);;
			mock.ProductLink = TestUtility.Instance.RandomString(499, false);;
			mock.ConnectorCode = TestUtility.Instance.RandomString(499, false);;
			mock.BaseId = TestUtility.Instance.RandomNumber();
			mock.OrgProductId = TestUtility.Instance.RandomNumber();
			mock.ImageFileType = TestUtility.Instance.RandomString(1, false);;
			mock.FullImageFileType = TestUtility.Instance.RandomString(1, false);;
			mock.Status = TestUtility.Instance.RandomString(1, false);;
			mock.AddedBy = TestUtility.Instance.RandomNumber();
			mock.AddedDate = TestUtility.Instance.RandomDateTime();
			mock.UpdatedBy = TestUtility.Instance.RandomNumber();
			mock.UpdatedDate = TestUtility.Instance.RandomDateTime();

		}
		#endregion
    }
}

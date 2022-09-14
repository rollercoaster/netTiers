﻿

/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file CreditCardTest.cs instead.
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
    /// Provides tests for the and <see cref="CreditCard"/> objects (entity, collection and repository).
    /// </summary>
   public partial class CreditCardTest
    {
    	// the CreditCard instance used to test the repository.
		protected CreditCard mock;

		// the TList<CreditCard> instance used to test the repository.
		protected TList<CreditCard> mockCollection;

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
			System.Console.WriteLine("-- Testing the CreditCard Entity with the {0} --", Nettiers.AdventureWorks.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock CreditCard entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CreditCardProvider.Insert(tm, mock), "Insert failed");

				System.Console.WriteLine("DataRepository.CreditCardProvider.Insert(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Selects all CreditCard objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;

				mockCollection = DataRepository.CreditCardProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");

				System.Console.WriteLine("DataRepository.CreditCardProvider.Find():");
				System.Console.WriteLine(mockCollection);

				// GetPaged
				count = -1;

				mockCollection = DataRepository.CreditCardProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}




		/// <summary>
		/// Deep load all CreditCard children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.CreditCardProvider.GetPaged(tm, 0, 10, out count);

				DataRepository.CreditCardProvider.DeepLoading += new EntityProviderBaseCore<CreditCard, CreditCardKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{

					DataRepository.CreditCardProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("CreditCard instance correctly deep loaded at 1 level.");

					mockCollection.Add(mock);
					// DataRepository.CreditCardProvider.DeepSave(tm, mockCollection);
				}

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		/// <summary>
		/// Updates a mock CreditCard entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CreditCard mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.CreditCardProvider.Insert(tm, mock), "Insert failed");

				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.CreditCardProvider.Update(tm, mock), "Update failed.");

				System.Console.WriteLine("DataRepository.CreditCardProvider.Update(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}


		/// <summary>
		/// Delete the mock CreditCard entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (CreditCard)CreateMockInstance(tm);
				DataRepository.CreditCardProvider.Insert(tm, mock);

				Assert.IsTrue(DataRepository.CreditCardProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.CreditCardProvider.Delete(mock):");
				System.Console.WriteLine(mock);

				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}

		#region Serialization tests

		/// <summary>
		/// Serialize the mock CreditCard entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CreditCard.xml");

				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");

				System.Console.WriteLine("mock correctly serialized to a temporary file.");
			}
		}

		/// <summary>
		/// Deserialize the mock CreditCard entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CreditCard.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<CreditCard>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);

			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}

		/// <summary>
		/// Serialize a CreditCard collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CreditCardCollection.xml");

				mock = CreateMockInstance(tm);
				TList<CreditCard> mockCollection = new TList<CreditCard>();
				mockCollection.Add(mock);

				EntityHelper.SerializeXml(mockCollection, fileName);

				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<CreditCard> correctly serialized to a temporary file.");
			}
		}


		/// <summary>
		/// Deserialize a CreditCard collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_CreditCardCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");

			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<CreditCard>));
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<CreditCard> mockCollection = (TList<CreditCard>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}

			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<CreditCard> correctly deserialized from a temporary file.");
		}
		#endregion



		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				CreditCard entity = CreateMockInstance(tm);
				bool result = DataRepository.CreditCardProvider.Insert(tm, entity);

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
				CreditCard entity = CreateMockInstance(tm);
				bool result = DataRepository.CreditCardProvider.Insert(tm, entity);

				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");


				CreditCard t0 = DataRepository.CreditCardProvider.GetByCardNumber(tm, entity.CardNumber);
				CreditCard t1 = DataRepository.CreditCardProvider.GetByCreditCardId(tm, entity.CreditCardId);
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

				CreditCard entity = mock.Copy() as CreditCard;
				entity = (CreditCard)mock.Clone();
				Assert.IsTrue(CreditCard.ValueEquals(entity, mock), "Clone is not working");
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
				CreditCard mock = CreateMockInstance(tm);
				bool result = DataRepository.CreditCardProvider.Insert(tm, mock);

				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				CreditCardQuery query = new CreditCardQuery();

				query.AppendEquals(CreditCardColumn.CreditCardId, mock.CreditCardId.ToString());
				query.AppendEquals(CreditCardColumn.CardType, mock.CardType.ToString());
				query.AppendEquals(CreditCardColumn.CardNumber, mock.CardNumber.ToString());
				query.AppendEquals(CreditCardColumn.ExpMonth, mock.ExpMonth.ToString());
				query.AppendEquals(CreditCardColumn.ExpYear, mock.ExpYear.ToString());
				query.AppendEquals(CreditCardColumn.ModifiedDate, mock.ModifiedDate.ToString());

				TList<CreditCard> results = DataRepository.CreditCardProvider.Find(tm, query);

				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}

		#region Mock Instance
		///<summary>
		///  Returns a Typed CreditCard Entity with mock values.
		///</summary>
		static public CreditCard CreateMockInstance_Generated(TransactionManager tm)
		{
			CreditCard mock = new CreditCard();

			mock.CardType = TestUtility.Instance.RandomString(24, false);;
			mock.CardNumber = TestUtility.Instance.RandomString(11, false);;
			mock.ExpMonth = TestUtility.Instance.RandomByte();
			mock.ExpYear = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();


			// create a temporary collection and add the item to it
			TList<CreditCard> tempMockCollection = new TList<CreditCard>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);


		   return (CreditCard)mock;
		}


		///<summary>
		///  Update the Typed CreditCard Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, CreditCard mock)
		{
			mock.CardType = TestUtility.Instance.RandomString(24, false);;
			mock.CardNumber = TestUtility.Instance.RandomString(11, false);;
			mock.ExpMonth = TestUtility.Instance.RandomByte();
			mock.ExpYear = TestUtility.Instance.RandomShort();
			mock.ModifiedDate = TestUtility.Instance.RandomDateTime();

		}
		#endregion
    }
}

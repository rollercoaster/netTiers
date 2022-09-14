﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file Nettiers.AdventureWorks.Entities.Contact.cs instead.
*/

#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using System.Web.Services.Protocols;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data.Bases;

#endregion

namespace Nettiers.AdventureWorks.Data.WebServiceClient
{

	///<summary>
	/// This class is the webservice client implementation that exposes CRUD methods for Nettiers.AdventureWorks.Entities.Contact objects.
	///</summary>
	public abstract partial class WsContactProviderBase : ContactProviderBase
	{
		#region Declarations

		/// <summary>
		/// the Url of the webservice.
		/// </summary>
		private string url;

		#endregion Declarations

		#region Constructors

		/// <summary>
		/// Creates a new <see cref="WsContactProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		public WsContactProviderBase()
		{
		}

		/// <summary>
		/// Creates a new <see cref="WsContactProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="url">The url to the nettiers webservice.</param>
		public WsContactProviderBase(string url)
		{
			this.Url = url;
		}

		#endregion Constructors

		#region Url
		///<summary>
		/// Current URL for webservice endpoint.
		///</summary>
		public string Url
        {
        	get {return url;}
        	set {url = value;}
        }
		#endregion

		#region Convertion utility

		/// <summary>
		/// Convert a collection from the ws proxy to a nettiers collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.TList<Contact> Convert(WsProxy.Contact[] items)
		{
			Nettiers.AdventureWorks.Entities.TList<Contact> outItems = new Nettiers.AdventureWorks.Entities.TList<Contact>();
			foreach(WsProxy.Contact item in items)
			{
				outItems.Add(Convert(item));
			}
			return outItems;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.Contact Convert(WsProxy.Contact item)
		{
			Nettiers.AdventureWorks.Entities.Contact outItem = item == null ? null : new Nettiers.AdventureWorks.Entities.Contact();
			Convert(outItem, item);
			return outItem;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.Contact Convert(Nettiers.AdventureWorks.Entities.Contact outItem , WsProxy.Contact item)
		{
			if (item != null && outItem != null)
			{
				outItem.ContactId = item.ContactId;
				outItem.NameStyle = item.NameStyle;
				outItem.Title = item.Title;
				outItem.FirstName = item.FirstName;
				outItem.MiddleName = item.MiddleName;
				outItem.LastName = item.LastName;
				outItem.Suffix = item.Suffix;
				outItem.EmailAddress = item.EmailAddress;
				outItem.EmailPromotion = item.EmailPromotion;
				outItem.Phone = item.Phone;
				outItem.PasswordHash = item.PasswordHash;
				outItem.PasswordSalt = item.PasswordSalt;
				outItem.AdditionalContactInfo = item.AdditionalContactInfo;
				outItem.Rowguid = item.Rowguid;
				outItem.ModifiedDate = item.ModifiedDate;

				outItem.AcceptChanges();
			}

			return outItem;
		}

		/// <summary>
		/// Convert a nettiers entity to the ws proxy entity.
		/// </summary>
		public static WsProxy.Contact Convert(Nettiers.AdventureWorks.Entities.Contact item)
		{
			WsProxy.Contact outItem = new WsProxy.Contact();
			outItem.ContactId = item.ContactId;
			outItem.NameStyle = item.NameStyle;
			outItem.Title = item.Title;
			outItem.FirstName = item.FirstName;
			outItem.MiddleName = item.MiddleName;
			outItem.LastName = item.LastName;
			outItem.Suffix = item.Suffix;
			outItem.EmailAddress = item.EmailAddress;
			outItem.EmailPromotion = item.EmailPromotion;
			outItem.Phone = item.Phone;
			outItem.PasswordHash = item.PasswordHash;
			outItem.PasswordSalt = item.PasswordSalt;
			outItem.AdditionalContactInfo = item.AdditionalContactInfo;
			outItem.Rowguid = item.Rowguid;
			outItem.ModifiedDate = item.ModifiedDate;


			return outItem;
		}

		/// <summary>
		/// Convert a collection from  to a nettiers collection to a the ws proxy collection.
		/// </summary>
		public static WsProxy.Contact[] Convert(Nettiers.AdventureWorks.Entities.TList<Contact> items)
		{
			WsProxy.Contact[] outItems = new WsProxy.Contact[items.Count];
			int count = 0;

			foreach (Nettiers.AdventureWorks.Entities.Contact item in items)
			{
				outItems[count++] = Convert(item);
			}
			return outItems;
		}


		#endregion

		#region Get from  Many To Many Relationship Functions
		#region GetByCreditCardIdFromContactCreditCard

		/// <summary>
		///		Gets Contact objects from the datasource by CreditCardID in the
		///		ContactCreditCard table. Table Contact is related to table CreditCard
		///		through the (M:N) relationship defined in the ContactCreditCard table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="_creditCardId">Credit card identification number. Foreign key to CreditCard.CreditCardID.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Contact objects.</returns>
		public override TList<Contact> GetByCreditCardIdFromContactCreditCard(TransactionManager transactionManager, System.Int32 _creditCardId, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_GetByCreditCardIdFromContactCreditCard(_creditCardId, start, pagelen, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion GetByCreditCardIdFromContactCreditCard

		#region GetByCustomerIdFromStoreContact

		/// <summary>
		///		Gets Contact objects from the datasource by CustomerID in the
		///		StoreContact table. Table Contact is related to table Store
		///		through the (M:N) relationship defined in the StoreContact table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="_customerId">Store identification number. Foreign key to Customer.CustomerID.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Contact objects.</returns>
		public override TList<Contact> GetByCustomerIdFromStoreContact(TransactionManager transactionManager, System.Int32 _customerId, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_GetByCustomerIdFromStoreContact(_customerId, start, pagelen, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion GetByCustomerIdFromStoreContact

		#region GetByVendorIdFromVendorContact

		/// <summary>
		///		Gets Contact objects from the datasource by VendorID in the
		///		VendorContact table. Table Contact is related to table Vendor
		///		through the (M:N) relationship defined in the VendorContact table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="_vendorId">Primary key.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Contact objects.</returns>
		public override TList<Contact> GetByVendorIdFromVendorContact(TransactionManager transactionManager, System.Int32 _vendorId, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_GetByVendorIdFromVendorContact(_vendorId, start, pagelen, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion GetByVendorIdFromVendorContact

		#endregion


		#region Delete Methods

			/// <summary>
			/// 	Deletes a row from the DataSource.
			/// </summary>
			/// <param name="_contactId">Primary key for Contact records.. Primary Key.</param>

			/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
			/// <remarks>Deletes based on primary key(s).</remarks>
			/// <returns>Returns true if operation suceeded.</returns>
			public override bool Delete(TransactionManager transactionManager, System.Int32 _contactId)
			{
				try
				{
				// call the proxy
				WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
				proxy.Url = Url;

				bool result = proxy.ContactProvider_Delete(_contactId);
				return result;
				}
				catch(SoapException soex)
				{
					System.Diagnostics.Debug.WriteLine(soex);
					throw soex;
				}
				catch(Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex);
					throw ex;
				}
			}

			#endregion Delete Methods


		#region Find Methods


		/// <summary>
		/// 	Returns rows meeting the whereclause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks>Operators must be capitalized (OR, AND)</remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Contact objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Contact> Find(TransactionManager transactionManager, string whereClause, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_Find(whereClause, start, pagelen, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion Find Methods


		#region GetAll Methods

		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Contact objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Contact> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_GetAll(start, pageLength, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion GetAll Methods

		#region GetPaged Methods

		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Contact objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Contact> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			try
			{
			whereClause = whereClause ?? string.Empty;
			orderBy = orderBy ?? string.Empty;

			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Contact[] items = proxy.ContactProvider_GetPaged(whereClause, orderBy, start, pageLength, out count);

			// Create a collection and fill it with the dataset
			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion GetPaged Methods


		#region Get By Foreign Key Functions
		#endregion


		#region Get By Index Functions

		/// <summary>
		/// 	Gets rows from the datasource based on the AK_Contact_rowguid index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rowguid">ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.Contact"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.Contact GetByRowguid(TransactionManager transactionManager, System.Guid _rowguid, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Contact items = proxy.ContactProvider_GetByRowguid(_rowguid, start, pageLength, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}


		/// <summary>
		/// 	Gets rows from the datasource based on the IX_Contact_EmailAddress index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_emailAddress">E-mail address for the person.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.TList&lt;Contact&gt;"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Contact> GetByEmailAddress(TransactionManager transactionManager, System.String _emailAddress, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Contact[] items = proxy.ContactProvider_GetByEmailAddress(_emailAddress, start, pageLength, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}


		/// <summary>
		/// 	Gets rows from the datasource based on the PK_Contact_ContactID index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_contactId">Primary key for Contact records.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.Contact"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.Contact GetByContactId(TransactionManager transactionManager, System.Int32 _contactId, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Contact items = proxy.ContactProvider_GetByContactId(_contactId, start, pageLength, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}


		/// <summary>
		/// 	Gets rows from the datasource based on the PXML_Contact_AddContact index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_additionalContactInfo">Additional contact information about the person stored in xml format. </param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.TList&lt;Contact&gt;"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Contact> GetByAdditionalContactInfo(TransactionManager transactionManager, string _additionalContactInfo, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Contact[] items = proxy.ContactProvider_GetByAdditionalContactInfo(_additionalContactInfo, start, pageLength, out count);

			return Convert(items);
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion Get By Index Functions


		#region Insert Methods
		/// <summary>
		/// 	Inserts a Nettiers.AdventureWorks.Entities.Contact object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.Contact object to insert.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Insert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.Contact entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.Contact result = proxy.ContactProvider_Insert(Convert(entity));
				Convert(entity, result);
				return true;
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		/// <summary>
		/// Lets you efficiently bulk many entity to the database.
		/// </summary>
		/// <param name="transactionManager">NOTE: The transaction manager should be null for the web service client implementation.</param>
		/// <param name="entityList">The entities.</param>
		/// <remarks>
		/// After inserting into the datasource, the Nettiers.AdventureWorks.Entities.Contact object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		public override void BulkInsert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.TList<Contact> entityList)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			try
			{
				proxy.ContactProvider_BulkInsert(Convert(entityList));
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion Insert Methods


		#region Update Methods

		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.Contact object to update.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Update(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.Contact entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.Contact result = proxy.ContactProvider_Update(Convert(entity));
				Convert(entity, result);
				entity.AcceptChanges();
				return true;
			}
			catch(SoapException soex)
			{
				System.Diagnostics.Debug.WriteLine(soex);
				throw soex;
			}
			catch(Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
				throw ex;
			}
		}

		#endregion Update Methods

		#region Custom Methods


		#endregion

	}//end class
} // end namespace

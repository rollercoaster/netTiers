﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file Nettiers.AdventureWorks.Entities.Location.cs instead.
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
	/// This class is the webservice client implementation that exposes CRUD methods for Nettiers.AdventureWorks.Entities.Location objects.
	///</summary>
	public abstract partial class WsLocationProviderBase : LocationProviderBase
	{
		#region Declarations

		/// <summary>
		/// the Url of the webservice.
		/// </summary>
		private string url;

		#endregion Declarations

		#region Constructors

		/// <summary>
		/// Creates a new <see cref="WsLocationProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		public WsLocationProviderBase()
		{
		}

		/// <summary>
		/// Creates a new <see cref="WsLocationProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="url">The url to the nettiers webservice.</param>
		public WsLocationProviderBase(string url)
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
		public static Nettiers.AdventureWorks.Entities.TList<Location> Convert(WsProxy.Location[] items)
		{
			Nettiers.AdventureWorks.Entities.TList<Location> outItems = new Nettiers.AdventureWorks.Entities.TList<Location>();
			foreach(WsProxy.Location item in items)
			{
				outItems.Add(Convert(item));
			}
			return outItems;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.Location Convert(WsProxy.Location item)
		{
			Nettiers.AdventureWorks.Entities.Location outItem = item == null ? null : new Nettiers.AdventureWorks.Entities.Location();
			Convert(outItem, item);
			return outItem;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.Location Convert(Nettiers.AdventureWorks.Entities.Location outItem , WsProxy.Location item)
		{
			if (item != null && outItem != null)
			{
				outItem.LocationId = item.LocationId;
				outItem.Name = item.Name;
				outItem.CostRate = item.CostRate;
				outItem.Availability = item.Availability;
				outItem.ModifiedDate = item.ModifiedDate;

				outItem.AcceptChanges();
			}

			return outItem;
		}

		/// <summary>
		/// Convert a nettiers entity to the ws proxy entity.
		/// </summary>
		public static WsProxy.Location Convert(Nettiers.AdventureWorks.Entities.Location item)
		{
			WsProxy.Location outItem = new WsProxy.Location();
			outItem.LocationId = item.LocationId;
			outItem.Name = item.Name;
			outItem.CostRate = item.CostRate;
			outItem.Availability = item.Availability;
			outItem.ModifiedDate = item.ModifiedDate;


			return outItem;
		}

		/// <summary>
		/// Convert a collection from  to a nettiers collection to a the ws proxy collection.
		/// </summary>
		public static WsProxy.Location[] Convert(Nettiers.AdventureWorks.Entities.TList<Location> items)
		{
			WsProxy.Location[] outItems = new WsProxy.Location[items.Count];
			int count = 0;

			foreach (Nettiers.AdventureWorks.Entities.Location item in items)
			{
				outItems[count++] = Convert(item);
			}
			return outItems;
		}


		#endregion

		#region Get from  Many To Many Relationship Functions
		#region GetByProductIdFromProductInventory

		/// <summary>
		///		Gets Location objects from the datasource by ProductID in the
		///		ProductInventory table. Table Location is related to table Product
		///		through the (M:N) relationship defined in the ProductInventory table.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pagelen">Number of rows to return.</param>
		/// <param name="_productId">Product identification number. Foreign key to Product.ProductID.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Location objects.</returns>
		public override TList<Location> GetByProductIdFromProductInventory(TransactionManager transactionManager, System.Int32 _productId, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Location[] items = proxy.LocationProvider_GetByProductIdFromProductInventory(_productId, start, pagelen, out count);

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

		#endregion GetByProductIdFromProductInventory

		#endregion


		#region Delete Methods

			/// <summary>
			/// 	Deletes a row from the DataSource.
			/// </summary>
			/// <param name="_locationId">Primary key for Location records.. Primary Key.</param>

			/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
			/// <remarks>Deletes based on primary key(s).</remarks>
			/// <returns>Returns true if operation suceeded.</returns>
			public override bool Delete(TransactionManager transactionManager, System.Int16 _locationId)
			{
				try
				{
				// call the proxy
				WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
				proxy.Url = Url;

				bool result = proxy.LocationProvider_Delete(_locationId);
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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Location objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Location> Find(TransactionManager transactionManager, string whereClause, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Location[] items = proxy.LocationProvider_Find(whereClause, start, pagelen, out count);

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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Location objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Location> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Location[] items = proxy.LocationProvider_GetAll(start, pageLength, out count);

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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.Location objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<Location> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			try
			{
			whereClause = whereClause ?? string.Empty;
			orderBy = orderBy ?? string.Empty;

			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.Location[] items = proxy.LocationProvider_GetPaged(whereClause, orderBy, start, pageLength, out count);

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
		/// 	Gets rows from the datasource based on the AK_Location_Name index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_name">Location description.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.Location"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.Location GetByName(TransactionManager transactionManager, System.String _name, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Location items = proxy.LocationProvider_GetByName(_name, start, pageLength, out count);

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
		/// 	Gets rows from the datasource based on the PK_Location_LocationID index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_locationId">Primary key for Location records.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.Location"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.Location GetByLocationId(TransactionManager transactionManager, System.Int16 _locationId, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.Location items = proxy.LocationProvider_GetByLocationId(_locationId, start, pageLength, out count);

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
		/// 	Inserts a Nettiers.AdventureWorks.Entities.Location object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.Location object to insert.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Insert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.Location entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.Location result = proxy.LocationProvider_Insert(Convert(entity));
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
		/// After inserting into the datasource, the Nettiers.AdventureWorks.Entities.Location object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		public override void BulkInsert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.TList<Location> entityList)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			try
			{
				proxy.LocationProvider_BulkInsert(Convert(entityList));
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
		/// <param name="entity">Nettiers.AdventureWorks.Entities.Location object to update.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Update(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.Location entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.Location result = proxy.LocationProvider_Update(Convert(entity));
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

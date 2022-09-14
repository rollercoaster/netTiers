﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file Nettiers.AdventureWorks.Entities.SalesTerritory.cs instead.
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
	/// This class is the webservice client implementation that exposes CRUD methods for Nettiers.AdventureWorks.Entities.SalesTerritory objects.
	///</summary>
	public abstract partial class WsSalesTerritoryProviderBase : SalesTerritoryProviderBase
	{
		#region Declarations

		/// <summary>
		/// the Url of the webservice.
		/// </summary>
		private string url;

		#endregion Declarations

		#region Constructors

		/// <summary>
		/// Creates a new <see cref="WsSalesTerritoryProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		public WsSalesTerritoryProviderBase()
		{
		}

		/// <summary>
		/// Creates a new <see cref="WsSalesTerritoryProviderBase"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="url">The url to the nettiers webservice.</param>
		public WsSalesTerritoryProviderBase(string url)
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
		public static Nettiers.AdventureWorks.Entities.TList<SalesTerritory> Convert(WsProxy.SalesTerritory[] items)
		{
			Nettiers.AdventureWorks.Entities.TList<SalesTerritory> outItems = new Nettiers.AdventureWorks.Entities.TList<SalesTerritory>();
			foreach(WsProxy.SalesTerritory item in items)
			{
				outItems.Add(Convert(item));
			}
			return outItems;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.SalesTerritory Convert(WsProxy.SalesTerritory item)
		{
			Nettiers.AdventureWorks.Entities.SalesTerritory outItem = item == null ? null : new Nettiers.AdventureWorks.Entities.SalesTerritory();
			Convert(outItem, item);
			return outItem;
		}

		/// <summary>
		/// Convert a nettiers collection to the ws proxy collection.
		/// </summary>
		public static Nettiers.AdventureWorks.Entities.SalesTerritory Convert(Nettiers.AdventureWorks.Entities.SalesTerritory outItem , WsProxy.SalesTerritory item)
		{
			if (item != null && outItem != null)
			{
				outItem.TerritoryId = item.TerritoryId;
				outItem.Name = item.Name;
				outItem.CountryRegionCode = item.CountryRegionCode;
				outItem.Group = item.Group;
				outItem.SalesYtd = item.SalesYtd;
				outItem.SalesLastYear = item.SalesLastYear;
				outItem.CostYtd = item.CostYtd;
				outItem.CostLastYear = item.CostLastYear;
				outItem.Rowguid = item.Rowguid;
				outItem.ModifiedDate = item.ModifiedDate;

				outItem.AcceptChanges();
			}

			return outItem;
		}

		/// <summary>
		/// Convert a nettiers entity to the ws proxy entity.
		/// </summary>
		public static WsProxy.SalesTerritory Convert(Nettiers.AdventureWorks.Entities.SalesTerritory item)
		{
			WsProxy.SalesTerritory outItem = new WsProxy.SalesTerritory();
			outItem.TerritoryId = item.TerritoryId;
			outItem.Name = item.Name;
			outItem.CountryRegionCode = item.CountryRegionCode;
			outItem.Group = item.Group;
			outItem.SalesYtd = item.SalesYtd;
			outItem.SalesLastYear = item.SalesLastYear;
			outItem.CostYtd = item.CostYtd;
			outItem.CostLastYear = item.CostLastYear;
			outItem.Rowguid = item.Rowguid;
			outItem.ModifiedDate = item.ModifiedDate;


			return outItem;
		}

		/// <summary>
		/// Convert a collection from  to a nettiers collection to a the ws proxy collection.
		/// </summary>
		public static WsProxy.SalesTerritory[] Convert(Nettiers.AdventureWorks.Entities.TList<SalesTerritory> items)
		{
			WsProxy.SalesTerritory[] outItems = new WsProxy.SalesTerritory[items.Count];
			int count = 0;

			foreach (Nettiers.AdventureWorks.Entities.SalesTerritory item in items)
			{
				outItems[count++] = Convert(item);
			}
			return outItems;
		}


		#endregion

		#region Get from  Many To Many Relationship Functions
		#endregion


		#region Delete Methods

			/// <summary>
			/// 	Deletes a row from the DataSource.
			/// </summary>
			/// <param name="_territoryId">Primary key for SalesTerritory records.. Primary Key.</param>

			/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
			/// <remarks>Deletes based on primary key(s).</remarks>
			/// <returns>Returns true if operation suceeded.</returns>
			public override bool Delete(TransactionManager transactionManager, System.Int32 _territoryId)
			{
				try
				{
				// call the proxy
				WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
				proxy.Url = Url;

				bool result = proxy.SalesTerritoryProvider_Delete(_territoryId);
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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.SalesTerritory objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<SalesTerritory> Find(TransactionManager transactionManager, string whereClause, int start, int pagelen, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.SalesTerritory[] items = proxy.SalesTerritoryProvider_Find(whereClause, start, pagelen, out count);

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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.SalesTerritory objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<SalesTerritory> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.SalesTerritory[] items = proxy.SalesTerritoryProvider_GetAll(start, pageLength, out count);

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
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.SalesTerritory objects.</returns>
		public override Nettiers.AdventureWorks.Entities.TList<SalesTerritory> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			try
			{
			whereClause = whereClause ?? string.Empty;
			orderBy = orderBy ?? string.Empty;

			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			WsProxy.SalesTerritory[] items = proxy.SalesTerritoryProvider_GetPaged(whereClause, orderBy, start, pageLength, out count);

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
		/// 	Gets rows from the datasource based on the AK_SalesTerritory_Name index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_name">Sales territory description</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.SalesTerritory"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.SalesTerritory GetByName(TransactionManager transactionManager, System.String _name, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.SalesTerritory items = proxy.SalesTerritoryProvider_GetByName(_name, start, pageLength, out count);

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
		/// 	Gets rows from the datasource based on the AK_SalesTerritory_rowguid index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_rowguid">ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.SalesTerritory"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.SalesTerritory GetByRowguid(TransactionManager transactionManager, System.Guid _rowguid, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.SalesTerritory items = proxy.SalesTerritoryProvider_GetByRowguid(_rowguid, start, pageLength, out count);

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
		/// 	Gets rows from the datasource based on the PK_SalesTerritory_TerritoryID index.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_territoryId">Primary key for SalesTerritory records.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.SalesTerritory"/> class.</returns>
		public override Nettiers.AdventureWorks.Entities.SalesTerritory GetByTerritoryId(TransactionManager transactionManager, System.Int32 _territoryId, int start, int pageLength, out int count)
		{
			try
			{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			WsProxy.SalesTerritory items = proxy.SalesTerritoryProvider_GetByTerritoryId(_territoryId, start, pageLength, out count);

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
		/// 	Inserts a Nettiers.AdventureWorks.Entities.SalesTerritory object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.SalesTerritory object to insert.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Insert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.SalesTerritory entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.SalesTerritory result = proxy.SalesTerritoryProvider_Insert(Convert(entity));
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
		/// After inserting into the datasource, the Nettiers.AdventureWorks.Entities.SalesTerritory object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		public override void BulkInsert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.TList<SalesTerritory> entityList)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;
			try
			{
				proxy.SalesTerritoryProvider_BulkInsert(Convert(entityList));
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
		/// <param name="entity">Nettiers.AdventureWorks.Entities.SalesTerritory object to update.</param>
		/// <remarks></remarks>
		/// <returns>Returns true if operation is successful.</returns>
		public override bool Update(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.SalesTerritory entity)
		{
			WsProxy.AdventureWorksServices proxy = new WsProxy.AdventureWorksServices();
			proxy.Url = Url;

			try
			{
				WsProxy.SalesTerritory result = proxy.SalesTerritoryProvider_Update(Convert(entity));
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

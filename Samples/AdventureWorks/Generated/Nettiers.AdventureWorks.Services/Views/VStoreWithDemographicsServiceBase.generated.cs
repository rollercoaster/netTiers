﻿
/*
	File generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file VStoreWithDemographics.cs instead.
*/

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Security;
using System.Data;

using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Entities.Validation;
using Entities = Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;


using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace Nettiers.AdventureWorks.Services
{

	///<summary>
	/// An object representation of the 'vStoreWithDemographics' View.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  class, modify the VStoreWithDemographics.cs file instead.
	/// All custom implementations should be done in the <see cref="VStoreWithDemographics"/> class.
	/// </remarks>
	[DataObject]
	public partial class VStoreWithDemographicsServiceBase : ServiceViewBase<VStoreWithDemographics>
	{

		#region Constructors
		///<summary>
		/// Creates a new <see cref="VStoreWithDemographics"/> instance .
		///</summary>
		public VStoreWithDemographicsServiceBase() : base()
		{
		}

		///<summary>
		/// A simple factory method to create a new <see cref="VStoreWithDemographics"/> instance.
		///</summary>
		///<param name="_customerId"></param>
		///<param name="_name"></param>
		///<param name="_contactType"></param>
		///<param name="_title"></param>
		///<param name="_firstName"></param>
		///<param name="_middleName"></param>
		///<param name="_lastName"></param>
		///<param name="_suffix"></param>
		///<param name="_phone"></param>
		///<param name="_emailAddress"></param>
		///<param name="_emailPromotion"></param>
		///<param name="_addressType"></param>
		///<param name="_addressLine1"></param>
		///<param name="_addressLine2"></param>
		///<param name="_city"></param>
		///<param name="_stateProvinceName"></param>
		///<param name="_postalCode"></param>
		///<param name="_countryRegionName"></param>
		///<param name="_annualSales"></param>
		///<param name="_annualRevenue"></param>
		///<param name="_bankName"></param>
		///<param name="_businessType"></param>
		///<param name="_yearOpened"></param>
		///<param name="_specialty"></param>
		///<param name="_squareFeet"></param>
		///<param name="_brands"></param>
		///<param name="_internet"></param>
		///<param name="_numberEmployees"></param>
		public static VStoreWithDemographics CreateVStoreWithDemographics(System.Int32 _customerId, System.String _name, System.String _contactType, System.String _title, System.String _firstName, System.String _middleName, System.String _lastName, System.String _suffix, System.String _phone, System.String _emailAddress, System.Int32 _emailPromotion, System.String _addressType, System.String _addressLine1, System.String _addressLine2, System.String _city, System.String _stateProvinceName, System.String _postalCode, System.String _countryRegionName, System.Decimal? _annualSales, System.Decimal? _annualRevenue, System.String _bankName, System.String _businessType, System.Int32? _yearOpened, System.String _specialty, System.Int32? _squareFeet, System.String _brands, System.String _internet, System.Int32? _numberEmployees)
		{
			VStoreWithDemographics newEntityVStoreWithDemographics = new VStoreWithDemographics();
			newEntityVStoreWithDemographics.CustomerId  = _customerId;
			newEntityVStoreWithDemographics.Name  = _name;
			newEntityVStoreWithDemographics.ContactType  = _contactType;
			newEntityVStoreWithDemographics.Title  = _title;
			newEntityVStoreWithDemographics.FirstName  = _firstName;
			newEntityVStoreWithDemographics.MiddleName  = _middleName;
			newEntityVStoreWithDemographics.LastName  = _lastName;
			newEntityVStoreWithDemographics.Suffix  = _suffix;
			newEntityVStoreWithDemographics.Phone  = _phone;
			newEntityVStoreWithDemographics.EmailAddress  = _emailAddress;
			newEntityVStoreWithDemographics.EmailPromotion  = _emailPromotion;
			newEntityVStoreWithDemographics.AddressType  = _addressType;
			newEntityVStoreWithDemographics.AddressLine1  = _addressLine1;
			newEntityVStoreWithDemographics.AddressLine2  = _addressLine2;
			newEntityVStoreWithDemographics.City  = _city;
			newEntityVStoreWithDemographics.StateProvinceName  = _stateProvinceName;
			newEntityVStoreWithDemographics.PostalCode  = _postalCode;
			newEntityVStoreWithDemographics.CountryRegionName  = _countryRegionName;
			newEntityVStoreWithDemographics.AnnualSales  = _annualSales;
			newEntityVStoreWithDemographics.AnnualRevenue  = _annualRevenue;
			newEntityVStoreWithDemographics.BankName  = _bankName;
			newEntityVStoreWithDemographics.BusinessType  = _businessType;
			newEntityVStoreWithDemographics.YearOpened  = _yearOpened;
			newEntityVStoreWithDemographics.Specialty  = _specialty;
			newEntityVStoreWithDemographics.SquareFeet  = _squareFeet;
			newEntityVStoreWithDemographics.Brands  = _brands;
			newEntityVStoreWithDemographics.Internet  = _internet;
			newEntityVStoreWithDemographics.NumberEmployees  = _numberEmployees;
			return newEntityVStoreWithDemographics;
		}
		#endregion Constructors

		#region Fields
		//private static SecurityContext<VStoreWithDemographics> securityContext = new SecurityContext<VStoreWithDemographics>();
		private static readonly string layerExceptionPolicy = "NoneExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		private static readonly int defaultMaxRecords = 10000;
		#endregion

		#region Data Access Methods

		#region Get
		/// <summary>
		/// Attempts to do a parameterized version of a simple whereclause.
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection of Entity objects.</returns>
		public override VList<VStoreWithDemographics> Get(string whereClause, string orderBy)
		{
			int totalCount = -1;
			return Get(whereClause, orderBy, 0, defaultMaxRecords, out totalCount);
		}

		/// <summary>
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
        /// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter to get total records for query</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection TList{VStoreWithDemographics} of <c>VStoreWithDemographics</c> objects.</returns>
		public override VList<VStoreWithDemographics> Get(string whereClause, string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Get");

			// get this data
			VList<VStoreWithDemographics> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null;

			try
            {
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;

				//Access repository
				list = dataProvider.VStoreWithDemographicsProvider.Get(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);

				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen)
					transactionManager.Rollback();

				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
					throw;
			}
			return list;
		}

		#endregion Get Methods

		#region GetAll
		/// <summary>
		/// Get a complete collection of <see cref="VStoreWithDemographics" /> entities.
		/// </summary>
		/// <returns></returns>
		public virtual VList<VStoreWithDemographics> GetAll()
		{
			int totalCount = -1;
			return GetAll(0, defaultMaxRecords, out totalCount);
		}


		/// <summary>
		/// Get a set portion of a complete list of <see cref="VStoreWithDemographics" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{VStoreWithDemographics}"/> </returns>
		public override VList<VStoreWithDemographics> GetAll(int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetAll");

			// get this data
			VList<VStoreWithDemographics> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null;

			try
            {
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;

				//Access repository
				list = dataProvider.VStoreWithDemographicsProvider.GetAll(transactionManager, start, pageLength, out totalCount);
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen)
					transactionManager.Rollback();

				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
					throw;
			}
			return list;
		}
		#endregion GetAll

		#region GetPaged
		/// <summary>
		/// Gets a page of <see cref="TList{VStoreWithDemographics}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public virtual VList<VStoreWithDemographics> GetPaged(out int totalCount)
		{
			return GetPaged(null, null, 0, defaultMaxRecords, out totalCount);
		}

		/// <summary>
		/// Gets a page of <see cref="TList{VStoreWithDemographics}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public virtual VList<VStoreWithDemographics> GetPaged(int start, int pageLength, out int totalCount)
		{
			return GetPaged(null, null, start, pageLength, out totalCount);
		}

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{VStoreWithDemographics}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public override VList<VStoreWithDemographics> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("GetPaged");

			// get this data
			VList<VStoreWithDemographics> list = null;
			totalCount = -1;
			TransactionManager transactionManager = null;

			try
            {
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;

				//Access repository
				list = dataProvider.VStoreWithDemographicsProvider.GetPaged(transactionManager, whereClause, orderBy, start, pageLength, out totalCount);

				//if borrowed tran, leave open for next call
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen)
					transactionManager.Rollback();

				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
					throw;
			}
			return list;
		}

		/// <summary>
		/// Gets the number of rows in the DataSource that match the specified whereClause.
		/// This method is only provided as a workaround for the ObjectDataSource's need to
		/// execute another method to discover the total count instead of using another param, like our out param.
		/// This method should be avoided if using the ObjectDataSource or another method.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <returns>Returns the number of rows.</returns>
		public int GetTotalItems(string whereClause, out int totalCount)
		{
			GetPaged(whereClause, null, 0, defaultMaxRecords, out totalCount);
			return totalCount;
		}
		#endregion GetPaged

		#region Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public virtual VList<VStoreWithDemographics> Find(IFilterParameterCollection parameters)
		{
			return Find(parameters, null);
		}

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public virtual VList<VStoreWithDemographics> Find(IFilterParameterCollection parameters, string orderBy)
		{
			int count = 0;
			return Find(parameters, orderBy, 0, defaultMaxRecords, out count);
		}

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of <c>VStoreWithDemographics</c> objects.</returns>
		public override VList<VStoreWithDemographics> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			// throws security exception if not authorized
			//SecurityContext.IsAuthorized("Find");

			// get this data
			TransactionManager transactionManager = null;
			VList<VStoreWithDemographics> list = null;
			count = -1;

			try
            {
				//since this is a read operation, don't create a tran by default, only use tran if provided to us for custom isolation level
				transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
				NetTiersProvider dataProvider = ConnectionScope.Current.DataProvider;

				//Access repository
				list = dataProvider.VStoreWithDemographicsProvider.Find(transactionManager, parameters, orderBy, start, pageLength, out count);
			}
            catch (Exception exc)
            {
				//if open, rollback, it's possible this is part of a larger commit
                if (transactionManager != null && transactionManager.IsOpen)
					transactionManager.Rollback();

				//Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
					throw;
			}

			return list;
		}

		#endregion Find Methods

		#region Custom Methods
		#endregion

		#endregion Data Access Methods


	}//End Class
} // end namespace




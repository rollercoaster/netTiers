﻿
/*
	File generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file WorkOrderRouting.cs instead.
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
using System.ServiceModel;

using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Entities.Validation;
//using Entities = Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;


using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace Nettiers.AdventureWorks.Contracts.Services
{

	///<summary>
	/// An interface representation of the 'WorkOrderRouting' table.
	///</summary>
	/// <remarks>
	/// IMPORTANT!!! You should not modify this partial  interface, modify the IWorkOrderRouting.cs file instead.
	/// All custom implementations should be done in the <see cref="IWorkOrderRouting"/> class.
	/// </remarks>
	[ServiceContract]
	public partial interface IWorkOrderRoutingServiceBase
	{

        #region Data Access Methods

		#region GetByForeignKey Methods
		/// <summary>
		/// 	method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the FK_WorkOrderRouting_Location_LocationID key.
		///		FK_WorkOrderRouting_Location_LocationID Description: Foreign key constraint referencing Location.LocationID.
		/// </summary>
		/// <param name="_locationId">Manufacturing location where the part is processed. Foreign key to Location.LocationID.</param>
		/// <returns>Returns a generic collection of WorkOrderRouting objects.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByLocationId(System.Int16 _locationId);

		/// <summary>
		/// 	method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the FK_WorkOrderRouting_Location_LocationID key.
		///		FK_WorkOrderRouting_Location_LocationID Description: Foreign key constraint referencing Location.LocationID.
		/// </summary>
		/// <param name="_locationId">Manufacturing location where the part is processed. Foreign key to Location.LocationID.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Page length of records you would like to retrieve</param>
		/// <param name="totalCount">Out parameter, number of total rows in given query.</param>
		/// <returns>Returns a collection <see cref="TList{WorkOrderRouting}" /> of <c>WorkOrderRouting</c> objects.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByLocationId(System.Int16 _locationId, int start, int pageLength, out int totalCount);

		/// <summary>
		/// 	method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the FK_WorkOrderRouting_WorkOrder_WorkOrderID key.
		///		FK_WorkOrderRouting_WorkOrder_WorkOrderID Description: Foreign key constraint referencing WorkOrder.WorkOrderID.
		/// </summary>
		/// <param name="_workOrderId">Primary key. Foreign key to WorkOrder.WorkOrderID.</param>
		/// <returns>Returns a generic collection of WorkOrderRouting objects.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByWorkOrderId(System.Int32 _workOrderId);

		/// <summary>
		/// 	method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the FK_WorkOrderRouting_WorkOrder_WorkOrderID key.
		///		FK_WorkOrderRouting_WorkOrder_WorkOrderID Description: Foreign key constraint referencing WorkOrder.WorkOrderID.
		/// </summary>
		/// <param name="_workOrderId">Primary key. Foreign key to WorkOrder.WorkOrderID.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Page length of records you would like to retrieve</param>
		/// <param name="totalCount">Out parameter, number of total rows in given query.</param>
		/// <returns>Returns a collection <see cref="TList{WorkOrderRouting}" /> of <c>WorkOrderRouting</c> objects.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByWorkOrderId(System.Int32 _workOrderId, int start, int pageLength, out int totalCount);

		#endregion GetByForeignKey Methods

		#region GetByIndexes

		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		WorkOrderRouting Get(WorkOrderRoutingKey key);


		/// <summary>
		///  method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the primary key IX_WorkOrderRouting_ProductID index.
		/// </summary>
		/// <param name="_productId">Primary key. Foreign key to Product.ProductID.</param>
		/// <returns>Returns an instance of the <see cref="TList{WorkOrderRouting}"/> class.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByProductId(System.Int32 _productId);

		/// <summary>
		///  Method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the primary key IX_WorkOrderRouting_ProductID index.
		/// </summary>
		/// <param name="_productId">Primary key. Foreign key to Product.ProductID.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Page length of records you would like to retrieve</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>Returns an instance of the <see cref="TList{WorkOrderRouting}"/> class.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		TList<WorkOrderRouting> GetByProductId(System.Int32 _productId, int start, int pageLength, out int totalCount);


		/// <summary>
		///  method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the primary key PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence index.
		/// </summary>
		/// <param name="_workOrderId">Primary key. Foreign key to WorkOrder.WorkOrderID.</param>
		/// <param name="_productId">Primary key. Foreign key to Product.ProductID.</param>
		/// <param name="_operationSequence">Primary key. Indicates the manufacturing process sequence.</param>
		/// <returns>Returns an instance of the <see cref="WorkOrderRouting"/> class.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		WorkOrderRouting GetByWorkOrderIdProductIdOperationSequence(System.Int32 _workOrderId, System.Int32 _productId, System.Int16 _operationSequence);

		/// <summary>
		///  Method that Gets rows in a <see cref="TList{WorkOrderRouting}" /> from the datasource based on the primary key PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence index.
		/// </summary>
		/// <param name="_workOrderId">Primary key. Foreign key to WorkOrder.WorkOrderID.</param>
		/// <param name="_productId">Primary key. Foreign key to Product.ProductID.</param>
		/// <param name="_operationSequence">Primary key. Indicates the manufacturing process sequence.</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Page length of records you would like to retrieve</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>Returns an instance of the <see cref="WorkOrderRouting"/> class.</returns>
		[DataObjectMethod(DataObjectMethodType.Select)]


		WorkOrderRouting GetByWorkOrderIdProductIdOperationSequence(System.Int32 _workOrderId, System.Int32 _productId, System.Int16 _operationSequence, int start, int pageLength, out int totalCount);

		#endregion GetByIndexes

		#region GetAll

		/// <summary>
		/// Get a complete collection of <see cref="WorkOrderRouting" /> entities.
		/// </summary>
		/// <returns></returns>


		TList<WorkOrderRouting> GetAll();

		/// <summary>
		/// Get a set portion of a complete list of <see cref="WorkOrderRouting" /> entities
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter, number of total rows in given query.</param>
		/// <returns>a <see cref="TList{WorkOrderRouting}"/> </returns>


		TList<WorkOrderRouting> GetAll(int start, int pageLength, out int totalCount);

		#endregion GetAll

		#region GetPaged

		/// <summary>
		/// Gets a page of <see cref="TList{WorkOrderRouting}" /> rows from the DataSource.
		/// </summary>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> GetPaged(out int totalCount);

		/// <summary>
		/// Gets a page of <see cref="TList{WorkOrderRouting}" /> rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> GetPaged(int start, int pageLength, out int totalCount);

		/// <summary>
		/// Gets a page of entity rows with a <see cref="TList{WorkOrderRouting}" /> from the DataSource with a where clause and order by clause.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC).</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">Out Parameter, Number of rows in the DataSource.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> GetPaged(string whereClause,string orderBy, int start, int pageLength, out int totalCount);

		/// <summary>
		/// Gets the number of rows in the DataSource that match the specified whereClause.
		/// This method is only provided as a workaround for the ObjectDataSource's need to
		/// execute another method to discover the total count instead of using another param, like our out param.
		/// This method should be avoided if using the ObjectDataSource or another method.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="totalCount">Number of rows in the DataSource.</param>
		/// <returns>Returns the number of rows.</returns>


		int GetTotalItems(string whereClause, out int totalCount);

		#endregion GetPaged

		#region Find

		#region Parsed Find Methods

		/// <summary>
		/// Attempts to do a parameterized version of a simple whereclause.
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection of Entity objects.</returns>


		TList<WorkOrderRouting> Find(string whereClause)	;

		/// <summary>
		/// Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="totalCount">out parameter to get total records for query</param>
		/// <remarks>Does NOT Support Advanced Operations such as SubSelects.  See GetPaged for that functionality.</remarks>
		/// <returns>Returns a typed collection TList{WorkOrderRouting} of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> Find(string whereClause, int start, int pageLength, out int totalCount);

		#endregion Parsed Find Methods

		#region Parameterized Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> Find(IFilterParameterCollection parameters);

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> Find(IFilterParameterCollection parameters, string orderBy);

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of <c>WorkOrderRouting</c> objects.</returns>


		TList<WorkOrderRouting> Find(IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count);

		#endregion Parameterized Find Methods

		#endregion

		#region Insert

		#region Insert Entity

		/// <summary>
		/// 	public virtualmethod that Inserts a WorkOrderRouting object into the datasource using a transaction.
		/// </summary>
		/// <param name="entity">WorkOrderRouting object to Insert.</param>
		/// <remarks>After Inserting into the datasource, the WorkOrderRouting object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns bool that the operation is successful.</returns>
		/// <example>
        /// The following code shows the usage of the Insert Method with an already open transaction.
        /// <code>
		/// WorkOrderRouting entity = new WorkOrderRouting();
		/// entity.StringProperty = "foo";
		/// entity.IntProperty = 12;
		/// entity.ChildObjectSource.StringProperty = "bar";
		/// TransactionManager tm = null;
		/// try
        ///	{
		/// 	tm = ConnectionContext.CreateTransaction();
		///		//Insert Child entity, Then Parent Entity
		/// 	ChildObjectType.Insert(entity.ChildObjectSource);
		///		WorkOrderRouting.Insert(entity);
		///	}
        ///	catch (Exception e)
        ///	{
		///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Insert)]


		bool Insert(WorkOrderRouting entity);

		#endregion Insert Entity

		#region Insert Collection

		/// <summary>
		/// 	method that Inserts rows in <see cref="TList{WorkOrderRouting}" /> to the datasource.
		/// </summary>
		/// <param name="entityCollection"><c>WorkOrderRouting</c> objects in a <see cref="TList{WorkOrderRouting}" /> object to Insert.</param>
		/// <remarks>
		///		This function will only Insert entity objects marked as dirty
		///		and have an identity field equal to zero.
		///		Upon Inserting the objects, each dirty object will have the public
		///		method <c>Object.AcceptChanges()</c> called to make it clean.
		/// 	After Inserting into the datasource, the <c>WorkOrderRouting</c> objects will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		///</remarks>
		/// <returns>Returns the number of successful Insert.</returns>
		/// <example>
        /// The following code shows the usage of the Insert Method with a collection of WorkOrderRouting.
        /// <code><![CDATA[
		/// TList<WorkOrderRouting> list = new TList<WorkOrderRouting>();
		/// WorkOrderRouting entity = new WorkOrderRouting();
		/// entity.StringProperty = "foo";
		/// WorkOrderRouting entity2 = new WorkOrderRouting();
		/// entity.StringProperty = "bar";
		/// list.Add(entity);
		/// list.Add(entity2);
		///	WorkOrderRoutingService.Insert(list);
		///	}
        ///	catch (Exception e)
        ///	{
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// ]]></code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Insert)]


		TList<WorkOrderRouting> Insert(TList<WorkOrderRouting> entityCollection);

		#endregion Insert Collection

		#endregion Insert

		#region Update

		#region Update Entity

		/// <summary>
		/// 	public virtualmethod that Updates a WorkOrderRouting object into the datasource using a transaction.
		/// </summary>
		/// <param name="entity">WorkOrderRouting object to Update.</param>
		/// <remarks>After Updateing into the datasource, the WorkOrderRouting object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns bool that the operation is successful.</returns>
		/// <example>
        /// The following code shows the usage of the Update Method with an already open transaction.
        /// <code>
		///	WorkOrderRouting entity = WorkOrderRoutingService.GetByPrimaryKeyColumn(1234);
		/// entity.StringProperty = "foo";
		/// entity.IntProperty = 12;
		/// entity.ChildObjectSource.StringProperty = "bar";
		/// TransactionManager tm = null;
		/// try
        ///	{
		/// 	tm = ConnectionContext.CreateTransaction();
		///		//Update Child entity, Then Parent Entity
		/// 	ChildObjectType.Update(entity.ChildObjectSource);
		///		WorkOrderRouting.Update(entity);
		///	}
        ///	catch (Exception e)
        ///	{
		///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Update)]


		bool Update(WorkOrderRouting entity);

		#endregion Update Entity

		#region Update Collection

		/// <summary>
		/// 	method that Updates rows in <see cref="TList{WorkOrderRouting}" /> to the datasource.
		/// </summary>
		/// <param name="entityCollection"><c>WorkOrderRouting</c> objects in a <see cref="TList{WorkOrderRouting}" /> object to Update.</param>
		/// <remarks>
		///		This function will only Update entity objects marked as dirty
		///		and have an identity field equal to zero.
		///		Upon Updateing the objects, each dirty object will have the public
		///		method <c>Object.AcceptChanges()</c> called to make it clean.
		/// 	After Updateing into the datasource, the <c>WorkOrderRouting</c> objects will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		///</remarks>
		/// <returns>Returns the number of successful Update.</returns>
		/// <example>
        /// The following code shows the usage of the Update Method with a collection of WorkOrderRouting.
        /// <code><![CDATA[
		/// TList<WorkOrderRouting> list = new TList<WorkOrderRouting>();
		/// WorkOrderRouting entity = new WorkOrderRouting();
		/// entity.StringProperty = "foo";
		/// WorkOrderRouting entity2 = new WorkOrderRouting();
		/// entity.StringProperty = "bar";
		/// list.Add(entity);
		/// list.Add(entity2);
		///	WorkOrderRoutingService.Update(list);
		///	}
        ///	catch (Exception e)
        ///	{
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// ]]></code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Update)]


		TList<WorkOrderRouting> Update(TList<WorkOrderRouting> entityCollection);

		#endregion Update Collection

		#endregion Update

		#region Save

		#region Save Entity

		/// <summary>
		/// 	public virtualmethod that Saves a WorkOrderRouting object into the datasource using a transaction.
		/// </summary>
		/// <param name="entity">WorkOrderRouting object to Save.</param>
		/// <remarks>After Saveing into the datasource, the WorkOrderRouting object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns bool that the operation is successful.</returns>
		/// <example>
        /// The following code shows the usage of the Save Method with an already open transaction.
        /// <code>
		///	WorkOrderRouting entity = WorkOrderRoutingService.GetByPrimaryKeyColumn(1234);
		/// entity.StringProperty = "foo";
		/// entity.IntProperty = 12;
		/// entity.ChildObjectSource.StringProperty = "bar";
		/// TransactionManager tm = null;
		/// try
        ///	{
		/// 	tm = ConnectionContext.CreateTransaction();
		///		//Save Child entity, Then Parent Entity
		/// 	ChildObjectType.Save(entity.ChildObjectSource);
		///		WorkOrderRouting.Save(entity);
		///	}
        ///	catch (Exception e)
        ///	{
		///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Update)]


		WorkOrderRouting Save(WorkOrderRouting entity);

		#endregion Save Entity

		#region Save Collection

		/// <summary>
		/// 	method that Saves rows in <see cref="TList{WorkOrderRouting}" /> to the datasource.
		/// </summary>
		/// <param name="entityCollection"><c>WorkOrderRouting</c> objects in a <see cref="TList{WorkOrderRouting}" /> object to Save.</param>
		/// <remarks>
		///		This function will only Save entity objects marked as dirty
		///		and have an identity field equal to zero.
		///		Upon Saveing the objects, each dirty object will have the public
		///		method <c>Object.AcceptChanges()</c> called to make it clean.
		/// 	After Saveing into the datasource, the <c>WorkOrderRouting</c> objects will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		///</remarks>
		/// <returns>Returns the number of successful Save.</returns>
		/// <example>
        /// The following code shows the usage of the Save Method with a collection of WorkOrderRouting.
        /// <code><![CDATA[
		/// TList<WorkOrderRouting> list = new TList<WorkOrderRouting>();
		/// WorkOrderRouting entity = new WorkOrderRouting();
		/// entity.StringProperty = "foo";
		/// WorkOrderRouting entity2 = new WorkOrderRouting();
		/// entity.StringProperty = "bar";
		/// list.Add(entity);
		/// list.Add(entity2);
		///	WorkOrderRoutingService.Save(list);
		///	}
        ///	catch (Exception e)
        ///	{
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// ]]></code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Update)]


		TList<WorkOrderRouting> Save(TList<WorkOrderRouting> entityCollection);

		#endregion Save Collection

		#endregion Save

		#region Delete

		#region Delete Entity

		/// <summary>
		/// 	public virtualmethod that Deletes a WorkOrderRouting object into the datasource using a transaction.
		/// </summary>
		/// <param name="entity">WorkOrderRouting object to Delete.</param>
		/// <remarks>After Deleteing into the datasource, the WorkOrderRouting object will be updated
		/// to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns bool that the operation is successful.</returns>
		/// <example>
        /// The following code shows the usage of the Delete Method with an already open transaction.
        /// <code>
		///	WorkOrderRouting entity = WorkOrderRoutingService.GetByPrimaryKeyColumn(1234);
		/// entity.StringProperty = "foo";
		/// entity.IntProperty = 12;
		/// entity.ChildObjectSource.StringProperty = "bar";
		/// TransactionManager tm = null;
		/// try
        ///	{
		/// 	tm = ConnectionContext.CreateTransaction();
		///		//Delete Child entity, Then Parent Entity
		/// 	ChildObjectType.Delete(entity.ChildObjectSource);
		///		WorkOrderRouting.Delete(entity);
		///	}
        ///	catch (Exception e)
        ///	{
		///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Delete)]


		bool Delete(WorkOrderRouting entity);

		#endregion Delete Entity

		#region Delete Collection

		/// <summary>
		/// 	method that Deletes rows in <see cref="TList{WorkOrderRouting}" /> to the datasource.
		/// </summary>
		/// <param name="entityCollection"><c>WorkOrderRouting</c> objects in a <see cref="TList{WorkOrderRouting}" /> object to Delete.</param>
		/// <remarks>
		///		This function will only Delete entity objects marked as dirty
		///		and have an identity field equal to zero.
		///		Upon Deleteing the objects, each dirty object will have the public
		///		method <c>Object.AcceptChanges()</c> called to make it clean.
		/// 	After Deleteing into the datasource, the <c>WorkOrderRouting</c> objects will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		///</remarks>
		/// <returns>Returns the number of successful Delete.</returns>
		/// <example>
        /// The following code shows the usage of the Delete Method with a collection of WorkOrderRouting.
        /// <code><![CDATA[
		/// TList<WorkOrderRouting> list = new TList<WorkOrderRouting>();
		/// WorkOrderRouting entity = new WorkOrderRouting();
		/// entity.StringProperty = "foo";
		/// WorkOrderRouting entity2 = new WorkOrderRouting();
		/// entity.StringProperty = "bar";
		/// list.Add(entity);
		/// list.Add(entity2);
		///	WorkOrderRoutingService.Delete(list);
		///	}
        ///	catch (Exception e)
        ///	{
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// ]]></code>
        /// </example>
		[DataObjectMethod(DataObjectMethodType.Delete)]


		TList<WorkOrderRouting> Delete(TList<WorkOrderRouting> entityCollection);

		#endregion Delete Collection

		#endregion Delete

		#region   Delete

		/// <summary>
		/// Deletes a row from the DataSource.
		/// </summary>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>


		bool Delete(WorkOrderRoutingKey key);


		/// <summary>
		/// Deletes a row from the DataSource based on the PK'S System.Int32 _workOrderId, System.Int32 _productId, System.Int16 _operationSequence
		/// </summary>
		/// <param name="_workOrderId">WorkOrderRouting pk id.</param>
		/// <param name="_productId">WorkOrderRouting pk id.</param>
		/// <param name="_operationSequence">WorkOrderRouting pk id.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		[DataObjectMethod(DataObjectMethodType.Delete)]


		bool Delete(System.Int32 _workOrderId, System.Int32 _productId, System.Int16 _operationSequence);


		#endregion

		#region  GetBy m:m Aggregate Relationships

		#endregion	N2N Relationships

		#region Custom Methods

		#endregion Custom Methods

		#endregion Data Access Methods

	}//End Class
} // end namespace






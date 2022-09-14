﻿
/*
	File Generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file SqlTestTimestampProvider.cs instead.
*/

#region using directives

using System;
using System.Data;
using System.Data.Common;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using System.Collections;
using System.Collections.Specialized;

using System.Diagnostics;
using Nettiers.AdventureWorks.Entities;
using Nettiers.AdventureWorks.Data;
using Nettiers.AdventureWorks.Data.Bases;

#endregion

namespace Nettiers.AdventureWorks.Data.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="TestTimestamp"/> entity.
	///</summary>
	public abstract partial class SqlTestTimestampProviderBase : TestTimestampProviderBase
	{
		#region Declarations

		string _connectionString;
	    bool _useStoredProcedure;
	    string _providerInvariantName;

		#endregion "Declarations"

		#region Constructors

		/// <summary>
		/// Creates a new <see cref="SqlTestTimestampProviderBase"/> instance.
		/// </summary>
		public SqlTestTimestampProviderBase()
		{
		}

	/// <summary>
	/// Creates a new <see cref="SqlTestTimestampProviderBase"/> instance.
	/// Uses connection string to connect to datasource.
	/// </summary>
	/// <param name="connectionString">The connection string to the database.</param>
	/// <param name="useStoredProcedure">A boolean value that indicates if we should use stored procedures or embedded queries.</param>
	/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
	public SqlTestTimestampProviderBase(string connectionString, bool useStoredProcedure, string providerInvariantName)
	{
		this._connectionString = connectionString;
		this._useStoredProcedure = useStoredProcedure;
		this._providerInvariantName = providerInvariantName;
	}

	#endregion "Constructors"

		#region Public properties
	/// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string ConnectionString
	{
		get {return this._connectionString;}
		set {this._connectionString = value;}
	}

	/// <summary>
    /// Gets or sets a value indicating whether to use stored procedures.
    /// </summary>
    /// <value><c>true</c> if we choose to use use stored procedures; otherwise, <c>false</c>.</value>
	public bool UseStoredProcedure
	{
		get {return this._useStoredProcedure;}
		set {this._useStoredProcedure = value;}
	}

	/// <summary>
    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
    /// </summary>
    /// <value>The name of the provider invariant.</value>
    public string ProviderInvariantName
    {
        get { return this._providerInvariantName; }
        set { this._providerInvariantName = value; }
    }
	#endregion

		#region Get Many To Many Relationship Functions
		#endregion

		#region Delete Functions
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_testTimestampId">. Primary Key.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_version">The timestamp field used for concurrency check.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        /// <exception cref="DBConcurrencyException">The record has been modified by an other user. Please reload the instance before deleting.</exception>
		public override bool Delete(TransactionManager transactionManager, System.Int32 _testTimestampId, byte[] _version)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Delete", _useStoredProcedure);
			database.AddInParameter(commandWrapper, "@TestTimestampId", DbType.Int32, _testTimestampId);
			database.AddInParameter(commandWrapper, "@Version", DbType.Binary, _version);

			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

			int results = 0;

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}

			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
			{
				string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(TestTimestamp)
					,_testTimestampId);
				EntityManager.StopTracking(entityKey);
			}

			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

			if (results == 0)
			{
				throw new DBConcurrencyException ("The record has been modified by an other user. Please reload the instance before deleting.");
			}
			commandWrapper = null;

			return Convert.ToBoolean(results);
		}//end Delete
		#endregion

		#region Find Functions

		#region Parsed Find Methods
		/// <summary>
		/// 	Returns rows meeting the whereClause condition from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks>Operators must be capitalized (OR, AND).</remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.TestTimestamp objects.</returns>
		public override TList<TestTimestamp> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
		{
			count = -1;
			if (whereClause.IndexOf(";") > -1)
				return new TList<TestTimestamp>();

			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Find", _useStoredProcedure);

		bool searchUsingOR = false;
		if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
			searchUsingOR = true;

		database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);

		database.AddInParameter(commandWrapper, "@TestTimestampId", DbType.Int32, DBNull.Value);
		database.AddInParameter(commandWrapper, "@DumbField", DbType.Boolean, DBNull.Value);
		database.AddInParameter(commandWrapper, "@Version", DbType.Binary, DBNull.Value);

			// replace all instances of 'AND' and 'OR' because we already set searchUsingOR
			whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|") ;
			string[] clauses = whereClause.ToLower().Split('|');

			// Here's what's going on below: Find a field, then to get the value we
			// drop the field name from the front, trim spaces, drop the '=' sign,
			// trim more spaces, and drop any outer single quotes.
			// Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"

			char[] equalSign = {'='};
			char[] singleQuote = {'\''};
	   		foreach (string clause in clauses)
			{
				if (clause.Trim().StartsWith("testtimestampid ") || clause.Trim().StartsWith("testtimestampid="))
				{
					database.SetParameterValue(commandWrapper, "@TestTimestampId",
						clause.Trim().Remove(0,15).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("dumbfield ") || clause.Trim().StartsWith("dumbfield="))
				{
					database.SetParameterValue(commandWrapper, "@DumbField",
						clause.Trim().Remove(0,9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}
				if (clause.Trim().StartsWith("version ") || clause.Trim().StartsWith("version="))
				{
					database.SetParameterValue(commandWrapper, "@Version",
						clause.Trim().Remove(0,7).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
					continue;
				}

				throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
			}

			IDataReader reader = null;
			//Create Collection
			TList<TestTimestamp> rows = new TList<TestTimestamp>();


			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				Fill(reader, rows, start, pageLength);

				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
			}
			finally
			{
				if (reader != null)
					reader.Close();

				commandWrapper = null;
			}
			return rows;
		}

		#endregion Parsed Find Methods

		#region Parameterized Find Methods

		/// <summary>
		/// 	Returns rows from the DataSource that meet the parameter conditions.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="parameters">A collection of <see cref="SqlFilterParameter"/> objects.</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.TestTimestamp objects.</returns>
		public override TList<TestTimestamp> Find(TransactionManager transactionManager, IFilterParameterCollection parameters, string orderBy, int start, int pageLength, out int count)
		{
			SqlFilterParameterCollection filter = null;

			if (parameters == null)
				filter = new SqlFilterParameterCollection();
			else
				filter = parameters.GetParameters();

			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Find_Dynamic", typeof(TestTimestampColumn), filter, orderBy, start, pageLength);

			SqlFilterParameter param;

			for ( int i = 0; i < filter.Count; i++ )
			{
				param = filter[i];
				database.AddInParameter(commandWrapper, param.Name, param.DbType, param.GetValue());
			}

			TList<TestTimestamp> rows = new TList<TestTimestamp>();
			IDataReader reader = null;

			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

				if ( transactionManager != null )
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;

				if ( reader.NextResult() )
				{
					if ( reader.Read() )
					{
						count = reader.GetInt32(0);
					}
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
			}
			finally
			{
				if ( reader != null )
					reader.Close();

				commandWrapper = null;
			}

			return rows;
		}

		#endregion Parameterized Find Methods

		#endregion Find Functions

		#region GetAll Methods

		/// <summary>
		/// 	Gets All rows from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out. The number of rows that match this query.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.TestTimestamp objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override TList<TestTimestamp> GetAll(TransactionManager transactionManager, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Get_List", _useStoredProcedure);

			IDataReader reader = null;

			//Create Collection
			TList<TestTimestamp> rows = new TList<TestTimestamp>();

			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAll", rows));

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				Fill(reader, rows, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
			}
			finally
			{
				if (reader != null)
					reader.Close();

				commandWrapper = null;
			}
			return rows;
		}//end getall

		#endregion

		#region GetPaged Methods

		/// <summary>
		/// Gets a page of rows from the DataSource.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">Number of rows in the DataSource.</param>
		/// <param name="whereClause">Specifies the condition for the rows returned by a query (Name='John Doe', Name='John Doe' AND Id='1', Name='John Doe' OR Id='1').</param>
		/// <param name="orderBy">Specifies the sort criteria for the rows in the DataSource (Name ASC; BirthDay DESC, Name ASC);</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of Nettiers.AdventureWorks.Entities.TestTimestamp objects.</returns>
		public override TList<TestTimestamp> GetPaged(TransactionManager transactionManager, string whereClause, string orderBy, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_GetPaged", _useStoredProcedure);


            if (commandWrapper.CommandType == CommandType.Text
                && commandWrapper.CommandText != null)
            {
                commandWrapper.CommandText = commandWrapper.CommandText.Replace(SqlUtil.PAGE_INDEX, string.Concat(SqlUtil.PAGE_INDEX, Guid.NewGuid().ToString("N").Substring(0, 8)));
            }

			database.AddInParameter(commandWrapper, "@WhereClause", DbType.String, whereClause);
			database.AddInParameter(commandWrapper, "@OrderBy", DbType.String, orderBy);
			database.AddInParameter(commandWrapper, "@PageIndex", DbType.Int32, start);
			database.AddInParameter(commandWrapper, "@PageSize", DbType.Int32, pageLength);

			IDataReader reader = null;
			//Create Collection
			TList<TestTimestamp> rows = new TList<TestTimestamp>();

			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetPaged", rows));

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				Fill(reader, rows, 0, int.MaxValue);
				count = rows.Count;

				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetPaged", rows));

			}
			catch(Exception)
			{
				throw;
			}
			finally
			{
				if (reader != null)
					reader.Close();

				commandWrapper = null;
			}

			return rows;
		}

		#endregion

		#region Get By Foreign Key Functions
	#endregion

		#region Get By Index Functions

		#region GetByTestTimestampId

		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TestTimestamp index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_testTimestampId"></param>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query.</param>
		/// <returns>Returns an instance of the <see cref="Nettiers.AdventureWorks.Entities.TestTimestamp"/> class.</returns>
		/// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override Nettiers.AdventureWorks.Entities.TestTimestamp GetByTestTimestampId(TransactionManager transactionManager, System.Int32 _testTimestampId, int start, int pageLength, out int count)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_GetByTestTimestampId", _useStoredProcedure);

				database.AddInParameter(commandWrapper, "@TestTimestampId", DbType.Int32, _testTimestampId);

			IDataReader reader = null;
			TList<TestTimestamp> tmp = new TList<TestTimestamp>();
			try
			{
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByTestTimestampId", tmp));

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				//Create collection and fill
				Fill(reader, tmp, start, pageLength);
				count = -1;
				if(reader.NextResult())
				{
					if(reader.Read())
					{
						count = reader.GetInt32(0);
					}
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetByTestTimestampId", tmp));
			}
			finally
			{
				if (reader != null)
					reader.Close();

				commandWrapper = null;
			}

			if (tmp.Count == 1)
			{
				return tmp[0];
			}
			else if (tmp.Count == 0)
			{
				return null;
			}
			else
			{
				throw new DataException("Cannot find the unique instance of the class.");
			}

			//return rows;
		}

		#endregion

	#endregion Get By Index Functions

		#region Insert Methods
		/// <summary>
		/// Lets you efficiently bulk insert many entities to the database.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entities">The entities.</param>
		/// <remarks>
		///		After inserting into the datasource, the Nettiers.AdventureWorks.Entities.TestTimestamp object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		public override void BulkInsert(TransactionManager transactionManager, TList<Nettiers.AdventureWorks.Entities.TestTimestamp> entities)
		{
			//System.Data.SqlClient.SqlBulkCopy bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);

			System.Data.SqlClient.SqlBulkCopy bulkCopy = null;

			if (transactionManager != null && transactionManager.IsOpen)
			{
				System.Data.SqlClient.SqlConnection cnx = transactionManager.TransactionObject.Connection as System.Data.SqlClient.SqlConnection;
				System.Data.SqlClient.SqlTransaction transaction = transactionManager.TransactionObject as System.Data.SqlClient.SqlTransaction;
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(cnx, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints, transaction); //, null);
			}
			else
			{
				bulkCopy = new System.Data.SqlClient.SqlBulkCopy(this._connectionString, System.Data.SqlClient.SqlBulkCopyOptions.CheckConstraints); //, null);
			}

			bulkCopy.BulkCopyTimeout = 360;
			bulkCopy.DestinationTableName = "TestTimestamp";

			DataTable dataTable = new DataTable();
			DataColumn col0 = dataTable.Columns.Add("TestTimestampId", typeof(System.Int32));
			col0.AllowDBNull = false;
			DataColumn col1 = dataTable.Columns.Add("DumbField", typeof(System.Boolean));
			col1.AllowDBNull = true;
			DataColumn col2 = dataTable.Columns.Add("Version", typeof(System.Byte[]));
			col2.AllowDBNull = false;

			bulkCopy.ColumnMappings.Add("TestTimestampId", "TestTimestampId");
			bulkCopy.ColumnMappings.Add("DumbField", "DumbField");
			bulkCopy.ColumnMappings.Add("Version", "Version");

			foreach(Nettiers.AdventureWorks.Entities.TestTimestamp entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;

				DataRow row = dataTable.NewRow();

					row["TestTimestampId"] = entity.TestTimestampId;


					row["DumbField"] = entity.DumbField.HasValue ? (object) entity.DumbField  : System.DBNull.Value;


					row["Version"] = entity.Version;


				dataTable.Rows.Add(row);
			}

			// send the data to the server
			bulkCopy.WriteToServer(dataTable);

			// update back the state
			foreach(Nettiers.AdventureWorks.Entities.TestTimestamp entity in entities)
			{
				if (entity.EntityState != EntityState.Added)
					continue;

				entity.AcceptChanges();
			}
		}

		/// <summary>
		/// 	Inserts a Nettiers.AdventureWorks.Entities.TestTimestamp object into the datasource using a transaction.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.TestTimestamp object to insert.</param>
		/// <remarks>
		///		After inserting into the datasource, the Nettiers.AdventureWorks.Entities.TestTimestamp object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
		public override bool Insert(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.TestTimestamp entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Insert", _useStoredProcedure);

			database.AddOutParameter(commandWrapper, "@TestTimestampId", DbType.Int32, 4);
			database.AddInParameter(commandWrapper, "@DumbField", DbType.Boolean, (entity.DumbField.HasValue ? (object) entity.DumbField  : System.DBNull.Value));
			database.AddOutParameter(commandWrapper, "@Version", DbType.Binary, 8);

			int results = 0;

			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}

			object _testTimestampId = database.GetParameterValue(commandWrapper, "@TestTimestampId");
			entity.TestTimestampId = (System.Int32)_testTimestampId;
			object _version = database.GetParameterValue(commandWrapper, "@Version");
			entity.Version = (System.Byte[])_version;


			entity.AcceptChanges();

			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

			return Convert.ToBoolean(results);
		}
		#endregion

		#region Update Methods

		/// <summary>
		/// 	Update an existing row in the datasource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">Nettiers.AdventureWorks.Entities.TestTimestamp object to update.</param>
		/// <remarks>
		///		After updating the datasource, the Nettiers.AdventureWorks.Entities.TestTimestamp object will be updated
		/// 	to refelect any changes made by the datasource. (ie: identity or computed columns)
		/// </remarks>
		/// <returns>Returns true if operation is successful.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        /// <exception cref="DBConcurrencyException">The record has been modified by an other user. Please reload the instance before updating.</exception>
		public override bool Update(TransactionManager transactionManager, Nettiers.AdventureWorks.Entities.TestTimestamp entity)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test.usp_adwTiers_TestTimestamp_Update", _useStoredProcedure);

			database.AddInParameter(commandWrapper, "@TestTimestampId", DbType.Int32, entity.TestTimestampId );
			database.AddInParameter(commandWrapper, "@DumbField", DbType.Boolean, (entity.DumbField.HasValue ? (object) entity.DumbField : System.DBNull.Value) );
			database.AddInParameter(commandWrapper, "@Version", DbType.Binary, entity.Version );
			database.AddOutParameter(commandWrapper, "@ReturnedVersion", DbType.Binary, 8);

			int results = 0;

			//Provider Data Requesting Command Event
			OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}

			//Stop Tracking Now that it has been updated and persisted.
			if (DataRepository.Provider.EnableEntityTracking)
				EntityManager.StopTracking(entity.EntityTrackingKey);

			if (results == 0)
			{
				throw new DBConcurrencyException("Concurrency exception");
			}
			entity.Version = (System.Byte[])database.GetParameterValue(commandWrapper, "@ReturnedVersion");

			entity.AcceptChanges();

			//Provider Data Requested Command Event
			OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

			return Convert.ToBoolean(results);
		}

		#endregion

		#region Custom Methods


		#region _TestTimestamp_GetAllTimestamp

		/// <summary>
		///	This method wraps the '_TestTimestamp_GetAllTimestamp' stored procedure.
		/// </summary>
		/// <param name="start">Row number at which to start reading.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object.</param>
		/// <remark>This method is generated from a stored procedure.</remark>
		/// <returns>A <see cref="TList&lt;TestTimestamp&gt;"/> instance.</returns>
		public override TList<TestTimestamp> GetAllTimestamp(TransactionManager transactionManager, int start, int pageLength )
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Test._TestTimestamp_GetAllTimestamp", true);



			IDataReader reader = null;

			//Create Collection
				TList<TestTimestamp> rows = new TList<TestTimestamp>();
				//Provider Data Requesting Command Event
				OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllTimestamp", rows));

				if (transactionManager != null)
				{
					reader = Utility.ExecuteReader(transactionManager, commandWrapper);
				}
				else
				{
					reader = Utility.ExecuteReader(database, commandWrapper);
				}

				try
				{
					Fill(reader, rows, start, pageLength);
				}
				finally
				{
					if (reader != null)
						reader.Close();
				}

				//Provider Data Requested Command Event
				OnDataRequested(new CommandEventArgs(commandWrapper, "GetAllTimestamp", rows));


				return rows;
		}
		#endregion
		#endregion
	}//end class
} // end namespace

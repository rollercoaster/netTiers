﻿/*
	File generated by NetTiers templates [https://github.com/netTiers/netTiers]
	Important: Do not modify this file. Edit the file VJobCandidateEducation.cs instead.
*/
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml.Serialization;
#endregion

namespace Nettiers.AdventureWorks.Entities
{
	///<summary>
	/// Displays the content from each education related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.
	///</summary>
	[Serializable]
	[CLSCompliant(true)]
	[ToolboxItem("VJobCandidateEducationBase")]
	public abstract partial class VJobCandidateEducationBase : System.IComparable, System.ICloneable, INotifyPropertyChanged
	{

		#region Variable Declarations

		/// <summary>
		/// JobCandidateID :
		/// </summary>
		private System.Int32		  _jobCandidateId = (int)0;

		/// <summary>
		/// Edu.Level :
		/// </summary>
		private System.String		  _safeNameEduLevel = null;

		/// <summary>
		/// Edu.StartDate :
		/// </summary>
		private System.DateTime?		  _safeNameEduStartDate = null;

		/// <summary>
		/// Edu.EndDate :
		/// </summary>
		private System.DateTime?		  _safeNameEduEndDate = null;

		/// <summary>
		/// Edu.Degree :
		/// </summary>
		private System.String		  _safeNameEduDegree = null;

		/// <summary>
		/// Edu.Major :
		/// </summary>
		private System.String		  _safeNameEduMajor = null;

		/// <summary>
		/// Edu.Minor :
		/// </summary>
		private System.String		  _safeNameEduMinor = null;

		/// <summary>
		/// Edu.GPA :
		/// </summary>
		private System.String		  _safeNameEduGpa = null;

		/// <summary>
		/// Edu.GPAScale :
		/// </summary>
		private System.String		  _safeNameEduGpaScale = null;

		/// <summary>
		/// Edu.School :
		/// </summary>
		private System.String		  _safeNameEduSchool = null;

		/// <summary>
		/// Edu.Loc.CountryRegion :
		/// </summary>
		private System.String		  _safeNameEduLocCountryRegion = null;

		/// <summary>
		/// Edu.Loc.State :
		/// </summary>
		private System.String		  _safeNameEduLocState = null;

		/// <summary>
		/// Edu.Loc.City :
		/// </summary>
		private System.String		  _safeNameEduLocCity = null;

		/// <summary>
		/// Object that contains data to associate with this object
		/// </summary>
		private object _tag;

		/// <summary>
		/// Suppresses Entity Events from Firing,
		/// useful when loading the entities from the database.
		/// </summary>
	    [NonSerialized]
		private bool suppressEntityEvents = false;

		#endregion Variable Declarations

		#region Constructors
		///<summary>
		/// Creates a new <see cref="VJobCandidateEducationBase"/> instance.
		///</summary>
		public VJobCandidateEducationBase()
		{
		}

		///<summary>
		/// Creates a new <see cref="VJobCandidateEducationBase"/> instance.
		///</summary>
		///<param name="_jobCandidateId"></param>
		///<param name="_safeNameEduLevel"></param>
		///<param name="_safeNameEduStartDate"></param>
		///<param name="_safeNameEduEndDate"></param>
		///<param name="_safeNameEduDegree"></param>
		///<param name="_safeNameEduMajor"></param>
		///<param name="_safeNameEduMinor"></param>
		///<param name="_safeNameEduGpa"></param>
		///<param name="_safeNameEduGpaScale"></param>
		///<param name="_safeNameEduSchool"></param>
		///<param name="_safeNameEduLocCountryRegion"></param>
		///<param name="_safeNameEduLocState"></param>
		///<param name="_safeNameEduLocCity"></param>
		public VJobCandidateEducationBase(System.Int32 _jobCandidateId, System.String _safeNameEduLevel, System.DateTime? _safeNameEduStartDate, System.DateTime? _safeNameEduEndDate, System.String _safeNameEduDegree, System.String _safeNameEduMajor, System.String _safeNameEduMinor, System.String _safeNameEduGpa, System.String _safeNameEduGpaScale, System.String _safeNameEduSchool, System.String _safeNameEduLocCountryRegion, System.String _safeNameEduLocState, System.String _safeNameEduLocCity)
		{
			this._jobCandidateId = _jobCandidateId;
			this._safeNameEduLevel = _safeNameEduLevel;
			this._safeNameEduStartDate = _safeNameEduStartDate;
			this._safeNameEduEndDate = _safeNameEduEndDate;
			this._safeNameEduDegree = _safeNameEduDegree;
			this._safeNameEduMajor = _safeNameEduMajor;
			this._safeNameEduMinor = _safeNameEduMinor;
			this._safeNameEduGpa = _safeNameEduGpa;
			this._safeNameEduGpaScale = _safeNameEduGpaScale;
			this._safeNameEduSchool = _safeNameEduSchool;
			this._safeNameEduLocCountryRegion = _safeNameEduLocCountryRegion;
			this._safeNameEduLocState = _safeNameEduLocState;
			this._safeNameEduLocCity = _safeNameEduLocCity;
		}

		///<summary>
		/// A simple factory method to create a new <see cref="VJobCandidateEducation"/> instance.
		///</summary>
		///<param name="_jobCandidateId"></param>
		///<param name="_safeNameEduLevel"></param>
		///<param name="_safeNameEduStartDate"></param>
		///<param name="_safeNameEduEndDate"></param>
		///<param name="_safeNameEduDegree"></param>
		///<param name="_safeNameEduMajor"></param>
		///<param name="_safeNameEduMinor"></param>
		///<param name="_safeNameEduGpa"></param>
		///<param name="_safeNameEduGpaScale"></param>
		///<param name="_safeNameEduSchool"></param>
		///<param name="_safeNameEduLocCountryRegion"></param>
		///<param name="_safeNameEduLocState"></param>
		///<param name="_safeNameEduLocCity"></param>
		public static VJobCandidateEducation CreateVJobCandidateEducation(System.Int32 _jobCandidateId, System.String _safeNameEduLevel, System.DateTime? _safeNameEduStartDate, System.DateTime? _safeNameEduEndDate, System.String _safeNameEduDegree, System.String _safeNameEduMajor, System.String _safeNameEduMinor, System.String _safeNameEduGpa, System.String _safeNameEduGpaScale, System.String _safeNameEduSchool, System.String _safeNameEduLocCountryRegion, System.String _safeNameEduLocState, System.String _safeNameEduLocCity)
		{
			VJobCandidateEducation newVJobCandidateEducation = new VJobCandidateEducation();
			newVJobCandidateEducation.JobCandidateId = _jobCandidateId;
			newVJobCandidateEducation.SafeNameEduLevel = _safeNameEduLevel;
			newVJobCandidateEducation.SafeNameEduStartDate = _safeNameEduStartDate;
			newVJobCandidateEducation.SafeNameEduEndDate = _safeNameEduEndDate;
			newVJobCandidateEducation.SafeNameEduDegree = _safeNameEduDegree;
			newVJobCandidateEducation.SafeNameEduMajor = _safeNameEduMajor;
			newVJobCandidateEducation.SafeNameEduMinor = _safeNameEduMinor;
			newVJobCandidateEducation.SafeNameEduGpa = _safeNameEduGpa;
			newVJobCandidateEducation.SafeNameEduGpaScale = _safeNameEduGpaScale;
			newVJobCandidateEducation.SafeNameEduSchool = _safeNameEduSchool;
			newVJobCandidateEducation.SafeNameEduLocCountryRegion = _safeNameEduLocCountryRegion;
			newVJobCandidateEducation.SafeNameEduLocState = _safeNameEduLocState;
			newVJobCandidateEducation.SafeNameEduLocCity = _safeNameEduLocCity;
			return newVJobCandidateEducation;
		}

		#endregion Constructors

		#region Properties
		/// <summary>
		/// 	Gets or Sets the JobCandidateID property.
		///
		/// </summary>
		/// <value>This type is int</value>
		/// <remarks>
		/// This property can not be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.Int32 JobCandidateId
		{
			get
			{
				return this._jobCandidateId;
			}
			set
			{
				if (_jobCandidateId == value)
					return;

				this._jobCandidateId = value;
				this._isDirty = true;

				OnPropertyChanged("JobCandidateId");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Level property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduLevel
		{
			get
			{
				return this._safeNameEduLevel;
			}
			set
			{
				if (_safeNameEduLevel == value)
					return;

				this._safeNameEduLevel = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduLevel");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.StartDate property.
		///
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null.
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsSafeNameEduStartDateNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? SafeNameEduStartDate
		{
			get
			{
				return this._safeNameEduStartDate;
			}
			set
			{
				if (_safeNameEduStartDate == value && SafeNameEduStartDate != null )
					return;

				this._safeNameEduStartDate = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduStartDate");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.EndDate property.
		///
		/// </summary>
		/// <value>This type is datetime</value>
		/// <remarks>
		/// This property can be set to null.
		/// If this column is null, this property will return DateTime.MinValue. It is up to the developer
		/// to check the value of IsSafeNameEduEndDateNull() and perform business logic appropriately.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.DateTime? SafeNameEduEndDate
		{
			get
			{
				return this._safeNameEduEndDate;
			}
			set
			{
				if (_safeNameEduEndDate == value && SafeNameEduEndDate != null )
					return;

				this._safeNameEduEndDate = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduEndDate");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Degree property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduDegree
		{
			get
			{
				return this._safeNameEduDegree;
			}
			set
			{
				if (_safeNameEduDegree == value)
					return;

				this._safeNameEduDegree = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduDegree");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Major property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduMajor
		{
			get
			{
				return this._safeNameEduMajor;
			}
			set
			{
				if (_safeNameEduMajor == value)
					return;

				this._safeNameEduMajor = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduMajor");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Minor property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduMinor
		{
			get
			{
				return this._safeNameEduMinor;
			}
			set
			{
				if (_safeNameEduMinor == value)
					return;

				this._safeNameEduMinor = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduMinor");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.GPA property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduGpa
		{
			get
			{
				return this._safeNameEduGpa;
			}
			set
			{
				if (_safeNameEduGpa == value)
					return;

				this._safeNameEduGpa = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduGpa");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.GPAScale property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduGpaScale
		{
			get
			{
				return this._safeNameEduGpaScale;
			}
			set
			{
				if (_safeNameEduGpaScale == value)
					return;

				this._safeNameEduGpaScale = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduGpaScale");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.School property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduSchool
		{
			get
			{
				return this._safeNameEduSchool;
			}
			set
			{
				if (_safeNameEduSchool == value)
					return;

				this._safeNameEduSchool = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduSchool");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Loc.CountryRegion property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduLocCountryRegion
		{
			get
			{
				return this._safeNameEduLocCountryRegion;
			}
			set
			{
				if (_safeNameEduLocCountryRegion == value)
					return;

				this._safeNameEduLocCountryRegion = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduLocCountryRegion");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Loc.State property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduLocState
		{
			get
			{
				return this._safeNameEduLocState;
			}
			set
			{
				if (_safeNameEduLocState == value)
					return;

				this._safeNameEduLocState = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduLocState");
			}
		}

		/// <summary>
		/// 	Gets or Sets the Edu.Loc.City property.
		///
		/// </summary>
		/// <value>This type is nvarchar</value>
		/// <remarks>
		/// This property can be set to null.
		/// </remarks>
		[DescriptionAttribute(""), System.ComponentModel.Bindable( System.ComponentModel.BindableSupport.Yes)]
		public virtual System.String SafeNameEduLocCity
		{
			get
			{
				return this._safeNameEduLocCity;
			}
			set
			{
				if (_safeNameEduLocCity == value)
					return;

				this._safeNameEduLocCity = value;
				this._isDirty = true;

				OnPropertyChanged("SafeNameEduLocCity");
			}
		}


		/// <summary>
		///     Gets or sets the object that contains supplemental data about this object.
		/// </summary>
		/// <value>Object</value>
		[System.ComponentModel.Bindable(false)]
		[LocalizableAttribute(false)]
		[DescriptionAttribute("Object containing data to be associated with this object")]
		public virtual object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag == value)
					return;

				this._tag = value;
			}
		}

		/// <summary>
		/// Determines whether this entity is to suppress events while set to true.
		/// </summary>
		[System.ComponentModel.Bindable(false)]
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public bool SuppressEntityEvents
		{
			get
			{
				return suppressEntityEvents;
			}
			set
			{
				suppressEntityEvents = value;
			}
		}

		private bool _isDeleted = false;
		/// <summary>
		/// Gets a value indicating if object has been <see cref="MarkToDelete"/>. ReadOnly.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDeleted
		{
			get { return this._isDeleted; }
		}


		private bool _isDirty = false;
		/// <summary>
		///	Gets a value indicating  if the object has been modified from its original state.
		/// </summary>
		///<value>True if object has been modified from its original state; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsDirty
		{
			get { return this._isDirty; }
		}


		private bool _isNew = true;
		/// <summary>
		///	Gets a value indicating if the object is new.
		/// </summary>
		///<value>True if objectis new; otherwise False;</value>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public virtual bool IsNew
		{
			get { return this._isNew; }
			set { this._isNew = value; }
		}

		/// <summary>
		///		The name of the underlying database table.
		/// </summary>
		[BrowsableAttribute(false), XmlIgnoreAttribute()]
		public string ViewName
		{
			get { return "vJobCandidateEducation"; }
		}


		#endregion

		#region Methods

		/// <summary>
		/// Accepts the changes made to this object by setting each flags to false.
		/// </summary>
		public virtual void AcceptChanges()
		{
			this._isDeleted = false;
			this._isDirty = false;
			this._isNew = false;
			OnPropertyChanged(string.Empty);
		}


		///<summary>
		///  Revert all changes and restore original values.
		///  Currently not supported.
		///</summary>
		/// <exception cref="NotSupportedException">This method is not currently supported and always throws this exception.</exception>
		public virtual void CancelChanges()
		{
			throw new NotSupportedException("Method currently not Supported.");
		}

		///<summary>
		///   Marks entity to be deleted.
		///</summary>
		public virtual void MarkToDelete()
		{
			this._isDeleted = true;
		}

		#region ICloneable Members
		///<summary>
		///  Returns a Typed VJobCandidateEducationBase Entity
		///</summary>
		public virtual VJobCandidateEducationBase Copy()
		{
			//shallow copy entity
			VJobCandidateEducation copy = new VJobCandidateEducation();
				copy.JobCandidateId = this.JobCandidateId;
				copy.SafeNameEduLevel = this.SafeNameEduLevel;
				copy.SafeNameEduStartDate = this.SafeNameEduStartDate;
				copy.SafeNameEduEndDate = this.SafeNameEduEndDate;
				copy.SafeNameEduDegree = this.SafeNameEduDegree;
				copy.SafeNameEduMajor = this.SafeNameEduMajor;
				copy.SafeNameEduMinor = this.SafeNameEduMinor;
				copy.SafeNameEduGpa = this.SafeNameEduGpa;
				copy.SafeNameEduGpaScale = this.SafeNameEduGpaScale;
				copy.SafeNameEduSchool = this.SafeNameEduSchool;
				copy.SafeNameEduLocCountryRegion = this.SafeNameEduLocCountryRegion;
				copy.SafeNameEduLocState = this.SafeNameEduLocState;
				copy.SafeNameEduLocCity = this.SafeNameEduLocCity;
			copy.AcceptChanges();
			return (VJobCandidateEducation)copy;
		}

		///<summary>
		/// ICloneable.Clone() Member, returns the Deep Copy of this entity.
		///</summary>
		public object Clone(){
			return this.Copy();
		}

		///<summary>
		/// Returns a deep copy of the child collection object passed in.
		///</summary>
		public static object MakeCopyOf(object x)
		{
			if (x is ICloneable)
			{
				// Return a deep copy of the object
				return ((ICloneable)x).Clone();
			}
			else
				throw new System.NotSupportedException("Object Does Not Implement the ICloneable Interface.");
		}
		#endregion


		///<summary>
		/// Returns a value indicating whether this instance is equal to a specified object.
		///</summary>
		///<param name="toObject">An object to compare to this instance.</param>
		///<returns>true if toObject is a <see cref="VJobCandidateEducationBase"/> and has the same value as this instance; otherwise, false.</returns>
		public virtual bool Equals(VJobCandidateEducationBase toObject)
		{
			if (toObject == null)
				return false;
			return Equals(this, toObject);
		}


		///<summary>
		/// Determines whether the specified <see cref="VJobCandidateEducationBase"/> instances are considered equal.
		///</summary>
		///<param name="Object1">The first <see cref="VJobCandidateEducationBase"/> to compare.</param>
		///<param name="Object2">The second <see cref="VJobCandidateEducationBase"/> to compare. </param>
		///<returns>true if Object1 is the same instance as Object2 or if both are null references or if objA.Equals(objB) returns true; otherwise, false.</returns>
		public static bool Equals(VJobCandidateEducationBase Object1, VJobCandidateEducationBase Object2)
		{
			// both are null
			if (Object1 == null && Object2 == null)
				return true;

			// one or the other is null, but not both
			if (Object1 == null ^ Object2 == null)
				return false;

			bool equal = true;
			if (Object1.JobCandidateId != Object2.JobCandidateId)
				equal = false;
			if (Object1.SafeNameEduLevel != null && Object2.SafeNameEduLevel != null )
			{
				if (Object1.SafeNameEduLevel != Object2.SafeNameEduLevel)
					equal = false;
			}
			else if (Object1.SafeNameEduLevel == null ^ Object1.SafeNameEduLevel == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduStartDate != null && Object2.SafeNameEduStartDate != null )
			{
				if (Object1.SafeNameEduStartDate != Object2.SafeNameEduStartDate)
					equal = false;
			}
			else if (Object1.SafeNameEduStartDate == null ^ Object1.SafeNameEduStartDate == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduEndDate != null && Object2.SafeNameEduEndDate != null )
			{
				if (Object1.SafeNameEduEndDate != Object2.SafeNameEduEndDate)
					equal = false;
			}
			else if (Object1.SafeNameEduEndDate == null ^ Object1.SafeNameEduEndDate == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduDegree != null && Object2.SafeNameEduDegree != null )
			{
				if (Object1.SafeNameEduDegree != Object2.SafeNameEduDegree)
					equal = false;
			}
			else if (Object1.SafeNameEduDegree == null ^ Object1.SafeNameEduDegree == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduMajor != null && Object2.SafeNameEduMajor != null )
			{
				if (Object1.SafeNameEduMajor != Object2.SafeNameEduMajor)
					equal = false;
			}
			else if (Object1.SafeNameEduMajor == null ^ Object1.SafeNameEduMajor == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduMinor != null && Object2.SafeNameEduMinor != null )
			{
				if (Object1.SafeNameEduMinor != Object2.SafeNameEduMinor)
					equal = false;
			}
			else if (Object1.SafeNameEduMinor == null ^ Object1.SafeNameEduMinor == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduGpa != null && Object2.SafeNameEduGpa != null )
			{
				if (Object1.SafeNameEduGpa != Object2.SafeNameEduGpa)
					equal = false;
			}
			else if (Object1.SafeNameEduGpa == null ^ Object1.SafeNameEduGpa == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduGpaScale != null && Object2.SafeNameEduGpaScale != null )
			{
				if (Object1.SafeNameEduGpaScale != Object2.SafeNameEduGpaScale)
					equal = false;
			}
			else if (Object1.SafeNameEduGpaScale == null ^ Object1.SafeNameEduGpaScale == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduSchool != null && Object2.SafeNameEduSchool != null )
			{
				if (Object1.SafeNameEduSchool != Object2.SafeNameEduSchool)
					equal = false;
			}
			else if (Object1.SafeNameEduSchool == null ^ Object1.SafeNameEduSchool == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduLocCountryRegion != null && Object2.SafeNameEduLocCountryRegion != null )
			{
				if (Object1.SafeNameEduLocCountryRegion != Object2.SafeNameEduLocCountryRegion)
					equal = false;
			}
			else if (Object1.SafeNameEduLocCountryRegion == null ^ Object1.SafeNameEduLocCountryRegion == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduLocState != null && Object2.SafeNameEduLocState != null )
			{
				if (Object1.SafeNameEduLocState != Object2.SafeNameEduLocState)
					equal = false;
			}
			else if (Object1.SafeNameEduLocState == null ^ Object1.SafeNameEduLocState == null )
			{
				equal = false;
			}
			if (Object1.SafeNameEduLocCity != null && Object2.SafeNameEduLocCity != null )
			{
				if (Object1.SafeNameEduLocCity != Object2.SafeNameEduLocCity)
					equal = false;
			}
			else if (Object1.SafeNameEduLocCity == null ^ Object1.SafeNameEduLocCity == null )
			{
				equal = false;
			}
			return equal;
		}

		#endregion

		#region IComparable Members
		///<summary>
		/// Compares this instance to a specified object and returns an indication of their relative values.
		///<param name="obj">An object to compare to this instance, or a null reference (Nothing in Visual Basic).</param>
		///</summary>
		///<returns>A signed integer that indicates the relative order of this instance and obj.</returns>
		public virtual int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region INotifyPropertyChanged Members

		/// <summary>
      /// Event to indicate that a property has changed.
      /// </summary>
		[field:NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="propertyName">The name of the property that has changed.</param>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
      /// Called when a property is changed
      /// </summary>
      /// <param name="e">PropertyChangedEventArgs</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
		{
			if (!SuppressEntityEvents)
			{
				if (null != PropertyChanged)
				{
					PropertyChanged(this, e);
				}
			}
		}

		#endregion

		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public static object GetPropertyValueByName(VJobCandidateEducation entity, string propertyName)
		{
			switch (propertyName)
			{
				case "JobCandidateId":
					return entity.JobCandidateId;
				case "SafeNameEduLevel":
					return entity.SafeNameEduLevel;
				case "SafeNameEduStartDate":
					return entity.SafeNameEduStartDate;
				case "SafeNameEduEndDate":
					return entity.SafeNameEduEndDate;
				case "SafeNameEduDegree":
					return entity.SafeNameEduDegree;
				case "SafeNameEduMajor":
					return entity.SafeNameEduMajor;
				case "SafeNameEduMinor":
					return entity.SafeNameEduMinor;
				case "SafeNameEduGpa":
					return entity.SafeNameEduGpa;
				case "SafeNameEduGpaScale":
					return entity.SafeNameEduGpaScale;
				case "SafeNameEduSchool":
					return entity.SafeNameEduSchool;
				case "SafeNameEduLocCountryRegion":
					return entity.SafeNameEduLocCountryRegion;
				case "SafeNameEduLocState":
					return entity.SafeNameEduLocState;
				case "SafeNameEduLocCity":
					return entity.SafeNameEduLocCity;
			}
			return null;
		}

		/// <summary>
		/// Gets the property value by name.
		/// </summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <returns></returns>
		public object GetPropertyValueByName(string propertyName)
		{
			return GetPropertyValueByName(this as VJobCandidateEducation, propertyName);
		}

		///<summary>
		/// Returns a String that represents the current object.
		///</summary>
		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture,
				"{14}{13}- JobCandidateId: {0}{13}- SafeNameEduLevel: {1}{13}- SafeNameEduStartDate: {2}{13}- SafeNameEduEndDate: {3}{13}- SafeNameEduDegree: {4}{13}- SafeNameEduMajor: {5}{13}- SafeNameEduMinor: {6}{13}- SafeNameEduGpa: {7}{13}- SafeNameEduGpaScale: {8}{13}- SafeNameEduSchool: {9}{13}- SafeNameEduLocCountryRegion: {10}{13}- SafeNameEduLocState: {11}{13}- SafeNameEduLocCity: {12}{13}",
				this.JobCandidateId,
				(this.SafeNameEduLevel == null) ? string.Empty : this.SafeNameEduLevel.ToString(),

				(this.SafeNameEduStartDate == null) ? string.Empty : this.SafeNameEduStartDate.ToString(),

				(this.SafeNameEduEndDate == null) ? string.Empty : this.SafeNameEduEndDate.ToString(),

				(this.SafeNameEduDegree == null) ? string.Empty : this.SafeNameEduDegree.ToString(),

				(this.SafeNameEduMajor == null) ? string.Empty : this.SafeNameEduMajor.ToString(),

				(this.SafeNameEduMinor == null) ? string.Empty : this.SafeNameEduMinor.ToString(),

				(this.SafeNameEduGpa == null) ? string.Empty : this.SafeNameEduGpa.ToString(),

				(this.SafeNameEduGpaScale == null) ? string.Empty : this.SafeNameEduGpaScale.ToString(),

				(this.SafeNameEduSchool == null) ? string.Empty : this.SafeNameEduSchool.ToString(),

				(this.SafeNameEduLocCountryRegion == null) ? string.Empty : this.SafeNameEduLocCountryRegion.ToString(),

				(this.SafeNameEduLocState == null) ? string.Empty : this.SafeNameEduLocState.ToString(),

				(this.SafeNameEduLocCity == null) ? string.Empty : this.SafeNameEduLocCity.ToString(),

				System.Environment.NewLine,
				this.GetType());
		}

	}//End Class


	/// <summary>
	/// Enumerate the VJobCandidateEducation columns.
	/// </summary>
	[Serializable]
	public enum VJobCandidateEducationColumn
	{
		/// <summary>
		/// JobCandidateID :
		/// </summary>
		[EnumTextValue("JobCandidateID")]
		[ColumnEnum("JobCandidateID", typeof(System.Int32), System.Data.DbType.Int32, false, false, false)]
		JobCandidateId,
		/// <summary>
		/// Edu.Level :
		/// </summary>
		[EnumTextValue("Edu.Level")]
		[ColumnEnum("Edu.Level", typeof(System.String), System.Data.DbType.String, false, false, true)]
		SafeNameEduLevel,
		/// <summary>
		/// Edu.StartDate :
		/// </summary>
		[EnumTextValue("Edu.StartDate")]
		[ColumnEnum("Edu.StartDate", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		SafeNameEduStartDate,
		/// <summary>
		/// Edu.EndDate :
		/// </summary>
		[EnumTextValue("Edu.EndDate")]
		[ColumnEnum("Edu.EndDate", typeof(System.DateTime), System.Data.DbType.DateTime, false, false, true)]
		SafeNameEduEndDate,
		/// <summary>
		/// Edu.Degree :
		/// </summary>
		[EnumTextValue("Edu.Degree")]
		[ColumnEnum("Edu.Degree", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		SafeNameEduDegree,
		/// <summary>
		/// Edu.Major :
		/// </summary>
		[EnumTextValue("Edu.Major")]
		[ColumnEnum("Edu.Major", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		SafeNameEduMajor,
		/// <summary>
		/// Edu.Minor :
		/// </summary>
		[EnumTextValue("Edu.Minor")]
		[ColumnEnum("Edu.Minor", typeof(System.String), System.Data.DbType.String, false, false, true, 50)]
		SafeNameEduMinor,
		/// <summary>
		/// Edu.GPA :
		/// </summary>
		[EnumTextValue("Edu.GPA")]
		[ColumnEnum("Edu.GPA", typeof(System.String), System.Data.DbType.String, false, false, true, 5)]
		SafeNameEduGpa,
		/// <summary>
		/// Edu.GPAScale :
		/// </summary>
		[EnumTextValue("Edu.GPAScale")]
		[ColumnEnum("Edu.GPAScale", typeof(System.String), System.Data.DbType.String, false, false, true, 5)]
		SafeNameEduGpaScale,
		/// <summary>
		/// Edu.School :
		/// </summary>
		[EnumTextValue("Edu.School")]
		[ColumnEnum("Edu.School", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameEduSchool,
		/// <summary>
		/// Edu.Loc.CountryRegion :
		/// </summary>
		[EnumTextValue("Edu.Loc.CountryRegion")]
		[ColumnEnum("Edu.Loc.CountryRegion", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameEduLocCountryRegion,
		/// <summary>
		/// Edu.Loc.State :
		/// </summary>
		[EnumTextValue("Edu.Loc.State")]
		[ColumnEnum("Edu.Loc.State", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameEduLocState,
		/// <summary>
		/// Edu.Loc.City :
		/// </summary>
		[EnumTextValue("Edu.Loc.City")]
		[ColumnEnum("Edu.Loc.City", typeof(System.String), System.Data.DbType.String, false, false, true, 100)]
		SafeNameEduLocCity
	}//End enum

} // end namespace

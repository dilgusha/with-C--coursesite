﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseSite.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FinanceSite")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAbout(About instance);
    partial void UpdateAbout(About instance);
    partial void DeleteAbout(About instance);
    partial void InsertTeam(Team instance);
    partial void UpdateTeam(Team instance);
    partial void DeleteTeam(Team instance);
    partial void InsertOurService(OurService instance);
    partial void UpdateOurService(OurService instance);
    partial void DeleteOurService(OurService instance);
    partial void InsertInfo(Info instance);
    partial void UpdateInfo(Info instance);
    partial void DeleteInfo(Info instance);
    partial void InsertContact(Contact instance);
    partial void UpdateContact(Contact instance);
    partial void DeleteContact(Contact instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["FinanceSiteConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<About> Abouts
		{
			get
			{
				return this.GetTable<About>();
			}
		}
		
		public System.Data.Linq.Table<Team> Teams
		{
			get
			{
				return this.GetTable<Team>();
			}
		}
		
		public System.Data.Linq.Table<DetailView> DetailViews
		{
			get
			{
				return this.GetTable<DetailView>();
			}
		}
		
		public System.Data.Linq.Table<OurService> OurServices
		{
			get
			{
				return this.GetTable<OurService>();
			}
		}
		
		public System.Data.Linq.Table<General> Generals
		{
			get
			{
				return this.GetTable<General>();
			}
		}
		
		public System.Data.Linq.Table<Info> Infos
		{
			get
			{
				return this.GetTable<Info>();
			}
		}
		
		public System.Data.Linq.Table<Contact> Contacts
		{
			get
			{
				return this.GetTable<Contact>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.About")]
	public partial class About : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AboutID;
		
		private string _AboutContent;
		
		private string _AboutPhoto;
		
		private string _AboutSolution;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAboutIDChanging(int value);
    partial void OnAboutIDChanged();
    partial void OnAboutContentChanging(string value);
    partial void OnAboutContentChanged();
    partial void OnAboutPhotoChanging(string value);
    partial void OnAboutPhotoChanged();
    partial void OnAboutSolutionChanging(string value);
    partial void OnAboutSolutionChanged();
    #endregion
		
		public About()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AboutID
		{
			get
			{
				return this._AboutID;
			}
			set
			{
				if ((this._AboutID != value))
				{
					this.OnAboutIDChanging(value);
					this.SendPropertyChanging();
					this._AboutID = value;
					this.SendPropertyChanged("AboutID");
					this.OnAboutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutContent", DbType="NVarChar(MAX)")]
		public string AboutContent
		{
			get
			{
				return this._AboutContent;
			}
			set
			{
				if ((this._AboutContent != value))
				{
					this.OnAboutContentChanging(value);
					this.SendPropertyChanging();
					this._AboutContent = value;
					this.SendPropertyChanged("AboutContent");
					this.OnAboutContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutPhoto", DbType="NVarChar(MAX)")]
		public string AboutPhoto
		{
			get
			{
				return this._AboutPhoto;
			}
			set
			{
				if ((this._AboutPhoto != value))
				{
					this.OnAboutPhotoChanging(value);
					this.SendPropertyChanging();
					this._AboutPhoto = value;
					this.SendPropertyChanged("AboutPhoto");
					this.OnAboutPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutSolution", DbType="NVarChar(MAX)")]
		public string AboutSolution
		{
			get
			{
				return this._AboutSolution;
			}
			set
			{
				if ((this._AboutSolution != value))
				{
					this.OnAboutSolutionChanging(value);
					this.SendPropertyChanging();
					this._AboutSolution = value;
					this.SendPropertyChanged("AboutSolution");
					this.OnAboutSolutionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Team")]
	public partial class Team : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TeamID;
		
		private System.Nullable<int> _TeamAboutID;
		
		private string _TeamName;
		
		private string _TeamPosition;
		
		private string _TeamAbout;
		
		private string _TeamPhoto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTeamIDChanging(int value);
    partial void OnTeamIDChanged();
    partial void OnTeamAboutIDChanging(System.Nullable<int> value);
    partial void OnTeamAboutIDChanged();
    partial void OnTeamNameChanging(string value);
    partial void OnTeamNameChanged();
    partial void OnTeamPositionChanging(string value);
    partial void OnTeamPositionChanged();
    partial void OnTeamAboutChanging(string value);
    partial void OnTeamAboutChanged();
    partial void OnTeamPhotoChanging(string value);
    partial void OnTeamPhotoChanged();
    #endregion
		
		public Team()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TeamID
		{
			get
			{
				return this._TeamID;
			}
			set
			{
				if ((this._TeamID != value))
				{
					this.OnTeamIDChanging(value);
					this.SendPropertyChanging();
					this._TeamID = value;
					this.SendPropertyChanged("TeamID");
					this.OnTeamIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamAboutID", DbType="Int")]
		public System.Nullable<int> TeamAboutID
		{
			get
			{
				return this._TeamAboutID;
			}
			set
			{
				if ((this._TeamAboutID != value))
				{
					this.OnTeamAboutIDChanging(value);
					this.SendPropertyChanging();
					this._TeamAboutID = value;
					this.SendPropertyChanged("TeamAboutID");
					this.OnTeamAboutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(30)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this.OnTeamNameChanging(value);
					this.SendPropertyChanging();
					this._TeamName = value;
					this.SendPropertyChanged("TeamName");
					this.OnTeamNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamPosition", DbType="NVarChar(40)")]
		public string TeamPosition
		{
			get
			{
				return this._TeamPosition;
			}
			set
			{
				if ((this._TeamPosition != value))
				{
					this.OnTeamPositionChanging(value);
					this.SendPropertyChanging();
					this._TeamPosition = value;
					this.SendPropertyChanged("TeamPosition");
					this.OnTeamPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamAbout", DbType="NVarChar(MAX)")]
		public string TeamAbout
		{
			get
			{
				return this._TeamAbout;
			}
			set
			{
				if ((this._TeamAbout != value))
				{
					this.OnTeamAboutChanging(value);
					this.SendPropertyChanging();
					this._TeamAbout = value;
					this.SendPropertyChanged("TeamAbout");
					this.OnTeamAboutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamPhoto", DbType="NVarChar(MAX)")]
		public string TeamPhoto
		{
			get
			{
				return this._TeamPhoto;
			}
			set
			{
				if ((this._TeamPhoto != value))
				{
					this.OnTeamPhotoChanging(value);
					this.SendPropertyChanging();
					this._TeamPhoto = value;
					this.SendPropertyChanged("TeamPhoto");
					this.OnTeamPhotoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DetailView")]
	public partial class DetailView
	{
		
		private int _AboutID;
		
		private string _AboutContent;
		
		private string _AboutPhoto;
		
		private string _AboutSolution;
		
		private System.Nullable<int> _TeamID;
		
		private System.Nullable<int> _TeamAboutID;
		
		private string _TeamName;
		
		private string _TeamPosition;
		
		private string _TeamAbout;
		
		private string _TeamPhoto;
		
		public DetailView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutID", DbType="Int NOT NULL")]
		public int AboutID
		{
			get
			{
				return this._AboutID;
			}
			set
			{
				if ((this._AboutID != value))
				{
					this._AboutID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutContent", DbType="NVarChar(MAX)")]
		public string AboutContent
		{
			get
			{
				return this._AboutContent;
			}
			set
			{
				if ((this._AboutContent != value))
				{
					this._AboutContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutPhoto", DbType="NVarChar(MAX)")]
		public string AboutPhoto
		{
			get
			{
				return this._AboutPhoto;
			}
			set
			{
				if ((this._AboutPhoto != value))
				{
					this._AboutPhoto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutSolution", DbType="NVarChar(MAX)")]
		public string AboutSolution
		{
			get
			{
				return this._AboutSolution;
			}
			set
			{
				if ((this._AboutSolution != value))
				{
					this._AboutSolution = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamID", DbType="Int")]
		public System.Nullable<int> TeamID
		{
			get
			{
				return this._TeamID;
			}
			set
			{
				if ((this._TeamID != value))
				{
					this._TeamID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamAboutID", DbType="Int")]
		public System.Nullable<int> TeamAboutID
		{
			get
			{
				return this._TeamAboutID;
			}
			set
			{
				if ((this._TeamAboutID != value))
				{
					this._TeamAboutID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamName", DbType="NVarChar(30)")]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				if ((this._TeamName != value))
				{
					this._TeamName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamPosition", DbType="NVarChar(40)")]
		public string TeamPosition
		{
			get
			{
				return this._TeamPosition;
			}
			set
			{
				if ((this._TeamPosition != value))
				{
					this._TeamPosition = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamAbout", DbType="NVarChar(MAX)")]
		public string TeamAbout
		{
			get
			{
				return this._TeamAbout;
			}
			set
			{
				if ((this._TeamAbout != value))
				{
					this._TeamAbout = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeamPhoto", DbType="NVarChar(MAX)")]
		public string TeamPhoto
		{
			get
			{
				return this._TeamPhoto;
			}
			set
			{
				if ((this._TeamPhoto != value))
				{
					this._TeamPhoto = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OurService")]
	public partial class OurService : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OurServiceID;
		
		private System.Nullable<int> _OurServiceAboutID;
		
		private string _OurServiceName;
		
		private string _OurServiceAbout;
		
		private string _OurServicePhoto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOurServiceIDChanging(int value);
    partial void OnOurServiceIDChanged();
    partial void OnOurServiceAboutIDChanging(System.Nullable<int> value);
    partial void OnOurServiceAboutIDChanged();
    partial void OnOurServiceNameChanging(string value);
    partial void OnOurServiceNameChanged();
    partial void OnOurServiceAboutChanging(string value);
    partial void OnOurServiceAboutChanged();
    partial void OnOurServicePhotoChanging(string value);
    partial void OnOurServicePhotoChanged();
    #endregion
		
		public OurService()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OurServiceID
		{
			get
			{
				return this._OurServiceID;
			}
			set
			{
				if ((this._OurServiceID != value))
				{
					this.OnOurServiceIDChanging(value);
					this.SendPropertyChanging();
					this._OurServiceID = value;
					this.SendPropertyChanged("OurServiceID");
					this.OnOurServiceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceAboutID", DbType="Int")]
		public System.Nullable<int> OurServiceAboutID
		{
			get
			{
				return this._OurServiceAboutID;
			}
			set
			{
				if ((this._OurServiceAboutID != value))
				{
					this.OnOurServiceAboutIDChanging(value);
					this.SendPropertyChanging();
					this._OurServiceAboutID = value;
					this.SendPropertyChanged("OurServiceAboutID");
					this.OnOurServiceAboutIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceName", DbType="NVarChar(30)")]
		public string OurServiceName
		{
			get
			{
				return this._OurServiceName;
			}
			set
			{
				if ((this._OurServiceName != value))
				{
					this.OnOurServiceNameChanging(value);
					this.SendPropertyChanging();
					this._OurServiceName = value;
					this.SendPropertyChanged("OurServiceName");
					this.OnOurServiceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceAbout", DbType="NVarChar(MAX)")]
		public string OurServiceAbout
		{
			get
			{
				return this._OurServiceAbout;
			}
			set
			{
				if ((this._OurServiceAbout != value))
				{
					this.OnOurServiceAboutChanging(value);
					this.SendPropertyChanging();
					this._OurServiceAbout = value;
					this.SendPropertyChanged("OurServiceAbout");
					this.OnOurServiceAboutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServicePhoto", DbType="NVarChar(MAX)")]
		public string OurServicePhoto
		{
			get
			{
				return this._OurServicePhoto;
			}
			set
			{
				if ((this._OurServicePhoto != value))
				{
					this.OnOurServicePhotoChanging(value);
					this.SendPropertyChanging();
					this._OurServicePhoto = value;
					this.SendPropertyChanged("OurServicePhoto");
					this.OnOurServicePhotoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.General")]
	public partial class General
	{
		
		private int _AboutID;
		
		private string _AboutContent;
		
		private string _AboutPhoto;
		
		private string _AboutSolution;
		
		private System.Nullable<int> _OurServiceID;
		
		private System.Nullable<int> _OurServiceAboutID;
		
		private string _OurServiceName;
		
		private string _OurServiceAbout;
		
		private string _OurServicePhoto;
		
		public General()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutID", DbType="Int NOT NULL")]
		public int AboutID
		{
			get
			{
				return this._AboutID;
			}
			set
			{
				if ((this._AboutID != value))
				{
					this._AboutID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutContent", DbType="NVarChar(MAX)")]
		public string AboutContent
		{
			get
			{
				return this._AboutContent;
			}
			set
			{
				if ((this._AboutContent != value))
				{
					this._AboutContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutPhoto", DbType="NVarChar(MAX)")]
		public string AboutPhoto
		{
			get
			{
				return this._AboutPhoto;
			}
			set
			{
				if ((this._AboutPhoto != value))
				{
					this._AboutPhoto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AboutSolution", DbType="NVarChar(MAX)")]
		public string AboutSolution
		{
			get
			{
				return this._AboutSolution;
			}
			set
			{
				if ((this._AboutSolution != value))
				{
					this._AboutSolution = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceID", DbType="Int")]
		public System.Nullable<int> OurServiceID
		{
			get
			{
				return this._OurServiceID;
			}
			set
			{
				if ((this._OurServiceID != value))
				{
					this._OurServiceID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceAboutID", DbType="Int")]
		public System.Nullable<int> OurServiceAboutID
		{
			get
			{
				return this._OurServiceAboutID;
			}
			set
			{
				if ((this._OurServiceAboutID != value))
				{
					this._OurServiceAboutID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceName", DbType="NVarChar(30)")]
		public string OurServiceName
		{
			get
			{
				return this._OurServiceName;
			}
			set
			{
				if ((this._OurServiceName != value))
				{
					this._OurServiceName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServiceAbout", DbType="NVarChar(MAX)")]
		public string OurServiceAbout
		{
			get
			{
				return this._OurServiceAbout;
			}
			set
			{
				if ((this._OurServiceAbout != value))
				{
					this._OurServiceAbout = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OurServicePhoto", DbType="NVarChar(MAX)")]
		public string OurServicePhoto
		{
			get
			{
				return this._OurServicePhoto;
			}
			set
			{
				if ((this._OurServicePhoto != value))
				{
					this._OurServicePhoto = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Info")]
	public partial class Info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InfoID;
		
		private string _InfoPhone;
		
		private string _InfoEmail;
		
		private string _InfoLocation;
		
		private string _InfoPlace;
		
		private string _InfoFace;
		
		private string _InfoTwitter;
		
		private string _infoLink;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInfoIDChanging(int value);
    partial void OnInfoIDChanged();
    partial void OnInfoPhoneChanging(string value);
    partial void OnInfoPhoneChanged();
    partial void OnInfoEmailChanging(string value);
    partial void OnInfoEmailChanged();
    partial void OnInfoLocationChanging(string value);
    partial void OnInfoLocationChanged();
    partial void OnInfoPlaceChanging(string value);
    partial void OnInfoPlaceChanged();
    partial void OnInfoFaceChanging(string value);
    partial void OnInfoFaceChanged();
    partial void OnInfoTwitterChanging(string value);
    partial void OnInfoTwitterChanged();
    partial void OninfoLinkChanging(string value);
    partial void OninfoLinkChanged();
    #endregion
		
		public Info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int InfoID
		{
			get
			{
				return this._InfoID;
			}
			set
			{
				if ((this._InfoID != value))
				{
					this.OnInfoIDChanging(value);
					this.SendPropertyChanging();
					this._InfoID = value;
					this.SendPropertyChanged("InfoID");
					this.OnInfoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoPhone", DbType="NVarChar(30)")]
		public string InfoPhone
		{
			get
			{
				return this._InfoPhone;
			}
			set
			{
				if ((this._InfoPhone != value))
				{
					this.OnInfoPhoneChanging(value);
					this.SendPropertyChanging();
					this._InfoPhone = value;
					this.SendPropertyChanged("InfoPhone");
					this.OnInfoPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoEmail", DbType="NVarChar(30)")]
		public string InfoEmail
		{
			get
			{
				return this._InfoEmail;
			}
			set
			{
				if ((this._InfoEmail != value))
				{
					this.OnInfoEmailChanging(value);
					this.SendPropertyChanging();
					this._InfoEmail = value;
					this.SendPropertyChanged("InfoEmail");
					this.OnInfoEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoLocation", DbType="NVarChar(MAX)")]
		public string InfoLocation
		{
			get
			{
				return this._InfoLocation;
			}
			set
			{
				if ((this._InfoLocation != value))
				{
					this.OnInfoLocationChanging(value);
					this.SendPropertyChanging();
					this._InfoLocation = value;
					this.SendPropertyChanged("InfoLocation");
					this.OnInfoLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoPlace", DbType="NVarChar(100)")]
		public string InfoPlace
		{
			get
			{
				return this._InfoPlace;
			}
			set
			{
				if ((this._InfoPlace != value))
				{
					this.OnInfoPlaceChanging(value);
					this.SendPropertyChanging();
					this._InfoPlace = value;
					this.SendPropertyChanged("InfoPlace");
					this.OnInfoPlaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoFace", DbType="NVarChar(50)")]
		public string InfoFace
		{
			get
			{
				return this._InfoFace;
			}
			set
			{
				if ((this._InfoFace != value))
				{
					this.OnInfoFaceChanging(value);
					this.SendPropertyChanging();
					this._InfoFace = value;
					this.SendPropertyChanged("InfoFace");
					this.OnInfoFaceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InfoTwitter", DbType="NVarChar(50)")]
		public string InfoTwitter
		{
			get
			{
				return this._InfoTwitter;
			}
			set
			{
				if ((this._InfoTwitter != value))
				{
					this.OnInfoTwitterChanging(value);
					this.SendPropertyChanging();
					this._InfoTwitter = value;
					this.SendPropertyChanged("InfoTwitter");
					this.OnInfoTwitterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_infoLink", DbType="NVarChar(50)")]
		public string infoLink
		{
			get
			{
				return this._infoLink;
			}
			set
			{
				if ((this._infoLink != value))
				{
					this.OninfoLinkChanging(value);
					this.SendPropertyChanging();
					this._infoLink = value;
					this.SendPropertyChanged("infoLink");
					this.OninfoLinkChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contact")]
	public partial class Contact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ContactID;
		
		private string _ContactName;
		
		private string _ContactEmail;
		
		private string _ContactSubject;
		
		private string _ContactMessage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnContactIDChanging(int value);
    partial void OnContactIDChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactEmailChanging(string value);
    partial void OnContactEmailChanged();
    partial void OnContactSubjectChanging(string value);
    partial void OnContactSubjectChanged();
    partial void OnContactMessageChanging(string value);
    partial void OnContactMessageChanged();
    #endregion
		
		public Contact()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ContactID
		{
			get
			{
				return this._ContactID;
			}
			set
			{
				if ((this._ContactID != value))
				{
					this.OnContactIDChanging(value);
					this.SendPropertyChanging();
					this._ContactID = value;
					this.SendPropertyChanged("ContactID");
					this.OnContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="NVarChar(30)")]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactEmail", DbType="NVarChar(30)")]
		public string ContactEmail
		{
			get
			{
				return this._ContactEmail;
			}
			set
			{
				if ((this._ContactEmail != value))
				{
					this.OnContactEmailChanging(value);
					this.SendPropertyChanging();
					this._ContactEmail = value;
					this.SendPropertyChanged("ContactEmail");
					this.OnContactEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactSubject", DbType="NVarChar(30)")]
		public string ContactSubject
		{
			get
			{
				return this._ContactSubject;
			}
			set
			{
				if ((this._ContactSubject != value))
				{
					this.OnContactSubjectChanging(value);
					this.SendPropertyChanging();
					this._ContactSubject = value;
					this.SendPropertyChanged("ContactSubject");
					this.OnContactSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactMessage", DbType="NVarChar(500)")]
		public string ContactMessage
		{
			get
			{
				return this._ContactMessage;
			}
			set
			{
				if ((this._ContactMessage != value))
				{
					this.OnContactMessageChanging(value);
					this.SendPropertyChanging();
					this._ContactMessage = value;
					this.SendPropertyChanged("ContactMessage");
					this.OnContactMessageChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
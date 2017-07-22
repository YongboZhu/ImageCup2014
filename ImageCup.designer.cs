﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageCup2014
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DreamSpark_Data")]
	public partial class ImageCupDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public ImageCupDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DreamSpark_DataConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ImageCupDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImageCupDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImageCupDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImageCupDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GameImage> GameImage
		{
			get
			{
				return this.GetTable<GameImage>();
			}
		}
		
		public System.Data.Linq.Table<TextEvolution> TextEvolution
		{
			get
			{
				return this.GetTable<TextEvolution>();
			}
		}
		
		public System.Data.Linq.Table<ImagineCup> ImagineCup
		{
			get
			{
				return this.GetTable<ImagineCup>();
			}
		}
		
		public System.Data.Linq.Table<Info> Info
		{
			get
			{
				return this.GetTable<Info>();
			}
		}
		
		public System.Data.Linq.Table<NewMenber_Application> NewMenber_Application
		{
			get
			{
				return this.GetTable<NewMenber_Application>();
			}
		}
		
		public System.Data.Linq.Table<sysdiagrams> sysdiagrams
		{
			get
			{
				return this.GetTable<sysdiagrams>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GameImage")]
	public partial class GameImage
	{
		
		private int _ID;
		
		private string _Name;
		
		private System.Data.Linq.Binary _littleImage;
		
		public GameImage()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_littleImage", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary littleImage
		{
			get
			{
				return this._littleImage;
			}
			set
			{
				if ((this._littleImage != value))
				{
					this._littleImage = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TextEvolution")]
	public partial class TextEvolution
	{
		
		private int _SID;
		
		private string _Character;
		
		private string _Text;
		
		private System.Data.Linq.Binary _MinImage;
		
		private System.Data.Linq.Binary _MaxImage;
		
		private string _Notes;
		
		public TextEvolution()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SID", DbType="Int NOT NULL")]
		public int SID
		{
			get
			{
				return this._SID;
			}
			set
			{
				if ((this._SID != value))
				{
					this._SID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Character", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
		public string Character
		{
			get
			{
				return this._Character;
			}
			set
			{
				if ((this._Character != value))
				{
					this._Character = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(MAX)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this._Text = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinImage", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MinImage
		{
			get
			{
				return this._MinImage;
			}
			set
			{
				if ((this._MinImage != value))
				{
					this._MinImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxImage", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary MaxImage
		{
			get
			{
				return this._MaxImage;
			}
			set
			{
				if ((this._MaxImage != value))
				{
					this._MaxImage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(500)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this._Notes = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ImagineCup")]
	public partial class ImagineCup
	{
		
		private string _Sid;
		
		private string _Name;
		
		private string _Grade;
		
		private string _Major;
		
		private string _Phone;
		
		private string _Email;
		
		private string _ProjectTypes;
		
		private string _ProjectNames;
		
		private string _TroopsName;
		
		private string _Ip;
		
		private System.Nullable<bool> _IsDeal;
		
		private System.Nullable<bool> _IsStudent;
		
		public ImagineCup()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sid", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Sid
		{
			get
			{
				return this._Sid;
			}
			set
			{
				if ((this._Sid != value))
				{
					this._Sid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grade", DbType="VarChar(10)")]
		public string Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this._Grade = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Major", DbType="VarChar(50)")]
		public string Major
		{
			get
			{
				return this._Major;
			}
			set
			{
				if ((this._Major != value))
				{
					this._Major = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectTypes", DbType="VarChar(50)")]
		public string ProjectTypes
		{
			get
			{
				return this._ProjectTypes;
			}
			set
			{
				if ((this._ProjectTypes != value))
				{
					this._ProjectTypes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectNames", DbType="VarChar(50)")]
		public string ProjectNames
		{
			get
			{
				return this._ProjectNames;
			}
			set
			{
				if ((this._ProjectNames != value))
				{
					this._ProjectNames = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TroopsName", DbType="VarChar(50)")]
		public string TroopsName
		{
			get
			{
				return this._TroopsName;
			}
			set
			{
				if ((this._TroopsName != value))
				{
					this._TroopsName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ip", DbType="VarChar(50)")]
		public string Ip
		{
			get
			{
				return this._Ip;
			}
			set
			{
				if ((this._Ip != value))
				{
					this._Ip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDeal", DbType="Bit")]
		public System.Nullable<bool> IsDeal
		{
			get
			{
				return this._IsDeal;
			}
			set
			{
				if ((this._IsDeal != value))
				{
					this._IsDeal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsStudent", DbType="Bit")]
		public System.Nullable<bool> IsStudent
		{
			get
			{
				return this._IsStudent;
			}
			set
			{
				if ((this._IsStudent != value))
				{
					this._IsStudent = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Info")]
	public partial class Info
	{
		
		private string _Name;
		
		private string _Phone;
		
		private string _Email;
		
		private string _Ip;
		
		private bool _IsDeal;
		
		public Info()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ip", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Ip
		{
			get
			{
				return this._Ip;
			}
			set
			{
				if ((this._Ip != value))
				{
					this._Ip = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDeal", DbType="Bit NOT NULL")]
		public bool IsDeal
		{
			get
			{
				return this._IsDeal;
			}
			set
			{
				if ((this._IsDeal != value))
				{
					this._IsDeal = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NewMenber_Application")]
	public partial class NewMenber_Application
	{
		
		private string _Sid;
		
		private string _Name;
		
		private string _Grade;
		
		private string _Major;
		
		private string _Phone;
		
		private string _Email;
		
		private string _ProjectTypes;
		
		private string _ProjectNames;
		
		public NewMenber_Application()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sid", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Sid
		{
			get
			{
				return this._Sid;
			}
			set
			{
				if ((this._Sid != value))
				{
					this._Sid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grade", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this._Grade = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Major", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Major
		{
			get
			{
				return this._Major;
			}
			set
			{
				if ((this._Major != value))
				{
					this._Major = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this._Phone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectTypes", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string ProjectTypes
		{
			get
			{
				return this._ProjectTypes;
			}
			set
			{
				if ((this._ProjectTypes != value))
				{
					this._ProjectTypes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectNames", DbType="NVarChar(500)")]
		public string ProjectNames
		{
			get
			{
				return this._ProjectNames;
			}
			set
			{
				if ((this._ProjectNames != value))
				{
					this._ProjectNames = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.sysdiagrams")]
	public partial class sysdiagrams
	{
		
		private string _name;
		
		private int _principal_id;
		
		private int _diagram_id;
		
		private System.Nullable<int> _version;
		
		private System.Data.Linq.Binary _definition;
		
		public sysdiagrams()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_principal_id", DbType="Int NOT NULL")]
		public int principal_id
		{
			get
			{
				return this._principal_id;
			}
			set
			{
				if ((this._principal_id != value))
				{
					this._principal_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diagram_id", DbType="Int NOT NULL")]
		public int diagram_id
		{
			get
			{
				return this._diagram_id;
			}
			set
			{
				if ((this._diagram_id != value))
				{
					this._diagram_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_version", DbType="Int")]
		public System.Nullable<int> version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((this._version != value))
				{
					this._version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_definition", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary definition
		{
			get
			{
				return this._definition;
			}
			set
			{
				if ((this._definition != value))
				{
					this._definition = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
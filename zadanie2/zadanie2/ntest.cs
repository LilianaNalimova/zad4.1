﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



public partial class Students : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Определения метода расширяемости
  partial void OnCreated();
  partial void InsertStudentList(StudentList instance);
  partial void UpdateStudentList(StudentList instance);
  partial void DeleteStudentList(StudentList instance);
  partial void InsertSubject(Subject instance);
  partial void UpdateSubject(Subject instance);
  partial void DeleteSubject(Subject instance);
  #endregion
	
	public Students(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Students(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Students(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public Students(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<StudentList> StudentLists
	{
		get
		{
			return this.GetTable<StudentList>();
		}
	}
	
	public System.Data.Linq.Table<Subject> Subjects
	{
		get
		{
			return this.GetTable<Subject>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetStudentByName")]
	public ISingleResult<GetStudentByNameResult> GetStudentByName([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string sub)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sub);
		return ((ISingleResult<GetStudentByNameResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSubjectByTitle")]
	public ISingleResult<GetSubjectByTitleResult> GetSubjectByTitle([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string sub)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), sub);
		return ((ISingleResult<GetSubjectByTitleResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.IvanovGetStudentById")]
	public ISingleResult<IvanovGetStudentByIdResult> IvanovGetStudentById([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), stId);
		return ((ISingleResult<IvanovGetStudentByIdResult>)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentList")]
public partial class StudentList : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Surname;
	
	private string _PhoneNumber;
	
	private string _Address;
	
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
	
	public StudentList()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
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
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NChar(10)")]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this.OnSurnameChanging(value);
				this.SendPropertyChanging();
				this._Surname = value;
				this.SendPropertyChanged("Surname");
				this.OnSurnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NChar(10)")]
	public string PhoneNumber
	{
		get
		{
			return this._PhoneNumber;
		}
		set
		{
			if ((this._PhoneNumber != value))
			{
				this.OnPhoneNumberChanging(value);
				this.SendPropertyChanging();
				this._PhoneNumber = value;
				this.SendPropertyChanged("PhoneNumber");
				this.OnPhoneNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subject")]
public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Title;
	
	private string _NumberOfHours;
	
	private string _Teacher;
	
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnNumberOfHoursChanging(string value);
    partial void OnNumberOfHoursChanged();
    partial void OnTeacherChanging(string value);
    partial void OnTeacherChanged();
    #endregion
	
	public Subject()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NChar(20)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfHours", DbType="NChar(10)")]
	public string NumberOfHours
	{
		get
		{
			return this._NumberOfHours;
		}
		set
		{
			if ((this._NumberOfHours != value))
			{
				this.OnNumberOfHoursChanging(value);
				this.SendPropertyChanging();
				this._NumberOfHours = value;
				this.SendPropertyChanged("NumberOfHours");
				this.OnNumberOfHoursChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Teacher", DbType="NChar(30)")]
	public string Teacher
	{
		get
		{
			return this._Teacher;
		}
		set
		{
			if ((this._Teacher != value))
			{
				this.OnTeacherChanging(value);
				this.SendPropertyChanging();
				this._Teacher = value;
				this.SendPropertyChanged("Teacher");
				this.OnTeacherChanged();
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

public partial class GetStudentByNameResult
{
	
	private System.Nullable<int> _Id;
	
	private string _Name;
	
	private string _Surname;
	
	private string _PhoneNumber;
	
	private string _Address;
	
	public GetStudentByNameResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
	public System.Nullable<int> Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this._Id = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NChar(10)")]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this._Surname = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NChar(10)")]
	public string PhoneNumber
	{
		get
		{
			return this._PhoneNumber;
		}
		set
		{
			if ((this._PhoneNumber != value))
			{
				this._PhoneNumber = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this._Address = value;
			}
		}
	}
}

public partial class GetSubjectByTitleResult
{
	
	private System.Nullable<int> _Id;
	
	private string _Title;
	
	private string _NumberOfHours;
	
	private string _Teacher;
	
	public GetSubjectByTitleResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
	public System.Nullable<int> Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this._Id = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NChar(20)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this._Title = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfHours", DbType="NChar(10)")]
	public string NumberOfHours
	{
		get
		{
			return this._NumberOfHours;
		}
		set
		{
			if ((this._NumberOfHours != value))
			{
				this._NumberOfHours = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Teacher", DbType="NChar(30)")]
	public string Teacher
	{
		get
		{
			return this._Teacher;
		}
		set
		{
			if ((this._Teacher != value))
			{
				this._Teacher = value;
			}
		}
	}
}

public partial class IvanovGetStudentByIdResult
{
	
	private System.Nullable<int> _Id;
	
	private string _Name;
	
	private string _Surname;
	
	private string _PhoneNumber;
	
	private string _Address;
	
	public IvanovGetStudentByIdResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int")]
	public System.Nullable<int> Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this._Id = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NChar(10)")]
	public string Surname
	{
		get
		{
			return this._Surname;
		}
		set
		{
			if ((this._Surname != value))
			{
				this._Surname = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NChar(10)")]
	public string PhoneNumber
	{
		get
		{
			return this._PhoneNumber;
		}
		set
		{
			if ((this._PhoneNumber != value))
			{
				this._PhoneNumber = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NChar(10)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this._Address = value;
			}
		}
	}
}
#pragma warning restore 1591

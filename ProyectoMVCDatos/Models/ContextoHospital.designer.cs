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

namespace ProyectoMVCDatos.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Hospital")]
	public partial class ContextoHospitalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertENFERMO(ENFERMO instance);
    partial void UpdateENFERMO(ENFERMO instance);
    partial void DeleteENFERMO(ENFERMO instance);
    partial void InsertDOCTOR(DOCTOR instance);
    partial void UpdateDOCTOR(DOCTOR instance);
    partial void DeleteDOCTOR(DOCTOR instance);
    partial void InsertHOSPITAL(HOSPITAL instance);
    partial void UpdateHOSPITAL(HOSPITAL instance);
    partial void DeleteHOSPITAL(HOSPITAL instance);
    #endregion
		
		public ContextoHospitalDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoHospitalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoHospitalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoHospitalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoHospitalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ENFERMO> ENFERMOs
		{
			get
			{
				return this.GetTable<ENFERMO>();
			}
		}
		
		public System.Data.Linq.Table<DOCTOR> DOCTORs
		{
			get
			{
				return this.GetTable<DOCTOR>();
			}
		}
		
		public System.Data.Linq.Table<DEPT> DEPTs
		{
			get
			{
				return this.GetTable<DEPT>();
			}
		}
		
		public System.Data.Linq.Table<EMP> EMPs
		{
			get
			{
				return this.GetTable<EMP>();
			}
		}
		
		public System.Data.Linq.Table<PLANTILLA> PLANTILLAs
		{
			get
			{
				return this.GetTable<PLANTILLA>();
			}
		}
		
		public System.Data.Linq.Table<HOSPITAL> HOSPITALs
		{
			get
			{
				return this.GetTable<HOSPITAL>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarDept")]
		public int EliminarDept([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> dept_no)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dept_no);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ModificarSalario")]
		public int ModificarSalario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="INCR", DbType="Int")] System.Nullable<int> iNCR, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DEPT_NO", DbType="Int")] System.Nullable<int> dEPT_NO)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iNCR, dEPT_NO);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarPlantilla")]
		public int EliminarPlantilla([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> emp_no)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), emp_no);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ENFERMO")]
	public partial class ENFERMO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _INSCRIPCION;
		
		private string _APELLIDO;
		
		private string _DIRECCION;
		
		private System.Nullable<System.DateTime> _FECHA_NAC;
		
		private string _S;
		
		private System.Nullable<int> _NSS;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnINSCRIPCIONChanging(int value);
    partial void OnINSCRIPCIONChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    partial void OnFECHA_NACChanging(System.Nullable<System.DateTime> value);
    partial void OnFECHA_NACChanged();
    partial void OnSChanging(string value);
    partial void OnSChanged();
    partial void OnNSSChanging(System.Nullable<int> value);
    partial void OnNSSChanged();
    #endregion
		
		public ENFERMO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INSCRIPCION", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int INSCRIPCION
		{
			get
			{
				return this._INSCRIPCION;
			}
			set
			{
				if ((this._INSCRIPCION != value))
				{
					this.OnINSCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._INSCRIPCION = value;
					this.SendPropertyChanged("INSCRIPCION");
					this.OnINSCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_NAC", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_NAC
		{
			get
			{
				return this._FECHA_NAC;
			}
			set
			{
				if ((this._FECHA_NAC != value))
				{
					this.OnFECHA_NACChanging(value);
					this.SendPropertyChanging();
					this._FECHA_NAC = value;
					this.SendPropertyChanged("FECHA_NAC");
					this.OnFECHA_NACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S", DbType="NVarChar(50)")]
		public string S
		{
			get
			{
				return this._S;
			}
			set
			{
				if ((this._S != value))
				{
					this.OnSChanging(value);
					this.SendPropertyChanging();
					this._S = value;
					this.SendPropertyChanged("S");
					this.OnSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NSS", DbType="Int")]
		public System.Nullable<int> NSS
		{
			get
			{
				return this._NSS;
			}
			set
			{
				if ((this._NSS != value))
				{
					this.OnNSSChanging(value);
					this.SendPropertyChanging();
					this._NSS = value;
					this.SendPropertyChanged("NSS");
					this.OnNSSChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOCTOR")]
	public partial class DOCTOR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<int> _HOSPITAL_COD;
		
		private int _DOCTOR_NO;
		
		private string _APELLIDO;
		
		private string _ESPECIALIDAD;
		
		private System.Nullable<int> _SALARIO;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(System.Nullable<int> value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnDOCTOR_NOChanging(int value);
    partial void OnDOCTOR_NOChanged();
    partial void OnAPELLIDOChanging(string value);
    partial void OnAPELLIDOChanged();
    partial void OnESPECIALIDADChanging(string value);
    partial void OnESPECIALIDADChanged();
    partial void OnSALARIOChanging(System.Nullable<int> value);
    partial void OnSALARIOChanged();
    #endregion
		
		public DOCTOR()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="Int")]
		public System.Nullable<int> HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOCTOR_NO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DOCTOR_NO
		{
			get
			{
				return this._DOCTOR_NO;
			}
			set
			{
				if ((this._DOCTOR_NO != value))
				{
					this.OnDOCTOR_NOChanging(value);
					this.SendPropertyChanging();
					this._DOCTOR_NO = value;
					this.SendPropertyChanged("DOCTOR_NO");
					this.OnDOCTOR_NOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this.OnAPELLIDOChanging(value);
					this.SendPropertyChanging();
					this._APELLIDO = value;
					this.SendPropertyChanged("APELLIDO");
					this.OnAPELLIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ESPECIALIDAD", DbType="NVarChar(50)")]
		public string ESPECIALIDAD
		{
			get
			{
				return this._ESPECIALIDAD;
			}
			set
			{
				if ((this._ESPECIALIDAD != value))
				{
					this.OnESPECIALIDADChanging(value);
					this.SendPropertyChanging();
					this._ESPECIALIDAD = value;
					this.SendPropertyChanged("ESPECIALIDAD");
					this.OnESPECIALIDADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="Int")]
		public System.Nullable<int> SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this.OnSALARIOChanging(value);
					this.SendPropertyChanging();
					this._SALARIO = value;
					this.SendPropertyChanged("SALARIO");
					this.OnSALARIOChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPT")]
	public partial class DEPT
	{
		
		private System.Nullable<int> _DEPT_NO;
		
		private string _DNOMBRE;
		
		private string _LOC;
		
		public DEPT()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPT_NO", DbType="Int")]
		public System.Nullable<int> DEPT_NO
		{
			get
			{
				return this._DEPT_NO;
			}
			set
			{
				if ((this._DEPT_NO != value))
				{
					this._DEPT_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNOMBRE", DbType="NVarChar(50)")]
		public string DNOMBRE
		{
			get
			{
				return this._DNOMBRE;
			}
			set
			{
				if ((this._DNOMBRE != value))
				{
					this._DNOMBRE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOC", DbType="NVarChar(50)")]
		public string LOC
		{
			get
			{
				return this._LOC;
			}
			set
			{
				if ((this._LOC != value))
				{
					this._LOC = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMP")]
	public partial class EMP
	{
		
		private System.Nullable<int> _EMP_NO;
		
		private string _APELLIDO;
		
		private string _OFICIO;
		
		private System.Nullable<int> _DIR;
		
		private System.Nullable<System.DateTime> _FECHA_ALT;
		
		private System.Nullable<int> _SALARIO;
		
		private System.Nullable<int> _COMISION;
		
		private System.Nullable<int> _DEPT_NO;
		
		public EMP()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMP_NO", DbType="Int")]
		public System.Nullable<int> EMP_NO
		{
			get
			{
				return this._EMP_NO;
			}
			set
			{
				if ((this._EMP_NO != value))
				{
					this._EMP_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this._APELLIDO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OFICIO", DbType="NVarChar(50)")]
		public string OFICIO
		{
			get
			{
				return this._OFICIO;
			}
			set
			{
				if ((this._OFICIO != value))
				{
					this._OFICIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIR", DbType="Int")]
		public System.Nullable<int> DIR
		{
			get
			{
				return this._DIR;
			}
			set
			{
				if ((this._DIR != value))
				{
					this._DIR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_ALT", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_ALT
		{
			get
			{
				return this._FECHA_ALT;
			}
			set
			{
				if ((this._FECHA_ALT != value))
				{
					this._FECHA_ALT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="Int")]
		public System.Nullable<int> SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this._SALARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMISION", DbType="Int")]
		public System.Nullable<int> COMISION
		{
			get
			{
				return this._COMISION;
			}
			set
			{
				if ((this._COMISION != value))
				{
					this._COMISION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEPT_NO", DbType="Int")]
		public System.Nullable<int> DEPT_NO
		{
			get
			{
				return this._DEPT_NO;
			}
			set
			{
				if ((this._DEPT_NO != value))
				{
					this._DEPT_NO = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PLANTILLA")]
	public partial class PLANTILLA
	{
		
		private System.Nullable<int> _HOSPITAL_COD;
		
		private string _SALA_COD;
		
		private string _EMPLEADO_NO;
		
		private string _APELLIDO;
		
		private string _FUNCION;
		
		private string _T;
		
		private string _SALARIO;
		
		public PLANTILLA()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="Int")]
		public System.Nullable<int> HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this._HOSPITAL_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALA_COD", DbType="NVarChar(50)")]
		public string SALA_COD
		{
			get
			{
				return this._SALA_COD;
			}
			set
			{
				if ((this._SALA_COD != value))
				{
					this._SALA_COD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPLEADO_NO", DbType="NVarChar(50)")]
		public string EMPLEADO_NO
		{
			get
			{
				return this._EMPLEADO_NO;
			}
			set
			{
				if ((this._EMPLEADO_NO != value))
				{
					this._EMPLEADO_NO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDO", DbType="NVarChar(50)")]
		public string APELLIDO
		{
			get
			{
				return this._APELLIDO;
			}
			set
			{
				if ((this._APELLIDO != value))
				{
					this._APELLIDO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FUNCION", DbType="NVarChar(50)")]
		public string FUNCION
		{
			get
			{
				return this._FUNCION;
			}
			set
			{
				if ((this._FUNCION != value))
				{
					this._FUNCION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_T", DbType="NVarChar(50)")]
		public string T
		{
			get
			{
				return this._T;
			}
			set
			{
				if ((this._T != value))
				{
					this._T = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALARIO", DbType="NVarChar(50)")]
		public string SALARIO
		{
			get
			{
				return this._SALARIO;
			}
			set
			{
				if ((this._SALARIO != value))
				{
					this._SALARIO = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOSPITAL")]
	public partial class HOSPITAL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HOSPITAL_COD;
		
		private string _NOMBRE;
		
		private string _DIRECCION;
		
		private string _TELEFONO;
		
		private string _NUM_CAMA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHOSPITAL_CODChanging(int value);
    partial void OnHOSPITAL_CODChanged();
    partial void OnNOMBREChanging(string value);
    partial void OnNOMBREChanged();
    partial void OnDIRECCIONChanging(string value);
    partial void OnDIRECCIONChanged();
    partial void OnTELEFONOChanging(string value);
    partial void OnTELEFONOChanged();
    partial void OnNUM_CAMAChanging(string value);
    partial void OnNUM_CAMAChanged();
    #endregion
		
		public HOSPITAL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HOSPITAL_COD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int HOSPITAL_COD
		{
			get
			{
				return this._HOSPITAL_COD;
			}
			set
			{
				if ((this._HOSPITAL_COD != value))
				{
					this.OnHOSPITAL_CODChanging(value);
					this.SendPropertyChanging();
					this._HOSPITAL_COD = value;
					this.SendPropertyChanged("HOSPITAL_COD");
					this.OnHOSPITAL_CODChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this.OnNOMBREChanging(value);
					this.SendPropertyChanging();
					this._NOMBRE = value;
					this.SendPropertyChanged("NOMBRE");
					this.OnNOMBREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIRECCION", DbType="NVarChar(50)")]
		public string DIRECCION
		{
			get
			{
				return this._DIRECCION;
			}
			set
			{
				if ((this._DIRECCION != value))
				{
					this.OnDIRECCIONChanging(value);
					this.SendPropertyChanging();
					this._DIRECCION = value;
					this.SendPropertyChanged("DIRECCION");
					this.OnDIRECCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TELEFONO", DbType="NVarChar(50)")]
		public string TELEFONO
		{
			get
			{
				return this._TELEFONO;
			}
			set
			{
				if ((this._TELEFONO != value))
				{
					this.OnTELEFONOChanging(value);
					this.SendPropertyChanging();
					this._TELEFONO = value;
					this.SendPropertyChanged("TELEFONO");
					this.OnTELEFONOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUM_CAMA", DbType="NVarChar(50)")]
		public string NUM_CAMA
		{
			get
			{
				return this._NUM_CAMA;
			}
			set
			{
				if ((this._NUM_CAMA != value))
				{
					this.OnNUM_CAMAChanging(value);
					this.SendPropertyChanging();
					this._NUM_CAMA = value;
					this.SendPropertyChanged("NUM_CAMA");
					this.OnNUM_CAMAChanged();
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

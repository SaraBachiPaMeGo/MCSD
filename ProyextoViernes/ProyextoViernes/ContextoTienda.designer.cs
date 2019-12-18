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

namespace ProyextoViernes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Tienda")]
	public partial class ContextoTiendaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ContextoTiendaDataContext() : 
				base(global::ProyextoViernes.Properties.Settings.Default.TiendaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTiendaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTiendaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTiendaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContextoTiendaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Clientes
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clientes")]
	public partial class Cliente
	{
		
		private string _CodigoCliente;
		
		private string _Empresa;
		
		private string _Contacto;
		
		private string _Cargo;
		
		private string _Ciudad;
		
		private System.Nullable<int> _Telefono;
		
		public Cliente()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodigoCliente", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CodigoCliente
		{
			get
			{
				return this._CodigoCliente;
			}
			set
			{
				if ((this._CodigoCliente != value))
				{
					this._CodigoCliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empresa", DbType="NVarChar(MAX)")]
		public string Empresa
		{
			get
			{
				return this._Empresa;
			}
			set
			{
				if ((this._Empresa != value))
				{
					this._Empresa = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contacto", DbType="NVarChar(MAX)")]
		public string Contacto
		{
			get
			{
				return this._Contacto;
			}
			set
			{
				if ((this._Contacto != value))
				{
					this._Contacto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="NVarChar(MAX)")]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this._Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ciudad", DbType="NVarChar(MAX)")]
		public string Ciudad
		{
			get
			{
				return this._Ciudad;
			}
			set
			{
				if ((this._Ciudad != value))
				{
					this._Ciudad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int")]
		public System.Nullable<int> Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
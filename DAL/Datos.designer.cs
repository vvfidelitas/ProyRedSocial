﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProyRedSocial")]
	public partial class DatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DatosDataContext() : 
				base(global::DAL.Properties.Settings.Default.ProyRedSocialConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ActualizarROL")]
		public int ActualizarROL([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolID", DbType="Int")] System.Nullable<int> rolID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreRol", DbType="VarChar(20)")] string nombreRol)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), rolID, nombreRol);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarROL")]
		public int EliminarROL([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolID", DbType="Int")] System.Nullable<int> rolID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), rolID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ActualizarUSUARIOS")]
		public int ActualizarUSUARIOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(15)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApellidoUsuario", DbType="VarChar(30)")] string apellidoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelefonoUsuario", DbType="Int")] System.Nullable<int> telefonoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CorreoUsuario", DbType="VarChar(20)")] string correoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaNacimiento", DbType="DateTime")] System.Nullable<System.DateTime> fechaNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Genero", DbType="VarChar(10)")] string genero, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PassUsuario", DbType="VarChar(20)")] string passUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha_Registro", DbType="DateTime")] System.Nullable<System.DateTime> fecha_Registro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Rol_ID", DbType="Int")] System.Nullable<int> rol_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID, nombreUsuario, apellidoUsuario, telefonoUsuario, correoUsuario, fechaNacimiento, genero, passUsuario, fecha_Registro, rol_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultaROL")]
		public ISingleResult<ConsultaROLResult> ConsultaROL([global::System.Data.Linq.Mapping.ParameterAttribute(Name="RolID", DbType="Int")] System.Nullable<int> rolID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), rolID);
			return ((ISingleResult<ConsultaROLResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultarROL")]
		public ISingleResult<ConsultarROLResult> ConsultarROL()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ConsultarROLResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultarUSUARIOS")]
		public ISingleResult<ConsultarUSUARIOSResult> ConsultarUSUARIOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ConsultarUSUARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ConsultaUSUARIOS")]
		public ISingleResult<ConsultaUSUARIOSResult> ConsultaUSUARIOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((ISingleResult<ConsultaUSUARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CrearROL")]
		public int CrearROL([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreRol", DbType="VarChar(20)")] string nombreRol)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreRol);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.CrearUSUARIOS")]
		public int CrearUSUARIOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreUsuario", DbType="VarChar(15)")] string nombreUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ApellidoUsuario", DbType="VarChar(30)")] string apellidoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelefonoUsuario", DbType="Int")] System.Nullable<int> telefonoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CorreoUsuario", DbType="VarChar(20)")] string correoUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaNacimiento", DbType="DateTime")] System.Nullable<System.DateTime> fechaNacimiento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Genero", DbType="VarChar(10)")] string genero, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PassUsuario", DbType="VarChar(20)")] string passUsuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecha_Registro", DbType="DateTime")] System.Nullable<System.DateTime> fecha_Registro, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Rol_ID", DbType="Int")] System.Nullable<int> rol_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreUsuario, apellidoUsuario, telefonoUsuario, correoUsuario, fechaNacimiento, genero, passUsuario, fecha_Registro, rol_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarUSUARIOS")]
		public int EliminarUSUARIOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UsuarioID", DbType="Int")] System.Nullable<int> usuarioID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuarioID);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class ConsultaROLResult
	{
		
		private int _RolID;
		
		private string _NombreRol;
		
		public ConsultaROLResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					this._RolID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreRol", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string NombreRol
		{
			get
			{
				return this._NombreRol;
			}
			set
			{
				if ((this._NombreRol != value))
				{
					this._NombreRol = value;
				}
			}
		}
	}
	
	public partial class ConsultarROLResult
	{
		
		private int _RolID;
		
		private string _NombreRol;
		
		public ConsultarROLResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RolID", DbType="Int NOT NULL")]
		public int RolID
		{
			get
			{
				return this._RolID;
			}
			set
			{
				if ((this._RolID != value))
				{
					this._RolID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreRol", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string NombreRol
		{
			get
			{
				return this._NombreRol;
			}
			set
			{
				if ((this._NombreRol != value))
				{
					this._NombreRol = value;
				}
			}
		}
	}
	
	public partial class ConsultarUSUARIOSResult
	{
		
		private int _UsuarioID;
		
		private string _NombreUsuario;
		
		private string _ApellidoUsuario;
		
		private int _TelefonoUsuario;
		
		private string _CorreoUsuario;
		
		private System.DateTime _FechaNacimiento;
		
		private string _Genero;
		
		private string _PassUsuario;
		
		private System.DateTime _Fecha_Registro;
		
		private int _Rol_ID;
		
		public ConsultarUSUARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this._NombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoUsuario", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string ApellidoUsuario
		{
			get
			{
				return this._ApellidoUsuario;
			}
			set
			{
				if ((this._ApellidoUsuario != value))
				{
					this._ApellidoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelefonoUsuario", DbType="Int NOT NULL")]
		public int TelefonoUsuario
		{
			get
			{
				return this._TelefonoUsuario;
			}
			set
			{
				if ((this._TelefonoUsuario != value))
				{
					this._TelefonoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoUsuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CorreoUsuario
		{
			get
			{
				return this._CorreoUsuario;
			}
			set
			{
				if ((this._CorreoUsuario != value))
				{
					this._CorreoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaNacimiento", DbType="DateTime NOT NULL")]
		public System.DateTime FechaNacimiento
		{
			get
			{
				return this._FechaNacimiento;
			}
			set
			{
				if ((this._FechaNacimiento != value))
				{
					this._FechaNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassUsuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PassUsuario
		{
			get
			{
				return this._PassUsuario;
			}
			set
			{
				if ((this._PassUsuario != value))
				{
					this._PassUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Registro", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha_Registro
		{
			get
			{
				return this._Fecha_Registro;
			}
			set
			{
				if ((this._Fecha_Registro != value))
				{
					this._Fecha_Registro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rol_ID", DbType="Int NOT NULL")]
		public int Rol_ID
		{
			get
			{
				return this._Rol_ID;
			}
			set
			{
				if ((this._Rol_ID != value))
				{
					this._Rol_ID = value;
				}
			}
		}
	}
	
	public partial class ConsultaUSUARIOSResult
	{
		
		private int _UsuarioID;
		
		private string _NombreUsuario;
		
		private string _ApellidoUsuario;
		
		private int _TelefonoUsuario;
		
		private string _CorreoUsuario;
		
		private System.DateTime _FechaNacimiento;
		
		private string _Genero;
		
		private string _PassUsuario;
		
		private System.DateTime _Fecha_Registro;
		
		private int _Rol_ID;
		
		public ConsultaUSUARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsuarioID", DbType="Int NOT NULL")]
		public int UsuarioID
		{
			get
			{
				return this._UsuarioID;
			}
			set
			{
				if ((this._UsuarioID != value))
				{
					this._UsuarioID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreUsuario", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string NombreUsuario
		{
			get
			{
				return this._NombreUsuario;
			}
			set
			{
				if ((this._NombreUsuario != value))
				{
					this._NombreUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoUsuario", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string ApellidoUsuario
		{
			get
			{
				return this._ApellidoUsuario;
			}
			set
			{
				if ((this._ApellidoUsuario != value))
				{
					this._ApellidoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelefonoUsuario", DbType="Int NOT NULL")]
		public int TelefonoUsuario
		{
			get
			{
				return this._TelefonoUsuario;
			}
			set
			{
				if ((this._TelefonoUsuario != value))
				{
					this._TelefonoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CorreoUsuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string CorreoUsuario
		{
			get
			{
				return this._CorreoUsuario;
			}
			set
			{
				if ((this._CorreoUsuario != value))
				{
					this._CorreoUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaNacimiento", DbType="DateTime NOT NULL")]
		public System.DateTime FechaNacimiento
		{
			get
			{
				return this._FechaNacimiento;
			}
			set
			{
				if ((this._FechaNacimiento != value))
				{
					this._FechaNacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassUsuario", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string PassUsuario
		{
			get
			{
				return this._PassUsuario;
			}
			set
			{
				if ((this._PassUsuario != value))
				{
					this._PassUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Registro", DbType="DateTime NOT NULL")]
		public System.DateTime Fecha_Registro
		{
			get
			{
				return this._Fecha_Registro;
			}
			set
			{
				if ((this._Fecha_Registro != value))
				{
					this._Fecha_Registro = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rol_ID", DbType="Int NOT NULL")]
		public int Rol_ID
		{
			get
			{
				return this._Rol_ID;
			}
			set
			{
				if ((this._Rol_ID != value))
				{
					this._Rol_ID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

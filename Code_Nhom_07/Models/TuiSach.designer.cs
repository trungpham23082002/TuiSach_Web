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

namespace Code_Nhom_07.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_TUISACH")]
	public partial class TuiSachDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCHITIETDONHANG(CHITIETDONHANG instance);
    partial void UpdateCHITIETDONHANG(CHITIETDONHANG instance);
    partial void DeleteCHITIETDONHANG(CHITIETDONHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertPHANLOAI(PHANLOAI instance);
    partial void UpdatePHANLOAI(PHANLOAI instance);
    partial void DeletePHANLOAI(PHANLOAI instance);
    partial void InsertTUISACH(TUISACH instance);
    partial void UpdateTUISACH(TUISACH instance);
    partial void DeleteTUISACH(TUISACH instance);
    partial void InsertTHUONGHIEU(THUONGHIEU instance);
    partial void UpdateTHUONGHIEU(THUONGHIEU instance);
    partial void DeleteTHUONGHIEU(THUONGHIEU instance);
    #endregion
		
		public TuiSachDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_TUISACHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TuiSachDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TuiSachDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TuiSachDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TuiSachDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<PHANLOAI> PHANLOAIs
		{
			get
			{
				return this.GetTable<PHANLOAI>();
			}
		}
		
		public System.Data.Linq.Table<TUISACH> TUISACHes
		{
			get
			{
				return this.GetTable<TUISACH>();
			}
		}
		
		public System.Data.Linq.Table<THUONGHIEU> THUONGHIEUs
		{
			get
			{
				return this.GetTable<THUONGHIEU>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONHANG")]
	public partial class CHITIETDONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<int> _MaTuiSach;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _DonGia;
		
		private System.Nullable<double> _Thue;
		
		private System.Nullable<int> _MaKhachHang;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private System.Nullable<System.DateTime> _NgayGiao;
		
		private System.Nullable<System.DateTime> _NgayThanhToan;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
		private EntityRef<TUISACH> _TUISACH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnMaTuiSachChanging(System.Nullable<int> value);
    partial void OnMaTuiSachChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(System.Nullable<decimal> value);
    partial void OnDonGiaChanged();
    partial void OnThueChanging(System.Nullable<double> value);
    partial void OnThueChanged();
    partial void OnMaKhachHangChanging(System.Nullable<int> value);
    partial void OnMaKhachHangChanged();
    partial void OnNgayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapChanged();
    partial void OnNgayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGiaoChanged();
    partial void OnNgayThanhToanChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayThanhToanChanged();
    #endregion
		
		public CHITIETDONHANG()
		{
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			this._TUISACH = default(EntityRef<TUISACH>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTuiSach", DbType="Int")]
		public System.Nullable<int> MaTuiSach
		{
			get
			{
				return this._MaTuiSach;
			}
			set
			{
				if ((this._MaTuiSach != value))
				{
					if (this._TUISACH.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaTuiSachChanging(value);
					this.SendPropertyChanging();
					this._MaTuiSach = value;
					this.SendPropertyChanged("MaTuiSach");
					this.OnMaTuiSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Money")]
		public System.Nullable<decimal> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thue", DbType="Float")]
		public System.Nullable<double> Thue
		{
			get
			{
				return this._Thue;
			}
			set
			{
				if ((this._Thue != value))
				{
					this.OnThueChanging(value);
					this.SendPropertyChanging();
					this._Thue = value;
					this.SendPropertyChanged("Thue");
					this.OnThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="Int")]
		public System.Nullable<int> MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="Date")]
		public System.Nullable<System.DateTime> NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="Date")]
		public System.Nullable<System.DateTime> NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayThanhToan", DbType="Date")]
		public System.Nullable<System.DateTime> NgayThanhToan
		{
			get
			{
				return this._NgayThanhToan;
			}
			set
			{
				if ((this._NgayThanhToan != value))
				{
					this.OnNgayThanhToanChanging(value);
					this.SendPropertyChanging();
					this._NgayThanhToan = value;
					this.SendPropertyChanged("NgayThanhToan");
					this.OnNgayThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_CHITIETDONHANG", Storage="_KHACHHANG", ThisKey="MaKhachHang", OtherKey="MaKhachHang", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.CHITIETDONHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONHANGs.Add(this);
						this._MaKhachHang = value.MaKhachHang;
					}
					else
					{
						this._MaKhachHang = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUISACH_CHITIETDONHANG", Storage="_TUISACH", ThisKey="MaTuiSach", OtherKey="MaTuiSach", IsForeignKey=true)]
		public TUISACH TUISACH
		{
			get
			{
				return this._TUISACH.Entity;
			}
			set
			{
				TUISACH previousValue = this._TUISACH.Entity;
				if (((previousValue != value) 
							|| (this._TUISACH.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TUISACH.Entity = null;
						previousValue.CHITIETDONHANGs.Remove(this);
					}
					this._TUISACH.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONHANGs.Add(this);
						this._MaTuiSach = value.MaTuiSach;
					}
					else
					{
						this._MaTuiSach = default(Nullable<int>);
					}
					this.SendPropertyChanged("TUISACH");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKhachHang;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _GioiTinh;
		
		private string _DienThoai;
		
		private string _TaiKhoan;
		
		private string _MatKhau;
		
		private string _Email;
		
		private string _DiaChi;
		
		private string _AnhKhachHang;
		
		private EntitySet<CHITIETDONHANG> _CHITIETDONHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachHangChanging(int value);
    partial void OnMaKhachHangChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnAnhKhachHangChanging(string value);
    partial void OnAnhKhachHangChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._CHITIETDONHANGs = new EntitySet<CHITIETDONHANG>(new Action<CHITIETDONHANG>(this.attach_CHITIETDONHANGs), new Action<CHITIETDONHANG>(this.detach_CHITIETDONHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhachHang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKhachHang
		{
			get
			{
				return this._MaKhachHang;
			}
			set
			{
				if ((this._MaKhachHang != value))
				{
					this.OnMaKhachHangChanging(value);
					this.SendPropertyChanging();
					this._MaKhachHang = value;
					this.SendPropertyChanged("MaKhachHang");
					this.OnMaKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="NVarChar(20)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="NVarChar(30)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(30)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhKhachHang", DbType="NVarChar(50)")]
		public string AnhKhachHang
		{
			get
			{
				return this._AnhKhachHang;
			}
			set
			{
				if ((this._AnhKhachHang != value))
				{
					this.OnAnhKhachHangChanging(value);
					this.SendPropertyChanging();
					this._AnhKhachHang = value;
					this.SendPropertyChanged("AnhKhachHang");
					this.OnAnhKhachHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_CHITIETDONHANG", Storage="_CHITIETDONHANGs", ThisKey="MaKhachHang", OtherKey="MaKhachHang")]
		public EntitySet<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this._CHITIETDONHANGs;
			}
			set
			{
				this._CHITIETDONHANGs.Assign(value);
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
		
		private void attach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHANLOAI")]
	public partial class PHANLOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoai;
		
		private string _TenLoai;
		
		private string _GioiTinh;
		
		private EntitySet<TUISACH> _TUISACHes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(int value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    #endregion
		
		public PHANLOAI()
		{
			this._TUISACHes = new EntitySet<TUISACH>(new Action<TUISACH>(this.attach_TUISACHes), new Action<TUISACH>(this.detach_TUISACHes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANLOAI_TUISACH", Storage="_TUISACHes", ThisKey="MaLoai", OtherKey="MaLoai")]
		public EntitySet<TUISACH> TUISACHes
		{
			get
			{
				return this._TUISACHes;
			}
			set
			{
				this._TUISACHes.Assign(value);
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
		
		private void attach_TUISACHes(TUISACH entity)
		{
			this.SendPropertyChanging();
			entity.PHANLOAI = this;
		}
		
		private void detach_TUISACHes(TUISACH entity)
		{
			this.SendPropertyChanging();
			entity.PHANLOAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TUISACH")]
	public partial class TUISACH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTuiSach;
		
		private string _TenTuiSach;
		
		private System.Nullable<int> _MaThuongHieu;
		
		private string _HinhAnh;
		
		private string _XuatXu;
		
		private System.Nullable<int> _GiaBan;
		
		private System.Nullable<int> _MaLoai;
		
		private string _ChatLieu;
		
		private string _ChieuCao;
		
		private string _ChieuRong;
		
		private string _ChieuDai;
		
		private string _MauSac;
		
		private string _MoTa;
		
		private EntitySet<CHITIETDONHANG> _CHITIETDONHANGs;
		
		private EntityRef<PHANLOAI> _PHANLOAI;
		
		private EntityRef<THUONGHIEU> _THUONGHIEU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTuiSachChanging(int value);
    partial void OnMaTuiSachChanged();
    partial void OnTenTuiSachChanging(string value);
    partial void OnTenTuiSachChanged();
    partial void OnMaThuongHieuChanging(System.Nullable<int> value);
    partial void OnMaThuongHieuChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnXuatXuChanging(string value);
    partial void OnXuatXuChanged();
    partial void OnGiaBanChanging(System.Nullable<int> value);
    partial void OnGiaBanChanged();
    partial void OnMaLoaiChanging(System.Nullable<int> value);
    partial void OnMaLoaiChanged();
    partial void OnChatLieuChanging(string value);
    partial void OnChatLieuChanged();
    partial void OnChieuCaoChanging(string value);
    partial void OnChieuCaoChanged();
    partial void OnChieuRongChanging(string value);
    partial void OnChieuRongChanged();
    partial void OnChieuDaiChanging(string value);
    partial void OnChieuDaiChanged();
    partial void OnMauSacChanging(string value);
    partial void OnMauSacChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public TUISACH()
		{
			this._CHITIETDONHANGs = new EntitySet<CHITIETDONHANG>(new Action<CHITIETDONHANG>(this.attach_CHITIETDONHANGs), new Action<CHITIETDONHANG>(this.detach_CHITIETDONHANGs));
			this._PHANLOAI = default(EntityRef<PHANLOAI>);
			this._THUONGHIEU = default(EntityRef<THUONGHIEU>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTuiSach", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaTuiSach
		{
			get
			{
				return this._MaTuiSach;
			}
			set
			{
				if ((this._MaTuiSach != value))
				{
					this.OnMaTuiSachChanging(value);
					this.SendPropertyChanging();
					this._MaTuiSach = value;
					this.SendPropertyChanged("MaTuiSach");
					this.OnMaTuiSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTuiSach", DbType="NVarChar(MAX)")]
		public string TenTuiSach
		{
			get
			{
				return this._TenTuiSach;
			}
			set
			{
				if ((this._TenTuiSach != value))
				{
					this.OnTenTuiSachChanging(value);
					this.SendPropertyChanging();
					this._TenTuiSach = value;
					this.SendPropertyChanged("TenTuiSach");
					this.OnTenTuiSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThuongHieu", DbType="Int")]
		public System.Nullable<int> MaThuongHieu
		{
			get
			{
				return this._MaThuongHieu;
			}
			set
			{
				if ((this._MaThuongHieu != value))
				{
					if (this._THUONGHIEU.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaThuongHieuChanging(value);
					this.SendPropertyChanging();
					this._MaThuongHieu = value;
					this.SendPropertyChanged("MaThuongHieu");
					this.OnMaThuongHieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(50)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XuatXu", DbType="NVarChar(30)")]
		public string XuatXu
		{
			get
			{
				return this._XuatXu;
			}
			set
			{
				if ((this._XuatXu != value))
				{
					this.OnXuatXuChanging(value);
					this.SendPropertyChanging();
					this._XuatXu = value;
					this.SendPropertyChanged("XuatXu");
					this.OnXuatXuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Int")]
		public System.Nullable<int> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="Int")]
		public System.Nullable<int> MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._PHANLOAI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatLieu", DbType="NVarChar(30)")]
		public string ChatLieu
		{
			get
			{
				return this._ChatLieu;
			}
			set
			{
				if ((this._ChatLieu != value))
				{
					this.OnChatLieuChanging(value);
					this.SendPropertyChanging();
					this._ChatLieu = value;
					this.SendPropertyChanged("ChatLieu");
					this.OnChatLieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChieuCao", DbType="NVarChar(10)")]
		public string ChieuCao
		{
			get
			{
				return this._ChieuCao;
			}
			set
			{
				if ((this._ChieuCao != value))
				{
					this.OnChieuCaoChanging(value);
					this.SendPropertyChanging();
					this._ChieuCao = value;
					this.SendPropertyChanged("ChieuCao");
					this.OnChieuCaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChieuRong", DbType="NVarChar(10)")]
		public string ChieuRong
		{
			get
			{
				return this._ChieuRong;
			}
			set
			{
				if ((this._ChieuRong != value))
				{
					this.OnChieuRongChanging(value);
					this.SendPropertyChanging();
					this._ChieuRong = value;
					this.SendPropertyChanged("ChieuRong");
					this.OnChieuRongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChieuDai", DbType="NVarChar(10)")]
		public string ChieuDai
		{
			get
			{
				return this._ChieuDai;
			}
			set
			{
				if ((this._ChieuDai != value))
				{
					this.OnChieuDaiChanging(value);
					this.SendPropertyChanging();
					this._ChieuDai = value;
					this.SendPropertyChanged("ChieuDai");
					this.OnChieuDaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MauSac", DbType="NVarChar(20)")]
		public string MauSac
		{
			get
			{
				return this._MauSac;
			}
			set
			{
				if ((this._MauSac != value))
				{
					this.OnMauSacChanging(value);
					this.SendPropertyChanging();
					this._MauSac = value;
					this.SendPropertyChanged("MauSac");
					this.OnMauSacChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TUISACH_CHITIETDONHANG", Storage="_CHITIETDONHANGs", ThisKey="MaTuiSach", OtherKey="MaTuiSach")]
		public EntitySet<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this._CHITIETDONHANGs;
			}
			set
			{
				this._CHITIETDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANLOAI_TUISACH", Storage="_PHANLOAI", ThisKey="MaLoai", OtherKey="MaLoai", IsForeignKey=true)]
		public PHANLOAI PHANLOAI
		{
			get
			{
				return this._PHANLOAI.Entity;
			}
			set
			{
				PHANLOAI previousValue = this._PHANLOAI.Entity;
				if (((previousValue != value) 
							|| (this._PHANLOAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHANLOAI.Entity = null;
						previousValue.TUISACHes.Remove(this);
					}
					this._PHANLOAI.Entity = value;
					if ((value != null))
					{
						value.TUISACHes.Add(this);
						this._MaLoai = value.MaLoai;
					}
					else
					{
						this._MaLoai = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHANLOAI");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THUONGHIEU_TUISACH", Storage="_THUONGHIEU", ThisKey="MaThuongHieu", OtherKey="MaThuongHieu", IsForeignKey=true)]
		public THUONGHIEU THUONGHIEU
		{
			get
			{
				return this._THUONGHIEU.Entity;
			}
			set
			{
				THUONGHIEU previousValue = this._THUONGHIEU.Entity;
				if (((previousValue != value) 
							|| (this._THUONGHIEU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._THUONGHIEU.Entity = null;
						previousValue.TUISACHes.Remove(this);
					}
					this._THUONGHIEU.Entity = value;
					if ((value != null))
					{
						value.TUISACHes.Add(this);
						this._MaThuongHieu = value.MaThuongHieu;
					}
					else
					{
						this._MaThuongHieu = default(Nullable<int>);
					}
					this.SendPropertyChanged("THUONGHIEU");
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
		
		private void attach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TUISACH = this;
		}
		
		private void detach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.TUISACH = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THUONGHIEU")]
	public partial class THUONGHIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaThuongHieu;
		
		private string _TenThuongHieu;
		
		private string _LichSu;
		
		private string _HinhAnhThuongHieu;
		
		private EntitySet<TUISACH> _TUISACHes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaThuongHieuChanging(int value);
    partial void OnMaThuongHieuChanged();
    partial void OnTenThuongHieuChanging(string value);
    partial void OnTenThuongHieuChanged();
    partial void OnLichSuChanging(string value);
    partial void OnLichSuChanged();
    partial void OnHinhAnhThuongHieuChanging(string value);
    partial void OnHinhAnhThuongHieuChanged();
    #endregion
		
		public THUONGHIEU()
		{
			this._TUISACHes = new EntitySet<TUISACH>(new Action<TUISACH>(this.attach_TUISACHes), new Action<TUISACH>(this.detach_TUISACHes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThuongHieu", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaThuongHieu
		{
			get
			{
				return this._MaThuongHieu;
			}
			set
			{
				if ((this._MaThuongHieu != value))
				{
					this.OnMaThuongHieuChanging(value);
					this.SendPropertyChanging();
					this._MaThuongHieu = value;
					this.SendPropertyChanged("MaThuongHieu");
					this.OnMaThuongHieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenThuongHieu", DbType="NVarChar(30)")]
		public string TenThuongHieu
		{
			get
			{
				return this._TenThuongHieu;
			}
			set
			{
				if ((this._TenThuongHieu != value))
				{
					this.OnTenThuongHieuChanging(value);
					this.SendPropertyChanging();
					this._TenThuongHieu = value;
					this.SendPropertyChanged("TenThuongHieu");
					this.OnTenThuongHieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LichSu", DbType="NVarChar(MAX)")]
		public string LichSu
		{
			get
			{
				return this._LichSu;
			}
			set
			{
				if ((this._LichSu != value))
				{
					this.OnLichSuChanging(value);
					this.SendPropertyChanging();
					this._LichSu = value;
					this.SendPropertyChanged("LichSu");
					this.OnLichSuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnhThuongHieu", DbType="NVarChar(50)")]
		public string HinhAnhThuongHieu
		{
			get
			{
				return this._HinhAnhThuongHieu;
			}
			set
			{
				if ((this._HinhAnhThuongHieu != value))
				{
					this.OnHinhAnhThuongHieuChanging(value);
					this.SendPropertyChanging();
					this._HinhAnhThuongHieu = value;
					this.SendPropertyChanged("HinhAnhThuongHieu");
					this.OnHinhAnhThuongHieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THUONGHIEU_TUISACH", Storage="_TUISACHes", ThisKey="MaThuongHieu", OtherKey="MaThuongHieu")]
		public EntitySet<TUISACH> TUISACHes
		{
			get
			{
				return this._TUISACHes;
			}
			set
			{
				this._TUISACHes.Assign(value);
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
		
		private void attach_TUISACHes(TUISACH entity)
		{
			this.SendPropertyChanging();
			entity.THUONGHIEU = this;
		}
		
		private void detach_TUISACHes(TUISACH entity)
		{
			this.SendPropertyChanging();
			entity.THUONGHIEU = null;
		}
	}
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeriesDisk
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SERIESTV")]
	public partial class SeriesDisqueDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void Insertt_serie(t_serie instance);
    partial void Updatet_serie(t_serie instance);
    partial void Deletet_serie(t_serie instance);
    partial void Insertt_disque(t_disque instance);
    partial void Updatet_disque(t_disque instance);
    partial void Deletet_disque(t_disque instance);
    #endregion
		
		public SeriesDisqueDataContext() : 
				base(global::SeriesDisk.Properties.Settings.Default.SERIESTVConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SeriesDisqueDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SeriesDisqueDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SeriesDisqueDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SeriesDisqueDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<t_serie> t_serie
		{
			get
			{
				return this.GetTable<t_serie>();
			}
		}
		
		public System.Data.Linq.Table<t_disque> t_disque
		{
			get
			{
				return this.GetTable<t_disque>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_serie")]
	public partial class t_serie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _serie_id;
		
		private string _serie_nom;
		
		private int _serie_an;
		
		private int _disque_id;
		
		private System.DateTime _serie_maj;
		
		private EntityRef<t_disque> _t_disque;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onserie_idChanging(int value);
    partial void Onserie_idChanged();
    partial void Onserie_nomChanging(string value);
    partial void Onserie_nomChanged();
    partial void Onserie_anChanging(int value);
    partial void Onserie_anChanged();
    partial void Ondisque_idChanging(int value);
    partial void Ondisque_idChanged();
    partial void Onserie_majChanging(System.DateTime value);
    partial void Onserie_majChanged();
    #endregion
		
		public t_serie()
		{
			this._t_disque = default(EntityRef<t_disque>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serie_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int serie_id
		{
			get
			{
				return this._serie_id;
			}
			set
			{
				if ((this._serie_id != value))
				{
					this.Onserie_idChanging(value);
					this.SendPropertyChanging();
					this._serie_id = value;
					this.SendPropertyChanged("serie_id");
					this.Onserie_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serie_nom", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string serie_nom
		{
			get
			{
				return this._serie_nom;
			}
			set
			{
				if ((this._serie_nom != value))
				{
					this.Onserie_nomChanging(value);
					this.SendPropertyChanging();
					this._serie_nom = value;
					this.SendPropertyChanged("serie_nom");
					this.Onserie_nomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serie_an", DbType="Int NOT NULL")]
		public int serie_an
		{
			get
			{
				return this._serie_an;
			}
			set
			{
				if ((this._serie_an != value))
				{
					this.Onserie_anChanging(value);
					this.SendPropertyChanging();
					this._serie_an = value;
					this.SendPropertyChanged("serie_an");
					this.Onserie_anChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disque_id", DbType="Int NOT NULL")]
		public int disque_id
		{
			get
			{
				return this._disque_id;
			}
			set
			{
				if ((this._disque_id != value))
				{
					if (this._t_disque.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondisque_idChanging(value);
					this.SendPropertyChanging();
					this._disque_id = value;
					this.SendPropertyChanged("disque_id");
					this.Ondisque_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serie_maj", DbType="SmallDateTime NOT NULL")]
		public System.DateTime serie_maj
		{
			get
			{
				return this._serie_maj;
			}
			set
			{
				if ((this._serie_maj != value))
				{
					this.Onserie_majChanging(value);
					this.SendPropertyChanging();
					this._serie_maj = value;
					this.SendPropertyChanged("serie_maj");
					this.Onserie_majChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="t_disque_t_serie", Storage="_t_disque", ThisKey="disque_id", OtherKey="disque_id", IsForeignKey=true)]
		public t_disque t_disque
		{
			get
			{
				return this._t_disque.Entity;
			}
			set
			{
				t_disque previousValue = this._t_disque.Entity;
				if (((previousValue != value) 
							|| (this._t_disque.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._t_disque.Entity = null;
						previousValue.t_serie.Remove(this);
					}
					this._t_disque.Entity = value;
					if ((value != null))
					{
						value.t_serie.Add(this);
						this._disque_id = value.disque_id;
					}
					else
					{
						this._disque_id = default(int);
					}
					this.SendPropertyChanged("t_disque");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_disque")]
	public partial class t_disque : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _disque_id;
		
		private string _disque_vol_name;
		
		private System.DateTime _disque_maj;
		
		private EntitySet<t_serie> _t_serie;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ondisque_idChanging(int value);
    partial void Ondisque_idChanged();
    partial void Ondisque_vol_nameChanging(string value);
    partial void Ondisque_vol_nameChanged();
    partial void Ondisque_majChanging(System.DateTime value);
    partial void Ondisque_majChanged();
    #endregion
		
		public t_disque()
		{
			this._t_serie = new EntitySet<t_serie>(new Action<t_serie>(this.attach_t_serie), new Action<t_serie>(this.detach_t_serie));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disque_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int disque_id
		{
			get
			{
				return this._disque_id;
			}
			set
			{
				if ((this._disque_id != value))
				{
					this.Ondisque_idChanging(value);
					this.SendPropertyChanging();
					this._disque_id = value;
					this.SendPropertyChanged("disque_id");
					this.Ondisque_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disque_vol_name", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string disque_vol_name
		{
			get
			{
				return this._disque_vol_name;
			}
			set
			{
				if ((this._disque_vol_name != value))
				{
					this.Ondisque_vol_nameChanging(value);
					this.SendPropertyChanging();
					this._disque_vol_name = value;
					this.SendPropertyChanged("disque_vol_name");
					this.Ondisque_vol_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_disque_maj", DbType="SmallDateTime NOT NULL")]
		public System.DateTime disque_maj
		{
			get
			{
				return this._disque_maj;
			}
			set
			{
				if ((this._disque_maj != value))
				{
					this.Ondisque_majChanging(value);
					this.SendPropertyChanging();
					this._disque_maj = value;
					this.SendPropertyChanged("disque_maj");
					this.Ondisque_majChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="t_disque_t_serie", Storage="_t_serie", ThisKey="disque_id", OtherKey="disque_id")]
		public EntitySet<t_serie> t_serie
		{
			get
			{
				return this._t_serie;
			}
			set
			{
				this._t_serie.Assign(value);
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
		
		private void attach_t_serie(t_serie entity)
		{
			this.SendPropertyChanging();
			entity.t_disque = this;
		}
		
		private void detach_t_serie(t_serie entity)
		{
			this.SendPropertyChanging();
			entity.t_disque = null;
		}
	}
}
#pragma warning restore 1591

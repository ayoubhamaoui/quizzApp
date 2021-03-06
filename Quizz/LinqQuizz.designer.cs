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

namespace Quizz
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="quizz")]
	public partial class LinqQuizzDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmatiere(matiere instance);
    partial void Updatematiere(matiere instance);
    partial void Deletematiere(matiere instance);
    partial void Insertquestion(question instance);
    partial void Updatequestion(question instance);
    partial void Deletequestion(question instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void Insertresult(result instance);
    partial void Updateresult(result instance);
    partial void Deleteresult(result instance);
    #endregion
		
		public LinqQuizzDataContext() : 
				base(global::Quizz.Properties.Settings.Default.quizzConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqQuizzDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqQuizzDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqQuizzDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqQuizzDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<matiere> matieres
		{
			get
			{
				return this.GetTable<matiere>();
			}
		}
		
		public System.Data.Linq.Table<question> questions
		{
			get
			{
				return this.GetTable<question>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<result> results
		{
			get
			{
				return this.GetTable<result>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.matieres")]
	public partial class matiere : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_m;
		
		private string _label;
		
		private EntitySet<question> _questions;
		
		private EntitySet<result> _results;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_mChanging(string value);
    partial void Onid_mChanged();
    partial void OnlabelChanging(string value);
    partial void OnlabelChanged();
    #endregion
		
		public matiere()
		{
			this._questions = new EntitySet<question>(new Action<question>(this.attach_questions), new Action<question>(this.detach_questions));
			this._results = new EntitySet<result>(new Action<result>(this.attach_results), new Action<result>(this.detach_results));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_m", DbType="VarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_m
		{
			get
			{
				return this._id_m;
			}
			set
			{
				if ((this._id_m != value))
				{
					this.Onid_mChanging(value);
					this.SendPropertyChanging();
					this._id_m = value;
					this.SendPropertyChanged("id_m");
					this.Onid_mChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_label", DbType="VarChar(55)")]
		public string label
		{
			get
			{
				return this._label;
			}
			set
			{
				if ((this._label != value))
				{
					this.OnlabelChanging(value);
					this.SendPropertyChanging();
					this._label = value;
					this.SendPropertyChanged("label");
					this.OnlabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="matiere_question", Storage="_questions", ThisKey="id_m", OtherKey="id_m")]
		public EntitySet<question> questions
		{
			get
			{
				return this._questions;
			}
			set
			{
				this._questions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="matiere_result", Storage="_results", ThisKey="id_m", OtherKey="id_m")]
		public EntitySet<result> results
		{
			get
			{
				return this._results;
			}
			set
			{
				this._results.Assign(value);
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
		
		private void attach_questions(question entity)
		{
			this.SendPropertyChanging();
			entity.matiere = this;
		}
		
		private void detach_questions(question entity)
		{
			this.SendPropertyChanging();
			entity.matiere = null;
		}
		
		private void attach_results(result entity)
		{
			this.SendPropertyChanging();
			entity.matiere = this;
		}
		
		private void detach_results(result entity)
		{
			this.SendPropertyChanging();
			entity.matiere = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.questions")]
	public partial class question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_q;
		
		private string _question1;
		
		private string _trueAnwer;
		
		private string _answer1;
		
		private string _answer2;
		
		private string _answer3;
		
		private string _id_m;
		
		private System.Nullable<int> _note;
		
		private EntityRef<matiere> _matiere;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_qChanging(int value);
    partial void Onid_qChanged();
    partial void Onquestion1Changing(string value);
    partial void Onquestion1Changed();
    partial void OntrueAnwerChanging(string value);
    partial void OntrueAnwerChanged();
    partial void Onanswer1Changing(string value);
    partial void Onanswer1Changed();
    partial void Onanswer2Changing(string value);
    partial void Onanswer2Changed();
    partial void Onanswer3Changing(string value);
    partial void Onanswer3Changed();
    partial void Onid_mChanging(string value);
    partial void Onid_mChanged();
    partial void OnnoteChanging(System.Nullable<int> value);
    partial void OnnoteChanged();
    #endregion
		
		public question()
		{
			this._matiere = default(EntityRef<matiere>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_q", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_q
		{
			get
			{
				return this._id_q;
			}
			set
			{
				if ((this._id_q != value))
				{
					this.Onid_qChanging(value);
					this.SendPropertyChanging();
					this._id_q = value;
					this.SendPropertyChanged("id_q");
					this.Onid_qChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="question", Storage="_question1", DbType="VarChar(500)")]
		public string question1
		{
			get
			{
				return this._question1;
			}
			set
			{
				if ((this._question1 != value))
				{
					this.Onquestion1Changing(value);
					this.SendPropertyChanging();
					this._question1 = value;
					this.SendPropertyChanged("question1");
					this.Onquestion1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trueAnwer", DbType="VarChar(500)")]
		public string trueAnwer
		{
			get
			{
				return this._trueAnwer;
			}
			set
			{
				if ((this._trueAnwer != value))
				{
					this.OntrueAnwerChanging(value);
					this.SendPropertyChanging();
					this._trueAnwer = value;
					this.SendPropertyChanged("trueAnwer");
					this.OntrueAnwerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer1", DbType="VarChar(500)")]
		public string answer1
		{
			get
			{
				return this._answer1;
			}
			set
			{
				if ((this._answer1 != value))
				{
					this.Onanswer1Changing(value);
					this.SendPropertyChanging();
					this._answer1 = value;
					this.SendPropertyChanged("answer1");
					this.Onanswer1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer2", DbType="VarChar(500)")]
		public string answer2
		{
			get
			{
				return this._answer2;
			}
			set
			{
				if ((this._answer2 != value))
				{
					this.Onanswer2Changing(value);
					this.SendPropertyChanging();
					this._answer2 = value;
					this.SendPropertyChanged("answer2");
					this.Onanswer2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_answer3", DbType="VarChar(500)")]
		public string answer3
		{
			get
			{
				return this._answer3;
			}
			set
			{
				if ((this._answer3 != value))
				{
					this.Onanswer3Changing(value);
					this.SendPropertyChanging();
					this._answer3 = value;
					this.SendPropertyChanged("answer3");
					this.Onanswer3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_m", DbType="VarChar(25)")]
		public string id_m
		{
			get
			{
				return this._id_m;
			}
			set
			{
				if ((this._id_m != value))
				{
					if (this._matiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_mChanging(value);
					this.SendPropertyChanging();
					this._id_m = value;
					this.SendPropertyChanged("id_m");
					this.Onid_mChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_note", DbType="Int")]
		public System.Nullable<int> note
		{
			get
			{
				return this._note;
			}
			set
			{
				if ((this._note != value))
				{
					this.OnnoteChanging(value);
					this.SendPropertyChanging();
					this._note = value;
					this.SendPropertyChanged("note");
					this.OnnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="matiere_question", Storage="_matiere", ThisKey="id_m", OtherKey="id_m", IsForeignKey=true)]
		public matiere matiere
		{
			get
			{
				return this._matiere.Entity;
			}
			set
			{
				matiere previousValue = this._matiere.Entity;
				if (((previousValue != value) 
							|| (this._matiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._matiere.Entity = null;
						previousValue.questions.Remove(this);
					}
					this._matiere.Entity = value;
					if ((value != null))
					{
						value.questions.Add(this);
						this._id_m = value.id_m;
					}
					else
					{
						this._id_m = default(string);
					}
					this.SendPropertyChanged("matiere");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_u;
		
		private string _mdp;
		
		private EntitySet<result> _results;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_uChanging(string value);
    partial void Onid_uChanged();
    partial void OnmdpChanging(string value);
    partial void OnmdpChanged();
    #endregion
		
		public user()
		{
			this._results = new EntitySet<result>(new Action<result>(this.attach_results), new Action<result>(this.detach_results));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_u", DbType="VarChar(55) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_u
		{
			get
			{
				return this._id_u;
			}
			set
			{
				if ((this._id_u != value))
				{
					this.Onid_uChanging(value);
					this.SendPropertyChanging();
					this._id_u = value;
					this.SendPropertyChanged("id_u");
					this.Onid_uChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mdp", DbType="VarChar(25)")]
		public string mdp
		{
			get
			{
				return this._mdp;
			}
			set
			{
				if ((this._mdp != value))
				{
					this.OnmdpChanging(value);
					this.SendPropertyChanging();
					this._mdp = value;
					this.SendPropertyChanged("mdp");
					this.OnmdpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_result", Storage="_results", ThisKey="id_u", OtherKey="id_u")]
		public EntitySet<result> results
		{
			get
			{
				return this._results;
			}
			set
			{
				this._results.Assign(value);
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
		
		private void attach_results(result entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_results(result entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.result")]
	public partial class result : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _id_u;
		
		private string _id_m;
		
		private System.Nullable<double> _note;
		
		private EntityRef<matiere> _matiere;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_uChanging(string value);
    partial void Onid_uChanged();
    partial void Onid_mChanging(string value);
    partial void Onid_mChanged();
    partial void OnnoteChanging(System.Nullable<double> value);
    partial void OnnoteChanged();
    #endregion
		
		public result()
		{
			this._matiere = default(EntityRef<matiere>);
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_u", DbType="VarChar(55)")]
		public string id_u
		{
			get
			{
				return this._id_u;
			}
			set
			{
				if ((this._id_u != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_uChanging(value);
					this.SendPropertyChanging();
					this._id_u = value;
					this.SendPropertyChanged("id_u");
					this.Onid_uChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_m", DbType="VarChar(25)")]
		public string id_m
		{
			get
			{
				return this._id_m;
			}
			set
			{
				if ((this._id_m != value))
				{
					if (this._matiere.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_mChanging(value);
					this.SendPropertyChanging();
					this._id_m = value;
					this.SendPropertyChanged("id_m");
					this.Onid_mChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_note", DbType="Float")]
		public System.Nullable<double> note
		{
			get
			{
				return this._note;
			}
			set
			{
				if ((this._note != value))
				{
					this.OnnoteChanging(value);
					this.SendPropertyChanging();
					this._note = value;
					this.SendPropertyChanged("note");
					this.OnnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="matiere_result", Storage="_matiere", ThisKey="id_m", OtherKey="id_m", IsForeignKey=true)]
		public matiere matiere
		{
			get
			{
				return this._matiere.Entity;
			}
			set
			{
				matiere previousValue = this._matiere.Entity;
				if (((previousValue != value) 
							|| (this._matiere.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._matiere.Entity = null;
						previousValue.results.Remove(this);
					}
					this._matiere.Entity = value;
					if ((value != null))
					{
						value.results.Add(this);
						this._id_m = value.id_m;
					}
					else
					{
						this._id_m = default(string);
					}
					this.SendPropertyChanged("matiere");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_result", Storage="_user", ThisKey="id_u", OtherKey="id_u", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.results.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.results.Add(this);
						this._id_u = value.id_u;
					}
					else
					{
						this._id_u = default(string);
					}
					this.SendPropertyChanged("user");
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

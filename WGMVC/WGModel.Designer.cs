﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("WGModel", "FK_WgProducts_WGCategories1", "WGCategories", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(WGMVC.WGCategory), "WgProducts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WGMVC.WgProduct), true)]
[assembly: EdmRelationshipAttribute("WGModel", "FK_WgProducts_WGStatus1", "WGStatus", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WGMVC.WGStatu), "WgProducts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WGMVC.WgProduct), true)]
[assembly: EdmRelationshipAttribute("WGModel", "FK_WgProducts_WGVendors1", "WGVendors", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(WGMVC.WGVendor), "WgProducts", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(WGMVC.WgProduct), true)]

#endregion

namespace WGMVC
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class WGEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new WGEntities object using the connection string found in the 'WGEntities' section of the application configuration file.
        /// </summary>
        public WGEntities() : base("name=WGEntities", "WGEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WGEntities object.
        /// </summary>
        public WGEntities(string connectionString) : base(connectionString, "WGEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new WGEntities object.
        /// </summary>
        public WGEntities(EntityConnection connection) : base(connection, "WGEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WGCategory> WGCategories
        {
            get
            {
                if ((_WGCategories == null))
                {
                    _WGCategories = base.CreateObjectSet<WGCategory>("WGCategories");
                }
                return _WGCategories;
            }
        }
        private ObjectSet<WGCategory> _WGCategories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WgProduct> WgProducts
        {
            get
            {
                if ((_WgProducts == null))
                {
                    _WgProducts = base.CreateObjectSet<WgProduct>("WgProducts");
                }
                return _WgProducts;
            }
        }
        private ObjectSet<WgProduct> _WgProducts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WGStatu> WGStatus
        {
            get
            {
                if ((_WGStatus == null))
                {
                    _WGStatus = base.CreateObjectSet<WGStatu>("WGStatus");
                }
                return _WGStatus;
            }
        }
        private ObjectSet<WGStatu> _WGStatus;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<WGVendor> WGVendors
        {
            get
            {
                if ((_WGVendors == null))
                {
                    _WGVendors = base.CreateObjectSet<WGVendor>("WGVendors");
                }
                return _WGVendors;
            }
        }
        private ObjectSet<WGVendor> _WGVendors;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WGCategories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWGCategories(WGCategory wGCategory)
        {
            base.AddObject("WGCategories", wGCategory);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WgProducts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWgProducts(WgProduct wgProduct)
        {
            base.AddObject("WgProducts", wgProduct);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WGStatus EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWGStatus(WGStatu wGStatu)
        {
            base.AddObject("WGStatus", wGStatu);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the WGVendors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWGVendors(WGVendor wGVendor)
        {
            base.AddObject("WGVendors", wGVendor);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WGModel", Name="WGCategory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WGCategory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WGCategory object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static WGCategory CreateWGCategory(global::System.Int32 id, global::System.String name)
        {
            WGCategory wGCategory = new WGCategory();
            wGCategory.Id = id;
            wGCategory.Name = name;
            return wGCategory;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGCategories1", "WgProducts")]
        public EntityCollection<WgProduct> WgProducts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGCategories1", "WgProducts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGCategories1", "WgProducts", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WGModel", Name="WgProduct")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WgProduct : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WgProduct object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        /// <param name="vendorID">Initial value of the VendorID property.</param>
        /// <param name="statusID">Initial value of the StatusID property.</param>
        public static WgProduct CreateWgProduct(global::System.Int32 id, global::System.String name, global::System.Decimal price, global::System.Int32 vendorID, global::System.Int32 statusID)
        {
            WgProduct wgProduct = new WgProduct();
            wgProduct.ID = id;
            wgProduct.name = name;
            wgProduct.Price = price;
            wgProduct.VendorID = vendorID;
            wgProduct.StatusID = statusID;
            return wgProduct;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false, "name");
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true, "Description");
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, "Price");
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ImageUrl
        {
            get
            {
                return _ImageUrl;
            }
            set
            {
                OnImageUrlChanging(value);
                ReportPropertyChanging("ImageUrl");
                _ImageUrl = StructuralObject.SetValidValue(value, true, "ImageUrl");
                ReportPropertyChanged("ImageUrl");
                OnImageUrlChanged();
            }
        }
        private global::System.String _ImageUrl;
        partial void OnImageUrlChanging(global::System.String value);
        partial void OnImageUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoryID
        {
            get
            {
                return _CategoryID;
            }
            set
            {
                OnCategoryIDChanging(value);
                ReportPropertyChanging("CategoryID");
                _CategoryID = StructuralObject.SetValidValue(value, "CategoryID");
                ReportPropertyChanged("CategoryID");
                OnCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoryID;
        partial void OnCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 VendorID
        {
            get
            {
                return _VendorID;
            }
            set
            {
                OnVendorIDChanging(value);
                ReportPropertyChanging("VendorID");
                _VendorID = StructuralObject.SetValidValue(value, "VendorID");
                ReportPropertyChanged("VendorID");
                OnVendorIDChanged();
            }
        }
        private global::System.Int32 _VendorID;
        partial void OnVendorIDChanging(global::System.Int32 value);
        partial void OnVendorIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StatusID
        {
            get
            {
                return _StatusID;
            }
            set
            {
                OnStatusIDChanging(value);
                ReportPropertyChanging("StatusID");
                _StatusID = StructuralObject.SetValidValue(value, "StatusID");
                ReportPropertyChanged("StatusID");
                OnStatusIDChanged();
            }
        }
        private global::System.Int32 _StatusID;
        partial void OnStatusIDChanging(global::System.Int32 value);
        partial void OnStatusIDChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGCategories1", "WGCategories")]
        public WGCategory WGCategory
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGCategory>("WGModel.FK_WgProducts_WGCategories1", "WGCategories").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGCategory>("WGModel.FK_WgProducts_WGCategories1", "WGCategories").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WGCategory> WGCategoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGCategory>("WGModel.FK_WgProducts_WGCategories1", "WGCategories");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WGCategory>("WGModel.FK_WgProducts_WGCategories1", "WGCategories", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGStatus1", "WGStatus")]
        public WGStatu WGStatu
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGStatu>("WGModel.FK_WgProducts_WGStatus1", "WGStatus").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGStatu>("WGModel.FK_WgProducts_WGStatus1", "WGStatus").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WGStatu> WGStatuReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGStatu>("WGModel.FK_WgProducts_WGStatus1", "WGStatus");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WGStatu>("WGModel.FK_WgProducts_WGStatus1", "WGStatus", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGVendors1", "WGVendors")]
        public WGVendor WGVendor
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGVendor>("WGModel.FK_WgProducts_WGVendors1", "WGVendors").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGVendor>("WGModel.FK_WgProducts_WGVendors1", "WGVendors").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<WGVendor> WGVendorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<WGVendor>("WGModel.FK_WgProducts_WGVendors1", "WGVendors");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<WGVendor>("WGModel.FK_WgProducts_WGVendors1", "WGVendors", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WGModel", Name="WGStatu")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WGStatu : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WGStatu object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static WGStatu CreateWGStatu(global::System.Int32 id, global::System.String name)
        {
            WGStatu wGStatu = new WGStatu();
            wGStatu.ID = id;
            wGStatu.Name = name;
            return wGStatu;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGStatus1", "WgProducts")]
        public EntityCollection<WgProduct> WgProducts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGStatus1", "WgProducts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGStatus1", "WgProducts", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="WGModel", Name="WGVendor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WGVendor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new WGVendor object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="website">Initial value of the Website property.</param>
        public static WGVendor CreateWGVendor(global::System.Int32 id, global::System.String name, global::System.String website)
        {
            WGVendor wGVendor = new WGVendor();
            wGVendor.ID = id;
            wGVendor.Name = name;
            wGVendor.Website = website;
            return wGVendor;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Website
        {
            get
            {
                return _Website;
            }
            set
            {
                OnWebsiteChanging(value);
                ReportPropertyChanging("Website");
                _Website = StructuralObject.SetValidValue(value, false, "Website");
                ReportPropertyChanged("Website");
                OnWebsiteChanged();
            }
        }
        private global::System.String _Website;
        partial void OnWebsiteChanging(global::System.String value);
        partial void OnWebsiteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LogoUrl
        {
            get
            {
                return _LogoUrl;
            }
            set
            {
                OnLogoUrlChanging(value);
                ReportPropertyChanging("LogoUrl");
                _LogoUrl = StructuralObject.SetValidValue(value, true, "LogoUrl");
                ReportPropertyChanged("LogoUrl");
                OnLogoUrlChanged();
            }
        }
        private global::System.String _LogoUrl;
        partial void OnLogoUrlChanging(global::System.String value);
        partial void OnLogoUrlChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("WGModel", "FK_WgProducts_WGVendors1", "WgProducts")]
        public EntityCollection<WgProduct> WgProducts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGVendors1", "WgProducts");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<WgProduct>("WGModel.FK_WgProducts_WGVendors1", "WgProducts", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
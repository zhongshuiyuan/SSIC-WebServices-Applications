﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArtDatabanken.WebService.SwedishSpeciesObservationService {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AuthorityTaxaKey")]
        public string AuthorityTaxaCacheKey {
            get {
                return ((string)(this["AuthorityTaxaCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BirdNestActivities")]
        public string BirdNestActivitiesCacheKey {
            get {
                return ((string)(this["BirdNestActivitiesCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BirdNestActivityIdMin {
            get {
                return ((int)(this["BirdNestActivityIdMin"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public int BirdNestActivityIdMax {
            get {
                return ((int)(this["BirdNestActivityIdMax"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25000")]
        public long MaxPageSize {
            get {
                return ((long)(this["MaxPageSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public long MaxProtectedSpeciesObservationIndications {
            get {
                return ((long)(this["MaxProtectedSpeciesObservationIndications"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000000")]
        public long MaxSpeciesObservation {
            get {
                return ((long)(this["MaxSpeciesObservation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25000")]
        public long MaxSpeciesObservationWithInformation {
            get {
                return ((long)(this["MaxSpeciesObservationWithInformation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ProtectedSpeciesObservationIndicationTaxaKey")]
        public string ProtectedSpeciesObservationIndicationTaxaCacheKey {
            get {
                return ((string)(this["ProtectedSpeciesObservationIndicationTaxaCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ProtectedTaxaKey")]
        public string ProtectedTaxaCacheKey {
            get {
                return ((string)(this["ProtectedTaxaCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesActivities")]
        public string SpeciesActivitiesCacheKey {
            get {
                return ((string)(this["SpeciesActivitiesCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesActivityCategories")]
        public string SpeciesActivityCategoriesCacheKey {
            get {
                return ((string)(this["SpeciesActivityCategoriesCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SSODTaxonTree")]
        public string TaxonTreeCacheKey {
            get {
                return ((string)(this["TaxonTreeCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SSODTaxonTreeNode")]
        public string TaxonTreeNodeCacheKey {
            get {
                return ((string)(this["TaxonTreeNodeCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MinActiveActionPlanId {
            get {
                return ((int)(this["MinActiveActionPlanId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int MaxActiveActionPlanId {
            get {
                return ((int)(this["MaxActiveActionPlanId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int RefreshIntervalElasticsearch {
            get {
                return ((int)(this["RefreshIntervalElasticsearch"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesObservationExcludedFieldsKey")]
        public string SpeciesObservationExcludedFieldsCacheKey {
            get {
                return ((string)(this["SpeciesObservationExcludedFieldsCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesObservationDarwinCoreFieldsKey")]
        public string SpeciesObservationDarwinCoreFieldsCacheKey {
            get {
                return ((string)(this["SpeciesObservationDarwinCoreFieldsCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ProtectedSpeciesObservationIndicationFieldsKey")]
        public string ProtectedSpeciesObservationIndicationFieldsCacheKey {
            get {
                return ((string)(this["ProtectedSpeciesObservationIndicationFieldsCacheKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesObservationFieldDescriptionsKey")]
        public string SpeciesObservationFieldDescriptionsCacheKey {
            get {
                return ((string)(this["SpeciesObservationFieldDescriptionsCacheKey"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesObservationProvinceRegionsKey")]
        public string SpeciesObservationProvinceRegionsCacheKey
        {
            get
            {
                return ((string)(this["SpeciesObservationProvinceRegionsCacheKey"]));
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SpeciesObservationCountyRegionsKey")]
        public string SpeciesObservationCountyRegionsCacheKey
        {
            get
            {
                return ((string)(this["SpeciesObservationCountyRegionsCacheKey"]));
            }
        }
    }
}
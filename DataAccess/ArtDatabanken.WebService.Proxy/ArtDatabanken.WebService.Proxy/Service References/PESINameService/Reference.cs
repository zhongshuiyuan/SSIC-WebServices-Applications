﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1570
#pragma warning disable 1571
#pragma warning disable 1572
#pragma warning disable 1573
#pragma warning disable 1587
#pragma warning disable 1591

namespace ArtDatabanken.WebService.Proxy.PESINameService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://PESI/v0.5", ConfigurationName="PESINameService.PESINameServicePortType")]
    public interface PESINameServicePortType {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/GUID) of message getGUIDRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        ArtDatabanken.WebService.Proxy.PESINameService.getGUIDResponse getGUID(ArtDatabanken.WebService.Proxy.PESINameService.getGUIDRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIRecords) of message getPESIRecordsRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESIRecords", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsResponse getPESIRecords(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIName) of message getPESINameByGUIDRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESINameByGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDResponse getPESINameByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIRecord) of message getPESIRecordByGUIDRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESIRecordByGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDResponse getPESIRecordByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIRecords) of message getPESIRecordsByVernacularRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESIRecordsByVernacular", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularResponse getPESIRecordsByVernacular(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIVernaculars) of message getPESIVernacularsByGUIDRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESIVernacularsByGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDResponse getPESIVernacularsByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIRecords) of message matchTaxonRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="matchTaxon", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonResponse matchTaxon(ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://PESI/v0.5/PESIRecords) of message getPESISynonymsByGUIDRequest does not match the default value (http://PESI/v0.5)
        [System.ServiceModel.OperationContractAttribute(Action="getPESISynonymsByGUID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Vernacular))]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDResponse getPESISynonymsByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getGUID", WrapperNamespace="http://PESI/v0.5/GUID", IsWrapped=true)]
    public partial class getGUIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string scientificname;
        
        public getGUIDRequest() {
        }
        
        public getGUIDRequest(string scientificname) {
            this.scientificname = scientificname;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getGUIDResponse", WrapperNamespace="http://PESI/v0.5/GUID", IsWrapped=true)]
    public partial class getGUIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public getGUIDResponse() {
        }
        
        public getGUIDResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://PESI/v0.5")]
    public partial class PESIRecord : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string gUIDField;
        
        private string urlField;
        
        private string scientificnameField;
        
        private string authorityField;
        
        private string rankField;
        
        private string statusField;
        
        private string valid_guidField;
        
        private string valid_nameField;
        
        private string valid_authorityField;
        
        private string kingdomField;
        
        private string phylumField;
        
        private string classField;
        
        private string orderField;
        
        private string familyField;
        
        private string genusField;
        
        private string citationField;
        
        private string match_typeField;
        
        /// <remarks/>
        public string GUID {
            get {
                return this.gUIDField;
            }
            set {
                this.gUIDField = value;
                this.RaisePropertyChanged("GUID");
            }
        }
        
        /// <remarks/>
        public string url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("url");
            }
        }
        
        /// <remarks/>
        public string scientificname {
            get {
                return this.scientificnameField;
            }
            set {
                this.scientificnameField = value;
                this.RaisePropertyChanged("scientificname");
            }
        }
        
        /// <remarks/>
        public string authority {
            get {
                return this.authorityField;
            }
            set {
                this.authorityField = value;
                this.RaisePropertyChanged("authority");
            }
        }
        
        /// <remarks/>
        public string rank {
            get {
                return this.rankField;
            }
            set {
                this.rankField = value;
                this.RaisePropertyChanged("rank");
            }
        }
        
        /// <remarks/>
        public string status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
        
        /// <remarks/>
        public string valid_guid {
            get {
                return this.valid_guidField;
            }
            set {
                this.valid_guidField = value;
                this.RaisePropertyChanged("valid_guid");
            }
        }
        
        /// <remarks/>
        public string valid_name {
            get {
                return this.valid_nameField;
            }
            set {
                this.valid_nameField = value;
                this.RaisePropertyChanged("valid_name");
            }
        }
        
        /// <remarks/>
        public string valid_authority {
            get {
                return this.valid_authorityField;
            }
            set {
                this.valid_authorityField = value;
                this.RaisePropertyChanged("valid_authority");
            }
        }
        
        /// <remarks/>
        public string kingdom {
            get {
                return this.kingdomField;
            }
            set {
                this.kingdomField = value;
                this.RaisePropertyChanged("kingdom");
            }
        }
        
        /// <remarks/>
        public string phylum {
            get {
                return this.phylumField;
            }
            set {
                this.phylumField = value;
                this.RaisePropertyChanged("phylum");
            }
        }
        
        /// <remarks/>
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("class");
            }
        }
        
        /// <remarks/>
        public string order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
                this.RaisePropertyChanged("order");
            }
        }
        
        /// <remarks/>
        public string family {
            get {
                return this.familyField;
            }
            set {
                this.familyField = value;
                this.RaisePropertyChanged("family");
            }
        }
        
        /// <remarks/>
        public string genus {
            get {
                return this.genusField;
            }
            set {
                this.genusField = value;
                this.RaisePropertyChanged("genus");
            }
        }
        
        /// <remarks/>
        public string citation {
            get {
                return this.citationField;
            }
            set {
                this.citationField = value;
                this.RaisePropertyChanged("citation");
            }
        }
        
        /// <remarks/>
        public string match_type {
            get {
                return this.match_typeField;
            }
            set {
                this.match_typeField = value;
                this.RaisePropertyChanged("match_type");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://PESI/v0.5")]
    public partial class Vernacular : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string vernacularField;
        
        private string language_codeField;
        
        private string languageField;
        
        /// <remarks/>
        public string vernacular {
            get {
                return this.vernacularField;
            }
            set {
                this.vernacularField = value;
                this.RaisePropertyChanged("vernacular");
            }
        }
        
        /// <remarks/>
        public string language_code {
            get {
                return this.language_codeField;
            }
            set {
                this.language_codeField = value;
                this.RaisePropertyChanged("language_code");
            }
        }
        
        /// <remarks/>
        public string language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
                this.RaisePropertyChanged("language");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecords", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESIRecordsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string scientificname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public bool like;
        
        public getPESIRecordsRequest() {
        }
        
        public getPESIRecordsRequest(string scientificname, bool like) {
            this.scientificname = scientificname;
            this.like = like;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecordsResponse", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESIRecordsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public PESIRecord[] @return;
        
        public getPESIRecordsResponse() {
        }
        
        public getPESIRecordsResponse(PESIRecord[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESINameByGUID", WrapperNamespace="http://PESI/v0.5/PESIName", IsWrapped=true)]
    public partial class getPESINameByGUIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string GUID;
        
        public getPESINameByGUIDRequest() {
        }
        
        public getPESINameByGUIDRequest(string GUID) {
            this.GUID = GUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESINameByGUIDResponse", WrapperNamespace="http://PESI/v0.5/PESIName", IsWrapped=true)]
    public partial class getPESINameByGUIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string @return;
        
        public getPESINameByGUIDResponse() {
        }
        
        public getPESINameByGUIDResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecordByGUID", WrapperNamespace="http://PESI/v0.5/PESIRecord", IsWrapped=true)]
    public partial class getPESIRecordByGUIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string GUID;
        
        public getPESIRecordByGUIDRequest() {
        }
        
        public getPESIRecordByGUIDRequest(string GUID) {
            this.GUID = GUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecordByGUIDResponse", WrapperNamespace="http://PESI/v0.5/PESIRecord", IsWrapped=true)]
    public partial class getPESIRecordByGUIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public ArtDatabanken.WebService.Proxy.PESINameService.PESIRecord @return;
        
        public getPESIRecordByGUIDResponse() {
        }
        
        public getPESIRecordByGUIDResponse(ArtDatabanken.WebService.Proxy.PESINameService.PESIRecord @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecordsByVernacular", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESIRecordsByVernacularRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string vernacular;
        
        public getPESIRecordsByVernacularRequest() {
        }
        
        public getPESIRecordsByVernacularRequest(string vernacular) {
            this.vernacular = vernacular;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIRecordsByVernacularResponse", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESIRecordsByVernacularResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public PESIRecord[] @return;
        
        public getPESIRecordsByVernacularResponse() {
        }
        
        public getPESIRecordsByVernacularResponse(PESIRecord[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIVernacularsByGUID", WrapperNamespace="http://PESI/v0.5/PESIVernaculars", IsWrapped=true)]
    public partial class getPESIVernacularsByGUIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string GUID;
        
        public getPESIVernacularsByGUIDRequest() {
        }
        
        public getPESIVernacularsByGUIDRequest(string GUID) {
            this.GUID = GUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESIVernacularsByGUIDResponse", WrapperNamespace="http://PESI/v0.5/PESIVernaculars", IsWrapped=true)]
    public partial class getPESIVernacularsByGUIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public Vernacular[] @return;
        
        public getPESIVernacularsByGUIDResponse() {
        }
        
        public getPESIVernacularsByGUIDResponse(Vernacular[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="matchTaxon", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class matchTaxonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string scientificname;
        
        public matchTaxonRequest() {
        }
        
        public matchTaxonRequest(string scientificname) {
            this.scientificname = scientificname;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="matchTaxonResponse", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class matchTaxonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public PESIRecord[] @return;
        
        public matchTaxonResponse() {
        }
        
        public matchTaxonResponse(PESIRecord[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESISynonymsByGUID", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESISynonymsByGUIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string GUID;
        
        public getPESISynonymsByGUIDRequest() {
        }
        
        public getPESISynonymsByGUIDRequest(string GUID) {
            this.GUID = GUID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPESISynonymsByGUIDResponse", WrapperNamespace="http://PESI/v0.5/PESIRecords", IsWrapped=true)]
    public partial class getPESISynonymsByGUIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public PESIRecord[] @return;
        
        public getPESISynonymsByGUIDResponse() {
        }
        
        public getPESISynonymsByGUIDResponse(PESIRecord[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PESINameServicePortTypeChannel : ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PESINameServicePortTypeClient : System.ServiceModel.ClientBase<ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType>, ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType {
        
        public PESINameServicePortTypeClient() {
        }
        
        public PESINameServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PESINameServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PESINameServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PESINameServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getGUIDResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getGUID(ArtDatabanken.WebService.Proxy.PESINameService.getGUIDRequest request) {
            return base.Channel.getGUID(request);
        }
        
        public string getGUID(string scientificname) {
            ArtDatabanken.WebService.Proxy.PESINameService.getGUIDRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getGUIDRequest();
            inValue.scientificname = scientificname;
            ArtDatabanken.WebService.Proxy.PESINameService.getGUIDResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getGUID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESIRecords(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsRequest request) {
            return base.Channel.getPESIRecords(request);
        }
        
        public PESIRecord[] getPESIRecords(string scientificname, bool like) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsRequest();
            inValue.scientificname = scientificname;
            inValue.like = like;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESIRecords(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESINameByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDRequest request) {
            return base.Channel.getPESINameByGUID(request);
        }
        
        public string getPESINameByGUID(string GUID) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDRequest();
            inValue.GUID = GUID;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESINameByGUIDResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESINameByGUID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESIRecordByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDRequest request) {
            return base.Channel.getPESIRecordByGUID(request);
        }
        
        public ArtDatabanken.WebService.Proxy.PESINameService.PESIRecord getPESIRecordByGUID(string GUID) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDRequest();
            inValue.GUID = GUID;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordByGUIDResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESIRecordByGUID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESIRecordsByVernacular(ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularRequest request) {
            return base.Channel.getPESIRecordsByVernacular(request);
        }
        
        public PESIRecord[] getPESIRecordsByVernacular(string vernacular) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularRequest();
            inValue.vernacular = vernacular;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIRecordsByVernacularResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESIRecordsByVernacular(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESIVernacularsByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDRequest request) {
            return base.Channel.getPESIVernacularsByGUID(request);
        }
        
        public Vernacular[] getPESIVernacularsByGUID(string GUID) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDRequest();
            inValue.GUID = GUID;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESIVernacularsByGUIDResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESIVernacularsByGUID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.matchTaxon(ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonRequest request) {
            return base.Channel.matchTaxon(request);
        }
        
        public PESIRecord[] matchTaxon(string scientificname) {
            ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonRequest();
            inValue.scientificname = scientificname;
            ArtDatabanken.WebService.Proxy.PESINameService.matchTaxonResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).matchTaxon(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDResponse ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType.getPESISynonymsByGUID(ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDRequest request) {
            return base.Channel.getPESISynonymsByGUID(request);
        }
        
        public PESIRecord[] getPESISynonymsByGUID(string GUID) {
            ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDRequest inValue = new ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDRequest();
            inValue.GUID = GUID;
            ArtDatabanken.WebService.Proxy.PESINameService.getPESISynonymsByGUIDResponse retVal = ((ArtDatabanken.WebService.Proxy.PESINameService.PESINameServicePortType)(this)).getPESISynonymsByGUID(inValue);
            return retVal.@return;
        }
    }
}
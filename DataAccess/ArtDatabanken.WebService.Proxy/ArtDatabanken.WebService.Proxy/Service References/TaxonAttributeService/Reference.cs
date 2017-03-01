﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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

namespace ArtDatabanken.WebService.Proxy.TaxonAttributeService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:WebServices.ArtDatabanken.slu.se", ConfigurationName="TaxonAttributeService.ITaxonAttributeService", SessionMode=System.ServiceModel.SessionMode.NotAllowed)]
    public interface ITaxonAttributeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/ClearCache", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/ClearCacheResponse")]
        void ClearCache(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/CommitTransaction", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/CommitTransactionResp" +
            "onse")]
        void CommitTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/CreateSpeciesFacts", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/CreateSpeciesFactsRes" +
            "ponse")]
        void CreateSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, [System.ServiceModel.MessageParameterAttribute(Name="createSpeciesFacts")] System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> createSpeciesFacts1);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/DeleteSpeciesFacts", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/DeleteSpeciesFactsRes" +
            "ponse")]
        void DeleteSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, [System.ServiceModel.MessageParameterAttribute(Name="deleteSpeciesFacts")] System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> deleteSpeciesFacts1);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/DeleteTrace", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/DeleteTraceResponse")]
        void DeleteTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorDataTypes", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorDataTypesRes" +
            "ponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorDataType> GetFactorDataTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorFieldEnums", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorFieldEnumsRe" +
            "sponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorFieldEnum> GetFactorFieldEnums(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorFieldTypes", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorFieldTypesRe" +
            "sponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorFieldType> GetFactorFieldTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorOrigins", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorOriginsRespo" +
            "nse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorOrigin> GetFactorOrigins(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactors", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorsResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactor> GetFactors(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorsBySearchCri" +
            "teria", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorsBySearchCri" +
            "teriaResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactor> GetFactorsBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebFactorSearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorTrees", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorTreesRespons" +
            "e")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorTreeNode> GetFactorTrees(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorTreesBySearc" +
            "hCriteria", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorTreesBySearc" +
            "hCriteriaResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorTreeNode> GetFactorTreesBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebFactorTreeSearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorUpdateModes", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetFactorUpdateModesR" +
            "esponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorUpdateMode> GetFactorUpdateModes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetIndividualCategori" +
            "es", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetIndividualCategori" +
            "esResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebIndividualCategory> GetIndividualCategories(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetLog", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetLogResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebLogRow> GetLog(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.LogType type, string userName, int rowCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetPeriods", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetPeriodsResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebPeriod> GetPeriods(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetPeriodTypes", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetPeriodTypesRespons" +
            "e")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebPeriodType> GetPeriodTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactQualiti" +
            "es", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactQualiti" +
            "esResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFactQuality> GetSpeciesFactQualities(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsByIden" +
            "tifiers", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsByIden" +
            "tifiersResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsByIdentifiers(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> speciesFactIdentifiers);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsByIds", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsByIdsR" +
            "esponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsByIds(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<int> speciesFactIds);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsBySear" +
            "chCriteria", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetSpeciesFactsBySear" +
            "chCriteriaResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetStatus", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetStatusResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebResourceStatus> GetStatus(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetTaxaBySearchCriter" +
            "ia", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetTaxaBySearchCriter" +
            "iaResponse")]
        System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebTaxon> GetTaxaBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetTaxaCountBySearchC" +
            "riteria", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/GetTaxaCountBySearchC" +
            "riteriaResponse")]
        int GetTaxaCountBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/Login", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/LoginResponse")]
        ArtDatabanken.WebService.Data.WebLoginResponse Login(string userName, string password, string applicationIdentifier, bool isActivationRequired);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/Logout", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/LogoutResponse")]
        void Logout(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/Ping", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/PingResponse")]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/RollbackTransaction", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/RollbackTransactionRe" +
            "sponse")]
        void RollbackTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StartTrace", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StartTraceResponse")]
        void StartTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StartTransaction", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StartTransactionRespo" +
            "nse")]
        void StartTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, int timeout);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StopTrace", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/StopTraceResponse")]
        void StopTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/UpdateSpeciesFacts", ReplyAction="urn:WebServices.ArtDatabanken.slu.se/ITaxonAttributeService/UpdateSpeciesFactsRes" +
            "ponse")]
        void UpdateSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, [System.ServiceModel.MessageParameterAttribute(Name="updateSpeciesFacts")] System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> updateSpeciesFacts1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITaxonAttributeServiceChannel : ArtDatabanken.WebService.Proxy.TaxonAttributeService.ITaxonAttributeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaxonAttributeServiceClient : System.ServiceModel.ClientBase<ArtDatabanken.WebService.Proxy.TaxonAttributeService.ITaxonAttributeService>, ArtDatabanken.WebService.Proxy.TaxonAttributeService.ITaxonAttributeService {
        
        public TaxonAttributeServiceClient() {
        }
        
        public TaxonAttributeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaxonAttributeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaxonAttributeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaxonAttributeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ClearCache(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.ClearCache(clientInformation);
        }
        
        public void CommitTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.CommitTransaction(clientInformation);
        }
        
        public void CreateSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> createSpeciesFacts1) {
            base.Channel.CreateSpeciesFacts(clientInformation, createSpeciesFacts1);
        }
        
        public void DeleteSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> deleteSpeciesFacts1) {
            base.Channel.DeleteSpeciesFacts(clientInformation, deleteSpeciesFacts1);
        }
        
        public void DeleteTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.DeleteTrace(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorDataType> GetFactorDataTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorDataTypes(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorFieldEnum> GetFactorFieldEnums(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorFieldEnums(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorFieldType> GetFactorFieldTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorFieldTypes(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorOrigin> GetFactorOrigins(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorOrigins(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactor> GetFactors(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactors(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactor> GetFactorsBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebFactorSearchCriteria searchCriteria) {
            return base.Channel.GetFactorsBySearchCriteria(clientInformation, searchCriteria);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorTreeNode> GetFactorTrees(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorTrees(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorTreeNode> GetFactorTreesBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebFactorTreeSearchCriteria searchCriteria) {
            return base.Channel.GetFactorTreesBySearchCriteria(clientInformation, searchCriteria);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebFactorUpdateMode> GetFactorUpdateModes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetFactorUpdateModes(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebIndividualCategory> GetIndividualCategories(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetIndividualCategories(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebLogRow> GetLog(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.LogType type, string userName, int rowCount) {
            return base.Channel.GetLog(clientInformation, type, userName, rowCount);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebPeriod> GetPeriods(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetPeriods(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebPeriodType> GetPeriodTypes(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetPeriodTypes(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFactQuality> GetSpeciesFactQualities(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetSpeciesFactQualities(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsByIdentifiers(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> speciesFactIdentifiers) {
            return base.Channel.GetSpeciesFactsByIdentifiers(clientInformation, speciesFactIdentifiers);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsByIds(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<int> speciesFactIds) {
            return base.Channel.GetSpeciesFactsByIds(clientInformation, speciesFactIds);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> GetSpeciesFactsBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria) {
            return base.Channel.GetSpeciesFactsBySearchCriteria(clientInformation, searchCriteria);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebResourceStatus> GetStatus(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            return base.Channel.GetStatus(clientInformation);
        }
        
        public System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebTaxon> GetTaxaBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria) {
            return base.Channel.GetTaxaBySearchCriteria(clientInformation, searchCriteria);
        }
        
        public int GetTaxaCountBySearchCriteria(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, ArtDatabanken.WebService.Data.WebSpeciesFactSearchCriteria searchCriteria) {
            return base.Channel.GetTaxaCountBySearchCriteria(clientInformation, searchCriteria);
        }
        
        public ArtDatabanken.WebService.Data.WebLoginResponse Login(string userName, string password, string applicationIdentifier, bool isActivationRequired) {
            return base.Channel.Login(userName, password, applicationIdentifier, isActivationRequired);
        }
        
        public void Logout(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.Logout(clientInformation);
        }
        
        public bool Ping() {
            return base.Channel.Ping();
        }
        
        public void RollbackTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.RollbackTransaction(clientInformation);
        }
        
        public void StartTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, string userName) {
            base.Channel.StartTrace(clientInformation, userName);
        }
        
        public void StartTransaction(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, int timeout) {
            base.Channel.StartTransaction(clientInformation, timeout);
        }
        
        public void StopTrace(ArtDatabanken.WebService.Data.WebClientInformation clientInformation) {
            base.Channel.StopTrace(clientInformation);
        }
        
        public void UpdateSpeciesFacts(ArtDatabanken.WebService.Data.WebClientInformation clientInformation, System.Collections.Generic.List<ArtDatabanken.WebService.Data.WebSpeciesFact> updateSpeciesFacts1) {
            base.Channel.UpdateSpeciesFacts(clientInformation, updateSpeciesFacts1);
        }
    }
}
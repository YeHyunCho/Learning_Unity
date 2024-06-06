//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Core.Environments.Client.Http;



namespace Unity.Services.Core.Environments.Client.Models
{
    /// <summary>
    /// UnityProjectV1 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "unity.Project.v1")]
    internal class UnityProjectV1
    {
        /// <summary>
        /// Creates an instance of UnityProjectV1.
        /// </summary>
        /// <param name="id">ID of the project</param>
        /// <param name="genesisId">ID provided by Genesis, for a small number of projects this ID will not be a UUID for legacy reasons, so treat it as a string ID</param>
        /// <param name="name">Name of the project</param>
        /// <param name="coppa">COPPA value of the project, one of “unspecified”, “compliant”, or “not_compliant”</param>
        /// <param name="kidsStoreCompliance">Kids Store Compliance value for the project, true if either Apple Kids Category or Google Designed for Families is enabled</param>
        /// <param name="organizationId">ID of the organization where the project belongs to</param>
        /// <param name="organizationGenesisId">Organization ID provided by Genesis where the project belongs to</param>
        /// <param name="iconUrl">URL for the icon of the project (either a custom icon or a mobile store icon)</param>
        /// <param name="createdAt">UTC date and time describing when the entity was created</param>
        /// <param name="updatedAt">UTC date and time describing when the entity was last updated</param>
        /// <param name="archivedAt">UTC date and time describing when the entity was last archived (null if not archived)</param>
        /// <param name="defaultEnvironmentId">Default environment ID of the project</param>
        [Preserve]
        public UnityProjectV1(System.Guid id = default, string genesisId = default, string name = default, string coppa = default, bool kidsStoreCompliance = default, System.Guid organizationId = default, string organizationGenesisId = default, string iconUrl = default, DateTime createdAt = default, DateTime updatedAt = default, DateTime? archivedAt = default, System.Guid defaultEnvironmentId = default)
        {
            Id = id;
            GenesisId = genesisId;
            Name = name;
            Coppa = coppa;
            KidsStoreCompliance = kidsStoreCompliance;
            OrganizationId = organizationId;
            OrganizationGenesisId = organizationGenesisId;
            IconUrl = iconUrl;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ArchivedAt = archivedAt;
            DefaultEnvironmentId = defaultEnvironmentId;
        }

        /// <summary>
        /// ID of the project
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public System.Guid Id{ get; }
        
        /// <summary>
        /// ID provided by Genesis, for a small number of projects this ID will not be a UUID for legacy reasons, so treat it as a string ID
        /// </summary>
        [Preserve]
        [DataMember(Name = "genesisId", EmitDefaultValue = false)]
        public string GenesisId{ get; }
        
        /// <summary>
        /// Name of the project
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name{ get; }
        
        /// <summary>
        /// COPPA value of the project, one of “unspecified”, “compliant”, or “not_compliant”
        /// </summary>
        [Preserve]
        [DataMember(Name = "coppa", EmitDefaultValue = false)]
        public string Coppa{ get; }
        
        /// <summary>
        /// Kids Store Compliance value for the project, true if either Apple Kids Category or Google Designed for Families is enabled
        /// </summary>
        [Preserve]
        [DataMember(Name = "kidsStoreCompliance", EmitDefaultValue = true)]
        public bool KidsStoreCompliance{ get; }
        
        /// <summary>
        /// ID of the organization where the project belongs to
        /// </summary>
        [Preserve]
        [DataMember(Name = "organizationId", EmitDefaultValue = false)]
        public System.Guid OrganizationId{ get; }
        
        /// <summary>
        /// Organization ID provided by Genesis where the project belongs to
        /// </summary>
        [Preserve]
        [DataMember(Name = "organizationGenesisId", EmitDefaultValue = false)]
        public string OrganizationGenesisId{ get; }
        
        /// <summary>
        /// URL for the icon of the project (either a custom icon or a mobile store icon)
        /// </summary>
        [Preserve]
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl{ get; }
        
        /// <summary>
        /// UTC date and time describing when the entity was created
        /// </summary>
        [Preserve]
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt{ get; }
        
        /// <summary>
        /// UTC date and time describing when the entity was last updated
        /// </summary>
        [Preserve]
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt{ get; }
        
        /// <summary>
        /// UTC date and time describing when the entity was last archived (null if not archived)
        /// </summary>
        [Preserve]
        [DataMember(Name = "archivedAt", EmitDefaultValue = false)]
        public DateTime? ArchivedAt{ get; }
        
        /// <summary>
        /// Default environment ID of the project
        /// </summary>
        [Preserve]
        [DataMember(Name = "defaultEnvironmentId", EmitDefaultValue = false)]
        public System.Guid DefaultEnvironmentId{ get; }
    
        /// <summary>
        /// Formats a UnityProjectV1 into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Id != null)
            {
                serializedModel += "id," + Id + ",";
            }
            if (GenesisId != null)
            {
                serializedModel += "genesisId," + GenesisId + ",";
            }
            if (Name != null)
            {
                serializedModel += "name," + Name + ",";
            }
            if (Coppa != null)
            {
                serializedModel += "coppa," + Coppa + ",";
            }
            serializedModel += "kidsStoreCompliance," + KidsStoreCompliance.ToString() + ",";
            if (OrganizationId != null)
            {
                serializedModel += "organizationId," + OrganizationId + ",";
            }
            if (OrganizationGenesisId != null)
            {
                serializedModel += "organizationGenesisId," + OrganizationGenesisId + ",";
            }
            if (IconUrl != null)
            {
                serializedModel += "iconUrl," + IconUrl + ",";
            }
            if (CreatedAt != null)
            {
                serializedModel += "createdAt," + CreatedAt.ToString() + ",";
            }
            if (UpdatedAt != null)
            {
                serializedModel += "updatedAt," + UpdatedAt.ToString() + ",";
            }
            if (ArchivedAt != null)
            {
                serializedModel += "archivedAt," + ArchivedAt.ToString() + ",";
            }
            if (DefaultEnvironmentId != null)
            {
                serializedModel += "defaultEnvironmentId," + DefaultEnvironmentId;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a UnityProjectV1 as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Id != null)
            {
                var idStringValue = Id.ToString();
                dictionary.Add("id", idStringValue);
            }
            
            if (GenesisId != null)
            {
                var genesisIdStringValue = GenesisId.ToString();
                dictionary.Add("genesisId", genesisIdStringValue);
            }
            
            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            if (Coppa != null)
            {
                var coppaStringValue = Coppa.ToString();
                dictionary.Add("coppa", coppaStringValue);
            }
            
            var kidsStoreComplianceStringValue = KidsStoreCompliance.ToString();
            dictionary.Add("kidsStoreCompliance", kidsStoreComplianceStringValue);
            
            if (OrganizationId != null)
            {
                var organizationIdStringValue = OrganizationId.ToString();
                dictionary.Add("organizationId", organizationIdStringValue);
            }
            
            if (OrganizationGenesisId != null)
            {
                var organizationGenesisIdStringValue = OrganizationGenesisId.ToString();
                dictionary.Add("organizationGenesisId", organizationGenesisIdStringValue);
            }
            
            if (IconUrl != null)
            {
                var iconUrlStringValue = IconUrl.ToString();
                dictionary.Add("iconUrl", iconUrlStringValue);
            }
            
            if (CreatedAt != null)
            {
                var createdAtStringValue = CreatedAt.ToString();
                dictionary.Add("createdAt", createdAtStringValue);
            }
            
            if (UpdatedAt != null)
            {
                var updatedAtStringValue = UpdatedAt.ToString();
                dictionary.Add("updatedAt", updatedAtStringValue);
            }
            
            if (ArchivedAt != null)
            {
                var archivedAtStringValue = ArchivedAt.ToString();
                dictionary.Add("archivedAt", archivedAtStringValue);
            }
            
            if (DefaultEnvironmentId != null)
            {
                var defaultEnvironmentIdStringValue = DefaultEnvironmentId.ToString();
                dictionary.Add("defaultEnvironmentId", defaultEnvironmentIdStringValue);
            }
            
            return dictionary;
        }
    }
}

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
    /// UnityCreateEnvironmentRequest model
    /// </summary>
    [Preserve]
    [DataContract(Name = "unity_createEnvironment_request")]
    internal class UnityCreateEnvironmentRequest
    {
        /// <summary>
        /// Creates an instance of UnityCreateEnvironmentRequest.
        /// </summary>
        /// <param name="name">Name of the environment</param>
        [Preserve]
        public UnityCreateEnvironmentRequest(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name of the environment
        /// </summary>
        [Preserve]
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name{ get; }
    
        /// <summary>
        /// Formats a UnityCreateEnvironmentRequest into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Name != null)
            {
                serializedModel += "name," + Name;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a UnityCreateEnvironmentRequest as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Name != null)
            {
                var nameStringValue = Name.ToString();
                dictionary.Add("name", nameStringValue);
            }
            
            return dictionary;
        }
    }
}

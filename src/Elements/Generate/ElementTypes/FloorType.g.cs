//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Elements.ElementTypes
{
    #pragma warning disable // Disable all warnings

    using Elements.ElementTypes;
    using Elements.GeoJSON;
    using Elements.Geometry;
    using Elements.Geometry.Solids;
    using Elements.Properties;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    /// <summary>A container for properties common to floors.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class FloorType : ElementType
    {
        /// <summary>The material layers of the floor.</summary>
        [Newtonsoft.Json.JsonProperty("MaterialLayers", Required = Newtonsoft.Json.Required.AllowNull)]
        public  IList<MaterialLayer> MaterialLayers { get; internal set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static FloorType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FloorType>(data);
        }
    
    }
}
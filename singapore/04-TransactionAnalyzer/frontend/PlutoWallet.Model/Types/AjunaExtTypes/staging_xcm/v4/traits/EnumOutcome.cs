//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.staging_xcm.v4.traits
{
    
    
    /// <summary>
    /// >> Outcome
    /// </summary>
    public enum Outcome
    {
        
        /// <summary>
        /// >> Complete
        /// </summary>
        Complete = 0,
        
        /// <summary>
        /// >> Incomplete
        /// </summary>
        Incomplete = 1,
        
        /// <summary>
        /// >> Error
        /// </summary>
        Error = 2,
    }
    
    /// <summary>
    /// >> 516 - Variant[staging_xcm.v4.traits.Outcome]
    /// </summary>
    public sealed class EnumOutcome : BaseEnumExt<Outcome, Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight, BaseTuple<Substrate.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Generated.Model.xcm.v3.traits.EnumError>, Substrate.NetApi.Generated.Model.xcm.v3.traits.EnumError>
    {
    }
}

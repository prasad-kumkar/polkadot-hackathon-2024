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


namespace Bifrost.NetApi.Generated.Model.xcm.v2
{
    
    
    /// <summary>
    /// >> NetworkId
    /// </summary>
    public enum NetworkId
    {
        
        /// <summary>
        /// >> Any
        /// </summary>
        Any = 0,
        
        /// <summary>
        /// >> Named
        /// </summary>
        Named = 1,
        
        /// <summary>
        /// >> Polkadot
        /// </summary>
        Polkadot = 2,
        
        /// <summary>
        /// >> Kusama
        /// </summary>
        Kusama = 3,
    }
    
    /// <summary>
    /// >> 139 - Variant[xcm.v2.NetworkId]
    /// </summary>
    public sealed class EnumNetworkId : BaseEnumExt<NetworkId, BaseVoid, Bifrost.NetApi.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT1, BaseVoid, BaseVoid>
    {
    }
}

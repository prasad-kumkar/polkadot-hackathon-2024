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


namespace Substrate.NetApi.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Event
    {
        
        ProxyExecuted = 0,
        
        PureCreated = 1,
        
        Announced = 2,
        
        ProxyAdded = 3,
        
        ProxyRemoved = 4,
    }
    
    /// <summary>
    /// >> 78 - Variant[pallet_proxy.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.NetApi.Generated.Types.Base.EnumResult, BaseTuple<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U16>, BaseTuple<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumProxyType, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}

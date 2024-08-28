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


namespace Bifrost.NetApi.Generated.Model.bifrost_system_maker.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Charged
        /// </summary>
        Charged = 0,
        
        /// <summary>
        /// >> ConfigSet
        /// </summary>
        ConfigSet = 1,
        
        /// <summary>
        /// >> Closed
        /// </summary>
        Closed = 2,
        
        /// <summary>
        /// >> Paid
        /// </summary>
        Paid = 3,
        
        /// <summary>
        /// >> RedeemFailed
        /// </summary>
        RedeemFailed = 4,
    }
    
    /// <summary>
    /// >> 482 - Variant[bifrost_system_maker.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_system_maker.pallet.Info>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}

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


namespace Bifrost.NetApi.Generated.Model.bifrost_ve_minting.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ConfigSet
        /// </summary>
        ConfigSet = 0,
        
        /// <summary>
        /// >> Minted
        /// </summary>
        Minted = 1,
        
        /// <summary>
        /// >> Supply
        /// </summary>
        Supply = 2,
        
        /// <summary>
        /// >> LockCreated
        /// </summary>
        LockCreated = 3,
        
        /// <summary>
        /// >> UnlockTimeIncreased
        /// </summary>
        UnlockTimeIncreased = 4,
        
        /// <summary>
        /// >> AmountIncreased
        /// </summary>
        AmountIncreased = 5,
        
        /// <summary>
        /// >> Withdrawn
        /// </summary>
        Withdrawn = 6,
        
        /// <summary>
        /// >> IncentiveSet
        /// </summary>
        IncentiveSet = 7,
        
        /// <summary>
        /// >> RewardAdded
        /// </summary>
        RewardAdded = 8,
        
        /// <summary>
        /// >> Rewarded
        /// </summary>
        Rewarded = 9,
        
        /// <summary>
        /// >> AllRefreshed
        /// </summary>
        AllRefreshed = 10,
        
        /// <summary>
        /// >> PartiallyRefreshed
        /// </summary>
        PartiallyRefreshed = 11,
    }
    
    /// <summary>
    /// >> 487 - Variant[bifrost_ve_minting.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Bifrost.NetApi.Generated.Model.bifrost_ve_minting.VeConfig, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, Bifrost.NetApi.Generated.Model.bifrost_ve_minting.incentive.IncentiveConfig, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Substrate.NetApi.Model.Types.Primitive.U128>>>, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>
    {
    }
}

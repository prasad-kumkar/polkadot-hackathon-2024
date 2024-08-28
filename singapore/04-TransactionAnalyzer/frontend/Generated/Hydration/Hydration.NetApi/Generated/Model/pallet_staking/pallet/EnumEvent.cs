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


namespace Hydration.NetApi.Generated.Model.pallet_staking.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> PositionCreated
        /// New staking position was created and NFT was minted.
        /// </summary>
        PositionCreated = 0,
        
        /// <summary>
        /// >> StakeAdded
        /// Staked amount for existing position was increased.
        /// </summary>
        StakeAdded = 1,
        
        /// <summary>
        /// >> RewardsClaimed
        /// Rewards were claimed.
        /// </summary>
        RewardsClaimed = 2,
        
        /// <summary>
        /// >> Unstaked
        /// Staked amount was withdrawn and NFT was burned.
        /// </summary>
        Unstaked = 3,
        
        /// <summary>
        /// >> StakingInitialized
        /// Staking was initialized.
        /// </summary>
        StakingInitialized = 4,
        
        /// <summary>
        /// >> AccumulatedRpsUpdated
        /// Staking's `accumulated_reward_per_stake` was updated.
        /// </summary>
        AccumulatedRpsUpdated = 5,
    }
    
    /// <summary>
    /// >> 105 - Variant[pallet_staking.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U128, BaseTuple<Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}

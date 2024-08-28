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


namespace Bifrost.NetApi.Generated.Model.pallet_referenda.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Submitted
        /// A referendum has been submitted.
        /// </summary>
        Submitted = 0,
        
        /// <summary>
        /// >> DecisionDepositPlaced
        /// The decision deposit has been placed.
        /// </summary>
        DecisionDepositPlaced = 1,
        
        /// <summary>
        /// >> DecisionDepositRefunded
        /// The decision deposit has been refunded.
        /// </summary>
        DecisionDepositRefunded = 2,
        
        /// <summary>
        /// >> DepositSlashed
        /// A deposit has been slashed.
        /// </summary>
        DepositSlashed = 3,
        
        /// <summary>
        /// >> DecisionStarted
        /// A referendum has moved into the deciding phase.
        /// </summary>
        DecisionStarted = 4,
        
        /// <summary>
        /// >> ConfirmStarted
        /// </summary>
        ConfirmStarted = 5,
        
        /// <summary>
        /// >> ConfirmAborted
        /// </summary>
        ConfirmAborted = 6,
        
        /// <summary>
        /// >> Confirmed
        /// A referendum has ended its confirmation phase and is ready for approval.
        /// </summary>
        Confirmed = 7,
        
        /// <summary>
        /// >> Approved
        /// A referendum has been approved and its proposal has been scheduled.
        /// </summary>
        Approved = 8,
        
        /// <summary>
        /// >> Rejected
        /// A proposal has been rejected by referendum.
        /// </summary>
        Rejected = 9,
        
        /// <summary>
        /// >> TimedOut
        /// A referendum has been timed out without being decided.
        /// </summary>
        TimedOut = 10,
        
        /// <summary>
        /// >> Cancelled
        /// A referendum has been cancelled.
        /// </summary>
        Cancelled = 11,
        
        /// <summary>
        /// >> Killed
        /// A referendum has been killed.
        /// </summary>
        Killed = 12,
        
        /// <summary>
        /// >> SubmissionDepositRefunded
        /// The submission deposit has been refunded.
        /// </summary>
        SubmissionDepositRefunded = 13,
        
        /// <summary>
        /// >> MetadataSet
        /// Metadata for a referendum has been set.
        /// </summary>
        MetadataSet = 14,
        
        /// <summary>
        /// >> MetadataCleared
        /// Metadata for a referendum has been cleared.
        /// </summary>
        MetadataCleared = 15,
    }
    
    /// <summary>
    /// >> 497 - Variant[pallet_referenda.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Bifrost.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.pallet_ranked_collective.Tally>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.primitive_types.H256>>
    {
    }
}

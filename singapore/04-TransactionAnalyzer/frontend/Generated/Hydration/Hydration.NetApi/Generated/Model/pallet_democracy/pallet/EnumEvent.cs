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


namespace Hydration.NetApi.Generated.Model.pallet_democracy.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Proposed
        /// A motion has been proposed by a public account.
        /// </summary>
        Proposed = 0,
        
        /// <summary>
        /// >> Tabled
        /// A public proposal has been tabled for referendum vote.
        /// </summary>
        Tabled = 1,
        
        /// <summary>
        /// >> ExternalTabled
        /// An external proposal has been tabled.
        /// </summary>
        ExternalTabled = 2,
        
        /// <summary>
        /// >> Started
        /// A referendum has begun.
        /// </summary>
        Started = 3,
        
        /// <summary>
        /// >> Passed
        /// A proposal has been approved by referendum.
        /// </summary>
        Passed = 4,
        
        /// <summary>
        /// >> NotPassed
        /// A proposal has been rejected by referendum.
        /// </summary>
        NotPassed = 5,
        
        /// <summary>
        /// >> Cancelled
        /// A referendum has been cancelled.
        /// </summary>
        Cancelled = 6,
        
        /// <summary>
        /// >> Delegated
        /// An account has delegated their vote to another account.
        /// </summary>
        Delegated = 7,
        
        /// <summary>
        /// >> Undelegated
        /// An account has cancelled a previous delegation operation.
        /// </summary>
        Undelegated = 8,
        
        /// <summary>
        /// >> Vetoed
        /// An external proposal has been vetoed.
        /// </summary>
        Vetoed = 9,
        
        /// <summary>
        /// >> Blacklisted
        /// A proposal_hash has been blacklisted permanently.
        /// </summary>
        Blacklisted = 10,
        
        /// <summary>
        /// >> Voted
        /// An account has voted in a referendum
        /// </summary>
        Voted = 11,
        
        /// <summary>
        /// >> Seconded
        /// An account has secconded a proposal
        /// </summary>
        Seconded = 12,
        
        /// <summary>
        /// >> ProposalCanceled
        /// A proposal got canceled.
        /// </summary>
        ProposalCanceled = 13,
        
        /// <summary>
        /// >> MetadataSet
        /// Metadata for a proposal or a referendum has been set.
        /// </summary>
        MetadataSet = 14,
        
        /// <summary>
        /// >> MetadataCleared
        /// Metadata for a proposal or a referendum has been cleared.
        /// </summary>
        MetadataCleared = 15,
        
        /// <summary>
        /// >> MetadataTransferred
        /// Metadata has been transferred to new owner.
        /// </summary>
        MetadataTransferred = 16,
    }
    
    /// <summary>
    /// >> 42 - Variant[pallet_democracy.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Hydration.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>, Hydration.NetApi.Generated.Model.primitive_types.H256, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Hydration.NetApi.Generated.Model.pallet_democracy.vote.EnumAccountVote>, BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Hydration.NetApi.Generated.Model.pallet_democracy.types.EnumMetadataOwner, Hydration.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Hydration.NetApi.Generated.Model.pallet_democracy.types.EnumMetadataOwner, Hydration.NetApi.Generated.Model.primitive_types.H256>, BaseTuple<Hydration.NetApi.Generated.Model.pallet_democracy.types.EnumMetadataOwner, Hydration.NetApi.Generated.Model.pallet_democracy.types.EnumMetadataOwner, Hydration.NetApi.Generated.Model.primitive_types.H256>>
    {
    }
}

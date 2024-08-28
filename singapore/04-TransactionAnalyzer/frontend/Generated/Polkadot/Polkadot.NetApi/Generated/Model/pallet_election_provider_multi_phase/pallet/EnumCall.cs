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


namespace Polkadot.NetApi.Generated.Model.pallet_election_provider_multi_phase.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> submit_unsigned
        /// See [`Pallet::submit_unsigned`].
        /// </summary>
        submit_unsigned = 0,
        
        /// <summary>
        /// >> set_minimum_untrusted_score
        /// See [`Pallet::set_minimum_untrusted_score`].
        /// </summary>
        set_minimum_untrusted_score = 1,
        
        /// <summary>
        /// >> set_emergency_election_result
        /// See [`Pallet::set_emergency_election_result`].
        /// </summary>
        set_emergency_election_result = 2,
        
        /// <summary>
        /// >> submit
        /// See [`Pallet::submit`].
        /// </summary>
        submit = 3,
        
        /// <summary>
        /// >> governance_fallback
        /// See [`Pallet::governance_fallback`].
        /// </summary>
        governance_fallback = 4,
    }
    
    /// <summary>
    /// >> 244 - Variant[pallet_election_provider_multi_phase.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Polkadot.NetApi.Generated.Model.pallet_election_provider_multi_phase.RawSolution, Polkadot.NetApi.Generated.Model.pallet_election_provider_multi_phase.SolutionOrSnapshotSize>, Substrate.NetApi.Model.Types.Base.BaseOpt<Polkadot.NetApi.Generated.Model.sp_npos_elections.ElectionScore>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32, Polkadot.NetApi.Generated.Model.sp_npos_elections.Support>>, Polkadot.NetApi.Generated.Model.pallet_election_provider_multi_phase.RawSolution, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>>
    {
    }
}
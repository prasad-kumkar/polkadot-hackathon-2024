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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.polkadot_primitives
{
    
    
    /// <summary>
    /// >> SubstrateLedgerUpdateOperation
    /// </summary>
    public enum SubstrateLedgerUpdateOperation
    {
        
        /// <summary>
        /// >> Bond
        /// </summary>
        Bond = 0,
        
        /// <summary>
        /// >> Unlock
        /// </summary>
        Unlock = 1,
        
        /// <summary>
        /// >> Rebond
        /// </summary>
        Rebond = 2,
        
        /// <summary>
        /// >> Liquidize
        /// </summary>
        Liquidize = 3,
    }
    
    /// <summary>
    /// >> 471 - Variant[bifrost_slp.primitives.polkadot_primitives.SubstrateLedgerUpdateOperation]
    /// </summary>
    public sealed class EnumSubstrateLedgerUpdateOperation : BaseEnum<SubstrateLedgerUpdateOperation>
    {
    }
}
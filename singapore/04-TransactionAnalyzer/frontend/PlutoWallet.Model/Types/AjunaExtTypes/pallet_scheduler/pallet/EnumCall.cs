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


namespace Substrate.NetApi.Generated.Model.pallet_scheduler.pallet
{
    
    
    public enum Call
    {
        
        schedule = 0,
        
        cancel = 1,
        
        schedule_named = 2,
        
        cancel_named = 3,
        
        schedule_after = 4,
        
        schedule_named_after = 5,
    }
    
    /// <summary>
    /// >> 182 - Variant[pallet_scheduler.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeCall>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Generated.Types.Base.Arr32U8, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeCall>, Substrate.NetApi.Generated.Types.Base.Arr32U8, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeCall>, BaseTuple<Substrate.NetApi.Generated.Types.Base.Arr32U8, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Generated.Model.polkadot_runtime.EnumRuntimeCall>>
    {
    }
}
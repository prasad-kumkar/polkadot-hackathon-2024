//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_circuit_breaker
{
    
    
    /// <summary>
    /// >> 586 - Composite[pallet_circuit_breaker.TradeVolumeLimit]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class TradeVolumeLimit : BaseType
    {
        
        /// <summary>
        /// >> volume_in
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 VolumeIn { get; set; }
        /// <summary>
        /// >> volume_out
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 VolumeOut { get; set; }
        /// <summary>
        /// >> limit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Limit { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "TradeVolumeLimit";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(VolumeIn.Encode());
            result.AddRange(VolumeOut.Encode());
            result.AddRange(Limit.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            VolumeIn = new Substrate.NetApi.Model.Types.Primitive.U128();
            VolumeIn.Decode(byteArray, ref p);
            VolumeOut = new Substrate.NetApi.Model.Types.Primitive.U128();
            VolumeOut.Decode(byteArray, ref p);
            Limit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Limit.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}

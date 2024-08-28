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


namespace Polkadot.NetApi.Generated.Model.polkadot_parachain_primitives.primitives
{
    
    
    /// <summary>
    /// >> 345 - Composite[polkadot_parachain_primitives.primitives.ValidationCodeHash]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ValidationCodeHash : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public Polkadot.NetApi.Generated.Model.primitive_types.H256 Value { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ValidationCodeHash";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Polkadot.NetApi.Generated.Model.primitive_types.H256();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}

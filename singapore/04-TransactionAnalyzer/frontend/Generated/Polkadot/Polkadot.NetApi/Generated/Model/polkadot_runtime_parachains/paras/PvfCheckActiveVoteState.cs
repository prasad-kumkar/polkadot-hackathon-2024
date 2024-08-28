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


namespace Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras
{
    
    
    /// <summary>
    /// >> 771 - Composite[polkadot_runtime_parachains.paras.PvfCheckActiveVoteState]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PvfCheckActiveVoteState : BaseType
    {
        
        /// <summary>
        /// >> votes_accept
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0> VotesAccept { get; set; }
        /// <summary>
        /// >> votes_reject
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0> VotesReject { get; set; }
        /// <summary>
        /// >> age
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Age { get; set; }
        /// <summary>
        /// >> created_at
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CreatedAt { get; set; }
        /// <summary>
        /// >> causes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras.EnumPvfCheckCause> Causes { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PvfCheckActiveVoteState";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(VotesAccept.Encode());
            result.AddRange(VotesReject.Encode());
            result.AddRange(Age.Encode());
            result.AddRange(CreatedAt.Encode());
            result.AddRange(Causes.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            VotesAccept = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0>();
            VotesAccept.Decode(byteArray, ref p);
            VotesReject = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0>();
            VotesReject.Decode(byteArray, ref p);
            Age = new Substrate.NetApi.Model.Types.Primitive.U32();
            Age.Decode(byteArray, ref p);
            CreatedAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            CreatedAt.Decode(byteArray, ref p);
            Causes = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.paras.EnumPvfCheckCause>();
            Causes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}

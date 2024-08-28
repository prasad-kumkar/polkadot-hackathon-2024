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


namespace Hydration.NetApi.Generated.Model.orml_vesting
{
    
    
    /// <summary>
    /// >> 128 - Composite[orml_vesting.VestingSchedule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class VestingSchedule : BaseType
    {
        
        /// <summary>
        /// >> start
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Start { get; set; }
        /// <summary>
        /// >> period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Period { get; set; }
        /// <summary>
        /// >> period_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PeriodCount { get; set; }
        /// <summary>
        /// >> per_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> PerPeriod { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "VestingSchedule";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Start.Encode());
            result.AddRange(Period.Encode());
            result.AddRange(PeriodCount.Encode());
            result.AddRange(PerPeriod.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Start = new Substrate.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            Period = new Substrate.NetApi.Model.Types.Primitive.U32();
            Period.Decode(byteArray, ref p);
            PeriodCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            PeriodCount.Decode(byteArray, ref p);
            PerPeriod = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            PerPeriod.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}

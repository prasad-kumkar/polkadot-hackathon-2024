//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Opal.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> FellowshipReferendaStorage
    /// </summary>
    public sealed class FellowshipReferendaStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> FellowshipReferendaStorage Constructor
        /// </summary>
        public FellowshipReferendaStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipReferenda", "ReferendumCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipReferenda", "ReferendumInfoFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Opal.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipReferenda", "TrackQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipReferenda", "DecidingCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipReferenda", "MetadataOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Opal.NetApi.Generated.Model.primitive_types.H256)));
        }
        
        /// <summary>
        /// >> ReferendumCountParams
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public static string ReferendumCountParams()
        {
            return RequestGenerator.GetStorage("FellowshipReferenda", "ReferendumCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ReferendumCountDefault
        /// Default value as hex string
        /// </summary>
        public static string ReferendumCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> ReferendumCount(string blockhash, CancellationToken token)
        {
            string parameters = FellowshipReferendaStorage.ReferendumCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ReferendumInfoForParams
        ///  Information concerning any given referendum.
        /// </summary>
        public static string ReferendumInfoForParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("FellowshipReferenda", "ReferendumInfoFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReferendumInfoForDefault
        /// Default value as hex string
        /// </summary>
        public static string ReferendumInfoForDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo> ReferendumInfoFor(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipReferendaStorage.ReferendumInfoForParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TrackQueueParams
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public static string TrackQueueParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("FellowshipReferenda", "TrackQueue", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TrackQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string TrackQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36> TrackQueue(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipReferendaStorage.TrackQueueParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT36>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> DecidingCountParams
        ///  The number of referenda being decided currently.
        /// </summary>
        public static string DecidingCountParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("FellowshipReferenda", "DecidingCount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> DecidingCountDefault
        /// Default value as hex string
        /// </summary>
        public static string DecidingCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> DecidingCount(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipReferendaStorage.DecidingCountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MetadataOfParams
        ///  The metadata is a general information concerning the referendum.
        ///  The `Hash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        public static string MetadataOfParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("FellowshipReferenda", "MetadataOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MetadataOfDefault
        /// Default value as hex string
        /// </summary>
        public static string MetadataOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MetadataOf
        ///  The metadata is a general information concerning the referendum.
        ///  The `Hash` refers to the preimage of the `Preimages` provider which can be a JSON
        ///  dump or IPFS hash of a JSON file.
        /// 
        ///  Consider a garbage collection for a metadata of finished referendums to `unrequest` (remove)
        ///  large preimages.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.primitive_types.H256> MetadataOf(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipReferendaStorage.MetadataOfParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.primitive_types.H256>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> FellowshipReferendaCalls
    /// </summary>
    public sealed class FellowshipReferendaCalls
    {
        
        /// <summary>
        /// >> submit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Submit(Opal.NetApi.Generated.Model.opal_runtime.EnumOriginCaller proposal_origin, Opal.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded proposal, Opal.NetApi.Generated.Model.frame_support.traits.schedule.EnumDispatchTime enactment_moment)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_origin.Encode());
            byteArray.AddRange(proposal.Encode());
            byteArray.AddRange(enactment_moment.Encode());
            return new Method(48, "FellowshipReferenda", 0, "submit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> place_decision_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PlaceDecisionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 1, "place_decision_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_decision_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RefundDecisionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 2, "refund_decision_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Cancel(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 3, "cancel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kill
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Kill(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 4, "kill", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> nudge_referendum
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method NudgeReferendum(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 5, "nudge_referendum", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> one_fewer_deciding
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method OneFewerDeciding(Substrate.NetApi.Model.Types.Primitive.U16 track)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(track.Encode());
            return new Method(48, "FellowshipReferenda", 6, "one_fewer_deciding", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> refund_submission_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RefundSubmissionDeposit(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(48, "FellowshipReferenda", 7, "refund_submission_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_metadata
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMetadata(Substrate.NetApi.Model.Types.Primitive.U32 index, Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.primitive_types.H256> maybe_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(maybe_hash.Encode());
            return new Method(48, "FellowshipReferenda", 8, "set_metadata", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> FellowshipReferendaConstants
    /// </summary>
    public sealed class FellowshipReferendaConstants
    {
        
        /// <summary>
        /// >> SubmissionDeposit
        ///  The minimum amount to be used as a deposit for a public referendum proposal.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SubmissionDeposit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0xE8030000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxQueued
        ///  Maximum size of the referendum queue for a single track.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxQueued()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> UndecidingTimeout
        ///  The number of blocks after submission that a referendum must begin being decided by.
        ///  Once this passes, then anyone may cancel the referendum.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UndecidingTimeout()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x2C010000");
            return result;
        }
        
        /// <summary>
        /// >> AlarmInterval
        ///  Quantization level for the referendum wakeup scheduler. A higher number will result in
        ///  fewer storage reads/writes needed for smaller voters, but also result in delays to the
        ///  automatic referendum status changes. Explicit servicing instructions are unaffected.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AlarmInterval()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x01000000");
            return result;
        }
        
        /// <summary>
        /// >> Tracks
        ///  Information concerning the different referendum tracks.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Opal.NetApi.Generated.Model.pallet_referenda.types.TrackInfo>> Tracks()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Opal.NetApi.Generated.Model.pallet_referenda.types.TrackInfo>>();
            result.Create("0x040A004C64656D6F63726163795F70726F706F73616C730A0000000000E8890423C78A000000000" +
                    "0000000190000002C01000032000000050000000000CA9A3B0065CD1D00CA9A3B0000CA9A3B00000" +
                    "0000065CD1D");
            return result;
        }
    }
    
    /// <summary>
    /// >> FellowshipReferendaErrors
    /// </summary>
    public enum FellowshipReferendaErrors
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Referendum is not ongoing.
        /// </summary>
        NotOngoing,
        
        /// <summary>
        /// >> HasDeposit
        /// Referendum's decision deposit is already paid.
        /// </summary>
        HasDeposit,
        
        /// <summary>
        /// >> BadTrack
        /// The track identifier given was invalid.
        /// </summary>
        BadTrack,
        
        /// <summary>
        /// >> Full
        /// There are already a full complement of referenda in progress for this track.
        /// </summary>
        Full,
        
        /// <summary>
        /// >> QueueEmpty
        /// The queue of the track is empty.
        /// </summary>
        QueueEmpty,
        
        /// <summary>
        /// >> BadReferendum
        /// The referendum index provided is invalid in this context.
        /// </summary>
        BadReferendum,
        
        /// <summary>
        /// >> NothingToDo
        /// There was nothing to do in the advancement.
        /// </summary>
        NothingToDo,
        
        /// <summary>
        /// >> NoTrack
        /// No track exists for the proposal origin.
        /// </summary>
        NoTrack,
        
        /// <summary>
        /// >> Unfinished
        /// Any deposit cannot be refunded until after the decision is over.
        /// </summary>
        Unfinished,
        
        /// <summary>
        /// >> NoPermission
        /// The deposit refunder is not the depositor.
        /// </summary>
        NoPermission,
        
        /// <summary>
        /// >> NoDeposit
        /// The deposit cannot be refunded since none was made.
        /// </summary>
        NoDeposit,
        
        /// <summary>
        /// >> BadStatus
        /// The referendum status is invalid for this operation.
        /// </summary>
        BadStatus,
        
        /// <summary>
        /// >> PreimageNotExist
        /// The preimage does not exist.
        /// </summary>
        PreimageNotExist,
    }
}

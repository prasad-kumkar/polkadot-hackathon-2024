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


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> StableAssetStorage
    /// </summary>
    public sealed class StableAssetStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> StableAssetStorage Constructor
        /// </summary>
        public StableAssetStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StableAsset", "PoolCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StableAsset", "Pools"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Bifrost.NetApi.Generated.Model.bifrost_stable_asset.StableAssetPoolInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StableAsset", "TokenRateCaches"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId>), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StableAsset", "TokenRateHardcap"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId), typeof(Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill)));
        }
        
        /// <summary>
        /// >> PoolCountParams
        /// </summary>
        public static string PoolCountParams()
        {
            return RequestGenerator.GetStorage("StableAsset", "PoolCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PoolCountDefault
        /// Default value as hex string
        /// </summary>
        public static string PoolCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> PoolCount
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> PoolCount(string blockhash, CancellationToken token)
        {
            string parameters = StableAssetStorage.PoolCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PoolsParams
        /// </summary>
        public static string PoolsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("StableAsset", "Pools", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PoolsDefault
        /// Default value as hex string
        /// </summary>
        public static string PoolsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Pools
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.bifrost_stable_asset.StableAssetPoolInfo> Pools(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = StableAssetStorage.PoolsParams(key);
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.bifrost_stable_asset.StableAssetPoolInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TokenRateCachesParams
        /// </summary>
        public static string TokenRateCachesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId> key)
        {
            return RequestGenerator.GetStorage("StableAsset", "TokenRateCaches", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> TokenRateCachesDefault
        /// Default value as hex string
        /// </summary>
        public static string TokenRateCachesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TokenRateCaches
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>> TokenRateCaches(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId> key, string blockhash, CancellationToken token)
        {
            string parameters = StableAssetStorage.TokenRateCachesParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TokenRateHardcapParams
        /// </summary>
        public static string TokenRateHardcapParams(Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId key)
        {
            return RequestGenerator.GetStorage("StableAsset", "TokenRateHardcap", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TokenRateHardcapDefault
        /// Default value as hex string
        /// </summary>
        public static string TokenRateHardcapDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TokenRateHardcap
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill> TokenRateHardcap(Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId key, string blockhash, CancellationToken token)
        {
            string parameters = StableAssetStorage.TokenRateHardcapParams(key);
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> StableAssetCalls
    /// </summary>
    public sealed class StableAssetCalls
    {
    }
    
    /// <summary>
    /// >> StableAssetConstants
    /// </summary>
    public sealed class StableAssetConstants
    {
        
        /// <summary>
        /// >> PalletId
        /// </summary>
        public Bifrost.NetApi.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Bifrost.NetApi.Generated.Model.frame_support.PalletId();
            result.Create("0x62662F737461626C");
            return result;
        }
        
        /// <summary>
        /// >> FeePrecision
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 FeePrecision()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00E40B54020000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> SwapExactOverAmount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 SwapExactOverAmount()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x64000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> APrecision
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 APrecision()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x64000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> PoolAssetLimit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PoolAssetLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x05000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> StableAssetErrors
    /// </summary>
    public enum StableAssetErrors
    {
        
        /// <summary>
        /// >> InconsistentStorage
        /// </summary>
        InconsistentStorage,
        
        /// <summary>
        /// >> InvalidPoolAsset
        /// </summary>
        InvalidPoolAsset,
        
        /// <summary>
        /// >> ArgumentsMismatch
        /// </summary>
        ArgumentsMismatch,
        
        /// <summary>
        /// >> ArgumentsError
        /// </summary>
        ArgumentsError,
        
        /// <summary>
        /// >> PoolNotFound
        /// </summary>
        PoolNotFound,
        
        /// <summary>
        /// >> Math
        /// </summary>
        Math,
        
        /// <summary>
        /// >> InvalidPoolValue
        /// </summary>
        InvalidPoolValue,
        
        /// <summary>
        /// >> MintUnderMin
        /// </summary>
        MintUnderMin,
        
        /// <summary>
        /// >> SwapUnderMin
        /// </summary>
        SwapUnderMin,
        
        /// <summary>
        /// >> RedeemUnderMin
        /// </summary>
        RedeemUnderMin,
        
        /// <summary>
        /// >> RedeemOverMax
        /// </summary>
        RedeemOverMax,
        
        /// <summary>
        /// >> TokenRateNotCleared
        /// </summary>
        TokenRateNotCleared,
    }
}

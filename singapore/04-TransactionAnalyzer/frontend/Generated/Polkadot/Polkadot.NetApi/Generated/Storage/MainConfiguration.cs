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


namespace Polkadot.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> ConfigurationStorage
    /// </summary>
    public sealed class ConfigurationStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ConfigurationStorage Constructor
        /// </summary>
        public ConfigurationStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Configuration", "ActiveConfig"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Configuration", "PendingConfigs"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Configuration", "BypassConsistencyCheck"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> ActiveConfigParams
        ///  The active configuration for the current session.
        /// </summary>
        public static string ActiveConfigParams()
        {
            return RequestGenerator.GetStorage("Configuration", "ActiveConfig", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ActiveConfigDefault
        /// Default value as hex string
        /// </summary>
        public static string ActiveConfigDefault()
        {
            return @"0x0000000000000000000000000000000000000000000000000000000000000000020000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001027000080B2E60E80C3C90180969800000000000000000000000000050000000100000001000000010000000000060000006400000001000000000000000000000000000000000000000200000002000000020000000001000000";
        }
        
        /// <summary>
        /// >> ActiveConfig
        ///  The active configuration for the current session.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration> ActiveConfig(string blockhash, CancellationToken token)
        {
            string parameters = ConfigurationStorage.ActiveConfigParams();
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PendingConfigsParams
        ///  Pending configuration changes.
        /// 
        ///  This is a list of configuration changes, each with a session index at which it should
        ///  be applied.
        /// 
        ///  The list is sorted ascending by session index. Also, this list can only contain at most
        ///  2 items: for the next session and for the `scheduled_session`.
        /// </summary>
        public static string PendingConfigsParams()
        {
            return RequestGenerator.GetStorage("Configuration", "PendingConfigs", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PendingConfigsDefault
        /// Default value as hex string
        /// </summary>
        public static string PendingConfigsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PendingConfigs
        ///  Pending configuration changes.
        /// 
        ///  This is a list of configuration changes, each with a session index at which it should
        ///  be applied.
        /// 
        ///  The list is sorted ascending by session index. Also, this list can only contain at most
        ///  2 items: for the next session and for the `scheduled_session`.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>>> PendingConfigs(string blockhash, CancellationToken token)
        {
            string parameters = ConfigurationStorage.PendingConfigsParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Polkadot.NetApi.Generated.Model.polkadot_runtime_parachains.configuration.HostConfiguration>>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> BypassConsistencyCheckParams
        ///  If this is set, then the configuration setters will bypass the consistency checks. This
        ///  is meant to be used only as the last resort.
        /// </summary>
        public static string BypassConsistencyCheckParams()
        {
            return RequestGenerator.GetStorage("Configuration", "BypassConsistencyCheck", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BypassConsistencyCheckDefault
        /// Default value as hex string
        /// </summary>
        public static string BypassConsistencyCheckDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> BypassConsistencyCheck
        ///  If this is set, then the configuration setters will bypass the consistency checks. This
        ///  is meant to be used only as the last resort.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> BypassConsistencyCheck(string blockhash, CancellationToken token)
        {
            string parameters = ConfigurationStorage.BypassConsistencyCheckParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ConfigurationCalls
    /// </summary>
    public sealed class ConfigurationCalls
    {
        
        /// <summary>
        /// >> set_validation_upgrade_cooldown
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetValidationUpgradeCooldown(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 0, "set_validation_upgrade_cooldown", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_validation_upgrade_delay
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetValidationUpgradeDelay(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 1, "set_validation_upgrade_delay", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code_retention_period
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetCodeRetentionPeriod(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 2, "set_code_retention_period", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_code_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxCodeSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 3, "set_max_code_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_pov_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxPovSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 4, "set_max_pov_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_head_data_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxHeadDataSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 5, "set_max_head_data_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_coretime_cores
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetCoretimeCores(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 6, "set_coretime_cores", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_retries
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandRetries(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 7, "set_on_demand_retries", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_group_rotation_frequency
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetGroupRotationFrequency(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 8, "set_group_rotation_frequency", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_paras_availability_period
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetParasAvailabilityPeriod(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 9, "set_paras_availability_period", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_scheduling_lookahead
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetSchedulingLookahead(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 11, "set_scheduling_lookahead", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_validators_per_core
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxValidatorsPerCore(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 12, "set_max_validators_per_core", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_validators
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxValidators(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 13, "set_max_validators", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_dispute_period
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetDisputePeriod(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 14, "set_dispute_period", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_dispute_post_conclusion_acceptance_period
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetDisputePostConclusionAcceptancePeriod(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 15, "set_dispute_post_conclusion_acceptance_period", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_no_show_slots
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetNoShowSlots(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 18, "set_no_show_slots", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_n_delay_tranches
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetNDelayTranches(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 19, "set_n_delay_tranches", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_zeroth_delay_tranche_width
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetZerothDelayTrancheWidth(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 20, "set_zeroth_delay_tranche_width", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_needed_approvals
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetNeededApprovals(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 21, "set_needed_approvals", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_relay_vrf_modulo_samples
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetRelayVrfModuloSamples(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 22, "set_relay_vrf_modulo_samples", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_upward_queue_count
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxUpwardQueueCount(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 23, "set_max_upward_queue_count", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_upward_queue_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxUpwardQueueSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 24, "set_max_upward_queue_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_downward_message_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxDownwardMessageSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 25, "set_max_downward_message_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_upward_message_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxUpwardMessageSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 27, "set_max_upward_message_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_max_upward_message_num_per_candidate
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMaxUpwardMessageNumPerCandidate(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 28, "set_max_upward_message_num_per_candidate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_open_request_ttl
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpOpenRequestTtl(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 29, "set_hrmp_open_request_ttl", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_sender_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpSenderDeposit(Substrate.NetApi.Model.Types.Primitive.U128 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 30, "set_hrmp_sender_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_recipient_deposit
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpRecipientDeposit(Substrate.NetApi.Model.Types.Primitive.U128 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 31, "set_hrmp_recipient_deposit", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_channel_max_capacity
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpChannelMaxCapacity(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 32, "set_hrmp_channel_max_capacity", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_channel_max_total_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpChannelMaxTotalSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 33, "set_hrmp_channel_max_total_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_max_parachain_inbound_channels
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpMaxParachainInboundChannels(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 34, "set_hrmp_max_parachain_inbound_channels", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_channel_max_message_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpChannelMaxMessageSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 36, "set_hrmp_channel_max_message_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_max_parachain_outbound_channels
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpMaxParachainOutboundChannels(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 37, "set_hrmp_max_parachain_outbound_channels", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_hrmp_max_message_num_per_candidate
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetHrmpMaxMessageNumPerCandidate(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 39, "set_hrmp_max_message_num_per_candidate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_pvf_voting_ttl
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetPvfVotingTtl(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 42, "set_pvf_voting_ttl", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_minimum_validation_upgrade_delay
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMinimumValidationUpgradeDelay(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 43, "set_minimum_validation_upgrade_delay", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_bypass_consistency_check
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetBypassConsistencyCheck(Substrate.NetApi.Model.Types.Primitive.Bool @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 44, "set_bypass_consistency_check", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_async_backing_params
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetAsyncBackingParams(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.async_backing.AsyncBackingParams @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 45, "set_async_backing_params", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_executor_params
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetExecutorParams(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 46, "set_executor_params", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_base_fee
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandBaseFee(Substrate.NetApi.Model.Types.Primitive.U128 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 47, "set_on_demand_base_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_fee_variability
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandFeeVariability(Polkadot.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 48, "set_on_demand_fee_variability", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_queue_max_size
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandQueueMaxSize(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 49, "set_on_demand_queue_max_size", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_target_queue_utilization
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandTargetQueueUtilization(Polkadot.NetApi.Generated.Model.sp_arithmetic.per_things.Perbill @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 50, "set_on_demand_target_queue_utilization", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_on_demand_ttl
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetOnDemandTtl(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 51, "set_on_demand_ttl", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_minimum_backing_votes
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetMinimumBackingVotes(Substrate.NetApi.Model.Types.Primitive.U32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 52, "set_minimum_backing_votes", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_node_feature
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetNodeFeature(Substrate.NetApi.Model.Types.Primitive.U8 index, Substrate.NetApi.Model.Types.Primitive.Bool value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(51, "Configuration", 53, "set_node_feature", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_approval_voting_params
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetApprovalVotingParams(Polkadot.NetApi.Generated.Model.polkadot_primitives.vstaging.ApprovalVotingParams @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(51, "Configuration", 54, "set_approval_voting_params", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ConfigurationConstants
    /// </summary>
    public sealed class ConfigurationConstants
    {
    }
    
    /// <summary>
    /// >> ConfigurationErrors
    /// </summary>
    public enum ConfigurationErrors
    {
        
        /// <summary>
        /// >> InvalidNewValue
        /// The new value for a configuration parameter is invalid.
        /// </summary>
        InvalidNewValue,
    }
}

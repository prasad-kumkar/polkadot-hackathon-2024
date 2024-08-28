// Auto-generated via `yarn polkadot-types-from-chain`, do not edit
/* eslint-disable */

// import type lookup before we augment - in some environments
// this is required to allow for ambient/previous definitions
import "@polkadot/api-base/types/consts";

import type { ApiTypes, AugmentedConst } from "@polkadot/api-base/types";
import type { Option, u128, u16, u32, u64, u8 } from "@polkadot/types-codec";
import type { Codec } from "@polkadot/types-codec/types";
import type { AccountId32, Perbill, Permill } from "@polkadot/types/interfaces/runtime";
import type {
    FrameSupportPalletId,
    FrameSystemLimitsBlockLength,
    FrameSystemLimitsBlockWeights,
    SpVersionRuntimeVersion,
    SpWeightsRuntimeDbWeight,
    SpWeightsWeightV2Weight,
    StagingXcmV4Junctions,
} from "@polkadot/types/lookup";

export type __AugmentedConst<ApiType extends ApiTypes> = AugmentedConst<ApiType>;

declare module "@polkadot/api-base/types/consts" {
    interface AugmentedConsts<ApiType extends ApiTypes> {
        asyncBacking: {
            /** Purely informative, but used by mocking tools like chospticks to allow knowing how to mock blocks */
            expectedBlockTime: u64 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        authorityMapping: {
            sessionRemovalBoundary: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        balances: {
            /**
             * The minimum amount required to keep an account open. MUST BE GREATER THAN ZERO!
             *
             * If you _really_ need it to be zero, you can enable the feature `insecure_zero_ed` for this pallet. However, you
             * do so at your own risk: this will open up a major DoS vector. In case you have multiple sources of provider
             * references, you may also get unexpected behaviour if you set this to zero.
             *
             * Bottom line: Do yourself a favour and make it at least one!
             */
            existentialDeposit: u128 & AugmentedConst<ApiType>;
            /** The maximum number of individual freeze locks that can exist on an account at any time. */
            maxFreezes: u32 & AugmentedConst<ApiType>;
            /**
             * The maximum number of locks that should exist on an account. Not strictly enforced, but used for weight estimation.
             *
             * Use of locks is deprecated in favour of freezes. See `https://github.com/paritytech/substrate/pull/12951/`
             */
            maxLocks: u32 & AugmentedConst<ApiType>;
            /**
             * The maximum number of named reserves that can exist on an account.
             *
             * Use of reserves is deprecated in favour of holds. See `https://github.com/paritytech/substrate/pull/12951/`
             */
            maxReserves: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        configuration: {
            sessionDelay: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        dataPreservers: {
            maxAssignmentsPerParaId: u32 & AugmentedConst<ApiType>;
            maxNodeUrlLen: u32 & AugmentedConst<ApiType>;
            maxParaIdsVecLen: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        foreignAssets: {
            /** The amount of funds that must be reserved when creating a new approval. */
            approvalDeposit: u128 & AugmentedConst<ApiType>;
            /** The amount of funds that must be reserved for a non-provider asset account to be maintained. */
            assetAccountDeposit: u128 & AugmentedConst<ApiType>;
            /** The basic amount of funds that must be reserved for an asset. */
            assetDeposit: u128 & AugmentedConst<ApiType>;
            /** The basic amount of funds that must be reserved when adding metadata to your asset. */
            metadataDepositBase: u128 & AugmentedConst<ApiType>;
            /** The additional funds that must be reserved for the number of bytes you store in your metadata. */
            metadataDepositPerByte: u128 & AugmentedConst<ApiType>;
            /**
             * Max number of items to destroy per `destroy_accounts` and `destroy_approvals` call.
             *
             * Must be configured to result in a weight that makes each call fit in a block.
             */
            removeItemsLimit: u32 & AugmentedConst<ApiType>;
            /** The maximum length of a name or symbol stored on-chain. */
            stringLimit: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        identity: {
            /** The amount held on deposit for a registered identity. */
            basicDeposit: u128 & AugmentedConst<ApiType>;
            /** The amount held on deposit per encoded byte for a registered identity. */
            byteDeposit: u128 & AugmentedConst<ApiType>;
            /** Maximum number of registrars allowed in the system. Needed to bound the complexity of, e.g., updating judgements. */
            maxRegistrars: u32 & AugmentedConst<ApiType>;
            /** The maximum number of sub-accounts allowed per identified account. */
            maxSubAccounts: u32 & AugmentedConst<ApiType>;
            /** The maximum length of a suffix. */
            maxSuffixLength: u32 & AugmentedConst<ApiType>;
            /** The maximum length of a username, including its suffix and any system-added delimiters. */
            maxUsernameLength: u32 & AugmentedConst<ApiType>;
            /** The number of blocks within which a username grant must be accepted. */
            pendingUsernameExpiration: u32 & AugmentedConst<ApiType>;
            /**
             * The amount held on deposit for a registered subaccount. This should account for the fact that one storage
             * item's value will increase by the size of an account ID, and there will be another trie item whose value is the
             * size of an account ID plus 32 bytes.
             */
            subAccountDeposit: u128 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        inflationRewards: {
            /** Inflation rate per orchestrator block (proportion of the total issuance) */
            inflationRate: Perbill & AugmentedConst<ApiType>;
            /** The account that will store rewards waiting to be paid out */
            pendingRewardsAccount: AccountId32 & AugmentedConst<ApiType>;
            /** Proportion of the new supply dedicated to staking */
            rewardsPortion: Perbill & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        invulnerables: {
            /** Maximum number of invulnerables. */
            maxInvulnerables: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        messageQueue: {
            /**
             * The size of the page; this implies the maximum message size which can be sent.
             *
             * A good value depends on the expected message sizes, their weights, the weight that is available for processing
             * them and the maximal needed message size. The maximal message size is slightly lower than this as defined by
             * [`MaxMessageLenOf`].
             */
            heapSize: u32 & AugmentedConst<ApiType>;
            /**
             * The maximum amount of weight (if any) to be used from remaining weight `on_idle` which should be provided to
             * the message queue for servicing enqueued items `on_idle`. Useful for parachains to process messages at the same
             * block they are received.
             *
             * If `None`, it will not call `ServiceQueues::service_queues` in `on_idle`.
             */
            idleMaxServiceWeight: Option<SpWeightsWeightV2Weight> & AugmentedConst<ApiType>;
            /**
             * The maximum number of stale pages (i.e. of overweight messages) allowed before culling can happen. Once there
             * are more stale pages than this, then historical pages may be dropped, even if they contain unprocessed
             * overweight messages.
             */
            maxStale: u32 & AugmentedConst<ApiType>;
            /**
             * The amount of weight (if any) which should be provided to the message queue for servicing enqueued items `on_initialize`.
             *
             * This may be legitimately `None` in the case that you will call `ServiceQueues::service_queues` manually or set
             * [`Self::IdleMaxServiceWeight`] to have it run in `on_idle`.
             */
            serviceWeight: Option<SpWeightsWeightV2Weight> & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        multisig: {
            /**
             * The base amount of currency needed to reserve for creating a multisig execution or to store a dispatch call for later.
             *
             * This is held for an additional storage item whose value size is `4 + sizeof((BlockNumber, Balance, AccountId))`
             * bytes and whose key size is `32 + sizeof(AccountId)` bytes.
             */
            depositBase: u128 & AugmentedConst<ApiType>;
            /**
             * The amount of currency needed per unit threshold when creating a multisig execution.
             *
             * This is held for adding 32 bytes more into a pre-existing storage value.
             */
            depositFactor: u128 & AugmentedConst<ApiType>;
            /** The maximum amount of signatories allowed in the multisig. */
            maxSignatories: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        parachainSystem: {
            /** Returns the parachain ID we are running with. */
            selfParaId: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        pooledStaking: {
            /**
             * All eligible candidates are stored in a sorted list that is modified each time delegations changes. It is safer
             * to bound this list, in which case eligible candidate could fall out of this list if they have less stake than
             * the top `EligibleCandidatesBufferSize` eligible candidates. One of this top candidates leaving will then not
             * bring the dropped candidate in the list. An extrinsic is available to manually bring back such dropped candidate.
             */
            eligibleCandidatesBufferSize: u32 & AugmentedConst<ApiType>;
            /**
             * When creating the first Shares for a candidate the supply can arbitrary. Picking a value too high is a barrier
             * of entry for staking, which will increase overtime as the value of each share will increase due to auto compounding.
             */
            initialAutoCompoundingShareValue: u128 & AugmentedConst<ApiType>;
            /**
             * When creating the first Shares for a candidate the supply can be arbitrary. Picking a value too low will make
             * an higher supply, which means each share will get less rewards, and rewards calculations will have more
             * impactful rounding errors. Picking a value too high is a barrier of entry for staking.
             */
            initialManualClaimShareValue: u128 & AugmentedConst<ApiType>;
            /**
             * Minimum amount of stake a Candidate must delegate (stake) towards itself. Not reaching this minimum prevents
             * from being elected.
             */
            minimumSelfDelegation: u128 & AugmentedConst<ApiType>;
            /** Part of the rewards that will be sent exclusively to the collator. */
            rewardsCollatorCommission: Perbill & AugmentedConst<ApiType>;
            /** Account holding Currency of all delegators. */
            stakingAccount: AccountId32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        proxy: {
            /**
             * The base amount of currency needed to reserve for creating an announcement.
             *
             * This is held when a new storage item holding a `Balance` is created (typically 16 bytes).
             */
            announcementDepositBase: u128 & AugmentedConst<ApiType>;
            /**
             * The amount of currency needed per announcement made.
             *
             * This is held for adding an `AccountId`, `Hash` and `BlockNumber` (typically 68 bytes) into a pre-existing storage value.
             */
            announcementDepositFactor: u128 & AugmentedConst<ApiType>;
            /** The maximum amount of time-delayed announcements that are allowed to be pending. */
            maxPending: u32 & AugmentedConst<ApiType>;
            /** The maximum amount of proxies allowed for a single account. */
            maxProxies: u32 & AugmentedConst<ApiType>;
            /**
             * The base amount of currency needed to reserve for creating a proxy.
             *
             * This is held for an additional storage item whose value size is `sizeof(Balance)` bytes and whose key size is
             * `sizeof(AccountId)` bytes.
             */
            proxyDepositBase: u128 & AugmentedConst<ApiType>;
            /**
             * The amount of currency needed per proxy added.
             *
             * This is held for adding 32 bytes plus an instance of `ProxyType` more into a pre-existing storage value. Thus,
             * when configuring `ProxyDepositFactor` one should take into account `32 + proxy_type.encode().len()` bytes of data.
             */
            proxyDepositFactor: u128 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        registrar: {
            depositAmount: u128 & AugmentedConst<ApiType>;
            /** Max length of encoded genesis data */
            maxGenesisDataSize: u32 & AugmentedConst<ApiType>;
            /** Max length of para id list */
            maxLengthParaIds: u32 & AugmentedConst<ApiType>;
            maxLengthTokenSymbol: u32 & AugmentedConst<ApiType>;
            sessionDelay: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        relayStorageRoots: {
            /**
             * Limit the number of relay storage roots that will be stored. This limit applies to the number of items, not to
             * their age. Decreasing the value of `MaxStorageRoots` is a breaking change and needs a migration to clean the
             * `RelayStorageRoots` mapping.
             */
            maxStorageRoots: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        servicesPayment: {
            /** The maximum number of block production credits that can be accumulated */
            freeBlockProductionCredits: u32 & AugmentedConst<ApiType>;
            /** The maximum number of collator assigment production credits that can be accumulated */
            freeCollatorAssignmentCredits: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        streamPayment: {
            openStreamHoldAmount: u128 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        system: {
            /** Maximum number of block number to block hash mappings to keep (oldest pruned first). */
            blockHashCount: u32 & AugmentedConst<ApiType>;
            /** The maximum length of a block (in bytes). */
            blockLength: FrameSystemLimitsBlockLength & AugmentedConst<ApiType>;
            /** Block & extrinsics weights: base values and limits. */
            blockWeights: FrameSystemLimitsBlockWeights & AugmentedConst<ApiType>;
            /** The weight of runtime database operations the runtime can invoke. */
            dbWeight: SpWeightsRuntimeDbWeight & AugmentedConst<ApiType>;
            /**
             * The designated SS58 prefix of this chain.
             *
             * This replaces the "ss58Format" property declared in the chain spec. Reason is that the runtime should know
             * about the prefix in order to make use of it as an identifier of the chain.
             */
            ss58Prefix: u16 & AugmentedConst<ApiType>;
            /** Get the chain's in-code version. */
            version: SpVersionRuntimeVersion & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        timestamp: {
            /**
             * The minimum period between blocks.
             *
             * Be aware that this is different to the _expected_ period that the block production apparatus provides. Your
             * chosen consensus system will generally work with this to determine a sensible block time. For example, in the
             * Aura pallet it will be double this period on default settings.
             */
            minimumPeriod: u64 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        transactionPayment: {
            /**
             * A fee multiplier for `Operational` extrinsics to compute "virtual tip" to boost their `priority`
             *
             * This value is multiplied by the `final_fee` to obtain a "virtual tip" that is later added to a tip component in
             * regular `priority` calculations. It means that a `Normal` transaction can front-run a similarly-sized
             * `Operational` extrinsic (with no tip), by including a tip value greater than the virtual tip.
             *
             * ```rust,ignore
             * // For `Normal`
             * let priority = priority_calc(tip);
             *
             * // For `Operational`
             * let virtual_tip = (inclusion_fee + tip) * OperationalFeeMultiplier;
             * let priority = priority_calc(tip + virtual_tip);
             * ```
             *
             * Note that since we use `final_fee` the multiplier applies also to the regular `tip` sent with the transaction.
             * So, not only does the transaction get a priority bump based on the `inclusion_fee`, but we also amplify the
             * impact of tips applied to `Operational` transactions.
             */
            operationalFeeMultiplier: u8 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        treasury: {
            /** Percentage of spare funds (if any) that are burnt per spend period. */
            burn: Permill & AugmentedConst<ApiType>;
            /**
             * The maximum number of approvals that can wait in the spending queue.
             *
             * NOTE: This parameter is also used within the Bounties Pallet extension if enabled.
             */
            maxApprovals: u32 & AugmentedConst<ApiType>;
            /** The treasury's pallet id, used for deriving its sovereign account ID. */
            palletId: FrameSupportPalletId & AugmentedConst<ApiType>;
            /** The period during which an approved treasury spend has to be claimed. */
            payoutPeriod: u32 & AugmentedConst<ApiType>;
            /**
             * Fraction of a proposal's value that should be bonded in order to place the proposal. An accepted proposal gets
             * these back. A rejected proposal does not.
             */
            proposalBond: Permill & AugmentedConst<ApiType>;
            /** Maximum amount of funds that should be placed in a deposit for making a proposal. */
            proposalBondMaximum: Option<u128> & AugmentedConst<ApiType>;
            /** Minimum amount of funds that should be placed in a deposit for making a proposal. */
            proposalBondMinimum: u128 & AugmentedConst<ApiType>;
            /** Period between successive spends. */
            spendPeriod: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        txPause: {
            /**
             * Maximum length for pallet name and call name SCALE encoded string names.
             *
             * TOO LONG NAMES WILL BE TREATED AS PAUSED.
             */
            maxNameLen: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        utility: {
            /** The limit on the number of batched calls. */
            batchedCallsLimit: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        xcmCoreBuyer: {
            /**
             * Additional ttl for in flight orders (total would be CoreBuyingXCMQueryTtl + AdditionalTtlForInflightOrders)
             * after which the in flight orders can be cleaned up by anyone.
             */
            additionalTtlForInflightOrders: u32 & AugmentedConst<ApiType>;
            /** TTL to be used in xcm's notify query */
            coreBuyingXCMQueryTtl: u32 & AugmentedConst<ApiType>;
            /** TTL for pending blocks entry, which prevents anyone to submit another core buying xcm. */
            pendingBlocksTtl: u32 & AugmentedConst<ApiType>;
            universalLocation: StagingXcmV4Junctions & AugmentedConst<ApiType>;
            /**
             * A configuration for base priority of unsigned transactions.
             *
             * This is exposed so that it can be tuned for particular runtime, when multiple pallets send unsigned transactions.
             */
            unsignedPriority: u64 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
        xcmpQueue: {
            /**
             * The maximum number of inbound XCMP channels that can be suspended simultaneously.
             *
             * Any further channel suspensions will fail and messages may get dropped without further notice. Choosing a high
             * value (1000) is okay; the trade-off that is described in [`InboundXcmpSuspended`] still applies at that scale.
             */
            maxInboundSuspended: u32 & AugmentedConst<ApiType>;
            /** Generic const */
            [key: string]: Codec;
        };
    } // AugmentedConsts
} // declare module

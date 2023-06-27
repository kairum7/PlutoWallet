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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.pallet
{
    
    
    public enum Call
    {
        
        create = 0,
        
        force_create = 1,
        
        destroy = 2,
        
        mint = 3,
        
        force_mint = 4,
        
        burn = 5,
        
        transfer = 6,
        
        redeposit = 7,
        
        lock_item_transfer = 8,
        
        unlock_item_transfer = 9,
        
        lock_collection = 10,
        
        transfer_ownership = 11,
        
        set_team = 12,
        
        force_collection_owner = 13,
        
        force_collection_config = 14,
        
        approve_transfer = 15,
        
        cancel_approval = 16,
        
        clear_all_transfer_approvals = 17,
        
        lock_item_properties = 18,
        
        set_attribute = 19,
        
        force_set_attribute = 20,
        
        clear_attribute = 21,
        
        approve_item_attributes = 22,
        
        cancel_item_attributes_approval = 23,
        
        set_metadata = 24,
        
        clear_metadata = 25,
        
        set_collection_metadata = 26,
        
        clear_collection_metadata = 27,
        
        set_accept_ownership = 28,
        
        set_collection_max_supply = 29,
        
        update_mint_settings = 30,
        
        set_price = 31,
        
        buy_item = 32,
        
        pay_tips = 33,
        
        create_swap = 34,
        
        cancel_swap = 35,
        
        claim_swap = 36,
        
        mint_pre_signed = 37,
        
        set_attributes_pre_signed = 38,
    }
    
    /// <summary>
    /// >> 284 - Variant[pallet_nfts.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.CollectionConfig>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.CollectionConfig>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.DestroyWitness>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.MintWitness>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.ItemConfig>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT1>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.CollectionConfig>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumAttributeNamespace, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.CancelAttributesApprovalWitness>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.MintSettings>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT15, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.PriceWithDirection>, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.PriceWithDirection>>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.PreSignedMint, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.EnumMultiSignature, PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.PreSignedAttributes, PlutoWallet.NetApiExt.Generated.Model.sp_runtime.EnumMultiSignature, PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>
    {
    }
}

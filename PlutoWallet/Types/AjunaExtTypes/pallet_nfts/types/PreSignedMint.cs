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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 300 - Composite[pallet_nfts.types.PreSignedMint]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PreSignedMint : BaseType
    {
        
        /// <summary>
        /// >> collection
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _collection;
        
        /// <summary>
        /// >> item
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _item;
        
        /// <summary>
        /// >> attributes
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> _attributes;
        
        /// <summary>
        /// >> metadata
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _metadata;
        
        /// <summary>
        /// >> only_account
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _onlyAccount;
        
        /// <summary>
        /// >> deadline
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _deadline;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Collection
        {
            get
            {
                return this._collection;
            }
            set
            {
                this._collection = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> Attributes
        {
            get
            {
                return this._attributes;
            }
            set
            {
                this._attributes = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> OnlyAccount
        {
            get
            {
                return this._onlyAccount;
            }
            set
            {
                this._onlyAccount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Deadline
        {
            get
            {
                return this._deadline;
            }
            set
            {
                this._deadline = value;
            }
        }
        
        public override string TypeName()
        {
            return "PreSignedMint";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Collection.Encode());
            result.AddRange(Item.Encode());
            result.AddRange(Attributes.Encode());
            result.AddRange(Metadata.Encode());
            result.AddRange(OnlyAccount.Encode());
            result.AddRange(Deadline.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Collection = new Substrate.NetApi.Model.Types.Primitive.U32();
            Collection.Decode(byteArray, ref p);
            Item = new Substrate.NetApi.Model.Types.Primitive.U32();
            Item.Decode(byteArray, ref p);
            Attributes = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>();
            Attributes.Decode(byteArray, ref p);
            Metadata = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Metadata.Decode(byteArray, ref p);
            OnlyAccount = new Substrate.NetApi.Model.Types.Base.BaseOpt<PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>();
            OnlyAccount.Decode(byteArray, ref p);
            Deadline = new Substrate.NetApi.Model.Types.Primitive.U32();
            Deadline.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

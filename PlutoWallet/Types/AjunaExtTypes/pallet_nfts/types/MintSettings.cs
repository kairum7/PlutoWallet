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
    /// >> 288 - Composite[pallet_nfts.types.MintSettings]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintSettings : BaseType
    {
        
        /// <summary>
        /// >> mint_type
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumMintType _mintType;
        
        /// <summary>
        /// >> price
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> _price;
        
        /// <summary>
        /// >> start_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _startBlock;
        
        /// <summary>
        /// >> end_block
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> _endBlock;
        
        /// <summary>
        /// >> default_item_settings
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2 _defaultItemSettings;
        
        public PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumMintType MintType
        {
            get
            {
                return this._mintType;
            }
            set
            {
                this._mintType = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> StartBlock
        {
            get
            {
                return this._startBlock;
            }
            set
            {
                this._startBlock = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> EndBlock
        {
            get
            {
                return this._endBlock;
            }
            set
            {
                this._endBlock = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2 DefaultItemSettings
        {
            get
            {
                return this._defaultItemSettings;
            }
            set
            {
                this._defaultItemSettings = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintSettings";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MintType.Encode());
            result.AddRange(Price.Encode());
            result.AddRange(StartBlock.Encode());
            result.AddRange(EndBlock.Encode());
            result.AddRange(DefaultItemSettings.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MintType = new PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.EnumMintType();
            MintType.Decode(byteArray, ref p);
            Price = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            Price.Decode(byteArray, ref p);
            StartBlock = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            StartBlock.Decode(byteArray, ref p);
            EndBlock = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            EndBlock.Decode(byteArray, ref p);
            DefaultItemSettings = new PlutoWallet.NetApiExt.Generated.Model.pallet_nfts.types.BitFlagsT2();
            DefaultItemSettings.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

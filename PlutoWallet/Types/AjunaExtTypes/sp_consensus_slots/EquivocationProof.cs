//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.sp_consensus_slots
{
    
    
    /// <summary>
    /// >> 186 - Composite[sp_consensus_slots.EquivocationProof]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class EquivocationProof : BaseType
    {
        
        /// <summary>
        /// >> offender
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_consensus_babe.app.Public _offender;
        
        /// <summary>
        /// >> slot
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_consensus_slots.Slot _slot;
        
        /// <summary>
        /// >> first_header
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header _firstHeader;
        
        /// <summary>
        /// >> second_header
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header _secondHeader;
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_consensus_babe.app.Public Offender
        {
            get
            {
                return this._offender;
            }
            set
            {
                this._offender = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_consensus_slots.Slot Slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header FirstHeader
        {
            get
            {
                return this._firstHeader;
            }
            set
            {
                this._firstHeader = value;
            }
        }
        
        public PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header SecondHeader
        {
            get
            {
                return this._secondHeader;
            }
            set
            {
                this._secondHeader = value;
            }
        }
        
        public override string TypeName()
        {
            return "EquivocationProof";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Offender.Encode());
            result.AddRange(Slot.Encode());
            result.AddRange(FirstHeader.Encode());
            result.AddRange(SecondHeader.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Offender = new PlutoWallet.NetApiExt.Generated.Model.sp_consensus_babe.app.Public();
            Offender.Decode(byteArray, ref p);
            Slot = new PlutoWallet.NetApiExt.Generated.Model.sp_consensus_slots.Slot();
            Slot.Decode(byteArray, ref p);
            FirstHeader = new PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header();
            FirstHeader.Decode(byteArray, ref p);
            SecondHeader = new PlutoWallet.NetApiExt.Generated.Model.sp_runtime.generic.header.Header();
            SecondHeader.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

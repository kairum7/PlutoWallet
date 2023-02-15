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


namespace PlutoWallet.NetApiExt.Generated.Model.sp_core.sr25519
{
    
    
    /// <summary>
    /// >> 101 - Composite[sp_core.sr25519.Signature]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Signature : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private PlutoWallet.NetApiExt.Generated.Types.Base.Arr64U8 _value;
        
        public PlutoWallet.NetApiExt.Generated.Types.Base.Arr64U8 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "Signature";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new PlutoWallet.NetApiExt.Generated.Types.Base.Arr64U8();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

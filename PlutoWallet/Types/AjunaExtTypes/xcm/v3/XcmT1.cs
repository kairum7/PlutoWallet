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


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v3
{
    
    
    /// <summary>
    /// >> 55 - Composite[xcm.v3.XcmT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class XcmT1 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v3.EnumInstruction> _value;
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v3.EnumInstruction> Value
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
            return "XcmT1";
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
            Value = new Substrate.NetApi.Model.Types.Base.BaseVec<PlutoWallet.NetApiExt.Generated.Model.xcm.v3.EnumInstruction>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

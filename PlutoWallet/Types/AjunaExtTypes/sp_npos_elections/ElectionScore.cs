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


namespace PlutoWallet.NetApiExt.Generated.Model.sp_npos_elections
{
    
    
    /// <summary>
    /// >> 88 - Composite[sp_npos_elections.ElectionScore]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ElectionScore : BaseType
    {
        
        /// <summary>
        /// >> minimal_stake
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _minimalStake;
        
        /// <summary>
        /// >> sum_stake
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _sumStake;
        
        /// <summary>
        /// >> sum_stake_squared
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _sumStakeSquared;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 MinimalStake
        {
            get
            {
                return this._minimalStake;
            }
            set
            {
                this._minimalStake = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 SumStake
        {
            get
            {
                return this._sumStake;
            }
            set
            {
                this._sumStake = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 SumStakeSquared
        {
            get
            {
                return this._sumStakeSquared;
            }
            set
            {
                this._sumStakeSquared = value;
            }
        }
        
        public override string TypeName()
        {
            return "ElectionScore";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MinimalStake.Encode());
            result.AddRange(SumStake.Encode());
            result.AddRange(SumStakeSquared.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MinimalStake = new Ajuna.NetApi.Model.Types.Primitive.U128();
            MinimalStake.Decode(byteArray, ref p);
            SumStake = new Ajuna.NetApi.Model.Types.Primitive.U128();
            SumStake.Decode(byteArray, ref p);
            SumStakeSquared = new Ajuna.NetApi.Model.Types.Primitive.U128();
            SumStakeSquared.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

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


namespace PlutoWallet.NetApiExt.Generated.Model.xcm.v2
{
    
    
    public enum BodyId
    {
        
        Unit = 0,
        
        Named = 1,
        
        Index = 2,
        
        Executive = 3,
        
        Technical = 4,
        
        Legislative = 5,
        
        Judicial = 6,
        
        Defense = 7,
        
        Administration = 8,
        
        Treasury = 9,
    }
    
    /// <summary>
    /// >> 94 - Variant[xcm.v2.BodyId]
    /// </summary>
    public sealed class EnumBodyId : BaseEnumExt<BodyId, BaseVoid, PlutoWallet.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT1, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid>
    {
    }
}

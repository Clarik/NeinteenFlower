//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrDetail
    {
        public int TransactionID { get; set; }
        public int FlowerID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual MsFlower MsFlower { get; set; }
        public virtual TrHeader TrHeader { get; set; }
    }
}

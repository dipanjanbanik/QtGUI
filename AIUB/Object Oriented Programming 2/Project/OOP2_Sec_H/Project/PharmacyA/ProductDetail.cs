//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmacyA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDetail
    {
        public int Id { get; set; }
        public int BoxNo { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public byte[] Image { get; set; }
    
        public virtual ProductInfo ProductInfo { get; set; }
    }
}

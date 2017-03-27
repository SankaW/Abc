//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SW01.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Product_ProductCode { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> SubCategory_Id { get; set; }
        public Nullable<int> ManufacturerId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> ModelId { get; set; }
        public Nullable<int> ColorId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsUnit { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.Guid> ModifiedBy { get; set; }
        public Nullable<decimal> Weighted_Avg_Price { get; set; }
        public Nullable<decimal> ReOrderLevel { get; set; }
        public string ProductLogo { get; set; }
        public Nullable<int> LengthId { get; set; }
        public string Ref_Code { get; set; }
    }
}

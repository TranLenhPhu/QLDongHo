//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_06.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETDONHANG
    {
        public int MaDonHang { get; set; }
        public int MaDongHo { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
    
        public virtual DONDATHANG DONDATHANG { get; set; }
        public virtual DONGHO DONGHO { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKinhDoanhNhaThuoc.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class HANG_THUOC
    {
        public HANG_THUOC()
        {
            this.CT_CUNGCAP_THUOC = new HashSet<CT_CUNGCAP_THUOC>();
        }
    
        public string ma_hangthuoc { get; set; }
        public string ten_hangthuoc { get; set; }
        public string dia_chi { get; set; }
        public Nullable<int> sodienthoai { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<CT_CUNGCAP_THUOC> CT_CUNGCAP_THUOC { get; set; }
    }
}

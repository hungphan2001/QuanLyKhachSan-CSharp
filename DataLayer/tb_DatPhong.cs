//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_DatPhong
    {
        public int ID { get; set; }
        public Nullable<int> IDKH { get; set; }
        public Nullable<int> IDPHONG { get; set; }
        public Nullable<System.DateTime> NGAYDAT { get; set; }
        public Nullable<System.DateTime> NGAYTRA { get; set; }
        public Nullable<int> SONGAYTHUCO { get; set; }
        public Nullable<int> UID { get; set; }
        public Nullable<int> IDSP { get; set; }
    
        public virtual tb_KhachHang tb_KhachHang { get; set; }
        public virtual tb_Phong tb_Phong { get; set; }
        public virtual tb_Users tb_Users { get; set; }
    }
}

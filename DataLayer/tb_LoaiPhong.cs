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
    
    public partial class tb_LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_LoaiPhong()
        {
            this.tb_Phong = new HashSet<tb_Phong>();
        }
    
        public int IDLOAIPHONG { get; set; }
        public string TENLOAIPHONG { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<int> SONGUOI { get; set; }
        public Nullable<int> SOLUONG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Phong> tb_Phong { get; set; }
    }
}
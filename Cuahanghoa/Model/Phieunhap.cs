//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cuahanghoa.Model
{
    using Cuahanghoa.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class Phieunhap: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieunhap()
        {
            this.Phieunhapchitiet = new HashSet<Phieunhapchitiet>();
        }

        private string _Idphieunhap;
        public string Idphieunhap { get => _Idphieunhap; set { _Idphieunhap = value; OnPropertyChanged(); } }

        public Nullable<System.DateTime> _Ngaynhap;
        public Nullable<System.DateTime> Ngaynhap { get => _Ngaynhap; set { _Ngaynhap = value; OnPropertyChanged(); } }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieunhapchitiet> Phieunhapchitiet { get; set; }
    }
}
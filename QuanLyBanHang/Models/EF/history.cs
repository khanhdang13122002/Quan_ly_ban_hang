//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class history
    {
        public int historyId { get; set; }
        public Nullable<int> userId { get; set; }
        public string action { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public Nullable<bool> isProduct { get; set; }
        public Nullable<bool> isOrder { get; set; }
        public Nullable<bool> isUser { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrmMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class tmember_rate_class
    {
        public int rate_id { get; set; }
        public int reserve_id { get; set; }
        public int member_id { get; set; }
        public int class_id { get; set; }
        public int coach_id { get; set; }
        public decimal rate_class { get; set; }
        public string class_describe { get; set; }
        public decimal rate_coach { get; set; }
        public string coach_describe { get; set; }
    
        public virtual tclass_reserve tclass_reserve { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gymEntities : DbContext
    {
        public gymEntities()
            : base("name=gymEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tcity> tcity { get; set; }
        public virtual DbSet<tclass_limit_details> tclass_limit_details { get; set; }
        public virtual DbSet<tclass_reserve> tclass_reserve { get; set; }
        public virtual DbSet<tclass_schedule> tclass_schedule { get; set; }
        public virtual DbSet<tclass_sort_有氧> tclass_sort_有氧 { get; set; }
        public virtual DbSet<tclass_sort_訓練> tclass_sort_訓練 { get; set; }
        public virtual DbSet<tclass_status_detail> tclass_status_detail { get; set; }
        public virtual DbSet<tclasses> tclasses { get; set; }
        public virtual DbSet<tcoach_expert> tcoach_expert { get; set; }
        public virtual DbSet<tcoach_info_id> tcoach_info_id { get; set; }
        public virtual DbSet<tcoach_photo> tcoach_photo { get; set; }
        public virtual DbSet<tcompany> tcompany { get; set; }
        public virtual DbSet<tcourse_photo> tcourse_photo { get; set; }
        public virtual DbSet<tfield> tfield { get; set; }
        public virtual DbSet<tfield_photo> tfield_photo { get; set; }
        public virtual DbSet<tfield_reserve> tfield_reserve { get; set; }
        public virtual DbSet<tgender_Table> tgender_Table { get; set; }
        public virtual DbSet<tGym> tGym { get; set; }
        public virtual DbSet<tIdentity> tIdentity { get; set; }
        public virtual DbSet<tidentity_role_detail> tidentity_role_detail { get; set; }
        public virtual DbSet<tmember_follow> tmember_follow { get; set; }
        public virtual DbSet<tmember_rate_class> tmember_rate_class { get; set; }
        public virtual DbSet<tmember_status_details> tmember_status_details { get; set; }
        public virtual DbSet<towner> towner { get; set; }
        public virtual DbSet<tregion_table> tregion_table { get; set; }
        public virtual DbSet<ttimes_detail> ttimes_detail { get; set; }
    }
}

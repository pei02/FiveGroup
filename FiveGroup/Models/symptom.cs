//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FiveGroup.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class symptom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public symptom()
        {
            this.dep_sym_ref = new HashSet<dep_sym_ref>();
        }
    
        public string sym_id { get; set; }
        public string sym_name { get; set; }
        public string part_id { get; set; }
    
        public virtual bodypart bodypart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dep_sym_ref> dep_sym_ref { get; set; }
    }
}

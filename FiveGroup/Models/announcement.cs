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
    
    public partial class announcement
    {
        //[Key]
        //[DisplayName("編號")]
        //[Required(ErrorMessage = "編號為必填")]
        //[MaxLength(25, ErrorMessage = "最大長度為5")]
        public string a_id { get; set; }
        //[DisplayName("日期")]
        //[Required(ErrorMessage = "日期為必填")]
        //[DataType(DataType.DateTime, ErrorMessage = "輸入日期有誤")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public System.DateTime a_date { get; set; }
        //[DisplayName("內容")]
        //[Required(ErrorMessage = "內容為必填")]
        //[MaxLength(30, ErrorMessage = "內容最大長度為150")]
        public string a_content { get; set; }
        //[DisplayName("顯示")]
        //[Required(ErrorMessage = "顯示為必填")]
        public bool a_display { get; set; }
    }
}

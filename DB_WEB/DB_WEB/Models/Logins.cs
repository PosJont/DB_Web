using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DB_WEB.Models
{
    public class Logins
    {
        [Required]
        [Display(Name = "SQL Server 名稱") ]
        public string Sql_Code { get; set; }

        [Required]
        [Display(Name = "資料庫名稱")]
        public string DB_Code { get; set; }

        [Required]
        [Display(Name = "登入帳號")]
        public string usr_Code { get; set; }

        [Required]
        [Display(Name = "登入密碼")]
        [DataType(DataType.Password)]
        public string usr_password { get; set; }
    }
}

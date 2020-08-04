using System;
using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Data
{

    public class Role
    {
     
        [Key]
        public int PK_Role { get; set; }

        [Required]
        public string RoleName { get; set; }
        
    }
}
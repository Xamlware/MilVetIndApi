using System;
using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Authentication
{

    public class CreateRoleViewModel
    {
     
        [Key]
        public int PK_Role { get; set; }

        [Required]
        public string RoleName { get; set; }
        
    }
}
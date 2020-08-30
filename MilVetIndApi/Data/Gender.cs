using System.ComponentModel.DataAnnotations;

namespace MilVetIndApi.Data
{
	public class Gender
    {
        public Gender()
        {
        }


        [Key]
        [Required(ErrorMessage = "Gender id is required")]
        public int PK_Gender { get; set; }

        [Required(ErrorMessage = "Gender name is required")]
        public string GenderName { get; set; }
    }

}

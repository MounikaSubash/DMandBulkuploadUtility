using System.ComponentModel.DataAnnotations;

namespace DMandBulkUpload.Models
{
    public class BaseModel
    {
        [Required(ErrorMessage = "This field is Required")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        public int CreatedBy { get; set; }
    }
}

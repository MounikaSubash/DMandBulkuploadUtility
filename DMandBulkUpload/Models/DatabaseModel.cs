using System.ComponentModel.DataAnnotations;

namespace DMandBulkUpload.Models
{
    public class DatabaseModel : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        public string DataBaseName { get; set; }

    }
}

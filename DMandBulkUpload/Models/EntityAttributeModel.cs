using System.ComponentModel.DataAnnotations;

namespace DMandBulkUpload.Models
{
    public class EntityAttributeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="this field is required")]
        public string ColumnName { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public string ColumnDatatype { get; set; }
     
        public int length { get; set; }
        
        public bool Default { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime updatedDate { get; set; }
    }
}

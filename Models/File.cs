using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Application.Models
{
    [Table("File")]
    public class File
    {
        public File() : base()
        {
            DocumentId = Guid .NewGuid(); 
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string FileType { get; set; }

        [MaxLength]
        public byte[] DataFiles { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

    }
}
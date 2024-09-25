using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core_Web_App.Models
{
    public class FileStorageInfo
    {
        [Key]
        [Column("Id",TypeName ="varchar(16)")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("Data",TypeName = "varbinary(max)")]
        public byte[] Data { get; set; }    
    }
}




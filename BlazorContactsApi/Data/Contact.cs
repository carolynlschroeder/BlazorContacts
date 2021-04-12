using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorContactsApi.Data
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string Name { get; set; }
        [MaxLength(150)]
        [Required]
        public string Address { get; set; }
        [MaxLength(100)]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "char(2)")]
        [Required]
        public string State { get; set; }
        [MaxLength(10)]
        [Required]
        public string Zip { get; set; }
    }
}

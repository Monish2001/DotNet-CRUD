using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class ApplicationType
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}
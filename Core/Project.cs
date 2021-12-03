using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public string? ProjectName { get; set; }

        public string? ProjectDescription { get; set; }

        //naviation property for ef core
        public Issue ?Issue { get; set; }

    }
}

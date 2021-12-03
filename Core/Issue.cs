using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Issue
    {
        public int IssueId { get; set; }
        [Required]
        public int? ProjectId { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? SeverityId { get; set; }

    }
}
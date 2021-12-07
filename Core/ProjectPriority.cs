using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ProjectPriority
    {
        public int Id { get; set; }

        [DisplayName("Project Repository")]
        public string Name { get; set; }
    }
}

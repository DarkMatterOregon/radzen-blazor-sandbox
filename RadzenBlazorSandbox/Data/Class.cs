using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RadzenBlazorSandbox.Data
{
    public class Class
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


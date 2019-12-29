using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RadzenBlazorSandbox.Data
{
    public class Roster
    {
        [Key]
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string StudentId { get; set; }

    }
}


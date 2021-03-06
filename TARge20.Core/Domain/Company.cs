using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public List<Branch> Branches { get; set; }
        public int RegistryID { get; set; }
        public string? Address { get; set; }
        public string PhooneNR { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Data
{
    public class Demographic
    {
        public GenderEnum Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Race { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public DateTime LastUpdated { get; set; }       
    }
}

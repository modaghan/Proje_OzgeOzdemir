using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proje.Models
{
    [Table("Companies")]
    [DisplayName("Firmalar")]
    public class Company
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string TaxNo { get; set; }
        public string ContactAddress { get; set; }
        public string Owner { get; set; }
        public string Phone { get; set; }
        public string NaceCode { get; set; }
        public DateTime ProductionStarting { get; set; }
        public bool IsRegistered { get; set; }
        public DateTime LastCheck { get; set; }
        public DateTime DateCreated { get; set; }

        public States GetState()
        {
            if (IsRegistered)
                return States.Completed;
            else if (ProductionStarting > DateTime.Now) 
                return States.Continue;
            else if (
                (DateTime.Now - ProductionStarting).Days <= 
                Properties.Settings.Default.RegistrationDayLimit) 
                return States.Continue; 
            else 
                return States.InPenalty;
        }
    }
}

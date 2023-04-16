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
    [Table("Logs")]
    [DisplayName("Hata Kayıtları")]
    public class Log
    {
        public Log(Exception ex)
        {
            this.Exception = ex;
            this.DateCreated = DateTime.Now;
        }
        public Guid Id { get; set; }

        public Exception Exception { get; set; }

        public DateTime DateCreated { get; set; }

        public override string ToString()
        {
            if (Exception.InnerException != null)
            {
                return Exception.ToString() + "\n" + Exception.InnerException.ToString();
            }
            else
            {
                return Exception.ToString();
            }
        }
    }
}

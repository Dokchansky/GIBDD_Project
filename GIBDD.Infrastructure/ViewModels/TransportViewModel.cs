using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD.Infrastructure.ViewModels
{
    public class TransportViewModel
    {
        public long ID { get; set; }
        public long ModelID { get; set; }
        public string StateNumber { get; set; }
        public string Status { get; set; }
        public string Year { get; set; }
        public long UserID { get; set; }


    }
}

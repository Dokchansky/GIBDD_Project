using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD.Infrastructure.ViewModels
{
    public class FineViewModel
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Status { get; set; }
        public long TypeID { get; set; }
        public long TransportID { get; set; }
        public long TransportName { get; set; }

    }
}

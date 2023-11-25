using GIBDD.Infrastructure.Mappers;
using GIBDD.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD.Infrastructure.Database
{
    public class TransportRepository
    {
        public List<TransportViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Transports.ToList();
                return TransportMapper.Map(items);
            }
        }
    }
}

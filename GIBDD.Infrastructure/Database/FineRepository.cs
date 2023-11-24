using GIBDD.Infrastructure.Mappers;
using GIBDD.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD.Infrastructure.Database
{
    internal class FineRepository
    {
        public List<FineViewModel> GetList()
        {

            using (var context = new Context())
            {
                var items = context.Fines.ToList();
                return FineMapper.Map(items);
            }
        }
        public FineViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Fines.FirstOrDefault(x => x.ID == id);
                return FineMapper.Map(item);
            }
        }
    }
}

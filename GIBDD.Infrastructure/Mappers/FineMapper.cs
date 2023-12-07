using GIBDD.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDD.Infrastructure.Mappers
{
    internal class FineMapper
    {
        public static FineViewModel Map(FineEntity entity)
        {
            var viewModel = new FineViewModel
            {
                ID = entity.ID,
                Name = entity.Name,
                Status = entity.Status,
                Value = entity.Value,
                TypeID = entity.TypeID,
                TransportID = entity.TransportID,

            };
            return viewModel;
        }

        public static List<FineViewModel> Map(List<FineEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        internal static object Map(FineViewModel viewModel)
        {
            throw new NotImplementedException();
        }

    }
}

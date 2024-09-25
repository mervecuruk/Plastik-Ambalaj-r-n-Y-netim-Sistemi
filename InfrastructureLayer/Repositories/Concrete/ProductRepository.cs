using DomainLayer.Entities.Concrete;
using DomainLayer.Enums;
using DomainLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Concrete
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public List<Material> GetAllMaterials()
        {
            return Enum.GetValues(typeof(Material))
        .Cast<Material>()
        .ToList();
        }
    }
}

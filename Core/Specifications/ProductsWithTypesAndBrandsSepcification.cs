using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSepcification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSepcification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSepcification(int id) : base(x=>x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}
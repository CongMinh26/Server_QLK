using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.Product;

namespace Application.AProduct
{
    public interface IProductService
    {
        Task<int> AddProduct(ProductCreateRequest product);
        Task<int> Delete(int productId);
        Task<ApiResult<ProductVm>> Update(ProductUpdateRequest product);
        Task<PagedResult<ProductVm>> GetAll(GetProductPage product);
        Task<ApiResult<ProductVm>> GetById(ProductDelete product);
        Task<ApiResult<ProductVm>> AddListProduct(List<ProductVm> listProduct);
    }
}

using AMiZin.Application.Common;
using DataBase.EF;
using DataBase.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Common;
using ViewModel.Product;
using System.Linq;
namespace Application.AProduct
{
    public class ProductService : IProductService
    {
        private readonly QuanLyDBContext _context;
        private readonly IStorageService _storageService;
        public ProductService(QuanLyDBContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
        public async Task<int> AddProduct(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.name,
                Unit = request.unit,
                Quantity = request.amount
                
            };
            if(request.ThumbnailImage != null)
            {
                product.productImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Cation = "Thumbnail Image",
                        ProductId = product.ProductId,
                        PathImage = await this.SaveFile(request.ThumbnailImage),
                        FileSize = request.ThumbnailImage.Length,
                        SortOrder =1
                    }
                };
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.ProductId;
        }
       

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                throw new Exception($"Can't find a product:{productId}");
            }
            var images = _context.ProductImages.Where(i => i.ProductId == productId);
            foreach(var item in images)
            {
                await _storageService.DeleteFileAsync(item.PathImage);
            }
            _context.Remove(product);
             await _context.SaveChangesAsync();
            return productId;
        }
        public Task<ApiResult<ProductVm>> Update(ProductVm product)
        {
            throw new NotImplementedException();
        }
        public Task<ApiResult<ProductVm>> GetById(ProductDelete product)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ProductVm>> GetAll(GetProductPage product)
        {
            throw new NotImplementedException();
        }

       


       
        public Task<ApiResult<ProductVm>> AddListProduct(List<ProductVm> listProduct)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<ProductVm>> Update(ProductUpdateRequest product)
        {
            throw new NotImplementedException();
        }
    }
}

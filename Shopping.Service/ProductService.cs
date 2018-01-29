using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Service.Interface;
using Shopping.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Service
{
    public class ProductService : ServiceBase, IProductService
    {
        public ProductService(ShoppingContext context, IMapper mapper) : base(context, mapper)
        { }

        #region 新增
        public async Task CreateAsync(ProductDto dto)
        {
            dto.CreateDate = DateTime.Now;
            dto.IsDelete = false;
            _context.Add(dto);
            await _context.SaveChangesAsync();
        }
        #endregion

        public Task DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int? Id)
        {
            throw new NotImplementedException();
        }

        #region 產品類別下拉選單
        //public async Task<IEnumerable<SelectListItem>> GetProductCateSelectListAsync()
        //{
        //    var items = new List<SelectListItem>();

        //    var selectList = await _context.ProductCate.AsNoTracking().ToListAsync();

        //    foreach (var i in selectList)
        //    {
        //        var item = new SelectListItem()
        //        {
        //            Text = i.CateName,
        //            Value = i.Id.ToString(),
        //        };
        //        items.Add(item);
        //    }

        //    return items;
        //}
        #endregion

        #region 產品類別下拉選單-改
        public async Task<IEnumerable<ProductCateModel>> GetProductCateSelectListAsync()
        {
            var model = await _context.ProductCate.Select(pc => new ProductCateModel
            {
                Id = pc.Id,
                CateName = pc.CateName,
            }).AsNoTracking().ToListAsync();

            return model;
        }
        #endregion

        #region 產品單位下拉選單
        //public async Task<IEnumerable<SelectListItem>> GetUnitSelectListAsync()
        //{
        //    var items = new List<SelectListItem>();

        //    var selectList = await _context.Unit.AsNoTracking().ToListAsync();

        //    foreach (var i in selectList)
        //    {
        //        var item = new SelectListItem()
        //        {
        //            Text = i.UnitName,
        //            Value = i.Id.ToString(),
        //        };
        //        items.Add(item);
        //    }

        //    return items;
        //}
        #endregion

        #region 產品單位下拉選單-改
        public async Task<IEnumerable<UnitModel>> GetUnitSelectListAsync()
        {
            var model = await _context.Unit.Select(u => new UnitModel
            {
                Id = u.Id,
                UnitName = u.UnitName
            }).AsNoTracking().ToListAsync();

            return model;
        }
        #endregion

        #region 產品類別列表
        public async Task<IEnumerable<ProductCateModel>> GetProductCateListAsync()
        {
            var result = await _context.ProductCate.Select(p => new ProductCateModel
            {
                Id = p.Id,
                CateName = p.CateName
            }).AsNoTracking().ToListAsync();

            return result;
        }
        #endregion

        #region 產品單位列表
        public async Task<IEnumerable<UnitModel>> GetUnitListAsync()
        {
            var result = await _context.Unit.Select(u => new UnitModel
            {
                Id = u.Id,
                UnitName = u.UnitName
            }).AsNoTracking().ToListAsync();

            return result;
        }
        #endregion

        public async Task CreateCateAsync(ProductCateCreateModel model)
        {
            var entity = _mapper.Map<ProductCateCreateModel, ProductCate>(model);

            _context.ProductCate.Add(entity);

            await _context.SaveChangesAsync();
        }

    }
}

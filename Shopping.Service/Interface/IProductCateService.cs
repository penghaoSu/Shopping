using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Interface
{
    public interface IProductCateService
    {
        /// <summary>
        /// 單筆產品
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        //Task<Product> GetByIdAsync(int? Id);

        // 取列表
        //Task<IEnumerable<Company>> GetAllAsync(CompanySearch param, int page);

        /// <summary>
        /// 新增產品
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        //Task CreateAsync(ProductDto dto);

        // 編輯
        //Task EditAsync(int id, Company model);

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //Task DeleteAsync(int? id);

        /// <summary>
        /// 產品類別下拉選單
        /// </summary>
        /// <returns></returns>
        //Task<IEnumerable<SelectListItem>> GetProductCateSelectListAsync();

        /// <summary>
        /// 產品單位下拉選單
        /// </summary>
        /// <returns></returns>
        //Task<IEnumerable<SelectListItem>> GetUnitSelectListAsync();

        /// <summary>
        /// 產品類別列表
        /// </summary>
        /// <returns></returns>
        //Task<IEnumerable<ProductCateModel>> GetProductCateListAsync();

        /// <summary>
        /// 產品單位列表
        /// </summary>
        /// <returns></returns>
        //Task<IEnumerable<UnitDto>> GetUnitListAsync();
    }
}

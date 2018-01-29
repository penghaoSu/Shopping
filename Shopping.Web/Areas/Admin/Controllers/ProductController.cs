using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;
using Shopping.Service.Interface;
using Shopping.Service.Models;

namespace Shopping.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        public IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // GET: Product
        public IActionResult Index()
        {
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // 新增
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // 產品分類列表-Partial View
        public IActionResult ProductCate()
        {
            return PartialView("_ProductCatePartial");
        }

        // 產品分類-資料
        [HttpPost]
        public async Task<Response<IEnumerable<ProductCateModel>>> GetProductCate()
        {
            var response = new Response<IEnumerable<ProductCateModel>>
            {
                Data = await _productService.GetProductCateListAsync()
            };

            return response;
        }

        // 產品分類-新增
        [HttpPost]
        public async Task<Response<ProductCateModel>> CreateCate([FromBody]ProductCateCreateModel requset)
        {
            var response = new Response<ProductCateModel>();

            try
            {
                await _productService.CreateCateAsync(requset);

                response.IsSuccess = true;

            }
            catch (DbUpdateException ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        // 產品分類選單
        public async Task<Response<IEnumerable<ProductCateModel>>> GetProductCateSelectList()
        {
            var response = new Response<IEnumerable<ProductCateModel>>();

            try
            {
                response.Data = await _productService.GetProductCateSelectListAsync();

                response.IsSuccess = true;
            }
            catch (DbUpdateException ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        // 產品單位列表-Partial View
        public IActionResult Unit()
        {
            return PartialView("_UnitPartial");
        }

        // 產品單位-資料
        [HttpPost]
        public async Task<Response<IEnumerable<UnitModel>>> GetUnit()
        {
            var response = new Response<IEnumerable<UnitModel>>
            {
                Data = await _productService.GetUnitListAsync()
            };

            return response;
        }

        // 產品單位下拉選單
        public async Task<Response<IEnumerable<UnitModel>>> GetUnitSelectList()
        {
            var response = new Response<IEnumerable<UnitModel>>();

            try
            {
                response.Data = await _productService.GetUnitSelectListAsync();

                response.IsSuccess = true;
            }
            catch (DbUpdateException ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrundsBooks.DataAccess.Repository.IRepository;
using VrundsBooks.Models;

namespace VrundsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);
            }

            category = _unitofWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound(category);
            }
            return View(category);
        }

        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitofWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}

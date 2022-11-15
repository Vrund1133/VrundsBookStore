using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrundsBooks.DataAccess.Repository.IRepository;

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

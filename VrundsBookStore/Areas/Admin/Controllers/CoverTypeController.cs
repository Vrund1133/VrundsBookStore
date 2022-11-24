﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrundsBooks.DataAccess.Repository.IRepository;

namespace VrundsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        // API Calls
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });

        }
        #endregion
    }
}

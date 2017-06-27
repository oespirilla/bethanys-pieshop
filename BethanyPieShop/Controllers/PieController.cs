using System;
using Microsoft.AspNetCore.Mvc;
using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;

namespace BethanyPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;


        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PieListViewModel piesListViewModel = new PieListViewModel();
            piesListViewModel.Pies = _pieRepository.Pies;
            piesListViewModel.CurrentCategory = "Cheese Cakes";

            return View(piesListViewModel);
        }
    }
}

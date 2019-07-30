using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TenXOne.Models;
using TenXOne.Services;
using TenXOne.ViewModels;

namespace TenXOne.Controllers
{
    public class FinancialItemsController : Controller
    {
        private readonly IFinancialItemsService _financialItemsService;

        public FinancialItemsController(IFinancialItemsService financialItemsService)
        {
            _financialItemsService = financialItemsService;
        }
        public IActionResult Index()
        {
            var viewModel = new FinancialItemsViewModel();
            viewModel.FinancialItems = _financialItemsService.GetAllItems();
            viewModel.Partners = _financialItemsService.GetAllPartners();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(FinancialItem request)
        {
            _financialItemsService.AddItem(request.PartnerID, request.Date, request.Amount);
            var viewModel = new FinancialItemsViewModel();
            viewModel.FinancialItems = _financialItemsService.GetAllItems();
            viewModel.Partners = _financialItemsService.GetAllPartners();
            return PartialView( "_FinancialItemsListPartial", viewModel);
        }

        [HttpPut]
        public IActionResult Update(FinancialItem request)
        {
            _financialItemsService.UpdateItem(request.FinancialItemID, request.PartnerID, request.Date, request.Amount);
            var viewModel = new FinancialItemsViewModel();
            viewModel.FinancialItems = _financialItemsService.GetAllItems();
            viewModel.Partners = _financialItemsService.GetAllPartners();
            return PartialView( "_FinancialItemsListPartial", viewModel);
        }

        [HttpDelete]
        public IActionResult Delete(Guid itemId)
        {
            _financialItemsService.DeleteItem(itemId);
            var viewModel = new FinancialItemsViewModel();
            viewModel.FinancialItems = _financialItemsService.GetAllItems();
            viewModel.Partners = _financialItemsService.GetAllPartners();
            return PartialView( "_FinancialItemsListPartial", viewModel);
        }
    }
}

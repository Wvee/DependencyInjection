using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index() =>
        //    View(new MemoryRepository().Products);
        //public IRepository Repository { get; set; } = new MemoryRepository();
        //public IRepository Repository { get; } = TypeBroker.Repository;

        //public ViewResult Index() =>
        //    View(Repository.Products);

        private IRepository _repository;
        private ProductTotalizer _totalizer;

        public HomeController(IRepository repo, ProductTotalizer total)
        {
            _repository = repo;
            _totalizer = total;
        }
        public ViewResult Index()
        {
            //ViewBag.Total = _totalizer.Total;
            ViewBag.HomeController = _repository.ToString();
            ViewBag.Totalizer = _totalizer.Repository.ToString();
            return View(_repository.Products);
        }
    }
}

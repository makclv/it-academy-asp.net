using AutoMapper;
using Bookshop.Client.Models.Orders.Queries;
using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bookshop.Client.Controllers
{
    public class OrderController : Controller  
    {
        private readonly IOrdersDomainService ordersDomainService;

        public OrderController(IOrdersDomainService ordersDomainService)
        {
            this.ordersDomainService = ordersDomainService;
        }

        [HttpGet]
        public ActionResult GetAllOrders()
        {
            List<Order> orders = ordersDomainService.GetAllOrders();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, GetAllOrdersViewModel>()  // used for mapping example
                    .ForMember(dest => dest.Orders, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);
            var ordersVm = mapper.Map<List<Order>, GetAllOrdersViewModel>(orders);

            return Json(ordersVm, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetOrdersMadeToday()
        {
            List<Order> orders = ordersDomainService.GetOrdersMadeToday();
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<Order>, GetOrdersMadeTodayViewModel>()  // used for mapping example
                    .ForMember(dest => dest.Orders, opt => opt.MapFrom(c => c)));
            var mapper = new Mapper(config);
            var ordersVm = mapper.Map<List<Order>, GetOrdersMadeTodayViewModel>(orders);

            return Json(ordersVm, JsonRequestBehavior.AllowGet);
        }
    }
}
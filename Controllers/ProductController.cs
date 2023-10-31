using dotnet_notification.Configurations;
using dotnet_notification.Interfaces;
using dotnet_notification.Models;
using dotnet_notification.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_notification.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBaseApi
{
    private readonly ILogger<ProductController> _logger;
    private IProductService _productService;
    public ProductController(
        ILogger<ProductController> logger,
        IProductService productService,
        INotification notification) : base(notification)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return SendResponse(
            Ok(_productService.GetList())
        );
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        return SendResponse(
            Ok(_productService.Find(id))
        );
    }
}

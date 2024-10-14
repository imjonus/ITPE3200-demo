using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using Microsoft.EntityFrameworkCore;
using MyShop.DAL;

public class CustomerController : Controller
{

    private readonly ItemDbContext _itemDbContext;

    public CustomerController(ItemDbContext itemDbContext)
    {

        _itemDbContext = itemDbContext;
    }

    public async Task<ActionResult> Table()
    {
        List<Customer> customers = await _itemDbContext.Customers.ToListAsync();
        return View(customers);
    }
}
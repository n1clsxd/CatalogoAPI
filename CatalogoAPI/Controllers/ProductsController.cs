using CatalogoAPI.Context;
using CatalogoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAPI.Controllers;

[ApiController]
[Route("catalogoapi/[controller]")]
public class ProductsController :ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context) => _context = context;

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        var products = _context.Products.ToList();

        return products == null ? NotFound() : products;
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public ActionResult<Product> Get(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);

        return (product == null) ? NotFound() : product;
    }
    [HttpPost]
    public ActionResult Post(Product product)
    {
        if (product == null)
        {
            return BadRequest();
        }
        _context.Products.Add(product);
        _context.SaveChanges();
        return new CreatedAtRouteResult("GetProduct", new {id = product.Id}, product);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id,Product product) {
        if(id != product.Id) return BadRequest();

        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(product);

    }
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(product => product.Id == id);

        if (product == null) return NotFound();

        _context.Products.Remove(product); 
        _context.SaveChanges();

        return Ok(product);
    }
}

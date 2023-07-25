using CatalogoAPI.Context;
using CatalogoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAPI.Controllers;

[ApiController]
[Route("catalogoapi/[controller]")]
public class CategoriesController:ControllerBase
{
    private readonly AppDbContext _context;

    public CategoriesController(AppDbContext context) => _context = context;

    [HttpGet]
    public ActionResult<IEnumerable<Category>> GetAll()
    {
        var categories = _context.Categories.ToList();

        return categories == null ? NotFound() : categories;

    }

    [HttpGet("{id:int}", Name = "GetCategory")]
    public ActionResult<Category> Get(int id)
    {
        var category = _context.Categories.FirstOrDefault(category => category.Id == id);

        return (category == null) ? NotFound() : category;
    }

    [HttpGet("products")]
    public ActionResult<IEnumerable<Category>> GetCategoryProducts()
    {
        return _context.Categories.Include(category => category.Products).ToList();
    }
    [HttpPost]
    public ActionResult Post(Category category)
    {
        if (category == null)
        {
            return BadRequest();
        }
        _context.Categories.Add(category);
        _context.SaveChanges();
        return new CreatedAtRouteResult("GetCategory", new { id = category.Id }, category);
    }

    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Category category)
    {
        if (id != category.Id) return BadRequest();

        _context.Entry(category).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(category);

    }
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var category = _context.Categories.FirstOrDefault(category => category.Id == id);

        if (category == null) return NotFound();

        _context.Categories.Remove(category);
        _context.SaveChanges();

        return Ok(category);
    }
}

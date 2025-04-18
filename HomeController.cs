using Microsoft.AspNetCore.Mvc;
using product.Models; // Ensure this matches your actual project namespace
using System.Collections.Generic;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product
            {
                Name = "Daikin 3 Star Split AC",
                Price = "?35,000", // Corrected price format
                Description = "1.5 Ton, Inverter, PM 2.5 Filter, Dew Clean Technology",
                Rating = "4.5",
                Category = "Air Conditioners",
                ImageUrl = "/images/daikin1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "LG 1.5 Ton Split AC",
                Price = "?32,000", // Corrected price format
                Description = "1.5 Ton, 3 Star, Inverter, White",
                Rating = "4.2",
                Category = "Air Conditioners",
                ImageUrl = "/images/lg1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "Voltas 1.5 Ton Window AC",
                Price = "?28,000", // Corrected price format
                Description = "Turbo Mode, Copper Condenser, Anti-Rust Coating",
                Rating = "4.0",
                Category = "Air Conditioners",
                ImageUrl = "/images/voltas1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "Samsung WindFree Split AC",
                Price = "?40,000", // Corrected price format
                Description = "1.5 Ton, 5 Star, WindFree Cooling",
                Rating = "4.7",
                Category = "Air Conditioners",
                ImageUrl = "/images/samsung1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "Samsung WindFree Split AC",
                Price = "?40,000", // Corrected price format
                Description = "1.5 Ton, 5 Star, WindFree Cooling",
                Rating = "4.7",
                Category = "Air Conditioners",
                ImageUrl = "/images/samsung1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "Samsung WindFree Split AC",
                Price = "?40,000", // Corrected price format
                Description = "1.5 Ton, 5 Star, WindFree Cooling",
                Rating = "4.7",
                Category = "Air Conditioners",
                ImageUrl = "/images/samsung1.jpg" // Ensure image path is correct
            },
            new Product
            {
                Name = "Samsung WindFree Split AC",
                Price = "?40,000", // Corrected price format
                Description = "1.5 Ton, 5 Star, WindFree Cooling",
                Rating = "4.7",
                Category = "Air Conditioners",
                ImageUrl = "/images/samsung1.jpg" // Ensure image path is correct
            }

        };

        return View(products); // Passing the products list to the view
    }
}

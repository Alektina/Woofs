using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woof;
using Woof.Models;

namespace Woof.Controllers
{
    public class DogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dogs
        public async Task<IActionResult> Index()
        {
            var dogs = _context.Dogs.ToList();

            // Create a dictionary to store country names using the CountryID as the key
            var countryNames = _context.Countries.ToDictionary(c => c.CountryID, c => c.CountryName);

            // Pass the list of dogs and the country names to the view
            ViewData["CountryNames"] = countryNames;
            

            return _context.Dogs != null ? 
                          View(await _context.Dogs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Dogs'  is null.");
        }

        // GET: Dogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var dogs = _context.Dogs.ToList();

            // Create a dictionary to store country names using the CountryID as the key
            var countryNames = _context.Countries.ToDictionary(c => c.CountryID, c => c.CountryName);

            // Pass the list of dogs and the country names to the view
            ViewData["CountryNames"] = countryNames;

       

            if (id == null || _context.Dogs == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.DogID == id);
            if (dog == null)
            {
                return NotFound();
            }

            // Determine if there are related dogs
            var hasRelatedDogs = _context.Dogs.Any(d => d.MotherDogID == dog.DogID || d.FatherDogID == dog.DogID);

            // Pass the boolean flag to the view
            ViewData["HasRelatedDogs"] = hasRelatedDogs;

            return View(dog);
        }

        // GET: Dogs/Create
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(_context.Countries, "CountryID", "CountryName");
            return View();
        }

        // POST: Dogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DogID,RegNr,Name,Nickname,Sex,CountryID,BirthDate,DeathDate,Color,Hairlayers,Size,OriginalBreederID,CurrentOwnerID,MotherDogID,FatherDogID,BroodID,LitterID,Description,Merits,Titles")] Dog dog)
        {
            if (ModelState.IsValid)
            {
                if (dog.MotherDogID != null)
                {
                    var motherDog = await _context.Dogs.FindAsync(dog.MotherDogID);
                    if (motherDog != null && motherDog.Sex == "Male")
                    {
                        ModelState.AddModelError("MotherDogID", "A dog with sex 'Male' cannot be a mother.");
                        return View(dog);
                    }
                }

                if (dog.FatherDogID != null)
                {
                    var fatherDog = await _context.Dogs.FindAsync(dog.FatherDogID);
                    if (fatherDog != null && fatherDog.Sex == "Female")
                    {
                        ModelState.AddModelError("FatherDogID", "A dog with sex 'Female' cannot be a father.");
                        return View(dog);
                    }
                }

                _context.Add(dog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(dog);
        }




        // GET: Dogs/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            // Fetch the dog from the database by id
            var dog = await _context.Dogs.FindAsync(id);

            if (dog == null)
            {
                return NotFound();
            }

            // Fetch a list of countries for the dropdown
            var countries = await _context.Countries.ToListAsync();

            // Create a list of SelectListItem for the dropdown
            var countryList = countries.Select(c => new SelectListItem
            {
                Text = c.CountryName,
                Value = c.CountryID.ToString()
            }).ToList();

            // Set the selected country for the dog
            var selectedCountry = dog.CountryID.ToString();

            // Create a SelectList for the dropdown with the selected value
            ViewData["Countries"] = new SelectList(countryList, "Value", "Text", selectedCountry);

            return View(dog);
        }


        // POST: Dogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DogID,RegNr,Name,Nickname,Sex,CountryID,BirthDate,DeathDate,Color,Hairlayers,Size,OriginalBreederID,CurrentOwnerID,MotherDogID,FatherDogID,BroodID,LitterID,Description,Images,Merits,Titles")] Dog dog)
        {
            if (id != dog.DogID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogExists(dog.DogID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dog);
        }

        // GET: Dogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dogs == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .FirstOrDefaultAsync(m => m.DogID == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: Dogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dogs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Dogs'  is null.");
            }
            var dog = await _context.Dogs.FindAsync(id);
            if (dog != null)
            {
                _context.Dogs.Remove(dog);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ShowBrood(int? motherId, int? fatherId, DateTime? birthDate)
        {
            if (motherId == null || fatherId == null || birthDate == null)
            {
                return NotFound();
            }

            // Retrieve the mother and father dogs
            var mother = _context.Dogs.FirstOrDefault(d => d.DogID == motherId);
            var father = _context.Dogs.FirstOrDefault(d => d.DogID == fatherId);

            // Set ViewData values for the details you want to display
            ViewData["MotherID"] = motherId;
            ViewData["FatherID"] = fatherId;
            ViewData["BirthDate"] = birthDate;
            ViewData["MotherName"] = mother?.Name; // Get mother's name
            ViewData["FatherName"] = father?.Name; // Get father's name

            // Retrieve a list of dogs with matching MotherID, FatherID, and BirthDate
            var brood = _context.Dogs
                .Where(d => d.MotherDogID == motherId && d.FatherDogID == fatherId && d.BirthDate == birthDate)
                .ToList();

            return View(brood);
        }


        public IActionResult ShowLitter(int motherId, int fatherId)
        {
            ViewData["MotherID"] = motherId;
            ViewData["FatherID"] = fatherId;

            // Retrieve the mother and father dogs
            var mother = _context.Dogs.FirstOrDefault(d => d.DogID == motherId);
            var father = _context.Dogs.FirstOrDefault(d => d.DogID == fatherId);

            ViewData["MotherName"] = mother?.Name;
            ViewData["FatherName"] = father?.Name;

            // Retrieve a list of dogs with matching MotherID or FatherID
            var litters = _context.Dogs
                .Where(d => d.MotherDogID == motherId || d.FatherDogID == fatherId)
                .ToList();

            return View(litters);
        }






        private bool DogExists(int id)
        {
          return (_context.Dogs?.Any(e => e.DogID == id)).GetValueOrDefault();
        }
    }
}

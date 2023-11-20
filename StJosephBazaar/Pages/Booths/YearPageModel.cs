using StJosephBazaar.Data;
using StJosephBazaar.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StJosephBazaar.Pages.Courses
{
    public class YearPageModel : PageModel
    {
        public SelectList YearNameSL { get; set; }

        public void PopulateYearDropDownList(BazaarContext _context,
            object selectedYear = null)
        {
            var boothQuery = from d in _context.Year
                                   orderby d.YearVal // Sort by name.
                                   select d;

            YearNameSL = new SelectList(boothQuery.AsNoTracking(),
                nameof(Year.YearID),
                nameof(Year.YearVal),
                selectedYear);
        }
    }
}
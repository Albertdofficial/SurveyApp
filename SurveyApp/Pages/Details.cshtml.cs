using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyApp.Data;
using SurveyApp.Model;

namespace SurveyApp.Pages
{
    [BindProperties(SupportsGet = true)] // bind all of those properties 
                                         // so that they can be accessible to the view
    public class DetailsModel : PageModel
    {
        public List<ResponseDbTable> responseDbTable = new List<ResponseDbTable>();
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public string? Career { get; set; }
        public string? ProgrammingLanguage { get; set; }
        public string? HasPC { get; set; }

        private readonly ApplicationDbContext _context;
        public DetailsModel(ApplicationDbContext context)
        {
            _context = context; // this context represents our database
            
        }
        public void OnGet()
        {

            responseDbTable = _context.responseDbTable.ToList();

            ResponseDbTable responsesDbTable = new ResponseDbTable();


            responsesDbTable.FullName = FullName;
            responsesDbTable.Email = Email;
            responsesDbTable.Department = Department;
            responsesDbTable.Career = Career;
            responsesDbTable.ProgrammingLanguage = ProgrammingLanguage;
            responsesDbTable.HasPC = HasPC;


            _context.Add(responsesDbTable);
            _context.SaveChanges();

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurveyApp.Model;

namespace SurveyApp.Pages
{
    public class ResponseModel : PageModel
    {
        // to be able to access whatever we have in the model from the view we need to do data binding
        [BindProperty] //bind the Response model to the Responses.cshtml view model
                        // this will allow us to access fields of Response model in the Response.cshtml
        public ResponsesModel Response { get; set; } //create a successful reference to our ResponsesModel
        // we can now use Response to access all the field our model in the Response.cshtml
        public void OnGet()
        {
        
        }

        public IActionResult OnPost() {

            return RedirectToPage("/Details", new {Response.FullName, 
                                                    Response.Department, 
                                                    Response.ProgrammingLanguage,
                                                    Response.Email,
                                                    Response.Career,
                                                    Response.HasPC
                                                        });

        }

    }
}

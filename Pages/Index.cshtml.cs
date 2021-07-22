using HelloWorldRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }
        public String SubHeading { get; set; }
        
        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Message = "Hello World!";
        }

        public void onPost()
        {
            this.SubHeading = "Message changed.";
        }




    }
}

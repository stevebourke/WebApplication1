using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    public class ws1Model : PageModel
    {
        public string[] RugbyArray { get; set; }
            = { "Ireland", "England", "Scotland", "Wales", "France", "Italy", };

        public string Welcome { get; set; }

        public void OnGet()
        {
          
        }

        public void OnPost(string fname)
        {
            Welcome = String.Format("Hello {0}", fname);
        }
    }
}



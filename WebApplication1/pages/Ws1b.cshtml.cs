using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.pages
{
    public class Ws1bModel : PageModel
    {

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int Number2 { get; set; }

        public string SumMessage { get; set; }

        public int Sum { get; set; }

        public double Result { get; set; }

        public string ResultMessage{ get; set; }

        [BindProperty]
        public string Operation { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Sum = Number1 + Number2;

            SumMessage = String.Format("The sum of {0} and {1} is {2}", Number1, Number2, Sum);

            switch(Operation)
            {
                case "add":
                    Result = Number1 + Number2;
                    break;

                case "subtract":
                    Result = Number1 - Number2;
                    break;

                case "multiply":
                    Result = Number1 * Number2;
                    break;

                case "divide":
                    Result = Number1 / Number2;
                    break;

                    
            }

            ResultMessage = String.Format("The result is {0}", Result);
        }

    }
}
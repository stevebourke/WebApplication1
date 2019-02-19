﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.pages
{
    public class TimeModel : PageModel
    {
        public string[] Days { get; set; } = { "Monday", "Tuesday", "Wednesday",
        "Thursday", "Friday", "Saturday", "Sunday"};



        [BindProperty]
        public bool[] SelectedDay { get; set; } = { false, false, false, false,
        false, false, false };



        public void OnGet()
        {

        }

        


    }
}
﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewModels
{
    public class ThemesViewModel
    {
        public string SelectedTheme { get; set; }

        public List<SelectListItem> Themes { get; set; }
    }
}

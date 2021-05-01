﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNews.Areas.Admin.Models.ViewModels
{
    public class NewsDeleteViewModel : NewsViewModel
    {
        [Display(Name = "نویسنده خبر")]
        public string UserName { set; get; }
    }
}

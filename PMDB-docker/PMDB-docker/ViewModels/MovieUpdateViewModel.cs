﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMDB_docker.Models;

namespace PMDB_docker.ViewModels
{
    public class MovieUpdateViewModel
    {
        public MovieDto Movie { get; set; }
        public string PageTitle { get; set; }
    }
}

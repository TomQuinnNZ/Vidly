﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class ReturnsDto
    {
        public int custId { get; set; }
        public List<int> RentalIds { get; set; }
    }
}
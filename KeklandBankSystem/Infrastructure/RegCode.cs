﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    public class RegCode
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
    }
}

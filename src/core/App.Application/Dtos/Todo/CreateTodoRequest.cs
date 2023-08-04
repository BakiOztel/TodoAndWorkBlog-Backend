﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Dtos.Todo
{
    public class CreateTodoRequest
    {
        [Required]
        public string Text { get; set; }
    }
}

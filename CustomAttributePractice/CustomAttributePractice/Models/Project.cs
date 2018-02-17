using CustomAttributePractice.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomAttributePractice.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Remote("GenerateNextNumber", "Project")]
        public string Number { get; set; }
        public string Name { get; set; }
    }
}

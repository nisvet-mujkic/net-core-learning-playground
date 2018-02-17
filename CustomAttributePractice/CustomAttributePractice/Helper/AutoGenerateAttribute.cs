using CustomAttributePractice.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomAttributePractice.Helper
{
    public class AutoGenerateAttribute : Attribute
    {
        private readonly NetContext db;

        public AutoGenerateAttribute(NetContext db)
        {
            this.db = db;

            //var x = HttpContext.
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    class ShouldNotContainHTMLAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string valueAsString = value as string;
            if (valueAsString == null)
            {
                return true;
            }

            if (Regex.IsMatch(valueAsString, @"</?\w+\s+[^>]*>"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

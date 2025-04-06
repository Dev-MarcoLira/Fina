using Fina.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Categories
{
    internal class CreateCategoryRequest : Request
    {
        [ Required(ErrorMessage = "Invalid Title") ]
        [ MaxLength(80, ErrorMessage = "The title must contain up to 80 characters") ]
        public String Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invalid Description")]
        public String Description { get; set; } = string.Empty;


    }
}

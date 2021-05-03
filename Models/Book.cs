using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

    }

    
}

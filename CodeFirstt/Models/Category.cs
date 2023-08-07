using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstt.Models
{
    public class Category:BaseModel
    {

      
        public virtual ICollection<Book> Books { get; set; }= new List<Book>();
    }
}

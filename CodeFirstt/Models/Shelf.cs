using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstt.Models
{
    public class Shelf:BaseModel
    {
        public virtual ICollection<Book> Books { get; set; }= new List<Book>();
    }
}

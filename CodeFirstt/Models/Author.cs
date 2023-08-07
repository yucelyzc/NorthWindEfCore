using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstt.Models
{
    public class Author : BaseModel
    {
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
        public virtual ICollection<Publisher> Publisher { get; set; }= new List<Publisher>();
    }
}

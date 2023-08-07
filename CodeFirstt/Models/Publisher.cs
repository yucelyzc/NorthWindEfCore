using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstt.Models
{
    public class Publisher:BaseModel
    {
        public virtual ICollection<Book> Books { get; set; }= new List<Book>();

        public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
    }
}

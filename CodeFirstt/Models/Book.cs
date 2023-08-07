using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstt.Models
{
    public class Book:BaseModel
    {
        public int Pages { get; set; }
        public string ISBN { get; set; }

        public int ShelfId { get; set; }
        public virtual Shelf Shelf { get; set; }

        public virtual ICollection<Author> Authors { get; set; }= new List<Author>();

        public virtual ICollection<Publisher> Publishers { get; set; }=new List<Publisher>();   

        public virtual ICollection<Category> Categories { get; set; } =new List<Category>();
    }
}

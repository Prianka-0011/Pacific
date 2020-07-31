using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacifice_Website.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation Prop
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Model
{
    public class Carro
    {
        public int Id  { get; set; }
        public string Marca{ get; set; }
        public string Modelo { get; set; }
        public string ano { get; set; }
        public string   foto { get; set; }
        public string color { get; set; }
        public string comentario { get; set; }
        public string Chasis { get; set; }
    }
}

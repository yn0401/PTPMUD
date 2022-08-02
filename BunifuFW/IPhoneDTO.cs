using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_IPhone
{
    public class IphoneDTO
    {
        public int IdIphone { get; set; }
        public string NameIPhone { get; set; }
        public int PriceIphone { get; set; }
        public string Description { get; set; }
        public IphoneDTO() { }
        public IphoneDTO(int Id, string Name, int Price, string Descrip)
        {
            IdIphone = Id;
            NameIPhone = Name;
            PriceIphone = Price;
            Description = Descrip;
        }
    }
}

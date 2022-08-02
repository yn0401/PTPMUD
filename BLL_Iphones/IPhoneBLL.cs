using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_IPhone;

namespace BLL_Iphones
{
    public class IPhoneBLL
    {
        private List<IphoneDTO> iphone = new List<IphoneDTO>();
        public IphoneDTO Details(int Id)
        {
            foreach (IphoneDTO ip in iphone)
            {
                if (ip.IdIphone == Id)
                {
                    return ip;
                }
            }
            return null;
        }

        public bool AddIphone(IphoneDTO i)
        {
            iphone.Add(i);
            return true;
        }
        public bool RemoveIphone(int Id)
        {
            foreach (IphoneDTO ip in iphone)
            {
                if (ip.IdIphone == Id)
                {
                    iphone.Remove(ip);
                    return true;
                }
            }
            return false;
        }

        public List<IphoneDTO> getAllIphones()
        {
            return iphone;
        }
    }
}


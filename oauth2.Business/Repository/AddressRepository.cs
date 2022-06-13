using oauth2.Business.Implementation;
using oauth2.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oauth2.Business.Repository
{
    public class AddressRepository: IAddress //: BaseRepository<Address>, 
    {
        public AddressRepository()
        {
        }

        public Address GetAddress()
        {
            return new Address();
        }
    }
}

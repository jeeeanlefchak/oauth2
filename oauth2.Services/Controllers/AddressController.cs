using Microsoft.AspNetCore.Mvc;
using oauth2.Business.Implementation;
using oauth2.Model.Entity;
using oauth2.Services.Data;

namespace oauth2.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Address")]
    public class AddressController : AbstractController<Address>
    {
        private readonly IAddress _addressRepository;
        public AddressController(DataContext context, IAddress addressRepository) //, 
        {
            this.context = context;
            _addressRepository = addressRepository;
        }
    }
}

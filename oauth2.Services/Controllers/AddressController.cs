using Microsoft.AspNetCore.Mvc;
using oauth2.Business.Implementation;
using oauth2.Model.Entity;

namespace oauth2.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Address")]
    public class AddressController : AbstractController<Address>
    {
        private readonly IAddress _addressRepository;
        public AddressController(IAddress addressRepository) //, 
        {
            _addressRepository = addressRepository;
        }

        [HttpGet]
        public Address GetAddress()
        {
            return _addressRepository.GetAddress();
        }
    }
}

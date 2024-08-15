
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wc.BusinessENtity
{
    public class RegistrationViewModel
    {
        public int Userid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        public string PhoneNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int CityId { get; set; }

        public string Zipcode { get; set; }

        public string Email { get; set; }
        public List<SelectListItem> data { get; set; }

    }
}

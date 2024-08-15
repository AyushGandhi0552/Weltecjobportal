using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wc.BusinessENtity;
using Wc.BusinessServices.Interface;


namespace Weltecjobportal.Controllers
{
    public class UserController : Controller
    {
        private IUserServices _userService;
        public UserController(IUserServices userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            RegistrationViewModel userInfoViewModel = new RegistrationViewModel();

            userInfoViewModel. data= new List<SelectListItem>();

            userInfoViewModel.data.Add(new SelectListItem
            {
                Text = "vadodara",
                Value = "1"
            });
            userInfoViewModel.data.Add(new SelectListItem
            {
                Text = "Padra",
                Value = "2"
            });
            return View(userInfoViewModel);
        }
        [HttpPost]
        public IActionResult Index(RegistrationViewModel userInfoViewModel)
        {
            _userService.AddUserInfo(userInfoViewModel);
            return RedirectToAction("Index");
        }

        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult login(LoginviewModel loginViewModel)
        {
            return View();
        }
    }
}


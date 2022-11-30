using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public string GetName()
        {
            return "Jignesh";
        }

        public string GetFullName()
        {
            return "Jignesh R Solanki";
        }

        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}

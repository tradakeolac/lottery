using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lottery.Web.Api.Controllers
{
    public abstract class BaseController : Controller
    {
        
    }

    public abstract class AuthenticatedController : BaseController 
    {
        
    }
}

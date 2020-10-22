using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters
{
    public class CustomExceptionFilter : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new ContentResult() { Content = "CustomExceptionFilter" };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
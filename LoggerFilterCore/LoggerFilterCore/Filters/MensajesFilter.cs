using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggerFilterCore.Filters
{
    public class MensajesFilter: ActionFilterAttribute
    {
        ILogger logger;
        
        public MensajesFilter(ILogger<MensajesFilter>logger)
        {
            this.logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            //Console.WriteLine("-----------------------------  OnActionExecuting  ---------------------------- - ");
            logger.LogInformation("-----------------------------  OnActionExecuting  ---------------------------- - ");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            //Console.WriteLine("-----------------------------  OnActionExecuted  ---------------------------- - ");
            logger.LogInformation("-----------------------------  OnActionExecuted  ---------------------------- - ");

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            base.OnResultExecuting(context);
            //Console.WriteLine("-----------------------------  OnResultExecuting  ---------------------------- - ");
            logger.LogInformation("-----------------------------  OnResultExecuting  ---------------------------- - ");

        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            base.OnResultExecuted(context);
            //Console.WriteLine("-----------------------------  OnResultExecuted  ---------------------------- - ");
            logger.LogInformation("-----------------------------  OnResultExecuted  ---------------------------- - ");

        }
    }
}

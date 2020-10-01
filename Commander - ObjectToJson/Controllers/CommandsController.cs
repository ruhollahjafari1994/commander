namespace Commander.Controllers
{       
     [Microsoft.AspNetCore.Mvc.Route(template : "api/[Controller]")]
    public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public CommandsController() : base()
        {
            
        }
      [Microsoft.AspNetCore.Mvc.HttpGet(template : "a/b")]
      public Models.Command GetCommands()
      {
          Models.Command newCommand =new Models.Command{
              Id=2,
              Line="Forward",
              HowTo="Easy",
              Platform="C#"
              };
          return newCommand; 
      }
                                                                                                                                                         
    }
}
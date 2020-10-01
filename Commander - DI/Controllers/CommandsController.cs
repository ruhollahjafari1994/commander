namespace Commander.Controllers
{       [Microsoft.AspNetCore.Mvc.ApiController]
     [Microsoft.AspNetCore.Mvc.Route(template : "api/[Controller]")]
    public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public CommandsController() : base()
        {
            _repository = 
                new Data.ThisIsNotAGoodRepository(); //عرف(2)
        } 
        private readonly Data.ThisIsNotAGoodRepository  _repository; //عرف(1)

    //   private readonly   Data.ThisIsNotAGoodRepository  // عرف نیس(1)
    //   _repository =new Data.ThisIsNotAGoodRepository(); //عرف نیس(2)

      [Microsoft.AspNetCore.Mvc.HttpGet]
        public
         Microsoft.AspNetCore.Mvc.ActionResult
         <System.Collections.Generic.IEnumerable<Models.Command>>
         GetAll()
        {
            var result =_repository.GetAll();
            return Ok(result);
        }

        
      [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public
         Microsoft.AspNetCore.Mvc.ActionResult
             <Models.Command>
               GetById(int id)
        {
            var result =_repository.GetById(id);
            return Ok(result);
        }

        
    }
}
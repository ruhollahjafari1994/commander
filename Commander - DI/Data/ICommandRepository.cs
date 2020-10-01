namespace Data
{
    public interface ICommandRepository
    {
        Models.Command GetById(int id);
        
       System.Collections.Generic.IEnumerable<Models.Command> GetAll();

    }
    
}
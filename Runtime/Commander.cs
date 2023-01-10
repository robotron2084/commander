using System.Threading.Tasks;

namespace com.enemyhideout.commander
{
  /// <summary>
  /// Allows for the execution of Commands.
  /// </summary>
  public class Commander
  {
    public void Run(ICommand command)
    {
      CommanderCore.Run(command);
    }
    
    public async Task<T> Run<T>(ICommand<T> command)
    {
      return await CommanderCore.Run(command);
    }
  }
}
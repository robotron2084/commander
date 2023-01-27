using System.Threading.Tasks;

namespace com.enemyhideout.commands
{
  public static class CommandExtensions
  {

    public static void Run(this ICommand command)
    {
      CommanderCore.Run(command);
    }
    
    public static async Task<T> Run<T>(this ICommand<T> command)
    {
      return await CommanderCore.Run<T>(command);
    }

  }
}
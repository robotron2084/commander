using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.enemyhideout.commands
{
  public static class CommanderCore
  {
    public static void Run(ICommand command)
    {
      command.Execute();
    }
    
    public static async Task<T> Run<T>(ICommand<T> command)
    {
      return await command.Execute();
    }
    
    public static async Task Stagger(IEnumerable<ICommand> commands, float step)
    {
      foreach (ICommand command in commands)
      {
        await command.Execute();
        await Task.Delay((int)(step * 1000.0f));
      }
    }

    public static async Task<IEnumerable<T>> Stagger<T>(IEnumerable<ICommand<T>> commands, float step)
    {
      var retVal = new List<T>();
      foreach (ICommand<T> command in commands)
      {
        var val = await command.Execute();
        await Task.Delay((int)(step * 1000.0f));
        retVal.Add(val);
      }

      return retVal;
    }

    
  }
}
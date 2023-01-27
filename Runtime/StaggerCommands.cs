using System.Collections.Generic;
using System.Threading.Tasks;

namespace com.enemyhideout.commands
{
  public class StaggerCommands : ICommand
  {
    private IEnumerable<ICommand> _commands;
    private float _step;
    
    public StaggerCommands(IEnumerable<ICommand> commands, float step = 0.5f)
    {
      _commands = commands;
    }
    
    public async Task Execute()
    {
      await CommanderCore.Stagger(_commands, _step);
    }
  }
  
  public class StaggerCommands<T> : ICommand<IEnumerable<T>>
  {
    private IEnumerable<ICommand<T>> _commands;
    private float _step;
    
    public StaggerCommands(IEnumerable<ICommand<T>> commands, float step = 0.5f)
    {
      _commands = commands;
    }
    
    public async Task<IEnumerable<T>> Execute()
    {
      return await CommanderCore.Stagger(_commands, _step);
    }
  }
}
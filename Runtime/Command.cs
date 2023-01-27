using System.Threading.Tasks;

namespace com.enemyhideout.commands
{
  public abstract class Command : ICommand
  {
    public abstract Task Execute();
  }
}
using System;
using System.Threading.Tasks;

namespace com.enemyhideout.commands
{
  public interface ICommand
  {
    Task Execute();
  }

  public interface ICommand<T>
  {
    Task<T> Execute();
  }
}
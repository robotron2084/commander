using System;
using System.Threading.Tasks;

namespace com.enemyhideout.commander
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
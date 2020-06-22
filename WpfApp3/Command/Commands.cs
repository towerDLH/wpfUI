using System;
using System.Diagnostics;
using System.Windows.Input;

namespace WpfApp3.Command
{
    public class Commands : ICommand
    {

        #region 字段

        readonly Func<Boolean> _canExecute;

        readonly Action _execute;

        #endregion


        public Commands(Action execute) : this(execute, null)
        {

        }
        public Commands(Action execute, Func<Boolean> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }
        #region ICommand的成员

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }
        [DebuggerStepThrough]
        public Boolean CanExecute(Object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }
        public void Execute(Object parameter)
        {
            _execute();
        }
        #endregion
    }
}

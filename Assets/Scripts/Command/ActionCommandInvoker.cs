using UnityEngine;
using System.Collections.Generic;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// ActionCommand를 생성하고 실행합니다.
    /// </summary>
    public class ActionCommandInvoker
    {
        private static Stack<IActionCommand> _mCommandHistory = new Stack<IActionCommand>();

        public static void ExecuteCommand(IActionCommand command)
        {
            if (command == null)
            {
                throw new System.ArgumentNullException(nameof(command), "Command cannot be null.");
            }
            command.Execute();
            _mCommandHistory.Push(command);
            Debug.Log($"Executed command: {command.GetType().Name}");
        }

        public static void UndoCommand()
        {
            if (_mCommandHistory.Count == 0)
            {
                Debug.LogWarning("No commands to undo.");
            }
            else
            {
                var command = _mCommandHistory.Pop();
                command.Undo();
                Debug.Log($"Undone command: {command.GetType().Name}");
            }
        }

        public static void ClearHistory()
        {
            _mCommandHistory.Clear();
            Debug.Log("Command history cleared.");
        }
    }
}

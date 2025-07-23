using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// Actor ���� ������ �� �ִ� �ൿ(Action)�� �����մϴ�.
    /// </summary>
    public interface IActionCommand
    {
        void Execute();
        void Undo();
    }
}
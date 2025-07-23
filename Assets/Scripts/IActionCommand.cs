using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// Actor 들이 실행할 수 있는 행동(Action)을 정의합니다.
    /// </summary>
    public interface IActionCommand
    {
        void Execute();
        void Undo();
    }
}
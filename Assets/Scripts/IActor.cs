using UnityEngine;
using System.Collections;


namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// 플레이어와 AI 캐릭터의 이동을 담당하는 인터페이스입니다.
    /// </summary>
    public interface IActorMovement
    {
        float MoveSpeed { get; }
        bool IsMoving { get; }

        /// <summary>
        /// direction 방향으로 이동합니다. 코루틴으로 SmoothMove를 호출합니다.
        /// </summary>
        /// <param name="direction"></param>
        void Move(Vector2Int direction);

        /// <summary>
        /// target 위치로 이동할 수 있는지 판별합니다.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool CanToMove(Vector2 target);

        /// <summary>
        /// 실제 이동하는 로직이며, target 위치로 부드럽게 이동합니다.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        IEnumerator SmoothMove(Vector2 target);
    }
}
using UnityEngine;
using System.Collections;


namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// �÷��̾�� AI ĳ������ �̵��� ����ϴ� �������̽��Դϴ�.
    /// </summary>
    public interface IActorMovement
    {
        float MoveSpeed { get; }
        bool IsMoving { get; }

        /// <summary>
        /// direction �������� �̵��մϴ�. �ڷ�ƾ���� SmoothMove�� ȣ���մϴ�.
        /// </summary>
        /// <param name="direction"></param>
        void Move(Vector2Int direction);

        /// <summary>
        /// target ��ġ�� �̵��� �� �ִ��� �Ǻ��մϴ�.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        bool CanToMove(Vector2 target);

        /// <summary>
        /// ���� �̵��ϴ� �����̸�, target ��ġ�� �ε巴�� �̵��մϴ�.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        IEnumerator SmoothMove(Vector2 target);
    }
}
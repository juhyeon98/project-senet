using System.Collections;
using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// 플레이어와 AI 캐릭터의 공유 클래스입니다.
    /// </summary>
    public abstract class Actor : MonoBehaviour, IActorMovement
    {
        public float MoveSpeed { get; protected set; } = 5f;
        public bool IsMoving { get; protected set; } = false;

        public void Move(Vector2Int direction)
        {
            if (IsMoving)
            {
                return;
            }
            Vector2 targetPosition = (Vector2)transform.position + (Vector2)direction;
            if (CanToMove(targetPosition))
            {
                StartCoroutine(SmoothMove(targetPosition));
            }
        }

        public bool CanToMove(Vector2 target)
        {
            return true;
        }

        public IEnumerator SmoothMove(Vector2 target)
        {
            Vector2 startPosition = transform.position;
            float distance = Vector2.Distance(startPosition, target);
            float startTime = Time.time;

            while ((Vector2)transform.position != target)
            {
                IsMoving = true;
                float distanceCovered = (Time.time - startTime) * MoveSpeed;
                float fractionOfCovered = distanceCovered / distance;
                transform.position = Vector2.Lerp(transform.position, target, fractionOfCovered);
                yield return null;
            }
            IsMoving = false;
            yield return null;
        }
    }
}

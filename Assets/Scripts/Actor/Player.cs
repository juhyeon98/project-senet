using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// 플레이어 캐릭터를 나타내는 클래스입니다.
    /// </summary>
    public class Player : Actor
    {
        [SerializeField] private float moveSpeed;
        
        private void Awake()
        {
            MoveSpeed = moveSpeed;
        }
    }
}
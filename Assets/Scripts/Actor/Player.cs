using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// �÷��̾� ĳ���͸� ��Ÿ���� Ŭ�����Դϴ�.
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
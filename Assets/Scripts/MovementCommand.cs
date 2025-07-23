using UnityEngine;

namespace Juhyeon.ActorSystem
{
    /// <summary>
    /// Actor�� �̵��� ������ �����մϴ�.
    /// </summary>
    public enum MovementDirection
    {
        Up, Down, Left, Right
    }

    /// <summary>
    /// Actor�� �̵� ����� �����մϴ�.
    /// </summary>
    public class MovementCommand : IActionCommand
    {
        private IActorMovement _mActor;
        private Vector2Int _mDirection;

        public MovementCommand(IActorMovement actor, MovementDirection direction)
        {
            _mActor = actor;
            switch (direction)
            {
                case MovementDirection.Up:
                    _mDirection = Vector2Int.up;
                    break;
                case MovementDirection.Down:
                    _mDirection = Vector2Int.down;
                    break;
                case MovementDirection.Left:
                    _mDirection = Vector2Int.left;
                    break;
                case MovementDirection.Right:
                    _mDirection = Vector2Int.right;
                    break;
            }
        }

        public void Execute()
        {
            _mActor.Move(_mDirection);
        }

        public void Undo()
        {
            _mActor.Move(-_mDirection);
        }
    }
}

using UnityEngine;

namespace Juhyeon.InputSystem
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private ActorSystem.Actor player;

        private void Update()
        {
            ActorSystem.IActionCommand movementCommand = null;

            if (Input.GetKeyDown(KeyCode.W))
            {
                movementCommand = MakeCommand(ActorSystem.MovementDirection.Up);
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                movementCommand = MakeCommand(ActorSystem.MovementDirection.Down);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                movementCommand = MakeCommand(ActorSystem.MovementDirection.Left);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                movementCommand = MakeCommand(ActorSystem.MovementDirection.Right);
            }
            if (movementCommand != null)
            {
                ActorSystem.ActionCommandInvoker.ExecuteCommand(movementCommand);
                movementCommand = null;
            }
        }

        private ActorSystem.IActionCommand MakeCommand(ActorSystem.MovementDirection direction)
        {
            if (player == null)
            {
                Debug.LogError("Player actor is not assigned.");
                return null;
            }
            var command = new ActorSystem.MovementCommand(player, direction);
            return command;
        }
    }
}

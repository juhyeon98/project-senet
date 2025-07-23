using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class StageManager : MonoBehaviour
    {
        private void Start()
        {
            MazeGenerator mazeGenerator = new MazeGenerator();
            Debug.Log("Maze generation complete.");
        }
    }
    
}

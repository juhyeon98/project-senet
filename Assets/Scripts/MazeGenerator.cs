using UnityEngine;
using System.Collections.Generic;

namespace Juhyeon.StageSystem
{
    public class MazeGenerator
    {
        public Room StartRoom { get; private set; }
        public Room ExitRoom { get; private set; }

        private readonly int width;
        private readonly int height;
        private Room[,] _mMaze;
        private int _mStartRoomDirection;

        public MazeGenerator(int width = 4, int height = 4)
        {
            this.width = width;
            this.height = height;
            _mMaze = new Room[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    _mMaze[y, x] = new Room(x, y);
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var room = _mMaze[y, x];
                    if (y > 0)
                    {
                        room.AddNeighbor(RoomDirection.Up, _mMaze[y - 1, x]);
                    }
                    if (y < height - 1)
                    {
                        room.AddNeighbor(RoomDirection.Down, _mMaze[y + 1, x]);
                    }
                    if (x > 0)
                    {
                        room.AddNeighbor(RoomDirection.Left, _mMaze[y, x - 1]);
                    }
                    if (x < width - 1)
                    {
                        room.AddNeighbor(RoomDirection.Right, _mMaze[y, x + 1]);
                    }
                }

            }
            SetStartRoom();
            SetExitRoom();
            GenerateMaze();
        }

        private void SetStartRoom()
        {
            _mStartRoomDirection = Random.Range(0, 4); // 상, 하, 좌, 우 중 선택
            switch(_mStartRoomDirection)
            {
                case 0: // 상
                    StartRoom = _mMaze[0, Random.Range(0, width)];
                    break;
                case 1: // 하
                    StartRoom = _mMaze[height - 1, Random.Range(0, width)];
                    break;
                case 2: // 좌
                    StartRoom = _mMaze[Random.Range(0, height), 0];
                    break;
                case 3: // 우
                    StartRoom = _mMaze[Random.Range(0, height), width - 1];
                    break;
            }
        }

        private void SetExitRoom()
        {
            switch(_mStartRoomDirection)
            {
                case 0: // start room의 방향이 위쪽인 경우
                    ExitRoom = _mMaze[height - 1, Random.Range(0, width)];
                    break;
                case 1: // start room의 방향이 아래쪽인 경우
                    ExitRoom = _mMaze[0, Random.Range(0, width)];
                    break;
                case 2: // start room의 방향이 왼쪽인 경우
                    ExitRoom = _mMaze[Random.Range(0, height), width - 1];
                    break;
                case 3: // start room의 방향이 오른쪽인 경우
                    ExitRoom = _mMaze[Random.Range(0, height), 0];
                    break;
            }
        }

        private void GenerateMaze()
        {
            List<(RoomDirection direction, Room room)> visitedList = new List<(RoomDirection, Room)>();
            visitedList.Clear();
            StartRoom.IsVisited = true;
            foreach (var startRoomNeighbor in StartRoom.GetAllNeighbor())
            {
                visitedList.Add(startRoomNeighbor);
            }

            int visitedCount = 1;
            while (visitedCount < width * height)
            {
                int randomIndex = Random.Range(0, visitedList.Count);
                var selected = visitedList[randomIndex];
                visitedList.RemoveAt(randomIndex);
                if (selected.room.IsVisited)
                {
                    continue;
                }

                selected.room.IsVisited = true;
                StartRoom.OpenPath(selected.direction);
                selected.room.OpenPath(Room.OppositeDirection(selected.direction));
                foreach (var neighbor in selected.room.GetAllNeighbor())
                {
                    if (!neighbor.neighbor.IsVisited)
                    {
                        visitedList.Add(neighbor);
                    }
                }
                visitedCount++;
            }
        }
    }
}

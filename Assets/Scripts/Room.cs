using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public enum RoomDirection
    {
        None = -1, // ��Ÿ�� �� ���� ����
        Up, Down, Left, Right
    }

    /// <summary>
    /// �������� �ý��ۿ��� �� �ϳ��� ��Ÿ���ϴ�.
    /// �� �ϳ����� 8 * 8ũ���� Ÿ���� �ֽ��ϴ�.
    /// </summary>
    public class Room
    {
        public bool IsVisited { get; set; } = false;
        public Vector2Int Position { get; private set; } // �迭������ ��ġ

        private Dictionary<RoomDirection, Room> _mNeighborRooms = new Dictionary<RoomDirection, Room>();
        private HashSet<RoomDirection> _mPaths = new HashSet<RoomDirection>();

        public Room(int x, int y)
        {
            Position = new Vector2Int(y, x); // �迭�κ����� ��ġ�̱� ����
            _mNeighborRooms.Clear();
            _mPaths.Clear();
        }

        public void AddNeighbor(RoomDirection direction, Room neighbor)
        {
            if (!_mNeighborRooms.ContainsKey(direction))
            {
                _mNeighborRooms.Add(direction, neighbor);
            }
        }

        public void OpenPath(RoomDirection direction)
        {
            if (!_mPaths.Contains(direction))
            {
                _mPaths.Add(direction);
            }
        }

        public void ClosePath(RoomDirection direction)
        {
            if (_mPaths.Contains(direction))
            {
                _mPaths.Remove(direction);
            }
        }

        public IEnumerable<(RoomDirection direction, Room neighbor)> GetAllNeighbor()
        {
            foreach (var pair in _mNeighborRooms)
            {
                yield return (pair.Key, pair.Value);
            }
        }

        public static RoomDirection OppositeDirection(RoomDirection direction)
        {
            return direction switch
            {
                RoomDirection.Up => RoomDirection.Down,
                RoomDirection.Down => RoomDirection.Up,
                RoomDirection.Left => RoomDirection.Right,
                RoomDirection.Right => RoomDirection.Left,
                _ => RoomDirection.None
            };
        }
    }
}

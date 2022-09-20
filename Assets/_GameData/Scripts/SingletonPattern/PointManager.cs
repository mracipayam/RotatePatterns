using UnityEngine;

namespace _GameData.Scripts.SingletonPattern
{
    public class PointManager : MonoBehaviour
    {
        public static PointManager instance;
        private int _point;

        public int Point
        {
            get => _point;
            set => _point = value;
        }
        private void Awake()
        {
            instance = this;
        }
    }
}

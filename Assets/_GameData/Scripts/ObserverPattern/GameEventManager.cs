using System;
using UnityEngine;

namespace _GameData.Scripts.ObserverPattern
{
    public class GameEventManager : MonoBehaviour
    {
        public static GameEventManager instance;

        private void Awake()
        {
            instance = this;
        }

        public Action OnPointIncrease;
        public void RaisePointIncrease() => OnPointIncrease?.Invoke();
    }
}

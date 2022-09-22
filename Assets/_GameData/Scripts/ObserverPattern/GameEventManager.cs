using System;
using UnityEngine;

namespace _GameData.Scripts.ObserverPattern
{
    public class GameEventManager : MonoBehaviour
    {
        public static Action OnPointIncrease;
        public static void RaisePointIncrease() => OnPointIncrease?.Invoke();

        private void OnDestroy()
        {
            OnPointIncrease = null;
        }
    }
}

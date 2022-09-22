using System;
using UnityEngine;

namespace _GameData.Scripts.StrategyPattern
{
    public class StrategyExample : MonoBehaviour
    {
        private Action _selectedUpdate;

        private void Update()
        {
            TryChangeUpdateMethod();
            _selectedUpdate();
        }

        private void TryChangeUpdateMethod()
        {
            if (TryGetComponent(out CharacterController _))
            {
                _selectedUpdate = MoveWithCharacterController;
            }
            else if (TryGetComponent(out Rigidbody _))
            {
                _selectedUpdate = MoveWithRigidbody;
            }
            else
            {
                _selectedUpdate = NotMoving;
            }
        }

        private void NotMoving()
        {
            print("You move.");
        }

        private void MoveWithCharacterController()
        {
            print("Moving with character controller.");
        }

        private void MoveWithRigidbody()
        {
            print("Moving with rigidbody.");
        }
    }
}
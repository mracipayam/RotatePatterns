using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxStateManager : MonoBehaviour
    {
        private FoxBaseState _currentState;
        
        public FoxIdleState IdleState = new FoxIdleState();
        public FoxRunningState RunningState = new FoxRunningState();
        private void Start()
        {
            _currentState = IdleState;
            _currentState.EnterState(this);
        }
        private void Update()
        {
            _currentState.UpdateState(this);
        }
        
        public void SwitchState(FoxBaseState state)
        {
            _currentState = state;
            _currentState.EnterState(this);
        }
    }
}

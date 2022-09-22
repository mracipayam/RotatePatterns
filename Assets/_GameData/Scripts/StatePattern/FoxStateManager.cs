using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxStateManager : MonoBehaviour
    {
        private FoxBaseState _currentState;
        
        public FoxIdleState IdleState;
        public FoxRunningState RunningState;
        
        private void Start()
        {
            IdleState = new FoxIdleState(this);
            RunningState = new FoxRunningState(this);
            _currentState = IdleState;
            _currentState.EnterState();
        }
        private void Update()
        {
            _currentState.UpdateState();
        }
        
        public void SwitchState(FoxBaseState state)
        {
            _currentState = state;
            _currentState.EnterState();
        }
    }
}

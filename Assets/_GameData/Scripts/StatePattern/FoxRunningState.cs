using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxRunningState : FoxBaseState
    {
        public FoxRunningState(FoxStateManager stateManager) : base(stateManager)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Hello from FoxRunningState");
            _stateManager.GetComponent<Animator>().SetBool("isRunning",true);
        }

        public override void UpdateState()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _stateManager.SwitchState(_stateManager.IdleState);
            }
        }
    }
}

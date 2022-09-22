using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxIdleState : FoxBaseState
    {
        public FoxIdleState(FoxStateManager stateManager) : base(stateManager)
        {
        }

        public override void EnterState()
        {
            Debug.Log("Hello from FoxIdleState");
            _stateManager.GetComponent<Animator>().SetBool("isRunning",false);
        }

        public override void UpdateState()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _stateManager.SwitchState(_stateManager.RunningState);
            }
        }
    }
}

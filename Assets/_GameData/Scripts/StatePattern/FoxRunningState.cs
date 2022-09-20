using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxRunningState : FoxBaseState
    {
        public override void EnterState(FoxStateManager fox)
        {
            Debug.Log("Hello from FoxRunningState");
            fox.GetComponent<Animator>().SetBool("isRunning",true);
        }

        public override void UpdateState(FoxStateManager fox)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fox.SwitchState(fox.IdleState);
            }
        }
    }
}

using UnityEngine;

namespace _GameData.Scripts.StatePattern
{
    public class FoxIdleState : FoxBaseState
    {
        public override void EnterState(FoxStateManager fox)
        {
            Debug.Log("Hello from FoxIdleState");
            fox.GetComponent<Animator>().SetBool("isRunning",false);
        }

        public override void UpdateState(FoxStateManager fox)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                fox.SwitchState(fox.RunningState);
            }
        }
    }
}

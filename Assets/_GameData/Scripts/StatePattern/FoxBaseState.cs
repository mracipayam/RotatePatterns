namespace _GameData.Scripts.StatePattern
{
    public abstract class FoxBaseState 
    {
        protected FoxStateManager _stateManager;
        public FoxBaseState(FoxStateManager stateManager)
        {
            _stateManager = stateManager;
        }
        public abstract void EnterState();
        public abstract void UpdateState();
    }
}

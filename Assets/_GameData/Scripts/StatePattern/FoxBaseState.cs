namespace _GameData.Scripts.StatePattern
{
    public abstract class FoxBaseState 
    {
        public abstract void EnterState(FoxStateManager fox);
        public abstract void UpdateState(FoxStateManager fox);
    }
}

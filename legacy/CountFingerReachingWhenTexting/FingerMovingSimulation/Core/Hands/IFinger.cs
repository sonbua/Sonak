namespace FingerMovingSimulation.Core.Hands
{
    internal interface IFinger
    {
        void ReturnToHomeRow();

        double Press(Keys key);
    }
}
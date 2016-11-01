namespace FingerMovingSimulation.Core.Hands
{
    internal interface IHand
    {
        void ReturnToHomeRow();

        double Press(Keys key);
    }
}
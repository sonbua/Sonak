using FingerMovingSimulation.Core.Expanders;

namespace FingerMovingSimulation.Core
{
    public interface ITypist
    {
        void ResetHandPosition();

        double Type(string text);

        IToneMapper ToneMapper { set; }
    }
}
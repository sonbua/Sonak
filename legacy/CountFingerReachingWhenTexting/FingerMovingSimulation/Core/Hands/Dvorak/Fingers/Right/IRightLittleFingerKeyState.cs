namespace FingerMovingSimulation.Core.Hands.Dvorak.Fingers.Right
{
    internal interface IRightLittleFingerKeyState : IKeyState
    {
        double PressD0();

        double PressL();

        double PressS();

        double PressZ();
        
        double PressOpenSquareBracket();
        
        double PressSlash();
        
        double PressMinus();
        
        double PressRShift();
        
        double PressCloseSquareBracket();
        
        double PressPipe();
        
        double PressBackSlash();
        
        double PressEnter();
    }
}
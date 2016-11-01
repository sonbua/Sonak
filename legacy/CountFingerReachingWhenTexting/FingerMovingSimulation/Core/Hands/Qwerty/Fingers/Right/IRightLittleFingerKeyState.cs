namespace FingerMovingSimulation.Core.Hands.Qwerty.Fingers.Right
{
    internal interface IRightLittleFingerKeyState : IKeyState
    {
        double PressD0();

        double PressP();

        double PressSemicolon();

        double PressSlash();
        
        double PressMinus();
        
        double PressOpenSquareBracket();
        
        double PressSingleQuote();
        
        double PressRShift();
        
        double PressPipe();
        
        double PressCloseSquareBracket();
        
        double PressBackSlash();
        
        double PressEnter();
    }
}
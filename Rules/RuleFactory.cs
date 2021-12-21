using JumpingFrog.Interfaces;

namespace JumpingFrog.Rules
{
    public static class RuleFactory
    {
        public static IRules GetRules(FrogType frogType)
        {
            if(frogType == FrogType.GreenFrog)
                return new GreenFrogSlideRule();
            if(frogType == FrogType.BrownFrog)
                return new BrownFrogSlideRule();
            return new BrownFrogSlideRule();
        }
    }

    public enum FrogType
    {
        GreenFrog,
        BrownFrog
    }
}

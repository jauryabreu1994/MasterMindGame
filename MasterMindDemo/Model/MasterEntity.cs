using MasterMindDemo.Model.Enums;

namespace MasterMindDemo.Model
{
    public class MasterEntity
    {
        public CodePeg FirstPosition { get; set; } = CodePeg.None;
        public CodePeg SecondPosition { get; set; } = CodePeg.None;
        public CodePeg ThirdPosition { get; set; } = CodePeg.None;
        public CodePeg FourthPosition { get; set; } = CodePeg.None;

        public bool IsComplete { get; set; } = false;
    }
}

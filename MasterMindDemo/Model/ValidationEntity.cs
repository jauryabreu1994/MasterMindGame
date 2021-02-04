using MasterMindDemo.Model.Enums;
using System.Collections.Generic;

namespace MasterMindDemo.Model
{
    public class ValidationEntity : MasterEntity
    {
        public ValidationEntity()
        {
        }
        public ValidationEntity(MasterEntity entity, List<ResultPeg> result)
        {
            FirstPosition = entity.FirstPosition;
            SecondPosition = entity.SecondPosition;
            ThirdPosition = entity.ThirdPosition;
            FourthPosition = entity.FourthPosition;
            IsComplete = true;

            FirstResult = result[0];
            SecondResult = result[1];
            ThirdResult = result[2];
            FourthResult = result[3];
            IsEqual = false;
        }

        public ResultPeg FirstResult { get; set; } = ResultPeg.None;
        public ResultPeg SecondResult { get; set; } = ResultPeg.None;
        public ResultPeg ThirdResult { get; set; } = ResultPeg.None;
        public ResultPeg FourthResult { get; set; } = ResultPeg.None;

        public bool IsEqual { get; set; } = false;
    }
}

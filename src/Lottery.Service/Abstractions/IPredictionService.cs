namespace Lottery.Service.Abstractions
{
    using System.Collections.Generic;
    using System.Collections;
    using Lottery.Service.Models;

    public interface IPredictionService : IService
    {
         IEnumerable<LottoResult> Predict();

         void UserPredictLotto(IEnumerable<int> predictedNumbers);

         void UserPredictSpecialPrize(int specialPrize);
    }
}
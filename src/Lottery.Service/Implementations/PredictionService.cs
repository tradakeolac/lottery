namespace Lottery.Service.Implementations
{
    using System;
    using System.Collections.Generic;
    using Lottery.Prediction;
    using Lottery.Service.Abstractions;
    using Lottery.Service.Models;

    public class PredictionService : IPredictionService
    {
        protected readonly IPrediction Prediction;

        public PredictionService(IPrediction prediction)
        {
            this.Prediction = prediction;
        }

        public IEnumerable<LottoResult> Predict()
        {
            // Using algorithm to predict the result
            this.Prediction.Predict();

            return null;
        }

        public void UserPredictLotto(IEnumerable<int> predictedNumbers)
        {
            // insert in to database
        }

        public void UserPredictSpecialPrize(int specialPrize)
        {
            // insert into database
        }
    }
}
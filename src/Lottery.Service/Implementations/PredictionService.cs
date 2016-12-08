using System;
using Lottery.Service.Abstractions;


namespace Lottery.Service.Implementations
{
    public class PredictionService : IPredictionService
    {
        public int Predict()
        {
            var rand = new Random();
            return rand.Next();
        }
    }
}
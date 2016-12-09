namespace Lottery.Service.Abstractions
{
    public interface IPredictionService : IService
    {
         int Predict();
    }
}
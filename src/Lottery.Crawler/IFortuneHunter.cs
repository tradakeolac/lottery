using System.Threading.Tasks;

namespace Lottery.Crawler
{
    public interface IFortuneHunter
    {
        Task<string> Mine(MinerConfiguration configuration);
    }
}
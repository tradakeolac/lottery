using System;

namespace Lottery.Entity.Entities
{
    public abstract class LotteryResultEntity : BaseEntity, ILottoResult
    {
        public virtual int Lotto
        {
            get
            {
                return this.Result % 100;
            }
        }

        public virtual int Result { get; set; } 

        public virtual DateTime CreatedDate { get; set; }  
    }    

    public class FirstPrizeEntity : LotteryResultEntity { }

    public class SecondPrizeEntity : LotteryResultEntity { }

    public class ThirdPrizeEntity : LotteryResultEntity { }

    public class FourthPrizeEntity : LotteryResultEntity { }

    public class FifthPrizeEntity : LotteryResultEntity { }

    public class SixthPrizeEntity : LotteryResultEntity { }
    
    public class SeventhPrizeEntity: LotteryResultEntity { }
}
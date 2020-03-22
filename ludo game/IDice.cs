using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IDice
    {
        public  int DiceRolling { get; set; }
        ICounter Counter { get; set; }
        DiceStaus Status { get; set; }
    }
}

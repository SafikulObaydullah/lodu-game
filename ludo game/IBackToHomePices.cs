using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IBackToHomePices
    {
        IPlayerPiece canNotMOve { get; set; }
        IPlayerPiece NeedSix { get; }


    }
}

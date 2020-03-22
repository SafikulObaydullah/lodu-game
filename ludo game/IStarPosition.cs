using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IStarPosition
    {
        IplayerPiece DontCut { get; set; }

        void Move();
    }
}

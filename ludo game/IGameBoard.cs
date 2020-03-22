using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IGameBoard
    {
        IList<IPlayer> Players { get; set; }
        IList<IPlayerPiece> Pices { get; set; }
        string FinalHouse { get; set; }
        
    }
}

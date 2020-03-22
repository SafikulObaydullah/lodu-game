using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IGame
    {
        IList<IPlayer> Players { get; set; }
        IList<IDice> Dices { get; set; }
        void Start();
        void GameOver();
    }
}

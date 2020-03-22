using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IPlayerSelction
    {
        IPlayer Nnumber { get; set; }
        string PlayerPair { get; set; }
        IPlayer Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public class IPiecePostion : IPlayerSelction ,IStarPosition
    {
        public IPlayer Nnumber { get;set; }
        public string PlayerPair { get;set; }
        public IPlayer Position { get; set ; }
        public IplayerPiece DontCut { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}

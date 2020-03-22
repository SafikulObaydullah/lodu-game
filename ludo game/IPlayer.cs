using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IPlayer : IplayerPiece
    {
        string House { get; set; }
        string Position { get; set; }
        int Score { get; }
        void Cut();
        void AddPieces();
        void AddScorePoint();
    }
}

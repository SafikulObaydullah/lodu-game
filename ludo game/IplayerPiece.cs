using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public interface IplayerPiece
    {
        public bool isReady { get; }
        public bool canMove { get; }
        public bool MoveNow { get; set; }
        Coroutine moveSteps_coroutine { get; set; }
        IPathObjectsParents pathsParent { get; set; }
        public int numberofStepsAlreadyMOved { get; }
        public int numberofStepstoMove { get; set; }
        //Coroutine moveSteps _coroutine{get;set;}
        public void Awake();        
        public void MoveSteps();
        public void MakePlayerReadyToMove();
       
    }
}

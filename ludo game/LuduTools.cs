using System;
using System.Collections.Generic;
using System.Text;

namespace LUDU_Game_6a
{
    public class LuduTools : IGame,IplayerPiece
    {
        public int MaxmumNubmer { get; set; }
        public IList<IPlayer> Players { get; set; }
        public IList<IDice> Dices { get; set; }
        public int Postion { get ; set; }
        public string Size { get ; set ; }
        public string Color { get; set ; }
        public int Number { get; set; }

        public bool isReady => throw new NotImplementedException();

        public bool canMove => throw new NotImplementedException();

        public bool MoveNow { get; set; }
        public Coroutine moveSteps_coroutine { get; set; }
        public IPathObjectsParents pathsParent { get; set; }
        public int numberofStepsAlreadyMOved => throw new NotImplementedException();

        public int numberofStepstoMove { get; set; }

        public void Start(int sixNUmber)
        {
            
        }
        public void GameOver(int AllPices,string Terminal)
        {
            //finalbox.players == MaximumNumber;
            Console.WriteLine("Game is Over");

        }
        public void Move()
        {
            //Dices.DiceRolling.Count();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void GameOver()
        {
            throw new NotImplementedException();
        }

        public void Awake()
        {
            throw new NotImplementedException();
        }

        public void MoveSteps()
        {
            throw new NotImplementedException();
        }
    }
}

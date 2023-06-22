using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICreatureService
    {
        public void creatureService(IGameBoardService gameBoardService);

        public void InitializeCreatures(int preyCount, int predatorCount);

        public void Move(int timeout);

        public bool IsExtinction();
    }
}

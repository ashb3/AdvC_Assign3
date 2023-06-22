using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGameService
    {

        public void StartGame(int width, int height, int preyCount, int predatorCount);
        public bool IsGameOver { get; set; }
        public void NextIteration();
        
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGameBoardService
    {
        public void GenerateGameBoard();
        public GameBoardCell GetRandomDirectionalCell(GameBoardCell cell);
        public GameBoardCell GetCellWithCreatureType(GameBoardCell cell,CreatureType type);
        public GameBoardCell GetRandomEmptyCell();
        public void CreateBoard(int width, int height);
        public int Width { get; set; }
        public int Height { get; set; }
    }
}

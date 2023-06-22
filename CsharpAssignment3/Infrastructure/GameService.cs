using Core.Interfaces;

namespace Infrastructure
{
    public class GameService :IGameService
    {
        public GameService(IGameBoardService gameBoardService, ICreatureService creatureService)
        {
            this.creatureService = creatureService;
            this.gameBoardService = gameBoardService;
        }

        private ICreatureService creatureService { get; }
        private IGameBoardService gameBoardService { get; set; }
        public int Iteration { get; set; }
        public bool IsGameOver { get; set; }

        public void StartGame(int width, int height, int preyCount, int predatorCount)
        {
            gameBoardService.CreateBoard(width, height);
            creatureService.InitializeCreatures(preyCount, predatorCount);
            gameBoardService.GenerateGameBoard();
            WriteIteration();
        }

        public void NextIteration()
        {
            Iteration++;
            creatureService.Move(0);
            if(creatureService.IsExtinction())
                IsGameOver = true;

            WriteIteration();
        }

        private void WriteIteration()
        {
            gameBoardService.GenerateGameBoard();
            Console.SetCursorPosition(0, gameBoardService.Height + 4);
            Console.WriteLine($"Iteration: {Iteration}");
        }
    }
}

using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "güncellendi");
        }
    }
}

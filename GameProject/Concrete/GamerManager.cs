using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckManager _gamerCheckManager;

        public GamerManager(IGamerCheckManager gamerCheckManager)
        {
            _gamerCheckManager = gamerCheckManager;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer)==true)
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("yanlış giriş yaptınız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "güncellendi");
        }
    }
}

using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckManager
    {
        IGamerCheckManager _gamerCheckManager;
       
        public bool Check(Gamer gamer)
        {
            _gamerCheckManager = MernisServiceAdapter();

        }
    }
}

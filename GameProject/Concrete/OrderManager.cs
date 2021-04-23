using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaign campaign)
        {
            decimal indirimOrani =  game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine("sayın" + gamer.FirstName + campaign.DiscountRate + game.GameName + "adlı oyunu satın aldınız");
        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+ "adlı ürünü satın aldınız");
        }
    }
}

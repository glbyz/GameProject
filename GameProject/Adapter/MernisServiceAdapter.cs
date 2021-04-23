using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;
using ServiceReference1;

namespace GameProject.Adapter
{
    class MernisServiceAdapter:IGamerCheckManager
    {

        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64
                    (gamer.NationalityId),
                    gamer.FirstName.ToUpper(),
                    gamer.LastName.ToUpper(),
                    gamer.DateOfBirth.Year)));


        }

    }
}

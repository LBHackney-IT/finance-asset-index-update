using System.Collections.Generic;
using AssetIndexUpdateApi.V1.Domain;

namespace AssetIndexUpdateApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}

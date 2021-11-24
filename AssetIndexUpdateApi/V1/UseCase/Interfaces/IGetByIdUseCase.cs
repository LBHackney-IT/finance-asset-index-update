using AssetIndexUpdateApi.V1.Boundary.Response;

namespace AssetIndexUpdateApi.V1.UseCase.Interfaces
{
    public interface IGetByIdUseCase
    {
        ResponseObject Execute(int id);
    }
}

using GetApi.Models.DataModels;

namespace GetApi.DataLayer.Interface;
public  interface IGetApiData
{
    public IEnumerable<Command> GetCommands();
}
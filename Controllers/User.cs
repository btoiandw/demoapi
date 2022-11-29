using Microsoft.AspNetCore.Mvc;
using demoapi.Models;
namespace demoapi.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IEnumerable<UserModel> Get()
    {
        List<UserModel> list = new List<UserModel>();
        list.Add(new UserModel
        {
            Id = 1,
            Name = "User1",
            Age =21
        });
        list.Add(new UserModel
        {
            Id = 2,
            Name = "User2",
            Age =21
        });
        return list;
    }

    [HttpGet("{id}")]
    public UserModel Get(int id)
    {
        return new UserModel
        {
            Id = id,
            Name = "user1",
            Age = 21
        };
    }

    [HttpDelete("{id}")]
    public UserModel Delete(int id)
    {
        return new UserModel
        {
            Id = id,
            Name = "Deleted",
            Age = 21
        };
    }

    [HttpPost]
    public UserModel Create(UserModel data){
        data.Name += "Created";
        return data;
    }

    [HttpPut]
    public UserModel Update(UserModel data){
        data.Name += "Update";
        return data;
    }
}

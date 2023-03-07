using Application.Services.Users.Dto;
using Persistence.DAL;
using Persistence.DAL.Entities;

namespace Application.Services.Users
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<User> _userRpository;


        public UserService(IRepository<User> userRepo)
        {
            _userRpository = userRepo;
        }


        public Guid Create(CreateUserDto model)
        {
            var userentity = Mapper.Map<User>(model);
            var newuser = _userRpository.Create(userentity);
            return newuser.Id;

        }
          public void Delete(Guid id)
        {
            _userRpository.Delete(id);
            

        }
    
         public UserDto Get( Guid id)
        { 
            var newuser = _userRpository.Get(id);
            var mappedUser = Mapper.Map<UserDto>(newuser);
            return mappedUser;
        }
       
        public void Update(UserDto model)
        {
            var update = Mapper.Map<User>(model);
            _userRpository.Update(update);
            

        }
    
    }
}

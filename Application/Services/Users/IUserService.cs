using System;
using System.Collections.Generic;
using System.Linq;
using Application.Services.Users.Dto;

namespace Application.Services.Users
{
   
    
        public interface IUserService
        {
            Guid Create(CreateUserDto model);

            UserDto Get(Guid id);

            void Update(UserDto model);

            void Delete(Guid id);
        }


    
}

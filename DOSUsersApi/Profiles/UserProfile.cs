using AutoMapper;
using DOSUsersApi.DTOs;
using DOSUsersApi.Models;

namespace DOSUsersApi.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}

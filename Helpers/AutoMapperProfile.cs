using AutoMapper;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Helpers
{
    /// <summary>
    /// AutoMapper是一个OOM（Object-Object-Mapping）组件
    /// 实现实体间的相互转换，从而避免我们每次采用手工的方式进行转换
    /// 1. 将Entity转换到dto
    /// 2. 将dto转换到Entity
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
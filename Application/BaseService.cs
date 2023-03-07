using AutoMapper;

namespace Application
{
    public class BaseService
    {
        public IMapper Mapper { get; set; }

        public BaseService()
        {
        }

    }
}

using QuaHD.Application.Shared.Common;
using QuaHD.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Common
{
    public interface IVideosAppService
    {
        List<Video> GetAll(GetAllVideoInput input);

        Video GetById(Guid id);

        void Insert(Video video);

        void Update(Video video);

        void Delete(Video video);
    }
}

using QuaHD.Core.Entities.Common;
using QuaHD.Mvc.Areas.Admin.Models.Common;

namespace QuaHD.Mvc.Areas.Admin.Factories.Common
{
    public interface IVideoFactory
    {
        VideoViewModel PrepareVideoViewModel(VideoSearchModel searchModel);

        VideoModel PrepareVideoModel(Video? video);
    }
}

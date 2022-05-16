using AutoMapper;
using QuaHD.Application.Common;
using QuaHD.Application.Shared.Common;
using QuaHD.Core.Entities.Common;
using QuaHD.Mvc.Areas.Admin.Models;
using QuaHD.Mvc.Areas.Admin.Models.Common;

namespace QuaHD.Mvc.Areas.Admin.Factories.Common
{
    public class VideoFactory : IVideoFactory
    {
        private readonly IVideosAppService _videosAppService;
        private readonly IMapper _mapper;

        public VideoFactory(IVideosAppService videosAppService, IMapper mapper)
        {
            _videosAppService = videosAppService;
            _mapper = mapper;
        }

        public VideoViewModel PrepareVideoViewModel(VideoSearchModel searchModel)
        {
            var videos = _videosAppService.GetAll(_mapper.Map<GetAllVideoInput>(searchModel));

            return new VideoViewModel
            {
                SearchModel = searchModel,
                VideoModels = new Page<VideoModel>(_mapper.Map<List<VideoModel>>(videos), searchModel)
            };
        }

        public VideoModel PrepareVideoModel(Video? video)
        {
            var model = new VideoModel();
            if (video != null)
            {
                model = _mapper.Map<VideoModel>(video);
            }

            return model;
        }
    }
}

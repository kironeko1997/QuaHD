using QuaHD.Application.Shared.Common;
using QuaHD.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.Application.Common
{
    public class VideosAppService : IVideosAppService
    {
        private readonly IRepository<Video> _videoRepository;

        public VideosAppService(IRepository<Video> videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public List<Video> GetAll(GetAllVideoInput input)
        {
            var videos = _videoRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                videos = videos.Where(x => input.Filter.ToLower().Trim().Contains(x.Title.ToLower().Trim()) || input.Filter.ToLower().Trim().Contains(x.Url.ToLower().Trim()));
            }

            return videos.ToList();
        }

        public Video GetById(Guid id)
        {
            var video = _videoRepository.GetById(id);

            return video;
        }

        public void Insert(Video video)
        {
            _videoRepository.Insert(video);
        }

        public void Update(Video video)
        {
            _videoRepository.Update(video);
        }

        public void Delete(Video video)
        {
            _videoRepository.Delete(video);
        }
    }
}

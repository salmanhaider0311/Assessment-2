using Assesment_2.PostProcessingDelegates;
using Assesment_2.SocialMediaPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.PostProcessing
{
    public class ProcessHandeling
    {
        public void ProcessRegisterLogic(PostProcessingService postService)
        {
            // Text post processing
            var textPost = new SocialMediaPost<object>
            {
                PostId = 1,
                Type = PostType.Text,
                Content = "This is Text post",
                Status = ProcessingStatus.Pending
            };
            postService.ProcessPost(textPost);

            // Image post processing
            var imagePost = new SocialMediaPost<object>
            {
                PostId = 2,
                Type = PostType.Image,
                Content = "This is Image post",
                Status = ProcessingStatus.Completed
            };
            postService.ProcessPost(imagePost);

            // Video post processing
            var videoPost = new SocialMediaPost<object>
            {
                PostId = 3,
                Type = PostType.Video,
                Content = "This is Video post",
                Status = ProcessingStatus.Failed
            };
            postService.ProcessPost(videoPost);
        }
    }
}

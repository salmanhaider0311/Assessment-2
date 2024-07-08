using Assesment_2.PostProcessingDelegates;
using Assesment_2.SocialMediaPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assesment_2.PostProcessingDelegates.Delegates;

namespace Assesment_2.Handlers
{
    public class ProcessingHandlers
    {
        public void ProcessingHandlersMethod (PostProcessingService postService)
        {
            //Processing handlers

            postService.RegisterProcessor(PostType.Text, new Action<SocialMediaPost<object>>(TextProcessingHandler));
            postService.RegisterProcessor(PostType.Image, new Action<SocialMediaPost<object>>(ImageProcessingHandler));
            postService.RegisterProcessor(PostType.Video, new Action<SocialMediaPost<object>>(VideoProcessingHandler));
        }
        static void TextProcessingHandler(SocialMediaPost<object> post)
        {
            Console.WriteLine("Processing Text with id {0}", post.PostId);
            Thread.Sleep(1000);
        }
        static void ImageProcessingHandler(SocialMediaPost<object> post)
        {
            Console.WriteLine("Processing Image with id {0}", post.PostId);
            Thread.Sleep(2000);
        }
        static void VideoProcessingHandler(SocialMediaPost<object> post)
        {
            Console.WriteLine("Processing video with id {0}", post.PostId);
            Thread.Sleep(3000);
        }
    }

}

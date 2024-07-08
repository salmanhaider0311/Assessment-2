using Assesment_2.PostProcessingDelegates;
using Assesment_2.SocialMediaPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.Handlers
{
    public class ProcessingHandlers
    {
        public void ProcessingHandlersMethod (PostProcessingService postService)
        {
            //Processing handlers delegates

            postService.RegisterProcessor(PostType.Text, new Action<SocialMediaPost<object>>(TextProcessingHandler));
            postService.RegisterProcessor(PostType.Image, new Action<SocialMediaPost<object>>(ImageProcessingHandler));
            postService.RegisterProcessor(PostType.Video, new Action<SocialMediaPost<object>>(VideoProcessingHandler));
        }
        static void TextProcessingHandler(SocialMediaPost<object> post)
        {
            // Text processing Method
            Console.WriteLine("Processing Text with id {0}", post.PostId);

            // Waiting for 1 second
            Thread.Sleep(1000);
        }
        static void ImageProcessingHandler(SocialMediaPost<object> post)
        {
            // Image processing Method
            Console.WriteLine("Processing Image with id {0}", post.PostId);

            // Waiting for 2 second
            Thread.Sleep(2000);
        }
        static void VideoProcessingHandler(SocialMediaPost<object> post)
        {
            // video processing Method
            Console.WriteLine("Processing video with id {0}", post.PostId);

            // Waiting for 3 second
            Thread.Sleep(3000);
        }
    }

}

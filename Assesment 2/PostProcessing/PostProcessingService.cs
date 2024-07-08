using Assesment_2.SocialMediaPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.PostProcessingDelegates
{
    public class PostProcessingService
    {
        private Dictionary<PostType, Delegate> processors;
        public event EventHandler<SocialMediaPost<object>> PostProcessed;

        public PostProcessingService()
        {
            processors = new Dictionary<PostType, Delegate>();
        }

        public void RegisterProcessor(PostType type, Delegate processor)
        {
            // Process registering
            processors.Add(type, processor);
        }

        public void ProcessPost(SocialMediaPost<object> post)
        {
            // Implement asynchronous processing and event handling

            if(processors.TryGetValue(post.Type, out var processor))
            {
                ThreadPool.QueueUserWorkItem(state =>
                {
                    // Asynchronous Processing
                    processor.DynamicInvoke(post);


                    // Invoking Event
                    PostProcessed?.Invoke(this, post);
                });
            }
            else
            {
                post.Status = ProcessingStatus.Failed;
                PostProcessed?.Invoke(this, post);
            }
        }

    }
}

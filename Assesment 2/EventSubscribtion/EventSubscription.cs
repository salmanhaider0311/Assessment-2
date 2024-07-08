using Assesment_2.PostProcessingDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.EventSubscribtion
{
    public class EventSubscription
    {
        public void SubscribeEvent(PostProcessingService postService)
        {
            // Event subscribtion
            postService.PostProcessed += (sender, post) =>
            {
                Console.WriteLine(post.PostId + " processed with status " + post.Status);
            };
        }
    }
}

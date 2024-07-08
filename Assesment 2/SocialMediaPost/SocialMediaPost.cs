using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.SocialMediaPost
{
    public class SocialMediaPost<T>
    {
        public int PostId { get; set; }
        public PostType Type { get; set; }
        // Generic Type T 
        public T Content { get; set; }
        public ProcessingStatus Status { get; set; }

    }
    public enum PostType
    {
        Text,
        Image,
        Video
    }

    public enum ProcessingStatus
    {
        Pending,
        Processing,
        Completed,
        Failed
    }

}

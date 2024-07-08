using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.PostProcessingDelegates
{
    public class Delegates
    {
        public delegate void TextProcessingHandler(); // delegate for text posts 
        public delegate void ImageProcessingHandler(); // delegate for Image posts 
        public delegate void VideoProcessingHandler(); // delegate for Vidoe posts 
    }
}

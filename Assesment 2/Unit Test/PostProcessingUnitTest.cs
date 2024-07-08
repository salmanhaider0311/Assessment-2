using Assesment_2.PostProcessingDelegates;
using Assesment_2.SocialMediaPost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2.Unit_Test
{
    [TestFixture]
    public class PostProcessingUnitTest
    {
        [Test]
        public void ProcessPostSuccessfully()
        {
            // arrange
            var postProcess = new PostProcessingService();

            var textProcess = new SocialMediaPost<object>
            {
                PostId = 1,
                Content = "Unit test for post processing",
                Status = ProcessingStatus.Completed,
                Type = PostType.Text
            };

            //Act

            postProcess.ProcessPost(textProcess);

            //Assert
            Assert.Equals(ProcessingStatus.Completed, textProcess.Status);

        }
    }
}

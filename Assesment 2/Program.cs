using Assesment_2.EventSubscribtion;
using Assesment_2.Handlers;
using Assesment_2.PostProcessing;
using Assesment_2.PostProcessingDelegates;
using Assesment_2.SocialMediaPost;

class Program
{
    static void Main(string[] args)
    {
        // Create instance for PostProcessingService Class
        var postService = new PostProcessingService();

        // Create instance for ProcessingHandlers Class
        var handlers = new ProcessingHandlers();
        handlers.ProcessingHandlersMethod(postService);


        // Create instance for EventSubscription Class
        var eventSubscriber = new EventSubscription();
        eventSubscriber.SubscribeEvent(postService);

        // Create instance for ProcessHandeling Class
        var processes = new ProcessHandeling();
        processes.ProcessRegisterLogic(postService);

        Console.ReadLine();
    }
}
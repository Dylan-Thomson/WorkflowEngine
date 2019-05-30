using System;

namespace WorkflowEngine
{
    public class VideoUploadNotifier : IActivity
    {
        public void Execute()
        {
            // Logic for notifying video encoding service of upload
            // ...
            Console.WriteLine("Notifying encoding service...");
        }
    }
}

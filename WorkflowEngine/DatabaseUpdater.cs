using System;

namespace WorkflowEngine
{
    public class DatabaseUpdater : IActivity
    {
        public void Execute()
        {
            // Logic for updating status of video record in database to "processing"
            // ...
            Console.WriteLine("Updating video record in database to \"processing\"...");
        }
    }
}

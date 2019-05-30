using System;

namespace WorkflowEngine
{
    public class EmailNotifier : IActivity
    {
        public void Execute()
        {
            // Logic for sending email
            // ...
            Console.WriteLine("Emailing video owner to notify them that video has started processing...");
        }
    }
}

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new VideoUploadNotifier());
            workflow.Add(new EmailNotifier());
            workflow.Add(new DatabaseUpdater());
            WorkflowEngine.Run(workflow);
        }
    }
}

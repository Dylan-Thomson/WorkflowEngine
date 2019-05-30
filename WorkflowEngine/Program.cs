namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlowEngine();
            workflow.RegisterActivity(new VideoUploader());
            workflow.RegisterActivity(new VideoUploadNotifier());
            workflow.RegisterActivity(new EmailNotifier());
            workflow.RegisterActivity(new DatabaseUpdater());
            workflow.Run();
        }
    }
}

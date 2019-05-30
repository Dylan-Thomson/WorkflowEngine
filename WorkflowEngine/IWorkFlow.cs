namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void RegisterActivity(IActivity activity);

        void RemoveActivity(IActivity activity);

        void Run();
    }
}

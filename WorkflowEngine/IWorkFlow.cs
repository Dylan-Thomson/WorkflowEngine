namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void Add(IActivity activity);

        void Remove(IActivity activity);
    }
}

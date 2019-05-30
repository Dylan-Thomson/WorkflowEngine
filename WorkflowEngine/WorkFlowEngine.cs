namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public static void Run(Workflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }

    }
}

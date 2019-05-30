using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkFlowEngine : IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

    }
}

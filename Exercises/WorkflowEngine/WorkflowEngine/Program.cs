using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video");
        }
    }

    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending confirmation email");
        }
    }

    class ReceivedNotification : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Email received.");
        }
    }


    public interface IActivity
    {
        void Execute();
    }

    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }

    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }

    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception)
                {
                    // Log error.
                    // Terminate workflow and persist state.
                    throw;
                }
            }
        }
    }

    class Program
    {
        static void Main(string [] args)
        {
            var workflow = new Workflow();
            workflow.Add(new VideoUploader());
            workflow.Add(new SendEmail());
            workflow.Add(new ReceivedNotification());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }
    }
}

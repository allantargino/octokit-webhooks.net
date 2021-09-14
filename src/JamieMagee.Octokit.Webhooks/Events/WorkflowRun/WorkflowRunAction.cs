namespace JamieMagee.Octokit.Webhooks.Events.WorkflowRun
{
    public sealed class WorkflowRunAction : WebhookEventAction
    {
        public static readonly WorkflowRunAction Completed = new(WorkflowRunActionValue.Completed);

        public static readonly WorkflowRunAction Requested = new(WorkflowRunActionValue.Requested);

        private WorkflowRunAction(string value)
            : base(value)
        {
        }
    }
}
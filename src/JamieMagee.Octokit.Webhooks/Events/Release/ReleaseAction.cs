namespace JamieMagee.Octokit.Webhooks.Events.Release
{
    public sealed class ReleaseAction : WebhookEventAction
    {
        public static readonly ReleaseAction Created = new(ReleaseActionValue.Created);

        public static readonly ReleaseAction Deleted = new(ReleaseActionValue.Deleted);

        public static readonly ReleaseAction Edited = new(ReleaseActionValue.Edited);

        public static readonly ReleaseAction Prereleased = new(ReleaseActionValue.Prereleased);

        public static readonly ReleaseAction Published = new(ReleaseActionValue.Published);

        public static readonly ReleaseAction Released = new(ReleaseActionValue.Released);

        public static readonly ReleaseAction Unpublished = new(ReleaseActionValue.Unpublished);

        private ReleaseAction(string value)
            : base(value)
        {
        }
    }
}
namespace JamieMagee.Octokit.Webhooks.Events.Discussion
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(DiscussionActionValue.Answered)]
    public sealed record DiscussionAnsweredEvent : DiscussionEvent
    {
        [JsonPropertyName("action")]
        public override string Action => DiscussionAction.Answered;

        [JsonPropertyName("answer")]
        public DiscussionAnswer Answer { get; init; } = null!;
    }
}

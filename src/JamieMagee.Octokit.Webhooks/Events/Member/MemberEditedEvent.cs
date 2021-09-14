namespace JamieMagee.Octokit.Webhooks.Events.Member
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;
    using JamieMagee.Octokit.Webhooks.Models.MemberEvent;

    [WebhookActionType(MemberActionValue.Edited)]
    public sealed record MemberEditedEvent : MemberEvent
    {
        [JsonPropertyName("action")]
        public override string Action => MemberAction.Edited;

        [JsonPropertyName("changes")]
        public Changes Changes { get; init; } = null!;
    }
}

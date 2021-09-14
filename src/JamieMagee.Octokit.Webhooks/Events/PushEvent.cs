﻿namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;
    using JamieMagee.Octokit.Webhooks.Models.PushEvent;

    [WebhookEventType(WebhookEventType.Push)]
    public sealed record PushEvent : WebhookEvent
    {
        [JsonPropertyName("ref")]
        public string Ref { get; init; } = null!;

        [JsonPropertyName("before")]
        public string Before { get; init; } = null!;

        [JsonPropertyName("after")]
        public string After { get; init; } = null!;

        [JsonPropertyName("created")]
        public bool Created { get; init; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; init; }

        [JsonPropertyName("forced")]
        public bool Forced { get; init; }

        [JsonPropertyName("base_ref")]
        public string? BaseRef { get; init; }

        [JsonPropertyName("compare")]
        public string Compare { get; init; } = null!;

        [JsonPropertyName("commits")]
        public IEnumerable<Commit> Commits { get; init; } = null!;

        [JsonPropertyName("head_commit")]
        public Commit? HeadCommit { get; init; }

        [JsonPropertyName("pusher")]
        public Committer Pusher { get; init; } = null!;
    }
}
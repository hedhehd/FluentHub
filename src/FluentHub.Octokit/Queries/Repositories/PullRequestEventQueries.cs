﻿namespace FluentHub.Octokit.Queries.Repositories
{
    public class PullRequestEventQueries
    {
        public PullRequestEventQueries() => new App();

        public async Task<List<object>> GetAllAsync(string owner, string name, int number)
        {
            #region queries
            var query = new Query()
                .Repository(name, owner)
                .PullRequest(number)
                .TimelineItems(40, null, null, null, null, null, null)
                .Nodes
                .Select(node => node.Switch<object>(when => when
                .AddedToProjectEvent(y => new AddedToProjectEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AssignedEvent(y => new AssignedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutoMergeDisabledEvent(y => new AutoMergeDisabledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutoMergeEnabledEvent(y => new AutoMergeEnabledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutoRebaseEnabledEvent(y => new AutoRebaseEnabledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutoSquashEnabledEvent(y => new AutoSquashEnabledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutomaticBaseChangeFailedEvent(y => new AutomaticBaseChangeFailedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .AutomaticBaseChangeSucceededEvent(y => new AutomaticBaseChangeSucceededEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .BaseRefChangedEvent(y => new BaseRefChangedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .BaseRefDeletedEvent(y => new BaseRefDeletedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .BaseRefForcePushedEvent(y => new BaseRefForcePushedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ClosedEvent(y => new ClosedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .CommentDeletedEvent(y => new CommentDeletedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ConnectedEvent(y => new ConnectedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ConvertedNoteToIssueEvent(y => new ConvertedNoteToIssueEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .CrossReferencedEvent(y => new CrossReferencedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .DemilestonedEvent(y => new DemilestonedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .DeployedEvent(y => new DeployedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .DeploymentEnvironmentChangedEvent(y => new DeploymentEnvironmentChangedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .DisconnectedEvent(y => new DisconnectedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .HeadRefDeletedEvent(y => new HeadRefDeletedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .HeadRefForcePushedEvent(y => new HeadRefForcePushedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .HeadRefRestoredEvent(y => new HeadRefRestoredEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .IssueComment(y => new IssueComment
                {
                    Author = y.Author.Select(author => new Actor
                    {
                        AvatarUrl = author.AvatarUrl(100),
                        Login = author.Login,
                    })
                    .Single(),

                    AuthorAssociation = y.AuthorAssociation,
                    BodyHTML = y.BodyHTML,
                    MinimizedReason = y.MinimizedReason,
                    Url = y.Url,

                    Reactions = y.Reactions(6, null, null, null, null, null).Nodes.Select(reaction => new Reaction
                    {
                        Content = reaction.Content,
                        ReactorLogin = reaction.User.Login,
                    })
                    .ToList(),

                    IsMinimized = y.IsMinimized,
                    ViewerCanDelete = y.ViewerCanDelete,
                    ViewerCanMinimize = y.ViewerCanMinimize,
                    ViewerCanReact = y.ViewerCanReact,
                    ViewerCanUpdate = y.ViewerCanUpdate,
                    ViewerDidAuthor = y.ViewerDidAuthor,

                    LastEditedAt = y.LastEditedAt,
                    CreatedAt = y.CreatedAt,
                    UpdatedAt = y.UpdatedAt,
                })
                .LabeledEvent(y => new LabeledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    Label = y.Label.Select(label => new Label
                    {
                        Color = label.Color,
                        Description = label.Description,
                        Name = label.Name,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                    CreatedAtHumanized = y.CreatedAt.Humanize(null, null),
                })
                .LockedEvent(y => new LockedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    LockReason = y.LockReason,

                    CreatedAt = y.CreatedAt,
                })
                .MarkedAsDuplicateEvent(y => new MarkedAsDuplicateEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .MergedEvent(y => new MergedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .MilestonedEvent(y => new MilestonedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    MilestoneTitle = y.MilestoneTitle,

                    CreatedAt = y.CreatedAt,
                })
                .MovedColumnsInProjectEvent(y => new MovedColumnsInProjectEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .PinnedEvent(y => new PinnedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .PullRequestCommit(y => new PullRequestCommit
                {
                    Actor = y.Commit.Author.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Name,
                    })
                    .Single(),

                    CreatedAt = y.Commit.AuthoredDate,
                })
                .PullRequestReview(y => new PullRequestReview
                {
                    Actor = y.Commit.Author.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Name,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ReadyForReviewEvent(y => new ReadyForReviewEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ReferencedEvent(y => new ReferencedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .RemovedFromProjectEvent(y => new RemovedFromProjectEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .RenamedTitleEvent(y => new RenamedTitleEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CurrentTitle = y.CurrentTitle,
                    PreviousTitle = y.PreviousTitle,

                    CreatedAt = y.CreatedAt,
                })
                .ReopenedEvent(y => new ReopenedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ReviewDismissedEvent(y => new ReviewDismissedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ReviewRequestRemovedEvent(y => new ReviewRequestRemovedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .ReviewRequestedEvent(y => new ReviewRequestedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .TransferredEvent(y => new TransferredEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    FromRepository = y.FromRepository.Select(from => new Repository
                    {
                        Owner = from.Owner.Select(owner => new RepositoryOwner
                        {
                            AvatarUrl = owner.AvatarUrl(100),
                            Login = owner.Login,
                        })
                        .Single(),

                        Name = from.Name,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .UnassignedEvent(y => new UnassignedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .UnlabeledEvent(y => new UnlabeledEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    Label = y.Label.Select(label => new Label
                    {
                        Color = label.Color,
                        Description = label.Description,
                        Name = label.Name,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                    CreatedAtHumanized = y.CreatedAt.Humanize(null, null),
                })
                .UnlockedEvent(y => new UnlockedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .UnmarkedAsDuplicateEvent(y => new UnmarkedAsDuplicateEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .UnpinnedEvent(y => new UnpinnedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    CreatedAt = y.CreatedAt,
                })
                .UserBlockedEvent(y => new UserBlockedEvent
                {
                    Actor = y.Actor.Select(actor => new Actor
                    {
                        AvatarUrl = actor.AvatarUrl(100),
                        Login = actor.Login,
                    })
                    .Single(),

                    BlockDuration = y.BlockDuration,

                    CreatedAt = y.CreatedAt,
                })
                //.MentionedEvent(y => new MentionedEvent {})
                //.PullRequestCommitCommentThread(y => new PullRequestCommitCommentThread {})
                //.PullRequestReviewThread(y => new PullRequestReviewThread {})
                //.PullRequestRevisionMarker(y => new PullRequestRevisionMarker {})
                //.SubscribedEvent(y => new SubscribedEvent {})
                //.UnsubscribedEvent(y => new UnsubscribedEvent {})
                ))
                .Compile();
            #endregion

            var response = await App.Connection.Run(query);

            return response.ToList();
        }
    }
}

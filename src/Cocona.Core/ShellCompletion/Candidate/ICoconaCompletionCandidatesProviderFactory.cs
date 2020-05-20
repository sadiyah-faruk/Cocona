namespace Cocona.ShellCompletion.Candidate
{
    public interface ICoconaCompletionCandidatesProviderFactory
    {
        ICoconaCompletionStaticCandidatesProvider CreateStaticProvider(CoconaCompletionCandidatesMetadata metadata);
        ICoconaCompletionOnTheFlyCandidatesProvider CreateOnTheFlyProvider(CoconaCompletionCandidatesMetadata metadata);
    }
}
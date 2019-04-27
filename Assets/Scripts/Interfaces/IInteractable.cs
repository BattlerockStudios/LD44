public interface IInteractable
{
    bool IsBeingInteractedWith { get; }
    void BeginInteraction(IInteractionSource interactionSource);
    void EndInteraction(IInteractionSource interactionSource);
}
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class InteractiveObject : Actor, IInteractable
{
    public bool IsBeingInteractedWith => throw new System.NotImplementedException();

    public void BeginInteraction(IInteractionSource interactionSource)
    {
        throw new System.NotImplementedException();
    }

    public void EndInteraction(IInteractionSource interactionSource)
    {
        throw new System.NotImplementedException();
    }
}
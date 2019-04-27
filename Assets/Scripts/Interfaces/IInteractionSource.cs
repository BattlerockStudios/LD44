using UnityEngine;

public interface IInteractionSource
{
    void OnInteractionBegin(IInteractable interactable);
    void OnInteractionEnd(IInteractable interactable);
    void OnTriggerEnter(Collider other);
    void OnTriggerExit(Collider other);
}
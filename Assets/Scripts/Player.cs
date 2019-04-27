using UnityEngine;

public class Player : Character, IInteractionSource, IMovement
{
    public MoveState MoveState => throw new System.NotImplementedException();

    public void Direction()
    {
        throw new System.NotImplementedException();
    }

    public void OnInteractionBegin(IInteractable interactable)
    {
        throw new System.NotImplementedException();
    }

    public void OnInteractionEnd(IInteractable interactable)
    {
        throw new System.NotImplementedException();
    }

    public void OnTriggerEnter(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public void OnTriggerExit(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public void Rotation()
    {
        throw new System.NotImplementedException();
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IInteractionSource, IMovement
{
    #region Private Variables

    [SerializeField]
    private MoveState m_moveState = MoveState.Idle;
    private readonly Dictionary<Guid, IInteractable> m_nearbyInteractiveObjects = new Dictionary<Guid, IInteractable>();

    #endregion

    #region Public Properties

    public MoveState MoveState => m_moveState;

    #endregion

    #region Interface Methods

    #region IMovement

    public Vector3 Direction()
    {
        throw new System.NotImplementedException();
    }

    public void Rotation()
    {
        throw new System.NotImplementedException();
    }

    #endregion   

    #region IInteractionSource    

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
        var foundInteractive = other.GetComponent<IInteractable>();
        if (foundInteractive != null)
        {

        }
    }

    public void OnTriggerExit(Collider other)
    {
        throw new System.NotImplementedException();
    }

    #endregion    

    #endregion
}

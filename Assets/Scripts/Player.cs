using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IInteractionSource
{
    #region Private Variables

    private readonly Dictionary<Guid, IInteractable> m_nearbyInteractiveObjects = new Dictionary<Guid, IInteractable>();

    #endregion

    #region Unity Methods

    private void Update()
    {
        ApplyMovement();
    }

    #endregion

    #region Protected Methods

    protected override void ApplyMovement()
    {
        base.ApplyMovement();

        var direction = Direction();
        var velocity = Velocity;

        velocity.x = direction.x * Speed;
        velocity.z = direction.z * Speed;

        Rotation();

        Rigidbody.velocity = velocity;
    }

    #endregion

    #region Interface Methods

    #region IMovement

    public override Vector3 Direction()
    {
        Vector3 movementInput = new Vector3(Input.GetAxis(HORIZONTAL_AXIS), 0, Input.GetAxis(VERTICAL_AXIS));
        movementInput = Camera.main.transform.TransformDirection(movementInput).normalized;
        movementInput.y = 0;

        movementInput.Normalize();

        return movementInput;
    }

    public override void Rotation()
    {
        var direction = Direction();       

        // Find the wanted rotation angle based on the rotation vector
        Quaternion wantedRotation = Quaternion.LookRotation(direction, Vector3.up);

        Rigidbody.rotation = Quaternion.RotateTowards(Rigidbody.rotation, wantedRotation, Speed * Time.deltaTime);
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

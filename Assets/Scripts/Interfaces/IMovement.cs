using UnityEngine;

public interface IMovement
{
    MoveState MoveState { get; }

    bool IsOnGround { get; }
    bool IsMoving { get; }

    Vector3 Direction();
    void Rotation();

    Vector3 Velocity { get; }
}

public enum MoveState
{
    Idle,
    Walk,
    Run
}
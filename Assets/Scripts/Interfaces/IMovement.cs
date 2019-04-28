using UnityEngine;

public interface IMovement
{
    MoveState MoveState { get; }
    Vector3 Direction();
    void Rotation();
}

public enum MoveState
{
    Idle,
    Walk,
    Run
}
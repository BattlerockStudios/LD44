public interface IMovement
{
    MoveState MoveState { get; }
    void Direction();
    void Rotation();
}

public enum MoveState
{
    Idle,
    Walk,
    Run
}
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Character : Actor, IAttributes, IMovement
{
    #region Private Variables

    [SerializeField]
    private int m_health = 100;

    [SerializeField]
    private float m_speed = 10.0f;

    [SerializeField]
    private float m_rotationSpeed = 1000.0f;

    private bool m_isOnGround;
    private bool m_isMoving;
    private Vector3 m_velocity;

    [SerializeField]
    private MoveState m_moveState = MoveState.Idle;

    private Animator m_animator;
    private Rigidbody m_rigidbody;
    private Collider m_collider;

    #endregion

    #region Protected Variables

    protected const string HORIZONTAL_AXIS = "Horizontal";
    protected const string VERTICAL_AXIS = "Vertical";

    #endregion

    #region Public Properties

    public int Health => m_health;
    public float Speed => m_speed;

    public MoveState MoveState => m_moveState;

    public bool IsOnGround => m_isOnGround;
    public bool IsMoving => IsMoving;

    public Animator Animator => m_animator;
    public Rigidbody Rigidbody => m_rigidbody;
    public Collider Collider => m_collider;

    public Vector3 Velocity => m_velocity;

    public float RotationSpeed => m_rotationSpeed;

    #endregion

    #region Private Methods

    private void Start()
    {
        m_animator = GetComponent<Animator>();
        m_rigidbody = GetComponent<Rigidbody>();
        m_rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;


        m_collider = GetComponent<Collider>();

        m_velocity = m_rigidbody.velocity;
    }

    #endregion

    #region Protected Methods

    protected virtual void ApplyMovement()
    {
        Direction();
        Rotation();
    }

    #endregion

    #region Interface Methods

    public virtual Vector3 Direction()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Rotation()
    {
        throw new System.NotImplementedException();
    }

    #endregion
}
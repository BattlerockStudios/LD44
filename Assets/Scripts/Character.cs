using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Character : Actor, IAttributes
{
    #region Private Variables

    [SerializeField]
    private int m_health = 100;

    [SerializeField]
    private float m_speed = 10.0f;

    #endregion

    #region Public Properties

    public int Health => m_health;
    public float Speed => m_speed;

    #endregion
}
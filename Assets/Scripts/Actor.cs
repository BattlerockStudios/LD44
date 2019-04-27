using System;
using UnityEngine;

public class Actor : MonoBehaviour
{
    private Guid m_guid = Guid.NewGuid();

    public Guid Guid { get => m_guid; }
}

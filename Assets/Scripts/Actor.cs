using System;
using UnityEngine;

public class Actor : MonoBehaviour
{
    #region Private Variables

    private Guid m_guid = Guid.NewGuid();
    private string m_name = "DEFAULT_NAME";

    #endregion

    #region Public Properties

    public Guid Guid => m_guid;
    public string Name => m_name;

    #endregion
}

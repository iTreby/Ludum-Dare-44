using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour
{
    GameObject endPanel;
    GameObject UIPanel;

    public void Awake()
    {
        endPanel.setActive(false);
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameobject.tag == "Player")
        {
            endPanel.setActive(true);
            UIPanel.setActive(false);
        }
    }

}

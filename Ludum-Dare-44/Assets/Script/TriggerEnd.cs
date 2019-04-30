using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour
{
    [SerializeField] GameObject endPanel;
    [SerializeField] GameObject UIPanel;

    public void Awake()
    {
        endPanel.SetActive(false);
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            endPanel.SetActive(true);
            UIPanel.SetActive(false);
        }
    }

}

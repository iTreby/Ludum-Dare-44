using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    [SerializeField] Transform teleportPoint;
    [SerializeField] MainController countLimbs;
  
    public bool stageClear = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (stageClear && countLimbs.limbsGone == 4)
        {
            countLimbs.finalSwitch = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            stageClear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            stageClear = false;
        }
    }
}

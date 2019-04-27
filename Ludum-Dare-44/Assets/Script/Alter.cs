using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alter : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject rightArm;
    [SerializeField] GameObject leftArm;
    public bool hasRemovedLimb;

    // Start is called before the first frame update
    void Start()
    {
        hasRemovedLimb = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && !hasRemovedLimb)
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(false);
        }
    }


    public void RightArm()
    {
        rightArm.transform.localScale = new Vector3(0, 0, 0);
        hasRemovedLimb = true;
        panel.SetActive(false);
    }

    public void LeftArm()
    {
        hasRemovedLimb = true;
        leftArm.transform.localScale = new Vector3(0, 0, 0);
        panel.SetActive(false);
    }

}

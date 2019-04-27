using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alter : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject rightArm;
    [SerializeField] GameObject leftArm;
    [SerializeField] Health health;
    [SerializeField] GameObject healthImage;
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
            healthImage.SetActive(false);
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            healthImage.SetActive(true);
            panel.SetActive(false);
        }
    }


    public void RightArm()
    {
        rightArm.transform.localScale = new Vector3(0, 0, 0);
        hasRemovedLimb = true;
        panel.SetActive(false);
        health.Healths -= 10f;
        
    }

    public void LeftArm()
    {
        hasRemovedLimb = true;
        leftArm.transform.localScale = new Vector3(0, 0, 0);
        panel.SetActive(false);
        health.Healths -= 10f;
    }

}

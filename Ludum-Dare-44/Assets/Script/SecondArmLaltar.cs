using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondArmLaltar : MonoBehaviour
{
    
    [SerializeField] GameObject rightButton;
    [SerializeField] GameObject leftButton;
    [SerializeField] MainController countLimbs;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject[] limb;
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

    public void RemoveRight()
    {
        countLimbs.rightArmGone = true;
        hasRemovedLimb = true;
        countLimbs.limbsGone++;
        limb[0].transform.localScale = new Vector3(0, 0, 0);
        panel.SetActive(false);
        rightButton.SetActive(false);
        health.Healths -= 10f;
        this.enabled = false;
    }

    public void RemoveLeft()
    {
        countLimbs.leftArmGone = true;
        hasRemovedLimb = true;
        countLimbs.limbsGone++;
        limb[1].transform.localScale = new Vector3(0, 0, 0);
        panel.SetActive(false);
        leftButton.SetActive(false);
        health.Healths -= 10f;   
        this.enabled = false;
    }

}

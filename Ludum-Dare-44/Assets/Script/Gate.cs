using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] MainController countLimbs;
    [SerializeField] Animator gateAnime;
    bool playerPresent;


    // Start is called before the first frame update
    void Start()
    {
        gateAnime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(countLimbs.limbsGone >= 1 && playerPresent)
        {
            gateAnime.SetBool("GateDown", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerPresent = true;
        }
    }


}

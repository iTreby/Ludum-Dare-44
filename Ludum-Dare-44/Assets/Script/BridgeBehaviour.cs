using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBehaviour : MonoBehaviour
{
    [SerializeField] MainController countLimbs;
    Animator bridgeAnimator;

    // Start is called before the first frame update
    void Start()
    {
        bridgeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(countLimbs.limbsGone == 4)
        {
            bridgeAnimator.SetBool("isActivated", true);
        }
    }
}

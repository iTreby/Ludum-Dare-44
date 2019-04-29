using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    [SerializeField] Transform teleportPoint;
    [SerializeField] MainController countLimbs;
    [SerializeField] Animator animeRock;
    [SerializeField] GameObject rock;
    public bool stageClear = false;

    // Start is called before the first frame update
    void Start()
    {
        animeRock = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(stageClear && countLimbs.limbsGone == 2)
        {
            rock.SetActive(false);
            countLimbs.positionSwitch = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            stageClear = true;
        }
    }

}

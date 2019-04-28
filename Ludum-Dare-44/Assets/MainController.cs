using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] Animator anime;


    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anime.SetBool("Swing", true);
            StartCoroutine("Default");
        }

        if (Input.GetMouseButtonDown(1))
        {
            anime.SetBool("Shield", true);
            StartCoroutine("Idle");
        }
    }

    IEnumerator Default()
    {
        yield return new WaitForSeconds(2f);
        anime.SetBool("Swing", false);
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(2f);
        anime.SetBool("Shield", false);
    }


}

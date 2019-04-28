using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] float totalHealth = 100f;
    [SerializeField] float healths;
    [SerializeField] GameObject gameOver;

    public float Healths { get => healths; set => healths = value; }




    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        healths = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = healths / totalHealth;

        if(healthBar.fillAmount <= 0)
        {
            gameObject.SetActive(true);
        }
    }
}

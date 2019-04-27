using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] float totalHealth = 100f;
    [SerializeField] float health;


    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / totalHealth;
    }
}

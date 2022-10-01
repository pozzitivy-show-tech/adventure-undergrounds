using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthsystem : MonoBehaviour
{
    public GameObject death;
    public int maxhealth;
    private float health;
    public Image healthbar;
    public GameObject mainUI;
    public Sprite deathsprite;
    public movement check;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    public void ChangeHealth(int value)
    {
        health += value;

        if (health <= 0 && death.activeSelf == false)
        {
            if (check.horizontal == 1)
            {
                GetComponent<SpriteRenderer>().sprite = deathsprite;
                mainUI.SetActive(false);
                death.SetActive(true);
                transform.Rotate(0, 0, -90);
            }
            if (check.horizontal == -1)
            {
                GetComponent<SpriteRenderer>().sprite = deathsprite;
                mainUI.SetActive(false);
                death.SetActive(true);
                transform.Rotate(0, 0, 90);
            }


        }

        RenderHealth();
    }

    private void RenderHealth()
    {
        healthbar.fillAmount = (float)health / (float)maxhealth;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("heal potion"))
        {
            if(health <= 8)
            {
                ChangeHealth(2);
                collision.gameObject.SetActive(false);
            }
            else if(health == 9)
            {
                ChangeHealth(1);
                collision.gameObject.SetActive(false);
            }
            else
            {
                collision.gameObject.SetActive(false);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthsystem : MonoBehaviour
{
    public int maxhealth;
    private float health;
    public Image healthbar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    public void ChangeHealth(int value)
    {
        health -= value;

        RenderHealth();
    }

    private void RenderHealth()
    {
        healthbar.fillAmount = (float)health / (float)maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

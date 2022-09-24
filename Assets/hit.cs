using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public int i;
    public bool ishit;
    public GameObject blue;
    // Start is called before the first frame update
    void Start()
    {
        blue.SetActive(false);
        
    }

    public void FixedUpdate()
    {
        if(ishit == true)
        {
            Debug.Log("hit");
            while (i <= 3)
            {
                blue.SetActive(true);
                i+=1;
            }
            blue.SetActive(false);
            i = 0;
            
        }
        ishit = false;
    }

    // Update is called once per frame
    public void Swing()
    {
        ishit = true;
        
    }
}

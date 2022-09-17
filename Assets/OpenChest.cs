using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
	public GameObject reward;
    // Start is called before the first frame update
    void Start()
    {
    	reward.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D Collision)
    {
    	if(Collision.name == "player")
    	{
    		reward.SetActive(true);
    	}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extendTime : MonoBehaviour
{
    public int timeBonus = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("timer").GetComponent<timer>().timeRemaining += timeBonus;
        }

        GameObject.Destroy(gameObject);
    }
}

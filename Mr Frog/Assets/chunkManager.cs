using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkManager : MonoBehaviour
{
    public List<GameObject> chunkList = new List<GameObject>();

    public int chunkSize = 20;

    // Start is called before the first frame update
    void Start()
    {     
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject chunk in chunkList)
        {
            if (chunk.GetComponentInChildren<chunkLogic>().readyToRandomise)
                Debug.Log(chunk.name + " just moved.");
        }   
    }
}

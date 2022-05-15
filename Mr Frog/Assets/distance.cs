using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class distance : MonoBehaviour
{
    public TMP_Text distanceDisplay;
    public double distanceTravelled;

    // Start is called before the first frame update
    void Start()
    {
        distanceDisplay.text = "Distance Travelled: " + distanceTravelled;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled = GameObject.FindGameObjectWithTag("Player").transform.position.z;
        
        distanceDisplay.text = String.Format("{0:0.00}km", distanceTravelled/1000);
    }
}

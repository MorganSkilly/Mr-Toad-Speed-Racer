using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNoise : MonoBehaviour
{
    public List<AudioClip> poopPoops;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waiter()
    {
        while (true)
        {
            AudioSource audio = GetComponent<AudioSource>();
            int wait_time = Random.Range(20, 50);
            yield return new WaitForSeconds(wait_time);

            audio.clip = poopPoops[Random.Range(0, poopPoops.Count)];
            audio.Play();
        }            
    }
}

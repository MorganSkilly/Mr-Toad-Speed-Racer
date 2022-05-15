using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWith : MonoBehaviour
{
    public bool moveControl = true;
    public GameObject moveWithObj;

    public AudioClip poop;

    private float lastPos;

    // Start is called before the first frame update
    void Start()
    {
        lastPos = moveWithObj.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {       

        if (moveControl)
        {
            if (transform.position.z < moveWithObj.transform.position.z - 15)
                transform.position = new Vector3(transform.position.x, transform.position.y, moveWithObj.transform.position.z - 15);

            lastPos = moveWithObj.transform.position.z;
        }

        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().PlayOneShot(poop);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "randomVehicle")
            Destroy(collision.gameObject);
    }
}

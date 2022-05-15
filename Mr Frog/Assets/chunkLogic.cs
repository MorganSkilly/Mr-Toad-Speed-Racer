using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkLogic : MonoBehaviour
{
    public GameObject parent;

    public bool readyToRandomise = false;

    public GameObject emptyChunk;
    public List<GameObject> chunkVariants;

    public List<GameObject> spawnableObjects;
    public List<GameObject> spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (readyToRandomise)
        {
            int rng = Random.Range(1, 11);

            if (rng%5 == 0)
            {
                rng = Random.Range(0, chunkVariants.Count);
                SetRandomChunk(rng);
            }
            else
            {
                foreach (GameObject chunk in chunkVariants)
                {
                    chunk.SetActive(false);
                }
                emptyChunk.SetActive(true);

                rng = Random.Range(1, 11);

                if (rng % 5 == 0)
                {
                    rng = Random.Range(0, spawnableObjects.Count);
                    Instantiate(spawnableObjects[rng], spawnPoints[Random.Range(0, spawnPoints.Count)].transform.position, spawnPoints[Random.Range(0, spawnPoints.Count)].transform.rotation, null);
                }
            }

            readyToRandomise = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 oldPos = parent.transform.position;
            parent.transform.position = new Vector3(oldPos.x, oldPos.y, oldPos.z + 200);
            readyToRandomise = true;
        }
    }

    private void SetRandomChunk(int id)
    {
        emptyChunk.SetActive(false);

        foreach (GameObject chunk in chunkVariants)
        {
            chunk.SetActive(false);
        }

        chunkVariants[id].SetActive(true);
    }
}

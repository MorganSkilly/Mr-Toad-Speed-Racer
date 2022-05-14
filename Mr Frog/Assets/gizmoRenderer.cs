using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmoRenderer : MonoBehaviour
{
    public Color gizmoColour = new Color(1, 1, 1, 0.2f);
    public Vector3 gizmoSize = new Vector3(20, 20, 20);

    public bool wireframe = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColour;
        if (wireframe)
            Gizmos.DrawWireCube(transform.position, gizmoSize);
        else
            Gizmos.DrawCube(transform.position, gizmoSize);
    }
}

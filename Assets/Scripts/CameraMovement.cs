using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPos;
    private float Speed = 1;
    private float maf = 200;
    // Start is called before the first frame update
    void Start()
    {
        CameraPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //move camera up
        if (Input.GetKey(KeyCode.W))
        {
            CameraPos.y += Speed / maf;
        }
        //move camera down
        if (Input.GetKey(KeyCode.S)) 
        {
            CameraPos.y -= Speed / maf;
        }
        //move camera left
        if (Input.GetKey(KeyCode.A))
        {
            CameraPos.z -= Speed / maf;
        }
        //move camera right
        if (Input.GetKey(KeyCode.D))
        {
            CameraPos.z += Speed / maf;
        }
        //move camera in
        if (Input.GetKey(KeyCode.F))
        {
            CameraPos.x -= Speed / maf;
        }
        //move camera out
        if (Input.GetKey(KeyCode.B))
        {
            CameraPos.x += Speed / maf;
        }
        this.transform.position = CameraPos;
    }
}

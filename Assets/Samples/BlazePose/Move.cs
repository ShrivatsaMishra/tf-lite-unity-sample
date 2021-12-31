using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedx = 0F;
    public float speedy = 0F;
    public float rotx = 0F;
    public float roty = 0F;
    public float rotz = 0F;
    public GameObject child;

    // Update is called once per frame
    void Update()
    {
        speedy -= 2*Time.deltaTime;
        transform.Translate(speedx*Time.deltaTime, speedy*Time.deltaTime, 0);
        child.transform.Rotate(rotx*Time.deltaTime, roty*Time.deltaTime, rotz*Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
        Destroy(gameObject);
    }
}

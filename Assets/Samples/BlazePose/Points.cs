using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int points=0;
    [SerializeField]
    public Text pointText;

    private void Start()
    {
        pointText.text = "0";
        points = 0;
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log("Boom");
        points++;
        pointText.text = ""+points;
    }
}

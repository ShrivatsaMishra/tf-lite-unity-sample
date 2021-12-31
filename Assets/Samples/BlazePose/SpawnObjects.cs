using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    private float time = 0.0f;
    public int mode=0;
    public float sx = -5;
    private float interpolationPeriod = 2f;
    [SerializeField]
    public GameObject banana;
    [SerializeField]
    public GameObject watermelon;
    [SerializeField]
    public GameObject orange;
    [SerializeField]
    public GameObject tomato;
 
    void Update () {
        time += Time.deltaTime;
        if(sx>=-10)
            sx-=Time.deltaTime/3;
 
        if (time >= interpolationPeriod && mode==0) {
            time = 0.0f;
            int x = Random.Range(0, 4);
            GameObject obj;
            switch(x) {
                case 0: obj = banana;
                        break;
                case 1: obj = orange;
                        break;
                case 2: obj = watermelon;
                        break;
                default: obj = tomato;
                        break;
            }
            obj = (GameObject)Instantiate(obj, transform.position, transform.rotation);
            Move mv = (Move)obj.GetComponent(typeof(Move));
            mv.speedx = sx;
            
            mv.speedy = Random.Range(2.0f, 5.0f);
            mv.rotz = Random.Range(100f, 300f);
            
        }
    }
}

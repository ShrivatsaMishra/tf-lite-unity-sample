using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    private int mode=0;
    [SerializeField]
    public SpawnObjects spawn;
    [SerializeField]
    public Points pnts;
    
    private void Start()
    {
        spawn.mode=1;
        mode=1;
        menu.SetActive(true);
    }

    public void openMenu() {
        if(mode==0) {
            mode=1;
            spawn.mode=1;
            menu.SetActive(true);
        }
        else {
            mode=0;
            spawn.mode=1;
            menu.SetActive(false);
        }        
    }

    public void restart() {
        pnts.points=0;
    }

    public void changePr() {
        SceneManager.LoadScene("Practice");
    }
    public void changeAlt() {
        SceneManager.LoadScene("Alternate");
    }
}

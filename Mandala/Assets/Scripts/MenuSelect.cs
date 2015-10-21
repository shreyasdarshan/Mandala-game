using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {

    bool isClicked=false;
    public GameObject menu;
    void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;
            Instantiate(menu);
        }
        else
        {
            isClicked = false;
            Destroy(menu);
        }        
    }

}

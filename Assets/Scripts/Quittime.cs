using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quittime : MonoBehaviour {

    private void OnMouseDown()
    {
        new WaitForSeconds(2f);
        Application.Quit();
    }


}

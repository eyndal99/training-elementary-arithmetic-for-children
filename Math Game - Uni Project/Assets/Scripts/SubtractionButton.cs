using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractionButton : MonoBehaviour
{

    private void OnMouseDown() {
        Claculator Temp = GameObject.Find("Claculator").GetComponent<Claculator>();
        Temp.Subractionfunction();
    }

}

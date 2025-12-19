using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionButton : MonoBehaviour
{
    private void OnMouseDown() {
        Claculator Temp = GameObject.Find("Claculator").GetComponent<Claculator>();
        Temp.Divisionfunction();
    }

}

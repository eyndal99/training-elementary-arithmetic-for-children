using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumButton : MonoBehaviour
{
    private void OnMouseDown() {
        Claculator Temp = GameObject.Find("Claculator").GetComponent<Claculator>();
        Temp.Sumfunction();
    }
}

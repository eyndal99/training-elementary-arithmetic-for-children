using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapesname1 : MonoBehaviour
{
    void update()
    {
    }
    private void OnMouseDown()
    {
        Shapes A = GameObject.Find("Shapes Background").GetComponent<Shapes>();
        A.Shapesname1_action();
        Debug.Log("sdsds");
    }
}

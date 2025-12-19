using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramover : MonoBehaviour
{
public void Cameramove()
{
    Claculator A = GameObject.Find("Claculator").GetComponent<Claculator>();
    A.Cameramoving(); 
}
}

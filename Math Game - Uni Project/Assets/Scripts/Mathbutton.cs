using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathbutton : MonoBehaviour
{

private void OnMouseDown()
{
 Menu A = GameObject.Find("Menu").GetComponent<Menu>();
 A.Math();
}
}

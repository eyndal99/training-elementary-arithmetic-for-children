using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
 private void OnMouseDown()
 {

       GameObject.Find("Main Camera").transform.position=new Vector3(-45f,1f,-10f); 
       Claculator A =GameObject.Find("Claculator").GetComponent<Claculator>();
       A.Canvas.SetActive(false);
       Shapes B = GameObject.Find("Shapes Background").GetComponent<Shapes>();
       B.Canvas.SetActive(false);
}
}
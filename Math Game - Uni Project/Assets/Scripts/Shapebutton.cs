using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapebutton : MonoBehaviour
{
private void OnMouseDown()
{
    GameObject.Find("Main Camera").transform.position=new Vector3(-22.3f,1f,-10f);
     Shapes B = GameObject.Find("Shapes Background").GetComponent<Shapes>();
       B.Canvas.SetActive(true);
}
}

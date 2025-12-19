using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ACTION1 : MonoBehaviour
{
    //  void OnMouseDown(){
    //     Shapes temp = GameObject.Find("Shapes Background").GetComponent<Shapes>();
    //     temp.Shapesname1_action();
    // }
    
         void Start() {
            if(Input.GetMouseButtonDown(0)) //sum
       {
        Shapes temp = GameObject.Find("Shapes Background").GetComponent<Shapes>();
        temp.Shapesname1_action();
       }
         }
}

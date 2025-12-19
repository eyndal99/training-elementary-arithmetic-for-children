using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator Anim;
    public GameObject Canvasmenu;
    void Update()
    {

    }
    public void Math()
    {
    GameObject.Find("Main Camera").transform.position=new Vector3(0f,1f,-10f);
    Anim = GameObject.Find("Math Background").GetComponent<Animator>();
    Anim.Play("Entry");
    }
    public void Shapes()
    {
         GameObject.Find("Main Camera").transform.position=new Vector3(-24f,1f,-10f);
    }
}


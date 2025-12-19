using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shapes : MonoBehaviour
{
    int r ,n ,h ;
    string answer,rightanswer,answer1 = "Circle",answer2 = "Rectangle",rdm , Kind; 
    public Texture Circle,Rectangle,Triangle,Fivesides,Sixsides;
    public Text Shapesname1,Shapesname2,Shapesname3;
    public GameObject Canvas , box1,box2,box3;
    public Sprite Correct,Incorrect,None;


    void Start ()
    {
       // Final("Fivesides");
    }
    void Update()
    { 
         if(Input.GetKeyDown(KeyCode.C)) //sum
       {
        Final("Circle");
       }
        if(Input.GetKeyDown(KeyCode.R)) //subtraction
       {
        Final("Rectangle");
       }
        if(Input.GetKeyDown(KeyCode.T)) //Division
       {
        Final("Triangle");
       }
        if(Input.GetKeyDown(KeyCode.F)) //Multiplication
       {
        Final("Fivesides");
       }
               if(Input.GetKeyDown(KeyCode.S)) //Multiplication
       {
        Final("Sixsides");
       }
    }

    public void begin()
    {
        r = Random.Range(1,5);
        if(r==1){Final("Circle"); Kind ="Circle"; }
        if(r==2){Final("Rectangle"); Kind ="Rectangle";}
        if(r==3){Final("Triangle"); Kind ="Triangle";}
        if(r==4){Final("Fivesides"); Kind ="Fivesides";}
        if(r==5){Final("Sixsides"); Kind ="Sixsides";}
    }

    public void Rdm()
    {
           h = Random.Range(1,5);
        if(h==1){rdm="Circle"; }
        if(h==2){rdm="Rectangle"; }
        if(h==3){rdm="Triangle"; }
        if(h==4){rdm="Fivesides"; } 
        if(h==5){rdm="Sixsides"; }
    }
    void Setboxnames()
    {
        while(answer1==rightanswer)
        {
            Rdm();
            answer1=rdm;
        }
                while((answer2==rightanswer) && (answer1==answer2))
        {
            Rdm();
            answer2=rdm;
        }
        //
        n = Random.Range(1,6);
        if(n==1){Shapesname1.text=rightanswer; /**/ Shapesname2.text=answer1; /**/ Shapesname3.text=answer2; }
        if(n==2){Shapesname1.text=rightanswer; /**/ Shapesname2.text=answer2; /**/ Shapesname3.text=answer1; }
        if(n==3){Shapesname1.text=answer1; /**/ Shapesname2.text=rightanswer; /**/ Shapesname3.text=answer2; }
        if(n==4){Shapesname1.text=answer1; /**/ Shapesname2.text=answer2; /**/ Shapesname3.text=rightanswer; }
        if(n==5){Shapesname1.text=answer2; /**/ Shapesname2.text=answer1; /**/ Shapesname3.text=rightanswer; }
        if(n==6){Shapesname1.text=answer2; /**/ Shapesname2.text=rightanswer; /**/ Shapesname3.text=answer1; }
        //
    }
    IEnumerator Refreshpage()
     {
        yield return new WaitForSeconds(3);
       // Final(Kind);

        }
        public void True()
        {

        }
        public void Shapesname1_action()
        {
            if(Shapesname1.text == rightanswer){box1.GetComponent<Image>().sprite = Correct;True();}
        }
         public void Shapesname2_action()
        {
            if(Shapesname1.text == rightanswer){box2.GetComponent<Image>().sprite = Correct;True();}
        }
         public void Shapesname3_action()
        {
            if(Shapesname1.text == rightanswer){box3.GetComponent<Image>().sprite = Correct;True();}
        }
        public void Final(string R)
        {
       if(R=="Circle"){ GameObject.Find("Shapes").GetComponent<Renderer>().material.mainTexture = Circle ; Debug.Log("circle"); answer="circle"; rightanswer="Circle"; }
       if(R=="Rectangle"){ GameObject.Find("Shapes").GetComponent<Renderer>().material.mainTexture = Rectangle ; Debug.Log("Rectangle"); answer="Rectangle"; rightanswer="Rectangle";}
       if(R=="Triangle"){ GameObject.Find("Shapes").GetComponent<Renderer>().material.mainTexture = Triangle ; Debug.Log("Triangle"); answer="Triangle"; rightanswer="Triangle";}
       if(R=="Fivesides"){ GameObject.Find("Shapes").GetComponent<Renderer>().material.mainTexture = Fivesides ; Debug.Log("Fivesides"); answer="Fivesides"; rightanswer="Fivesides";}
       if(R=="Sixsides"){ GameObject.Find("Shapes").GetComponent<Renderer>().material.mainTexture = Sixsides ; Debug.Log("Sixsides"); answer="Sixsides"; rightanswer="Sixsides";}
       
       Setboxnames();
        }
        

    

}

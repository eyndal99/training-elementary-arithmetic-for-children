using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clacuator : MonoBehaviour
{
    int Firstnum,Secondnum,temp,Equal,answer1,answer2,Rdmanswer,pointt=0;
    public Text num1,num2,sign,box1,box2,box3,questionnum,Point;
    public Animator MBAnimator; //MB : Math Background
    public Texture Sumbackground , Suionbackground , Divisionbackground , Multiplicationbackground,Subtractionbackground;
    public Sprite Correct,Incorrect,None;
    public string Backname;
    private string signs;
    public GameObject Canvas,Box1_image,Box2_image,Box3_image;
    void Start()
    {
        Canvas.SetActive(false);
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.P)) //sum
       {
        Claculation("Sum");
       }
        if(Input.GetKeyDown(KeyCode.S)) //subtraction
       {
        Claculation("Sub");
       }
        if(Input.GetKeyDown(KeyCode.D)) //Division
       {
        Claculation("Div");
       }
        if(Input.GetKeyDown(KeyCode.M)) //Multiplication
       {
        Claculation("Mul");
       }
    }

    public void Sumfunction()
    {
        Backname = "Sum";
        Exitbuttons();
        

    }
     public void Subractionfunction()
    {
        Backname = "Subraction";
        Exitbuttons();
 
    }
     public void Multiplicationfunction()
    {
        Backname = "Multiplication";
        Exitbuttons();
;
    }
     public void Divisionfunction()
    {
        Backname = "Dvision";
        Exitbuttons();

    }
    //cahenge math scene//
    public void Exitbuttons()
    {
        MBAnimator = GameObject.Find("Math Background").GetComponent<Animator>();
        MBAnimator.Play("Exit");
        
    }
    //////////////////////////
    public void Cameramoving()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(17.88f,1f,-10f);
        //changing background image.
        if (Backname == "Sum") {                  Claculation("Sum");                GameObject.Find("Operations Scene").GetComponent<Renderer>().material.mainTexture = Sumbackground;}
        if (Backname == "Subraction") {           Claculation("Sub");                GameObject.Find("Operations Scene").GetComponent<Renderer>().material.mainTexture = Subtractionbackground;}
        if (Backname == "Multiplication") {       Claculation("Mul");                GameObject.Find("Operations Scene").GetComponent<Renderer>().material.mainTexture = Multiplicationbackground;}
        if (Backname == "Division") {             Claculation("Div");                GameObject.Find("Operations Scene").GetComponent<Renderer>().material.mainTexture = Divisionbackground;}
        Canvas.SetActive(true);
    }

    public void Returnhome()
    {
         GameObject.Find("Main Camera").transform.position = new Vector3(0f,1f,-10f);
         MBAnimator = GameObject.Find("Math Background").GetComponent<Animator>();
        MBAnimator.Play("Entry");
        Canvas.SetActive(false);
        Point.text = "0";
        
    }
    //box icons
    
    public void box1_action()
    {
        if(box1.text == Equal.ToString())
        {
        Box1_image.GetComponent<Image>().sprite = Correct;
        True();
        
        }
            else
            {
        Box1_image.GetComponent<Image>().sprite = Incorrect;
        False();
            }
    }
        public void box2_action()
    {
        if(box2.text == Equal.ToString())
        {
        Box2_image.GetComponent<Image>().sprite = Correct; 
        True();
        }
            else
            {
        Box2_image.GetComponent<Image>().sprite = Incorrect;
        False();  
            }
    }
        public void box3_action()
    {
        if(box3.text == Equal.ToString())
        {
        Box3_image.GetComponent<Image>().sprite = Correct; 
        True();
        }
            else
            {
        Box3_image.GetComponent<Image>().sprite = Incorrect;
        False(); 
            }   
    }
     //reset boximage
     public void Reset()
     {
        Box1_image.GetComponent<Image>().sprite = None;
        Box2_image.GetComponent<Image>().sprite = None;
        Box3_image.GetComponent<Image>().sprite = None;
        questionnum.text = "?";
     }

     public void False()
     {
        pointt = pointt-1;
        Point.text = pointt.ToString();
        questionnum.text = Equal.ToString();
        questionnum.color = Color.red;
        StartCoroutine(Refreshpage());
     }

     public void True()
     {
        questionnum.text = Equal.ToString();
        pointt = pointt+1;
        Point.text = pointt.ToString();
        StartCoroutine(Refreshpage());
        
        
     }

     IEnumerator Refreshpage()
     {
        yield return new WaitForSeconds(3);
        Claculation(signs);
        questionnum.color = Color.white;
  
     }
     public void Numsrange()
     {
         if(Equal<=10)
        {
        Rdmanswer=Random.Range(2,10);
        while(Rdmanswer==Equal)
        {
            Rdmanswer=Random.Range(2,10);
        }
        answer1=Rdmanswer;
        //
        Rdmanswer=Random.Range(2,10);
        while((Rdmanswer==Equal) || (Rdmanswer==answer1))
        {
            Rdmanswer=Random.Range(2,10);
        }
        answer2=Rdmanswer;
        }
        // Equal>10 && Equal<=50
        if(Equal>10 && Equal<=50)
        {
        Rdmanswer=Random.Range(10,50);
        while(Rdmanswer==Equal)
        {
            Rdmanswer=Random.Range(10,50);
        }
        answer1=Rdmanswer;
        //
        Rdmanswer=Random.Range(10,50);
        while((Rdmanswer==Equal) || (Rdmanswer==answer1))
        {
            Rdmanswer=Random.Range(10,50);
        }
        answer2=Rdmanswer;
        }
        // equal > 50
         if(Equal>50)
        {
        Rdmanswer=Random.Range(50,99);
        while(Rdmanswer==Equal)
        {
            Rdmanswer=Random.Range(50,99);
        }
        answer1=Rdmanswer;
        //
        Rdmanswer=Random.Range(50,99);
        while((Rdmanswer==Equal) || (Rdmanswer==answer1))
        {
            Rdmanswer=Random.Range(50,99);
        }
        answer2=Rdmanswer;
        }
     }
     ////////////////////////////////////////////////////////
     public void Boxnaums()
     {
        temp = Random.Range(1,6);
        if(temp==1)
        {
            box1.text = answer1.ToString(); /**/ box2.text =answer2.ToString(); /**/ box3.text = Equal.ToString(); 
        }
         if(temp==2)
        {
            box1.text = answer1.ToString(); /**/ box2.text =Equal.ToString(); /**/ box3.text = answer2.ToString(); 
        }
         if(temp==3)
        {
            box1.text = answer2.ToString(); /**/ box2.text =answer1.ToString(); /**/ box3.text = Equal.ToString(); 
        }
        if(temp==4)
        {
            box1.text = answer2.ToString(); /**/ box2.text =Equal.ToString(); /**/ box3.text = answer1.ToString(); 
        }
        if(temp==5)
        {
            box1.text = Equal.ToString(); /**/ box2.text =answer1.ToString(); /**/ box3.text = answer2.ToString(); 
        }
        if(temp==6)
        {
            box1.text = Equal.ToString(); /**/ box2.text =answer2.ToString(); /**/ box3.text = answer1.ToString(); 
        }
     }
     
    public void Claculation(string Draw)
    {
        Reset();
        Firstnum = Random.Range(1,10);
        Secondnum = Random.Range(1,10);

        if(Firstnum-Secondnum<0)
        {
            temp = Firstnum;
            Firstnum = Secondnum;
            Secondnum=temp;
        }
        if(Draw=="Sum")
        {
            Equal = Firstnum+Secondnum;
            signs = "Sum";
        }
        if(Draw=="Sub")
        {
            Equal = Firstnum-Secondnum; 
            signs = "Sub";
        }
        if(Draw=="Div")
        {
            while(Firstnum % Secondnum !=0)
            {
            Firstnum = Random.Range(2,99);
            Secondnum = Random.Range(2,99);
            }
 
            Equal = Firstnum/Secondnum;
            signs = "Div";
  
        }
        if(Draw=="Mul")
        {
            Equal = Firstnum*Secondnum; 
            signs = "Mul";
        }

        Debug.Log("First Num : "+Firstnum+" Second Num : "+Secondnum+" Final : "+Equal);
        
        num1.text = Firstnum.ToString();
        num2.text = Secondnum.ToString();

        if(signs == "Sum")
        {
            sign.text = "+";
        }
                if(signs == "Sub")
        {
            sign.text = "-";
        }
                if(signs == "Div")
        {
            sign.text = "÷";
        }
                if(signs == "Mul")
        {
            sign.text = "×";
        }

        //answers
        Numsrange();
        //box nums
        Boxnaums();    
    }
  
}

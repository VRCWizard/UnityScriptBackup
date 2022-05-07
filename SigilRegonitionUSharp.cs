
using UdonSharp;
using UnityEngine;
//using UnityEngine.UI; 
using VRC.SDKBase;
using VRC.Udon;

public class SigilRegonitionUSharp : UdonSharpBehaviour
{
        Vector3 lastPos; 
          [SerializeField] //Drag the object into this field on the inspector
        private UnityEngine.UI.Text Text;

        [SerializeField]
        private UnityEngine.UI.Text Spellname;

       //Drag the object into this field on the inspector
     //  [SerializeField] 
       // private Text Spellname;

        [SerializeField]  //Drag the object into this field on the inspector
        private TrailRenderer tr;

        [SerializeField]  //Drag the object into this field on the inspector
        private GameObject trailObject;

        [SerializeField]
         private Rigidbody test;
       

       // [SerializeField]
       // private RigidBody myRigidbody;
     
    // Transform obj; // drag the object to monitor here 
     
     public float threshold = 0.3f; // minimum displacement to recognize.
     public float straightline = 0.03f; // minimum displacement to recognize.
     int left = 0;
     int right = 0;
     int up = 0;
     float localUpVelocity;
     float localLeftVelocity;
      float localDownVelocity;
     float localRightVelocity;
     string SpellID="";
     bool Casting = false;

     //Vector3 pleasework = (45,0,0);
     
     int down = 0;
     //bool activated = false;
     
     void Start(){ 

            //or get the reference while the script is awaken
       // Text = transform.Find("Text").GetComponent<Text>();
       
         lastPos = transform.localPosition; 
         
         
         
         }
        

    void OnPickupUseUp(){
       
        Casting = false;
        trailObject.transform.parent = null;
        if(SpellID=="472")
        {
           SpellID="";
          
          Spellname.text = "FireBall";
           Spellname.color = Color.red;

        }
         if(SpellID=="2424")
        {
           SpellID="";
          Spellname.text = "MagicMirror";
          Spellname.color = Color.grey;

        }
         if(SpellID=="3571")
        {
           SpellID="";
          Spellname.text = "Shield";
           Spellname.color = Color.blue;

        }
         if(SpellID=="471")
        {
           SpellID="";
          Spellname.text = "Fly";
          Spellname.color = Color.white;

        }
          if(SpellID=="464")
        {
           SpellID="";
          Spellname.text = "Lightning";
          Spellname.color = Color.yellow;

        } 

     if(SpellID=="531")
        {
           SpellID="";
          Spellname.text = "OverGrow";
          Spellname.color = Color.green;

        }
         if(SpellID=="4682")
        {
           SpellID="";
          Spellname.text = "Summon";
          Spellname.color = Color.magenta;

        }
        
         Casting = false;
        // SpellID="";
        // SetText("Reset "+SpellID);
       //  tr.time=5;

    }
    void OnPickupUseDown(){
   // if (activated == false)
   // {
    
    
         SpellID="";
       SetText("Reset "+SpellID);
        Spellname.text = "";
        
        

     tr.Clear();
     trailObject.transform.position= transform.position;
     tr.Clear();
     trailObject.transform.parent = transform;
      tr.Clear();
     
        tr.time = 100;
        Casting = true;



    }
  
     
     void Update()
     { 
           Vector3 up = transform.up;
          Vector3  forward = transform.forward;

          Vector3 UpLeft = (up+forward).normalized;
         Vector3 UpRight = (up-forward).normalized;

     //   Vector3 eulerRotation = transform.rotation.eulerAngles;     
      //  transform.rotation = Quaternion.Euler(0, eulerRotation.y, eulerRotation.z);




            Vector3 offset = transform.localPosition - lastPos; 

            test = GetComponent<Rigidbody>();


            localUpVelocity = Vector3.Dot(test.velocity, transform.up);
            localLeftVelocity = Vector3.Dot(test.velocity, transform.forward);
            


            // add up to left and see if it is .80 faster


        //    if(Vector3.Dot(transform.right,offset) > threshold ){ 
          //      lastPos = transform.localPosition; 
          //      SetText("Moved Forward");
           //     Text.color = Color.red;
          //  } 
         // if (activated == false)
         // {
           if(Casting == true)
           {

           
            if ((Vector3.Dot(up,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                 SpellID+="1";
                SetText("North "+SpellID);
                Text.color = Color.green;
              //  activated = true;
             
             } 
                 if ((Vector3.Dot(-up,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="5";
                SetText("South "+SpellID);
                Text.color = Color.black;
                 
                
             } 

                    if ((Vector3.Dot(UpLeft ,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                 SpellID+="8";
                SetText("NW "+SpellID);
                Text.color = Color.green;
              //  activated = true;
              
             } 
                   if ((Vector3.Dot(UpRight ,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="2";
                SetText("NE "+SpellID);
                Text.color = Color.green;
                
              //  activated = true;
             } 
       



 
            if((Vector3.Dot(forward,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="7";
                SetText("West "+SpellID);
                Text.color = Color.blue;
                 
            } 

             if((Vector3.Dot(-forward,offset) > threshold)){ 
                lastPos = transform.localPosition; 
                  SpellID+="3";
                SetText("East "+SpellID);
                Text.color = Color.grey;
              
            } 

              if((Vector3.Dot(-UpRight,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="6";
                SetText("SW "+SpellID);
                Text.color = Color.blue;
                
            } 

             if((Vector3.Dot(-UpLeft,offset) > threshold)){ 
                lastPos = transform.localPosition; 
                 SpellID+="4";
                SetText("SE "+SpellID);
                Text.color = Color.grey;
                
            } 
           }

            //Quaternion.Euler(45,0,0) instead of please work


            
         // }
        
           // else if (offset.x < -threshold)
            //{ 
           // lastPos = transform.localPosition; 
            
           // } 
     } 


        public void SetText(string str)
        {
            Text.text = str;
        }






}

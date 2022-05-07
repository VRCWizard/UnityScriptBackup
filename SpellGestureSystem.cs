
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SpellGestureSystem : UdonSharpBehaviour
{
      Vector3 lastPos; 
          [SerializeField] //Drag the object into this field on the inspector
        private UnityEngine.UI.Text Text;

        [SerializeField]
        private UnityEngine.UI.Text Spellname;


        [SerializeField]  //Drag the object into this field on the inspector
        private TrailRenderer tr;

        [SerializeField]  //Drag the object into this field on the inspector
        private GameObject trailObject;



         [SerializeField] 
         private ParticleSystem MagicMissile;



         [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem FairyDust;

        [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem ElBlast;

        [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem Tent;


          [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem Arrow;

          [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem Portal;
          [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem Tornado;
          [SerializeField]  //Drag the object into this field on the inspector
        private ParticleSystem Chains;

         [SerializeField] 
    private GameObject mirror;

  
     
     public float threshold = 0.2f; // minimum displacement to recognize.

     float localUpVelocity;
     float localLeftVelocity;
      float localDownVelocity;
     float localRightVelocity;
     string SpellID="";
     bool Casting = false;

     
     void Start(){ 

         lastPos = transform.localPosition; 

         
         }
        

    void OnPickupUseUp(){
       
        Casting = false;
        trailObject.transform.parent = null;
        if(SpellID=="111333")
        {
           SpellID="";
          
          Spellname.text = "Magic Missile";
           Spellname.color = Color.blue;

           //MagicMissile.SetActive(true);
           MagicMissile.Play();
          // MagicMissile.Play();

           


        }
         if(SpellID=="444222")
        {
           SpellID="";
          
          Spellname.text = "Eldritch Blast";
           Spellname.color = Color.black;

           //ElBlast.SetActive(true);
           ElBlast.Play();

          // Fireball.Play();

           


        }
         if(SpellID=="4242")
        {
           SpellID="";
          
          Spellname.text = "Fairy Aura";
           Spellname.color = Color.magenta;

           // FairyDust.SetActive(true);
            FairyDust.Play();

           


        }
          if(SpellID=="13243142")
        {
           SpellID="";
          
          Spellname.text = "Storm Tentacles";
           Spellname.color = Color.blue;

          //  Tent.SetActive(true);
          Tent.Play();

           


        }
         if(SpellID=="4444"){
           SpellID="";
          Spellname.text = "Magic Arrow";
           Spellname.color = Color.blue;
            Arrow.Play();
        }
         if(SpellID=="23412341"){
           SpellID="";
          Spellname.text = "Portal";
           Spellname.color = Color.yellow;
            Portal.Play();
        }
         if(SpellID=="23411432"){
           SpellID="";
          Spellname.text = "Death Chains";
           Spellname.color = Color.black;
            Chains.Play();
        }
         if(SpellID=="3212321"){
           SpellID="";
          Spellname.text = "Tornado";
           Spellname.color = Color.grey;
            Tornado.Play();
        }


          if(SpellID=="123123"){
           SpellID="";
          Spellname.text = "Magic Mirror";
           Spellname.color = Color.grey;
           mirror.SetActive(!mirror.activeSelf);


            
        }

         Casting = false;


    }
      void TurnOffAll(){
           // FairyDust.SetActive(false);
           // ElBlast.SetActive(false);
           // MagicMissile.SetActive(false);
            // Tent.SetActive(false);
           // Arrow.SetActive(false);
              FairyDust.Stop();
            ElBlast.Stop();
            MagicMissile.Stop();
             Tent.Stop();
            Arrow.Stop();
            Portal.Stop();
            Chains.Stop();
            Tornado.Stop();

      }
 




    void OnPickupUseDown(){
 
    
    
         SpellID="";
       SetText("Reset "+SpellID);
        Spellname.text = "";
        
        

     tr.Clear();
     trailObject.transform.position= transform.position;
     tr.Clear();
     trailObject.transform.parent = transform;
      tr.Clear();
     
        tr.time = 100;



         lastPos = transform.localPosition; //I wish i throught of this sooner (THIS IS VERY IMPORTANT TO SET)

        Casting = true;

         TurnOffAll();



    }
  
     
     void Update()
     { 
  

           if(Casting == true)
           {
            Vector3 up = transform.up;
            Vector3  forward = transform.forward;
                Vector3 UpLeft = (up+forward).normalized;
             Vector3 UpRight = (up-forward).normalized;
               Vector3 offset = transform.localPosition - lastPos; 

           
            if ((Vector3.Dot(up,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                 SpellID+="1";
                SetText("North "+SpellID);
                Text.color = Color.green;
            
             
             } 
                 if ((Vector3.Dot(-up,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="3";
                SetText("South "+SpellID);
                Text.color = Color.black;
                 
                
             } 

 
            if((Vector3.Dot(forward,offset) > threshold) ){ 
                lastPos = transform.localPosition; 
                SpellID+="4";
                SetText("West "+SpellID);
                Text.color = Color.blue;
                 
            } 

             if((Vector3.Dot(-forward,offset) > threshold)){ 
                lastPos = transform.localPosition; 
                  SpellID+="2";
                SetText("East "+SpellID);
                Text.color = Color.grey;
              
            } 

             

         
           }

     } 


        public void SetText(string str)
        {
            Text.text = str;
        }

}

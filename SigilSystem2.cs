
using UdonSharp;
using UnityEngine;
using UnityEngine.UI; 
using VRC.SDKBase;
using VRC.Udon;

public class SigilSystem2 : UdonSharpBehaviour
{

    [SerializeField]  //Drag the object into this field on the inspector
    private Text Text;
   // [SerializeField]  //Drag the object into this field on the inspector
    //    private TrailRenderer tr;


        [SerializeField] 
    private GameObject MatrixColliders;

     VRCPlayerApi player;


//bool Casting = false;
string CurrentSpell= "ID:";

    void Start()
    {
        player = Networking.LocalPlayer;
        
    }
    
   
    



      public void SetText(string str)
        {
            Text.text = str;
        }
       void OnTriggerEnter(Collider other) {
        // if (other.gameObject.name == "Spell Matrix 1" &&Casting=true) {
         if (other.gameObject.name == "Spell Matrix 1" ) {
            // CurrentSpell +="1";

             //SetText(CurrentSpell);
             Text.text += "1";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 2" ) {
             // CurrentSpell +="2";

            // SetText(CurrentSpell);
            Text.text += "2";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 3" ) {
            //  CurrentSpell +="3";

             //SetText(CurrentSpell);
             Text.text += "3";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 4" ) {
            //  CurrentSpell +="4";

           //  SetText(CurrentSpell);
           Text.text += "4";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 5" ) {
            //  CurrentSpell +="5";

            // SetText(CurrentSpell);
            Text.text += "5";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 6" ) {
            //  CurrentSpell +="6";

            // SetText(CurrentSpell);
            Text.text += "6";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 7" ) {
            //  CurrentSpell +="7";

            // SetText(CurrentSpell);
            Text.text += "7";
             
             
         }
          if (other.gameObject.name == "Spell Matrix 8" ) {
             // CurrentSpell +="8";

           //  SetText(CurrentSpell);
           Text.text += "8";
             
         }
          if (other.gameObject.name == "Spell Matrix 9" ) {
            //  CurrentSpell +="9";

            // SetText(CurrentSpell);
            Text.text += "9";
             
             
         }
          
     }
      void Update()
    {
        
       
        MatrixColliders.transform.position = player.GetBonePosition(HumanBodyBones.LeftHand);
        MatrixColliders.transform.rotation = player.GetBoneRotation(HumanBodyBones.LeftHand);
        //MatrixColliders.transform.rotation = player.GetRotation();
       
     
         // transform.position = player.GetPosition();
    }
}

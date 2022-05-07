
using UdonSharp;
using UnityEngine;
using UnityEngine.UI; 
using VRC.SDKBase;
using VRC.Udon;

public class SpellFinisher : UdonSharpBehaviour
{

      [SerializeField]  //Drag the object into this field on the inspector
        private Text Text;

        [SerializeField]  //Drag the object into this field on the inspector
        private TrailRenderer tr;
    void Start()
    {
        
    }
      public void SetText(string str)
        {
            Text.text = str;
        }
     void OnPickupUseUp(){
        tr.time=0;
      //  Casting = false;
      
          //  CurrentSpell ="ID:";

        
        

    }
    void OnPickupUseDown(){
   
        tr.time=100;
         SetText("ID:");
       // Casting = true;

    }



}

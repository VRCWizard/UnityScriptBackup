
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ImmersiveButtonRemake : UdonSharpBehaviour
{
    [SerializeField] 
    private GameObject toggle;
  

    [SerializeField] 
    private AudioSource audioData1;
    [SerializeField] 
    private AudioSource audioData2;
   

 


    void Start()
    {
  
        
    }
   
    void OnCollisionEnter(Collision col)
    {
      
       if(col.gameObject.name == "BackButton")
       {
          //Debug.Log("Collsion Detected");
           
              audioData1.Play();
    

       }
       
        

     

    }
 
    void OnCollisionExit (Collision col)
    {
           if(col.gameObject.name == "BackButton")
       {
           //Debug.Log("Collsion Detected");
           toggle.SetActive(!toggle.activeSelf);
           audioData2.Play();
       
     

       }

    }


    
}

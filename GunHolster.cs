
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GunHolster : UdonSharpBehaviour
{
      [SerializeField] 
   private GameObject holsterObject;
   public float offsetXPos = 0f;
   public float offsetYPos = 0f;
   public float offsetZPos = 0f;
   public float offsetXRotation = 0f;
   public float offsetYRotation = 0f;
   public float offsetZRotation = 0f;

   bool beingHeld = false;

    void Start()
    {

        
    }
   void OnPickup(){
       beingHeld =true;
    }
    void OnDrop(){
        beingHeld =false;
    }
     void Update()
  {
    if (beingHeld ==false)
    {
     transform.position = new Vector3(holsterObject.transform.position.x +offsetXPos,holsterObject.transform.position.y+offsetYPos,holsterObject.transform.position.z+offsetZPos);
     var temp = holsterObject.transform.rotation.eulerAngles;
     temp.x += offsetXRotation;
     temp.y += offsetYRotation;
     temp.z += offsetZRotation;
    transform.rotation = Quaternion.Euler(temp);
    }
     

  }
}

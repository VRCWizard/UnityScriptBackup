
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayerHandColliders : UdonSharpBehaviour
{
    VRCPlayerApi player;
   [SerializeField] 
private GameObject rightHandy;
   // private Rigidbody rightHandy;



   [SerializeField] 
    private GameObject leftHandy;


    [SerializeField] 
    private GameObject MagicSpawn;
  // [SerializeField] 
    //private GameObject rightHandy;
   // private Rigidbody leftHandy;

    


    void Start()
    {
        player = Networking.LocalPlayer;
  
        //Fetch the Rigidbody from the GameObject with this script attached
      //  leftHandy = GetComponent<Rigidbody>();
      //  rightHandy = GetComponent<Rigidbody>();
   
        
    }

   
 
 //void FixedUpdate()
 //  {
        //Store user input as a movement vector
      //  Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
    //    rightHandy.MovePosition(player.GetBonePosition(HumanBodyBones.RightIndexDistal));
    //    leftHandy.MovePosition(player.GetBonePosition(HumanBodyBones.LeftIndexDistal));
   // }



    void Update()
  {
       // rightHandy.MovePosition(player.GetBonePosition(HumanBodyBones.RightIndexDistal));
      //  leftHandy.MovePosition(player.GetBonePosition(HumanBodyBones.LeftIndexDistal));


        rightHandy.transform.position = player.GetBonePosition(HumanBodyBones.RightIndexDistal);
        leftHandy.transform.position = player.GetBonePosition(HumanBodyBones.LeftIndexDistal);


        MagicSpawn.transform.position = player.GetPosition();
        MagicSpawn.transform.rotation = player.GetRotation();
        
       
       // player = Networking.LocalPlayer;
        //player = Networking.GetOwner();
        //HumanBodyBones head = HumanBodyBones.Head;
      //  rightHandy.transform.position = player.GetBonePosition(HumanBodyBones.RightIndexDistal);
       // leftHandy.transform.position = player.GetBonePosition(HumanBodyBones.LeftIndexDistal);
      // transform.position = player.GetBonePosition(HumanBodyBones.Head);
         // transform.position = player.GetPosition();
    }
}

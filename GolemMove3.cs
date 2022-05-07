
using UdonSharp;

using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class GolemMove3 : UdonSharpBehaviour
{
    
     public float speed = 1.0f;
     public int damping= 2;
 [SerializeField] 
     private Transform target;
      



    void Start()
    {
        
    }

    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if(dist > 2)
        {
            float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }
        

       // transform.LookAt(new Vector3(target.position.x, target.position.y, transform.position.z));
        var lookPos = target.position - transform.position;
   lookPos.y = 0;
   var rotation = Quaternion.LookRotation(-lookPos);
   transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping); 
      
    }
}
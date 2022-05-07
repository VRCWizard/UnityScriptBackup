
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MoveSideSideUSharp : UdonSharpBehaviour
{
    public float speed = 2.5f;
    float startZ;
    public float distance = 5;
    public float offset = 0f;
    float addZ;

    void Start()
    {
        startZ = transform.position.z + offset;
    }

    void Update()
    {
        addZ = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, transform.position.y, startZ + addZ);
    }
}

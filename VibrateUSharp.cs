
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class VibrateUSharp : UdonSharpBehaviour
{
    public float speed = .5f;
    float startY;
    public float distance = .1f;
    public float offset = 0f;
    float addY;

    void Start()
    {
        startY = transform.position.y + offset;
    }

    void Update()
    {
        addY = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, startY + addY, transform.position.z);
    }
}

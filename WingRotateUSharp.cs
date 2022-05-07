
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WingRotateUSharp : UdonSharpBehaviour
{
    public float speed = 20f;
    public float maxRotation = 10f;


    void Update()
    {

        transform.localEulerAngles = new Vector3(0, 0, maxRotation * Mathf.Sin(Time.time * speed));
    }
}

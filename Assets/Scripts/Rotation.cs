using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public Transform PRoot;

    private Vector3 prevMousePos;

    [SerializeField] private float speed;
    [SerializeField] private float mouseSpeed;



    void Update()
    {
        /*var deltaPos = Input.mousePosition - prevMousePos;
        var deltaRotation = new Vector3(-deltaPos.y, deltaPos.x) * Time.deltaTime * mouseSpeed;
        var rotation = PRoot.eulerAngles + deltaRotation;*/
        var deltaPos = Input.mousePosition - prevMousePos;
        var deltaRotation = new Vector3(0, deltaPos.x) * Time.deltaTime * mouseSpeed;
        var rotation = PRoot.eulerAngles + deltaRotation;

        PRoot.eulerAngles = new Vector3(Mathf.Clamp(rotation.x, 0f, 90f), rotation.y);
        prevMousePos = Input.mousePosition; 
    }
}

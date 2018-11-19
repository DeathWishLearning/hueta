using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public enum RotationAxes
    {
        MouseXAndY=0,
        MouseX=1,
        MouseY=2
    }

    public RotationAxes axes=RotationAxes.MouseXAndY;

    public float SensativityHor = 4.0f;
    public float SensativityVer = 4.0f;
    /*
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;
    */
    void Update ()
    {
		if (axes==RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X")*SensativityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
           /* _rotationX -= Input.GetAxis("MouseY") * SensativityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            */
        }
        else
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RobotRotation : MonoBehaviour
{
    [SerializeField] private InputAction mouseIsPressed, mouseAxis;
    [SerializeField] private float speed = 1f;
    private bool rotateAllowed;
    private Vector2 rotation;

    private void Awake()
    {
        mouseIsPressed.Enable();
        mouseAxis.Enable();
        mouseIsPressed.performed += _ =>
        {
            StartCoroutine(Rotate());
        };
        mouseIsPressed.canceled += _ => {rotateAllowed = false;};
        mouseAxis.performed += context => {rotation = context.ReadValue<Vector2>();};
    }

    private IEnumerator Rotate()
    {
        rotateAllowed = true;
        while (rotateAllowed)
        {
            //apply rotation
            rotation *= speed;
            transform.Rotate(-Vector3.up, rotation.x, Space.World);
            yield return null;
        }
    }
}

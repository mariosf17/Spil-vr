using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimationController : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty grabAnimation;
    public InputActionProperty upsAnimation;
    public InputActionProperty pointAnimation;


    public Animator handAnimation;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pinchValue = pinchAnimation.action.ReadValue<float>();
        Debug.Log("pinch value: " + pinchValue);
        handAnimation.SetFloat("Pinch", pinchValue);



        float grabValue = grabAnimation.action.ReadValue<float>();
        Debug.Log("grab value: " + grabValue);
        handAnimation.SetFloat("Grab", grabValue);


        float upsValue = upsAnimation.action.ReadValue<float>();
        Debug.Log("ups value: " + upsValue);
        handAnimation.SetFloat("Ups", upsValue);


        float pointValue = pointAnimation.action.ReadValue<float>();
        Debug.Log("point value: " + pointValue);
        handAnimation.SetFloat("Point", pointValue);

    }
}

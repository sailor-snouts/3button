using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoreTemp : MonoBehaviour
{
    [SerializeField]
    public GameObject needle;
    [SerializeField]
    private Transform needleTargetPos;

    private float gauge = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = gauge;
        Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
        needle.transform.localRotation = q;
        needle.transform.position = new Vector3(needleTargetPos.position.x- 0.092f, needleTargetPos.position.y + 0.849f, 0);        

        // For Testing
        if(Time.timeSinceLevelLoad % 1 == 0) {gauge = gauge + 1f;}
    }

    public void setTemp(float percent) 
        {
        if(percent > 100f) {percent = 100f;}
        if(percent <= 0f) { percent = 0f;}
        gauge = percent;
        }
}

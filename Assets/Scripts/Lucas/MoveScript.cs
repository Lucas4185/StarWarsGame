using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    float speed = 20.0f;
    float speed2 = 100.0f;

    // Update is called once per frame
    void Update()
    {

        walkFunction();
        transform.Translate(0, 0, 0.3f);

    }

    void walkFunction()
    {
     
        float input2 = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        transform.Translate(input2, 0, 0);
        float input3 = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed2;
        transform.Rotate(0, input3, 0);
    
    }
}

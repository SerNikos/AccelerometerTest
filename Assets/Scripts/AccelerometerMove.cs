using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempt = Input.acceleration.x; //κινηση όταν κινούμε την επιταχυνση για τον αξοχα χ και ολο αυτο το κανουμε store σε μια μεταβλητή τύπου float
        float z = Input.acceleration.z;
        Debug.Log(tempt); // λεει και τις τιμές που παίρνει (θετικές δεξία, αρνητικές αριστερά)

        transform.Translate(0, 0, speed); //κινείται ο κύβος σύμφωνα με το αν γερνουμε το κινητο στον άξονα χ

        transform.Rotate(0, 0, -tempt*speed); 
    }
}

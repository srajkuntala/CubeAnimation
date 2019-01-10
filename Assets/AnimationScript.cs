using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
      speed = Time.deltaTime;
      move();
      rotate();
      scale();
    }

    void move()
    {
        Vector3 movementVector = new Vector3(1.0f,1.0f,1.0f ) * speed;
        transform.Translate(movementVector);
    }

    void rotate()
    {
        Vector3 rotateVector = new Vector3(0,45,0) * speed;
        transform.Rotate(rotateVector);
    }

    void scale(){
      Vector3 scaleVector = new Vector3(0.4f, 0.4f, 0.4f) * speed;
      transform.localScale += scaleVector;
    }
}


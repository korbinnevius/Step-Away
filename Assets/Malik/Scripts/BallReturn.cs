using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturn : MonoBehaviour
{
    private float startingXPosition;
   private float startingZPosition;
   private float startingYPosition;
    
   private float minimumZ = 58;
   private float minimumX = -40;
   private float maximumX = 3;
   private float minimumY = 7;
   private Rigidbody rb;
   public float movementSpeed = 4;
   
       // Start is called before the first frame update
       void Start()
       {
           rb = GetComponent<Rigidbody>();
           startingXPosition = transform.position.x;
           startingZPosition = transform.position.z;
           startingYPosition = transform.position.y;
       }
       
       void Update()
       {
           ReturnToOriginalPosition();
       }

       public void ReturnToOriginalPosition()
       {
           if (transform.position.z > minimumZ)
           {
               transform.position = new Vector3(startingXPosition, startingYPosition, startingZPosition);
               StopMomentum();
           }
           if (transform.position.x < minimumX || transform.position.x > maximumX)
           {
               transform.position = new Vector3(startingXPosition, startingYPosition, startingZPosition);
               StopMomentum();
           }
           if (transform.position.y < minimumY)
           {
               transform.position = new Vector3(startingXPosition, startingYPosition, startingZPosition);
               StopMomentum();
           }

       }

       public void StopMomentum()
       {
           rb.velocity = Vector3.zero;
           rb.angularVelocity = Vector3.zero;
       }

}

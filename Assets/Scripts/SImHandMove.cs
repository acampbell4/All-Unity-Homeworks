using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
public class SImHandMove : MonoBehaviour
{
    //USe this space before the method to declare variables
    public Rigidbody spongebobRigidBody;
    public Vector3 locatioin;
    public float moveSpeed;
    public float turnSpeed;
    public float sprint;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //rotate using mouse.left hand rule
        #region using the keyboard
        /* if (Input.GetKey(KeyCode.Q)) //left
         {
             this.transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
             // this.transform.position = Vector3.forward; //foward is vector z positive 0,0,1 back is 0,0,-1 right is 1,0,0
         }
         if (Input.GetKey(KeyCode.E)) //right
         {
             this.transform.Translate(Vector3.up * Time.deltaTime * turnSpeed);
             // this.transform.position = Vector3.forward; //foward is vector z positive 0,0,1 back is 0,0,-1 right is 1,0,0
         }
         if (Input.GetKey(KeyCode.Z)) //forward
         {
             this.transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
             // this.transform.position = Vector3.forward; //foward is vector z positive 0,0,1 back is 0,0,-1 right is 1,0,0
         }
         if (Input.GetKey(KeyCode.C)) //back
         {
             this.transform.Translate(Vector3.left * Time.deltaTime * turnSpeed);
             // this.transform.position = Vector3.forward; //foward is vector z positive 0,0,1 back is 0,0,-1 right is 1,0,0
         }*/
        #endregion
        //mouse stuff//
        #region translational movement
   


        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= sprint;
            Babushka();
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed /= sprint;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
        #endregion
        #region rotation using mouse
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed, Space.Self);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse Y") * turnSpeed, Space.Self);
        #endregion 
    }
    public void Babushka()
    {
        Debug.Log("BABA YAGA");
    }
}

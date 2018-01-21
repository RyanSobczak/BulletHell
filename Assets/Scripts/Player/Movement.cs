using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    void Start() {

        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();

        print(GetComponent<Rigidbody>().velocity);
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //print(mousePos);

        //RaycastHit hit;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Physics.Raycast(ray, out hit, 100))
        //{
        //    print("Hit");
        //    transform.LookAt(hit.point);
        //}

        //Vector2 mousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 MouseLookAtPos = new Vector3(mousePos.x, mousePos.y, rb.transform.position.z + 10);
        //rb.transform.LookAt(MouseLookAtPos);
    }



    void checkInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += (transform.forward * 5);
            GetComponent<Rigidbody>().velocity += transform.forward * 2;
        }
        else//if (Input.GetKey(KeyCode.S))
        {                        
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, transform.forward * 10, 100 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, -transform.forward * 10, 100 * Time.deltaTime);
        }

        if (Input.mousePosition.y > ((Screen.height / 2) + 50))
        {
            transform.RotateAround(transform.position, -transform.right, 50 * Time.deltaTime);
        }

        if (Input.mousePosition.y < ((Screen.height / 2) - 50))
        {
            transform.RotateAround(transform.position, transform.right, 50 * Time.deltaTime);
        }
    }
}

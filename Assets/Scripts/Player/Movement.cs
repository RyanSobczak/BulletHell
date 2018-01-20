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

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print(mousePos);

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
            transform.position += (transform.forward * 5);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(transform.position, transform.right * 10, 100 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(transform.position, -transform.right * 10, 100 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, transform.forward * 10, 100 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, -transform.forward * 10, 100 * Time.deltaTime);
        }
    }
}

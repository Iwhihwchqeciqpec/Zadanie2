using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public int count;
    public GameObject Cylinder;
    public Text c;
    public float speed = 10f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }

        if (count <= 0)
        {
            this.gameObject.SetActive(false);
            c.text = "Вот и доигрались";
        }
        else c.text = count.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Cen");
        count--;
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Cet");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Cs");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Te");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Tx");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Ts");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("down"))
        {
            Physics.gravity = new Vector3(0, -10, 0);
        }

        if (Input.GetKeyDown("up"))
        {
            Physics.gravity = new Vector3(0, 10, 0);
        }
    }

    //private void Down()
    //{
    //    transform.position += new Vector3(0, -1.0f, 0);
    //}

    //private void Up()
    //{
    //    transform.position += new Vector3(0, 1.0f, 0);
    //}

    public void DestroyMe()
    {
        Destroy(this.gameObject);
    }
}

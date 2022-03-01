using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
    public float horizInput;
    public float moveSpeed;

    public Rigidbody2D playerRb;
    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void ProcessInputs()
    {
        horizInput = Input.GetAxis("Horizontal");
        playerAnim.SetFloat("horizInput", Mathf.Abs(horizInput));

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.eulerAngles = Vector3.zero;

            playerRb.AddForce(Vector3.right * moveSpeed * horizInput);


        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);

            playerRb.AddForce(Vector3.right * moveSpeed * horizInput);


        }
    }
}

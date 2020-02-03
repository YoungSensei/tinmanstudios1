using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float speed=10f;
    public float gravity;
    CharacterController controller;
    Vector3 velocity;
    public float force = 3f;
   

    public float jumpheight=4;
    public float jumpApex = .4f;
    float jumpvelocity;
    float vSpeed;

    AudioSource audi;
    public AudioClip walking;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        gravity = -(2 * jumpheight) / Mathf.Pow(jumpApex, 2);
        jumpvelocity = Mathf.Abs(gravity) * jumpApex;
        audi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        if (controller.isGrounded)
        {
            vSpeed = 0;
            if (Input.GetButtonDown("Jump"))
            {
                vSpeed = jumpvelocity;
            }
        }
        
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        if (hor != 0 || ver !=0)
        {
            if(!audi.isPlaying)
            audi.PlayOneShot(walking);
        }
        Vector3 playerMovement = transform.right * hor + transform.forward * ver;
        controller.Move(playerMovement*speed*Time.deltaTime);

        
        vSpeed += gravity * Time.deltaTime;
        velocity.y = vSpeed;
        

        controller.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
            if (hit.gameObject.tag == "Box")
            {
            
                hit.rigidbody.AddForce(transform.forward * force);
            }
        
    }

}

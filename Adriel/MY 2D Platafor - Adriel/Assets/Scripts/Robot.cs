using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Robot : MonoBehaviour
{
    public bool isjumping;
     public float speed;
  public float jump;
  private Rigidbody2D rig;
  void Start()
  {
    rig = GetComponent <Rigidbody2D>();
  }
  void Update()
  {
    Movement();

    Jump();

  }
  void Movement()
  {
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += movement * speed * Time.deltaTime;

  }
void Jump()
{
    if(Input.GetButtonDown("jump") && !isjumping)
    {
    rig.AddForce(new Vector3(0f, jump),ForceMode2D.Impulse);

    }
}
    private void OncollisionEnter2D(Collision2D collision)
 {
if(collision.gameObject.layer == 6)
{
    isjumping = true;

}
 }
}
 
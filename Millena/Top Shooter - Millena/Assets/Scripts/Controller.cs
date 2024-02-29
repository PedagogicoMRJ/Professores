using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Bullet bulletParameters;
    Vector2 playerPosition;
    Vector2 aimDirection;
    public float velocity=5;
    Vector2 movement;
    Rigidbody2D bodyRig;
    Vector2 aim;
    bool isAiming;
    Animator anim;
    public GameObject crossHair;
    void Start()
    {
        bulletParameters = GetComponentInChildren<Bullet>();
        bodyRig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        crossHair.SetActive(false);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = transform.position;
        if(isAiming){
            Aiming();
        }else{
            Movement();
        }
    }
    void Movement(){
        crossHair.SetActive(false);
        if(movement.x!=0 && movement.y!=0){
            bodyRig.velocity = new Vector2(movement.x, movement.y) * velocity * 0.7f;
        }
        else{
            bodyRig.velocity = new Vector2(movement.x, movement.y) * velocity;
        }
        anim.SetBool("Aim", false);
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Magnitude", movement.magnitude);
    }
    public void SetInputVector(Vector2 inputVector, Vector2 mouseVector, bool aiming){
        movement.x = inputVector.x;
        movement.y = inputVector.y;
        aim = mouseVector;
        isAiming = aiming;
    }
    public void Aiming(){
        aimDirection = aim-playerPosition;
        aimDirection.Normalize();
        crossHair.SetActive(true);
        bodyRig.velocity = Vector2.zero;
        anim.SetBool("Aim", true);
        anim.SetFloat("AimHorizontal", aimDirection.x);
        anim.SetFloat("AimVertical", aimDirection.y);
        crossHair.transform.position = aim;
        if(Input.GetMouseButtonDown(0)){
            bulletParameters.fireBullet(aim);
        }
    }
}

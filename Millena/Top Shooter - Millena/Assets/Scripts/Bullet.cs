using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    float bulletAngle;
    float muzzeAngle;
    Vector2 muzzlePosition;
    Animator bulletAnim;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        bulletAnim = GetComponent<Animator>();
    }
    public void fireBullet(Vector2 aim){
        transform.rotation = Quaternion.identity;
        bulletAngle = Mathf.Atan2(aim.y, aim.x)*Mathf.Rad2Deg;
        if(bulletAngle<0){
            bulletAngle += 360;
        }
        for(float i=22.5f;i<337.5f;i+=45.0f){
            if(bulletAngle>i && bulletAngle < i+45.0f){
                muzzeAngle = i+22.5f;
                break;
            }
            else{
                muzzeAngle = 0;
            }
        }
        float quadrant = muzzeAngle/45.0f;
        if(quadrant == 7 || quadrant == 0 || quadrant == 1){
            muzzlePosition.x = 0.45f;
        }
        else if(quadrant >= 3 && quadrant <= 5){
            muzzlePosition.x=-0.45f;
        }
        else{
            muzzlePosition.x = 0;
        }
        if(quadrant >= 1 && quadrant <=3){
            muzzlePosition.y = 1.25f;
        }
        else if(quadrant >= 5 && quadrant <=7){
            muzzlePosition.y = 0.15f;
        }
        else{
            muzzlePosition.y = 0.65f;
        }
        transform.Rotate(0f,0f,muzzeAngle);
        transform.localPosition = muzzlePosition;
        Debug.Log(muzzlePosition);
        bulletAnim.SetTrigger("Fire");
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.transform.Rotate(0f,0f,bulletAngle);
        bullet.GetComponent<Rigidbody2D>().velocity = aim*bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

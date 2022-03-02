using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiretSarte : MonoBehaviour
{
    [SerializeField] SpriteRenderer head_sprite;
    [SerializeField] GameObject HeadBullet;
    [SerializeField] Transform pos_head_shot;
    [SerializeField] float forsae = 20f; 
    #region useeless
    public static spiretSarte intanse;
    
    private void Awake()
    {
        intanse = this;
    }
 
    public bool head_On = true;
    #endregion

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (head_On != true) { return; }
            GameObject bullet = Instantiate(HeadBullet, pos_head_shot.position, pos_head_shot.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(pos_head_shot.right * forsae);
            head_sprite.enabled = false;
            head_On = false;
        }
    }
    public void Rest_Head()
    {
        head_sprite.enabled = true;
        head_On = true;
    }
}

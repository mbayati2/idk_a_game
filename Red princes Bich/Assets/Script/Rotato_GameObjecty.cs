using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato_GameObjecty : MonoBehaviour
{
    [SerializeField] private Transform PlayerTranform = null;
    [SerializeField] private Sprite dead;
    [SerializeField] Rigidbody2D Rb;
    [SerializeField] float Forxe;
    [SerializeField] Vector3 up_dowm;
    [SerializeField] GameObject gamepir;
    [SerializeField] bool picanle = false;
    [Header("enemy hit back stuff")]
    [SerializeField] Transform startpos = null;
    [SerializeField] Transform endpos = null;
    [SerializeField] float jourbeyTime = 1.0f;
    [SerializeField] float speed;
    [SerializeField] bool doit;
    [SerializeField] bool yep;

    float startTime;
    Vector3 centerPoint;
    Vector3 startRelCenter;
    Vector3 endRelCenter;
    bool oneChance = true;
    void FixedUpdate()
    {
        if(oneChance == false) { return; }
        gameObject.transform.position = PlayerTranform.position;

         Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);

         Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

         float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

         transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));
     }
    private void Update()
    {
        #if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.L)) { dioea(); }
        #endif
        GetCenter(Vector3.up);
        if (doit)
        {
            startpos = transform;
            float fracComlete = (Time.deltaTime - startTime) / jourbeyTime * speed;
            transform.position = Vector3.Slerp(startRelCenter, endRelCenter, fracComlete * speed);
            transform.position += centerPoint;
        }
        if (!Input.GetMouseButtonDown(0)) { return; }
        if (oneChance == true)
        {
            if (Rb == null) { return; }
            Rb.AddForce(-transform.right * Forxe);
            gameObject.GetComponent<SpriteRenderer>().sprite = dead;
            Instantiate(gamepir , transform.position, Quaternion.identity);
            oneChance = false;
        }
    }

    private void GetCenter(Vector3 up)
    {
        if (endpos == null) { endpos = GetTransform(); }
        centerPoint = (startpos.position + endpos.position) * 0.25f;
        centerPoint -= up;
        startRelCenter = startpos.position - centerPoint;
        endRelCenter = endpos.position - centerPoint;
    }
    private Transform GetTransform()
    {
        return getrengerse.it.EndPOint;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground") && picanle == false)
        {
            spiretSarte.intanse.gameObject.transform.position = this.transform.position + up_dowm;
            dioea();
            return;
        }
        if (other.tag == "Enemy")
        {
            Rb.velocity = Vector2.zero;
            picanle = true;
            doit = true;
        }
        if (other.tag == "Player" && picanle == true)
        {
            dioea();
        }
    }
    #region  Uselees
    void Start()
    {
        StartCoroutine(DIE());
    }
    IEnumerator DIE()
    {
        yield return new WaitForSeconds(5);
        if (picanle) { yield return new WaitForSeconds(5); }
        dioea();
    }
    private void dioea()
    {
        spiretSarte.intanse.Rest_Head();
        Destroy(gameObject);
    }
     float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
    #endregion
}

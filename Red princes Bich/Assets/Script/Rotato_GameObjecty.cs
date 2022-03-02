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
        if (!Input.GetMouseButtonDown(0)) { return; }
        if (oneChance == true)
        {
            Rb.velocity = Vector2.zero;
            Rb.AddForce(-transform.right * Forxe);
            gameObject.GetComponent<SpriteRenderer>().sprite = dead;
            Instantiate(gamepir , transform.position, Quaternion.identity);
            oneChance = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            spiretSarte.intanse.gameObject.transform.position = this.transform.position + up_dowm;
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

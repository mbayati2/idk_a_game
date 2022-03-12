
using UnityEngine;

public class CameraMoment : MonoBehaviour
{
    [SerializeField] float panSpeed = 20f;
    [SerializeField] float panBorderThickness = 10f;
    [SerializeField] Vector3 player_pos;
    [SerializeField] Transform Player;
    [SerializeField] KeyCode keyCode;
    [SerializeField] bool dontMove;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player_pos = new Vector3(Player.position.x , transform.position.y, Player.position.z - 5);
            pos = player_pos;
            Debug.Log("owo");
        }
        if (Input.GetKeyDown(keyCode))
        {
            if (dontMove == true)
            {
               dontMove = false;
            }
            else if (dontMove == false)
            {
                dontMove = true;
            }
        }
        if (dontMove==true) { return; }
        transform.position = pos;
    }
}

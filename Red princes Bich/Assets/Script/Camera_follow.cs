using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	
	// How long the object should shake for.
	public static float shakeDuration = 0f;
	
	// Amplitude of the shake. A larger value shakes the camera harder.
	public static float shakeAmount = 0.7f;
	public  float decreaseFactor = 1.0f;
    [SerializeField] private float Up = -20f;
	[SerializeField] private bool fellow_Player = true;

	[SerializeField] public GameObject playerScriptMoveMent = null;
	[SerializeField] private float smoothposss = 10f;
	[SerializeField] public static Camera_follow Cc { get; set;}
	[SerializeField] private Transform pos2d;


	
	Vector3 originalPos;
	
	void Awake()
	{
		Cc = this;
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void FixedUpdate()
	{
		if (playerScriptMoveMent == null) { return; }

        Vector3 pos = 
            new Vector3 (
                playerScriptMoveMent.transform.position.x, 
                playerScriptMoveMent.transform.position.y, 
                -Up);
		if (fellow_Player == false) { pos = pos2d.position; }
		Vector3 smoothpos = Vector3.Lerp(transform.position, pos, smoothposss * Time.deltaTime);
		originalPos = smoothpos;

	}


	void Update()
	{

		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			camTransform.localPosition = originalPos;
		}
	}

    public void BulltCameraShake(float f , float z )
    {

        shakeDuration = f;
        shakeAmount = z;
    }
	public static void Shakeing(float amout,float strong)
	{
		shakeAmount = amout;
		shakeDuration = strong;
	}
}

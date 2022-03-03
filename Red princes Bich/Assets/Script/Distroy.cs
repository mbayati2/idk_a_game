using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{
    [SerializeField] int time;
    void Start()
    {
        StartCoroutine(jojo());
    }
    IEnumerator jojo()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
    
}

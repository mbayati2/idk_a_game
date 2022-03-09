using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoxCollidersHandler : MonoBehaviour
{
       public Action<bool , GameObject> OnTriggerEnterH;
       public string playerTag;

       private void OnTriggerEnter(Collider other)
       {
           if (other.tag == playerTag)
           {
               YEPUpdaterd(true , other.gameObject);
           }
       }
       private void OnTriggerExit(Collider other)
       {
            if (other.tag == playerTag)
           {
               YEPUpdaterd(false , other.gameObject);
           }
       }

       private void YEPUpdaterd(bool owo, GameObject hit)
       {
           OnTriggerEnterH(owo , hit);
       }
}

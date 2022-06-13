using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Freya;

public class Test_Script : MonoBehaviour
{
   float Tau = 6.28f;
    [SerializeField] private float radiuse;
    [SerializeField] private int Angeles_Amount;

   private void OnDrawGizmosSelected() {
       

        Handles.DrawWireDisc(transform.position , transform.forward , radiuse);
        for (int i = 1; i < Angeles_Amount; i++)
        {
            i--;
            float Angels = i / (float)Angeles_Amount  * Tau;
            Vector2 dir2 = Mathfs.AngToDir(Angels);


            Handles.DrawLine(transform.position , (Vector2)transform.position + dir2 * radiuse);
        }

   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test_Script : MonoBehaviour
{
   float Tau = 6.28f;
    [SerializeField] private float radiuse;
    [SerializeField] private int Angeles_Amount;

   private void OnDrawGizmosSelected() {
       

        Handles.DrawWireDisc(transform.position , transform.forward , radiuse);
        for (int i = 0; i < Angeles_Amount; i++)
        {
            float Angels = i / Angeles_Amount * Tau;
            float x = Mathf.Cos(Angels);
            float y = Mathf.Sign(Angels);

            Vector2 dir = new Vector2(x , y).normalized;

            Handles.DrawLine(transform.position , (Vector2)transform.position + dir);
        }

   }
}

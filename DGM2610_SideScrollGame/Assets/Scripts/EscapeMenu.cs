using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EscapeMenu : MonoBehaviour
{

   public UnityEvent EscapeEvent;

   private void FixedUpdate()
   {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
         EscapeEvent.Invoke();
      }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiLaptop : MonoBehaviour
{
   public void ChangeScene(string Laptop)
   {
       Application.LoadLevel(Laptop);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPhoneX : MonoBehaviour
{
   public void ChangeScene(string iphonex)
   {
       Application.LoadLevel(iphonex);
   }
}

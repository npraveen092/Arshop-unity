using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiTv : MonoBehaviour
{
    public void ChangeScene(string Samsungtv)
   {
       Application.LoadLevel(Samsungtv);
   }
}

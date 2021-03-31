using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiWM : MonoBehaviour
{
public void ChangeScene(string washingmachine)
   {
       Application.LoadLevel(washingmachine);
   }
}
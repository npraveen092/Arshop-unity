using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
public void ChangeScene(string UI)
   {
       Application.LoadLevel(UI);
   }
}

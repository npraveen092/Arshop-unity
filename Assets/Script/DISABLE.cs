using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DISABLE : MonoBehaviour
{
	public GameObject Panel;
    
    public void WhenButtonClicked()
    {
    	if(Panel.activeInHierarchy == true)
    	Panel.SetActive(false);
    	else
    	Panel.SetActive(true);

    }
}

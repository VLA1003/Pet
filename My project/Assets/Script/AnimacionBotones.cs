using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnimacionBotones : MonoBehaviour
{
   public void ScaleUp()
   {

        LeanTween.scale(gameObject, Vector3.one * 1.5f, 0.2f).setEaseInBounce();
   }

    
    public void ScaleDown()
    {

        LeanTween.scale(gameObject, Vector3.one, 0.5f);
    }
}

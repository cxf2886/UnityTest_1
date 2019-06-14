using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageClick : MonoBehaviour, IPointerClickHandler
{
    #region IPointerClickHandler implementation
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.LogFormat("{0} is click", gameObject.name);
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayOnHoverButton : MonoBehaviour, IPointerEnterHandler {

	public AudioClip HoverSound;
	public void OnPointerEnter( PointerEventData eventData )
	{
		AudioSource.PlayClipAtPoint( HoverSound, Camera.main.transform.position );
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CameraFunction : MonoBehaviour 
{
	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset, offrot;

	void LateUpdate()
	{
        // Efecto de Movimiento Suave en la Cámara y seguimiento de la Cámara al Elevador
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
	}
}

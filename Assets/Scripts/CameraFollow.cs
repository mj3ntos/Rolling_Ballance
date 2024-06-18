using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencja do piłki
    public Vector3 offset; // Offset kamery względem piłki

    void Start()
    {
        // Możemy ustawić początkowy offset w Start, jeśli nie został ustawiony w Inspectorze
        if (offset == Vector3.zero)
        {
            offset = transform.position - target.position;
        }
    }

    void LateUpdate()
    {
        // Aktualizacja pozycji kamery
        Vector3 targetPosition = target.position + offset;
        transform.position = targetPosition;

        // Opcjonalnie, możemy zablokować obrót kamery, aby zawsze patrzyła w dół na piłkę
        transform.LookAt(target);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 mousePosition;

    void Update()
    {
        PlayerMove();
        SetPlayerPositionRestrict();
    }
    
    private void PlayerMove()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
        transform.position = new Vector3(transform.position.x, mousePosition.y, transform.position.z);
    }

    private void SetPlayerPositionRestrict()
    {
        float PlayerXPosition = Mathf.Clamp(gameObject.transform.position.x, -8f, -8f);
        float PlayerYPosition = Mathf.Clamp(gameObject.transform.position.y, -4.8f, 4.8f);
        transform.position = new Vector3(PlayerXPosition, PlayerYPosition, 0);
    }
}

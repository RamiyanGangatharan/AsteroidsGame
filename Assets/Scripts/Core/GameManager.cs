using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerManager playerManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) { playerManager.ResetPlayerShip(); }
    }
}
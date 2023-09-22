
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameStartPanel;
    [SerializeField] GameObject gameEndPanel;
    void Start()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        gm.AddEventToGameStart(DisableStartMenu);
        gm.AddEventToGameEnds(EnableEndMenu);

    }

    void EnableEndMenu()
    {
        gameEndPanel.SetActive(true);
        FindObjectOfType<ScoreManager>().EndGame();
    }


    void DisableStartMenu()
    {
        gameStartPanel.SetActive(false);
    }
}

using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text text;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
}

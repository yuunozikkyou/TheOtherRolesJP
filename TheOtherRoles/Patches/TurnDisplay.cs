using UnityEngine;
using UnityEngine.UI;

public class TurnDisplay : MonoBehaviour
{
    public Text turnText;

    // ターンを更新する関数
    public void UpdateTurn(int turnNumber)
    {
        turnText.text = "現在のターン: " + turnNumber.ToString();
    }
}

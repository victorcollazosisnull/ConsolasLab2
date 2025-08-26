using UnityEngine;
using TMPro;
public class kills : MonoBehaviour
{
    public TMP_Text illText; 

    private int killss = 0;

    public void AddKill()
    {
        killss++;
        illText.text = "Kills: " + killss.ToString();
    }
}

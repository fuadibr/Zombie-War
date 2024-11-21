using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public Text questText;
    private string quest1string;
    // Start is called before the first frame update
    void Start()
    {
        quest1string = "Pick your weapon. Go to retail shop or police station.";
        questText.text = quest1string;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    
    public GameObject gameOverPanel;

    void Start()
    {
        ShowPanel1();
    }

    public void ShowPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        gameOverPanel.SetActive(false); 
    }

    public void ShowPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(false);
    }
}



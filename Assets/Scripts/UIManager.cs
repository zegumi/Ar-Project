using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject infoPanel;

    public void ShowInfo() {
        infoPanel.SetActive(true);
    }

    public void CompleteTask() {
        Debug.Log("Görev tamamlandı! Zaman Kaşifi Rozeti kazandın.");
        infoPanel.SetActive(false);
        // İstersen buraya bir 'Rozet Kazanıldı' paneli de ekleyebiliriz
    }
}

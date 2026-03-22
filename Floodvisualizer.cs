using UnityEngine;

public class FloodVisualizer : MonoBehaviour
{
    public GameObject floodPrefab;

    public void ShowFloodRisk(int riskLevel)
    {
        if (riskLevel == 1)
        {
            GameObject flood = Instantiate(floodPrefab);
            flood.transform.position = new Vector3(0, 0, 2);
            flood.transform.localScale = new Vector3(5, 0.2f, 5);

            Debug.Log("⚠️ Flood Risk Detected!");
        }
        else
        {
            Debug.Log("✅ No Flood Risk");
        }
    }
}

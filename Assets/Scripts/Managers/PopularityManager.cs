using UnityEngine;

public class PopularityManager : MonoBehaviour
{
    public static PopularityManager Instance;

    public int Popularity { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void AddPopularity(int amount)
    {
        Popularity += amount;
        Debug.Log("Popularity: " + Popularity);
    }
}
using UnityEngine;
using TMPro;

public class GameHUD : MonoBehaviour
{
    public static GameHUD Instance;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI popularityText;
    public TextMeshProUGUI orderText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        moneyText.text = "Money: " + EconomyManager.Instance.Money;
        popularityText.text = "Popularity: " + PopularityManager.Instance.Popularity;
        orderText.text = "Order: Chicken Shawarma";
    }
}
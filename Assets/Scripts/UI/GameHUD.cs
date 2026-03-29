using UnityEngine;
using TMPro;

public class GameHUD : MonoBehaviour
{
    public static GameHUD Instance;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI popularityText;
    public TextMeshProUGUI orderText;
    public TextMeshProUGUI patienceText;
    public TextMeshProUGUI statusText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
        ClearOrder();
    }

    private void Update()
    {
        if (OrderManager.Instance == null)
        {
            return;
        }

        Customer currentCustomer = OrderManager.Instance.GetCurrentCustomer();

        if (patienceText == null)
        {
            return;
        }

        if (currentCustomer != null)
        {
            patienceText.text = "Patience: " + currentCustomer.CurrentPatience.ToString("F1");
        }
        else
        {
            patienceText.text = "Patience: -";
        }
    }

    public void ShowStatus(string message)
    {
        if (statusText != null)
        {
            statusText.text = message;
        }
    }

    public void UpdateUI()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: " + EconomyManager.Instance.Money;
        }

        if (popularityText != null)
        {
            popularityText.text = "Popularity: " + PopularityManager.Instance.Popularity;
        }
    }

    public void UpdateOrder(string order)
    {
        if (orderText != null)
        {
            orderText.text = "Order: " + order;
        }
    }

    public void ClearOrder()
    {
        if (orderText != null)
        {
            orderText.text = "Order: None";
        }
    }
}
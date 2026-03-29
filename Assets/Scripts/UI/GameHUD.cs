using System.Collections;
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

    private Coroutine statusCoroutine;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
        ClearOrder();
        SetWaitingStatus();
    }

    private void Update()
    {
        if (OrderManager.Instance == null || patienceText == null)
        {
            return;
        }

        Customer currentCustomer = OrderManager.Instance.GetCurrentCustomer();

        if (currentCustomer != null)
        {
            patienceText.text = "Patience: " + currentCustomer.CurrentPatience.ToString("F1");
        }
        else
        {
            patienceText.text = "Patience: -";
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

    public void SetWaitingStatus()
    {
        if (statusText != null)
        {
            statusText.text = "Customer waiting for order";
        }
    }

    public void ShowTemporaryStatus(string message, float duration)
    {
        if (statusCoroutine != null)
        {
            StopCoroutine(statusCoroutine);
        }

        statusCoroutine = StartCoroutine(ShowTemporaryStatusRoutine(message, duration));
    }

    private IEnumerator ShowTemporaryStatusRoutine(string message, float duration)
    {
        if (statusText != null)
        {
            statusText.text = message;
        }

        yield return new WaitForSeconds(duration);

        SetWaitingStatus();
        statusCoroutine = null;
    }
}
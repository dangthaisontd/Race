using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextPosition;
    [SerializeField] private TextMeshProUGUI m_TextLaps;
    [SerializeField] private TextMeshProUGUI m_TextCoin;
    [SerializeField] private TextMeshProUGUI m_TextKm;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        m_TextPosition.text = GameManager.Instance.positonCar.ToString();
        m_TextLaps.text = GameManager.Instance.lapsCar.ToString();
        m_TextCoin.text = GameManager.Instance.coinCar.ToString();
        m_TextKm.text = GameManager.Instance.km.ToString();
    }
}
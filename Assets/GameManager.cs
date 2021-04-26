

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button Btn1;
    //public Button Btn2;
    public GameObject Fire;
    bool IsStart = false;
    float timer = 15;
    //private void Awake()
    //{
    //    Btn1.onClick.AddListener(() =>
    //    {
    //        if (Fire.activeSelf || IsStart) return;
    //        Fire.SetActive(true);
    //        Invoke("Hide", 2);
    //    });
    //    Btn2.onClick.AddListener(() =>
    //    {
    //        if (IsStart) return;
    //        IsStart = true;
    //        Btn1.interactable = false;
    //    });
    //}
    private void Update()
    {
        if (Input .GetKeyDown (KeyCode.F ))
        {
            if (Fire.activeSelf || IsStart) return;
            Fire.SetActive(true);
            Invoke("Hide", 2);
        }
        if (Input .GetKeyDown (KeyCode.R  ))
        {
            if (IsStart) return;
            IsStart = true;
        }
        if (IsStart)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;

            }
            else
            {
                timer = 15;
                IsStart = false;
                Btn1.transform.GetChild(0).GetComponent<Text>().text = "";
                Btn1.interactable = true;
            }
            if (!IsStart) return;
            Btn1.transform.GetChild(0).GetComponent<Text>().text = ((int)timer).ToString();
        }
    }
    private void Hide()
    {
        Fire.SetActive(false);

    }
}
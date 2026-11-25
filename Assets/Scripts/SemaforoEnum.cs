using UnityEngine;

public class SemaforoEnum : MonoBehaviour
{
    [SerializeField]
    GameObject redLight;
    [SerializeField]
    GameObject ambarLight;
    [SerializeField]
    GameObject greenLight;

    [SerializeField]
    float timeinred = 10f;
    [SerializeField]
    float timeingreen = 15f;
    [SerializeField]
    float timeinambar = 2f;


    float contador = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EncenderLuces(false, false, true);
    }

    void EncenderLuces(bool greenStatus, bool orangeStatus, bool redStatus)
    {
        greenLight.SetActive(greenStatus);
        ambarLight.SetActive(orangeStatus);
        redLight.SetActive(redStatus);
    }


    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= 10f && redLight.activeSelf == true)
        {
            EncenderLuces(true, false, false);
            contador = 0.0f;
        }
        
        if (contador >= 15f && greenLight.activeSelf == true)
        {
            EncenderLuces(false, true, false);
            contador = 0.0f;

        }
        if (contador >= 2f && ambarLight.activeSelf == true)
        {
            EncenderLuces(false, false, true);
            contador = 0.0f;

        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance { get; private set; }
    private CinemachineVirtualCamera cameraVirtuel;
    private float shakeTime;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        cameraVirtuel = GetComponent<CinemachineVirtualCamera>();
    }

    public void ShakingCamera(float intensity, float time)
    {

        cameraVirtuel.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = intensity;
        shakeTime = time;

    }
    private void Update()
    {
        if(shakeTime > 0)
        {
            shakeTime -= Time.deltaTime;
            if(shakeTime <= 0f)
            {
                cameraVirtuel.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0f;
            }
        }
    }
}

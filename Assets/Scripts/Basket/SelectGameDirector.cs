using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectGameDirector : MonoBehaviour
{
    [SerializeField] Text redText;
    [SerializeField] Text greenText;
    [SerializeField] Text yellowText;

    [SerializeField] Button redButton;
    [SerializeField] Button greenButton;
    [SerializeField] Button yellowButton;

    // ��� ����Ȯ��
    int redApplePersent = 50;
    int yellowApplePersent = 70;
    int greenApplePersent = 40;

    int redMinusPoint = 10;
    int greenMinusPoint = 5;
    int yellowMinusPoint = 15;

    private void Start()
    {
        redText.text = string.Format
            ("�����׾Ƹ�\n" +
            "�������Ȯ�� : {0}\n��ź���� : {1}",
            redApplePersent, redMinusPoint);
        yellowText.text = string.Format
            ("����׾Ƹ�\n" +
            "�������Ȯ�� : {0}\n��ź���� : {1}",
            yellowApplePersent, yellowMinusPoint);
        greenText.text = string.Format
            ("�ʷ��׾Ƹ�\n" +
            "�������Ȯ�� : {0}\n��ź���� : {1}",
            greenApplePersent, greenMinusPoint);
    }
}

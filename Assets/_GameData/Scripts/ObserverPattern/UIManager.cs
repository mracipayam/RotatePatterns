using DG.Tweening;
using TMPro;
using UnityEngine;

namespace _GameData.Scripts.ObserverPattern
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text pointText;
        private int point;
        private void OnEnable()
        {
            GameEventManager.OnPointIncrease += OnPointIncreaseHandler;
        }

        private void OnDisable()
        {
            GameEventManager.OnPointIncrease -= OnPointIncreaseHandler;
        }

        private void OnPointIncreaseHandler()
        {
            point++;
            pointText.text = "Point : " + point;
            pointText.rectTransform.DOShakeScale(.2f,1.3f);
        }
    }
}

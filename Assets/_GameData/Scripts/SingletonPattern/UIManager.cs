using DG.Tweening;
using TMPro;
using UnityEngine;

namespace _GameData.Scripts.SingletonPattern
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text pointText;

        public void UpdateText()
        {
            PointManager.instance.Point++;
            pointText.text = "Point : " + PointManager.instance.Point;
            pointText.rectTransform.DOShakeScale(.2f,1.3f);
        }
    }
}

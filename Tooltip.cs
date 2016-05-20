/*using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    [System.Serializable]
    public class AnimationSettings
    {
        public enum OpenStyle { WidthToHeight, HeightToWidth, HeightAndWidth };
        public OpenStyle openStyle;
        public float widthSmooth = 4.6f, heightSmooth = 4.6f;
        public float textSmooth = 0.1f;

        [HideInInspector]
        public bool widthOpen = false, heightOpen = false;
        public void Initialize()
        {
            widthOpen = false;
            heightOpen = false;
        }
    }
    [System.Serializable]
    public class UISettings
    {
        public Image textBox;
        public Text text;
        public Vector2 initialBoxSize = new Vector2(0.25f, 0.25f);
        public Vector2 openedBoxSize = new Vector2(400, 200);
        public float snapToSizeDistance = 0.25f;
        public float lifeSpan = 5;

        [HideInInspector]
        public bool opening = false;
        [HideInInspector]
        public Color textColor;
        [HideInInspector]
        public Color textBoxColor;
        [HideInInspector]
        public RectTransform textBoxRect;
        [HideInInspector]
        public Vector2 currentSize;

        public void Initialize()
        {
            textBoxRect = textBox.GetComponent<RectTransform>();
            textBoxRect.sizeDelta = initialBoxSize;
            currentSize = textBoxRect.sizeDelta;
            opening = false;
            textColor = text.color;
            textColor.a = 0;
            text.color = textColor;
            textBoxColor = textBox.color;
            textBoxColor.a = 1;
            textBox.color = textBoxColor;

            textBox.gameObject.SetActive(false);
            text.gameObject.SetActive(false);

        }
    }

        public AnimationSettings animSettings = new AnimationSettings();
        public UISettings uiSettings = new UISettings();

        float lifeTimer = 0;

        void Start()
        {
            animSettings.Initialize();
            uiSettings.Initialize();
        }

        public void StartOpen()
        {
            uiSettings.opening = true;
            uiSettings.textBox.gameObject.SetActive(true);
            uiSettings.text.gameObject.SetActive(true);
        }

        void Update()
        {
            if (uiSettings.opening)
            {
                OpenToolTip();

                if (animSettings.widthOpen && animSettings.heightOpen)
                {
                    lifeTimer += Time.deltaTime;
                    if (lifeTimer > uiSettings.lifeSpan)
                    {
                        FadeToolTipOut();
                    }
                    else
                    {
                        FadeTextIn();
                    }

                }
            }
        }
        void OpenToolTip()
        {
            switch(animSettings.openStyle)
            {
                case AnimationSettings.OpenStyle.HeightToWidth:
                    OpenHeightToWidth();
                    break;
                case AnimationSettings.OpenStyle.WidthToHeight:
                    OpenWidthToHeight();
                    break;
                case AnimationSettings.OpenStyle.HeightAndWidth:
                    OpenHeightAndWidth();
                    break;
                default:
                    Debug.LogError("No Anim")
                    break;
            }
            uiSettings.textBoxRect.sizeDelta = uiSettings.currentSize;

        }
        void OpenWidthToHeight()
        {
            if (!animSetting.widthOpen)
            {
                OpenWidth();
            }
            else
            {
                OpenHeight();
            }
        }
        void OpenHeightToWidth()
        {
            if (!animSettings.heightOpen)
            {
                OpenHeight();
            }
            else
            {
                OpenWidth();
            }
        }
        void OpenWidth()
        {
            uiSettings.currentSiz.x = Mathf.Lerp(uiSettings.currentSize.x, uiSettings.openBoxSize.x, animSettings.widthSmooth * Time.deltaTime);
            if (Mathf.Abs(uiSettings.currentSize.x - uiSettings.snapToSizeDistance)
                {
                uiSettings.currentSize.x = uiSettings.openBoxSize.x;
                animSettings.widthOpen = true;
            }
        }
        void OpenHeight()
        {
            uiSettings.currentSize.y = Mathf.Lerp(uiSettings.currentSize.y, uiSettings.openedBoxSize.y, animSettings.heightSmooth * Time.deltaTime)
            animSetting.heightOpen = true;
        }
    } 

*/
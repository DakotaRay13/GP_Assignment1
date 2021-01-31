using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    //Slider Variables
    public Text sliderText;
    public Slider slider;

    //Input Field Variables
    public InputField nameBox;
    public Text nameText;

    private void Start()
    {
        ShowSliderValue();
        nameText.text = "";
    }

    public void Level01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Level02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void Level03()
    {
        SceneManager.LoadScene("Level03");
    }

    public void ShowSliderValue()
    {
        sliderText.text = slider.value.ToString();
    }

    public void ThankYouPlayer()
    {
        nameText.text = "Thank you, " + nameBox.text + "!";
    }
}

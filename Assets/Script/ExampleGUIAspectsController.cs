using UnityEngine;

class ExampleGUIAspectsController : MonoBehaviour
{
    private HealthSystem health_bar;

    private GlobeBarSystem globe_test_bar;

    public Rect HealthBarDimens;
    public bool VerticleHealthBar;
    public Texture HealthBubbleTexture;
    public Texture HealthTexture;
    public float HealthBubbleTextureRotation;

    public Rect GlobeBarDimens;
    public bool VerticleGlobeBar;
    public Texture GlobeBubbleTexture;
    public Texture GlobeTexture;
    public float GlobeBubbleTextureRotation;

    private int count = 0;


    public void Start()
    {
        health_bar = new HealthSystem(HealthBarDimens, VerticleHealthBar, HealthBubbleTexture, HealthTexture, HealthBubbleTextureRotation);
        globe_test_bar = new GlobeBarSystem(GlobeBarDimens, VerticleGlobeBar, GlobeBubbleTexture, GlobeTexture, GlobeBubbleTextureRotation);

        health_bar.Initialize();     
        globe_test_bar.Initialize();
    }

    public void OnGUI()
    {
        health_bar.DrawBar();

        globe_test_bar.DrawBar();
        
        // These are the example Incriment and Deincriment buttons, mainly for demonstration purposes only
        if (GUI.Button(new Rect(health_bar.getScrollBarRect().x + (health_bar.getScrollBarRect().width / 2) - (128/2), health_bar.getScrollBarRect().y + (health_bar.getScrollBarRect().height / 2) - 30, 128, 20), "Increase Health"))
        {
            health_bar.IncrimentBar(Random.Range(1, 6));
        }
        else if (GUI.Button(new Rect(health_bar.getScrollBarRect().x + (health_bar.getScrollBarRect().width / 2) - (128 / 2), health_bar.getScrollBarRect().y + (health_bar.getScrollBarRect().height / 2) + (20/2), 128, 20), "Decrease Health"))
        {
            health_bar.IncrimentBar(Random.Range(-6, -1));
        }

        if (GUI.Button(new Rect(globe_test_bar.getScrollBarRect().x + (globe_test_bar.getScrollBarRect().width / 2) - (140 / 2), globe_test_bar.getScrollBarRect().y + (globe_test_bar.getScrollBarRect().height / 2) - 85, 140, 20), "Increase Globe Value"))
        {
            globe_test_bar.IncrimentBar(Random.Range(1, 12));
        }
        else if (GUI.Button(new Rect(globe_test_bar.getScrollBarRect().x + (globe_test_bar.getScrollBarRect().width / 2) - (145 / 2), globe_test_bar.getScrollBarRect().y + (globe_test_bar.getScrollBarRect().height / 2) + 70, 145, 20), "Decrease Globe Value"))
        {
            globe_test_bar.IncrimentBar(Random.Range(-12, -1));
        }
        // End of example buttons
    }

    public void Update()
    {
        if (count > 5)
        {
            health_bar.IncrimentBar(-1);
            count = 0;
        }
        health_bar.Update();
        globe_test_bar.Update();
        count++;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaSystem : MonoBehaviour
{
    public Text count;
    public int maxMana;
    private float mana;
    public Image manaMeter;
    // Start is called before the first frame update
    void Start()
    {
        mana = maxMana;
    }

    public void ChangeMana(float value)
    {
        mana += value;

        RenderMana();
    }

    private void RenderMana()
    {
        manaMeter.fillAmount = (float)mana / (float)maxMana;
    }

    // Update is called once per frame
    public void LateUpdate()
    {
        if (mana < 100)
        {
            ChangeMana(.5f);
            count.text = mana.ToString();
        }
    }

    public void use()
    {
        if(mana > 15)
        {
            ChangeMana(-15);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { HealthItem, WeaponItem, InteractableItem, PowerItem}
public class HealthItem : Health
{
    // Start is called before the first frame update
    void Start()
    {
        base.LoadComponent();
    }

}
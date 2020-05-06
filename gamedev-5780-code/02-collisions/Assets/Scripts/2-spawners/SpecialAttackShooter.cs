using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttackShooter : KeyboardSpawner
{
    [SerializeField] NumberField scoreField;
    [SerializeField] CoolDown coolDown;
    private float cooldownCounter = 5;
    private bool coolingdown = false;

    protected override GameObject spawnObject()
    {

        GameObject newObject = base.spawnObject();  // base = super
        newObject.transform.position = new Vector3(newObject.transform.position.x - 1.9f, newObject.transform.position.y, 0);

        // Modify the text field of the new object.
        ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();

        if (newObjectScoreAdder)
            newObjectScoreAdder.SetScoreField(scoreField);


        return newObject;

    }
    private void Update()
    {
       if (!coolingdown)
            {
                if (Input.GetKeyDown(base.keyToPress))
                {
                    spawnObject();
                    this.coolingdown = true;


                }
             }
            else
            {
                this.cooldownCounter -= Time.deltaTime;
                this.coolDown.SetNumber(cooldownCounter);
                if (this.cooldownCounter <= 0)
                {
                    coolingdown = false;
                    cooldownCounter = 5;
                    this.coolDown.SetNumber(cooldownCounter);
            }
            }


    }
}
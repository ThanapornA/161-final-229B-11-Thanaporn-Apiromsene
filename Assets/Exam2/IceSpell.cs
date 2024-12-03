using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    void Start()
    {
        Init("Ice Shard Spell" , 10);
        Cast("SlimeB" , 10);
    }
}

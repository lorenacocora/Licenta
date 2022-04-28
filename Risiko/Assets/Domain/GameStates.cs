using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Domain
{
    public enum GameStates
    {
        PlayerSelectTerritory, 
        PlayerAddTanks, 
        PlayerAttackTerritory, 
        PlayerDefense, 
        GameOver, 
        EnemyTurn
    };
}

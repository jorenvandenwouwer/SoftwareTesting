﻿using System;

namespace Conway.Library
{
    public enum CellState
    {
        Alive,
        Dead
    }
    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            if( currentState == CellState.Alive && liveNeighbors < 2)
            {
                return CellState.Dead;
            }
            if (currentState == CellState.Alive && liveNeighbors > 3)
            {
                return CellState.Dead;
            }
            if (currentState == CellState.Dead && liveNeighbors == 3)
            {
                return CellState.Alive;
            }
            return currentState;
        }
    }
}
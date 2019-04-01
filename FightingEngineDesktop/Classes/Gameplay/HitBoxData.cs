﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Gameplay
{
    public class HitBoxData
    {
        //Hit Data 1
        public HITTYPE HitType;
        public int HitStop;
        public int HitStun;
        public int BlockStun;
        public int Damage;

        //Hit Data 2
        public HITRESULT HitResult;
        public JUGGLETYPE JuggleType;

        //Cancels
        public bool SpecialCancel;
        public bool JumpCancel;
        public bool UniqueActionCancel;
        public bool DashCancel;
        public string CancelRoutes;

        public HitBoxData(HITTYPE hitType, int hitStop, int hitStun, int blockStun, int damage, 
            HITRESULT hitResult, JUGGLETYPE juggleType,
            bool specialCancel, bool jumpCancel, bool uniqueActionCancel, bool dashCancel, string cancelRoutes)
        {
            HitType = hitType;
            HitStop = hitStop;
            HitStun = hitStun;
            BlockStun = blockStun;
            Damage = damage;

            HitResult = hitResult;
            JuggleType = juggleType;

            SpecialCancel = specialCancel;
            JumpCancel = jumpCancel;
            UniqueActionCancel = uniqueActionCancel;
            DashCancel = dashCancel;
            CancelRoutes = cancelRoutes;
        }
    }

    public enum HITTYPE
    {
        NONE,
        High,
        Mid,
        Low,
        Throw,
        Projectile,
        Unblockable
    }

    public enum HITRESULT
    {
        NONE,
        Normal,
        Knockdown,
        LaunchLow,
        LaunchMid,
        LaunchHigh,
        WallBounce,
        GroundBounce
    }

    public enum JUGGLETYPE
    {
        NONE,
        NoJuggle,
        Resets,
        CanJuggle
    }
}

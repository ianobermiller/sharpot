﻿using System;

namespace SharpOT
{
    public enum ServerPacketType : byte
    {
        MessageOfTheDay = 0x14,
        CharacterList = 0x64,

        SelfAppear = 0x0A,
        GMAction = 0x0B,
        ErrorMessage = 0x14,
        FyiMessage = 0x15,
        WaitingList = 0x16,
        Ping = 0x1E,
        Death = 0x28,
        CanReportBugs = 0x32,
        MapDescription = 0x64,
        MoveNorth = 0x65,
        MoveEast = 0x66,
        MoveSouth = 0x67,
        MoveWest = 0x68,
        TileUpdate = 0x69,
        TileAddThing = 0x6A,
        TileTransformThing = 0x6B,
        TileRemoveThing = 0x6C,
        CreatureMove = 0x6D,
        ContainerOpen = 0x6E,
        ContainerClose = 0x6F,
        ContainerAddItem = 0x70,
        ContainerUpdateItem = 0x71,
        ContainerRemoveItem = 0x72,
        InventorySetSlot = 0x78,
        InventoryResetSlot = 0x79,
        ShopWindowOpen = 0x7A,
        ShopSaleGoldCount = 0x7B,
        ShopWindowClose = 0x7C,
        SafeTradeRequestAck = 0x7D,
        SafeTradeRequestNoAck = 0x7E,
        SafeTradeClose = 0x7F,
        WorldLight = 0x82,
        Effect = 0x83,
        AnimatedText = 0x84,
        Projectile = 0x85,
        CreatureSquare = 0x86,
        CreatureHealth = 0x8C,
        CreatureLight = 0x8D,
        CreatureOutfit = 0x8E,
        CreatureSpeed = 0x8F,
        CreatureSkull = 0x90,
        CreatureShield = 0x91,
        ItemTextWindow = 0x96,
        HouseTextWindow = 0x97,
        PlayerStatus = 0xA0,
        PlayerSkillsUpdate = 0xA1,
        PlayerFlags = 0xA2,
        CancelTarget = 0xA3,
        CreatureSpeech = 0xAA,
        ChannelList = 0xAB,
        ChannelOpen = 0xAC,
        ChannelOpenPrivate = 0xAD,
        RuleViolationOpen = 0xAE,
        RuleViolationRemove = 0xAF,
        RuleViolationCancel = 0xB0,
        RuleViolationLock = 0xB1,
        PrivateChannelCreate = 0xB2,
        ChannelClosePrivate = 0xB3,
        TextMessage = 0xB4,
        PlayerWalkCancel = 0xB5,
        FloorChangeUp = 0xBE,
        FloorChangeDown = 0xBF,
        OutfitWindow = 0xC8,
        VipState = 0xD2,
        VipLogin = 0xD3,
        VipLogout = 0xD4,
        QuestList = 0xF0,
        QuestPartList = 0xF1,
        ShowTutorial = 0xDC,
        AddMapMarker = 0xDD,
    }

    public enum ClientPacketType : byte
    {
        LoginServerRequest = 0x01,
        GameServerRequest = 0x0A,
        Logout = 0x14,
        ItemMove = 0x78,
        ShopBuy = 0x7A,
        ShopSell = 0x7B,
        ShopClose = 0x7C,
        ItemUse = 0x82,
        ItemUseOn = 0x83,
        ItemRotate = 0x85,
        LookAt = 0x8C,
        PlayerSpeech = 0x96,
        ChannelList = 0x97,
        ChannelOpen = 0x98,
        ChannelClose = 0x99,
        Attack = 0xA1,
        Follow = 0xA2,
        CancelMove = 0xBE,
        ItemUseBattlelist = 0x84,
        ContainerClose = 0x87,
        ContainerOpenParent = 0x88,
        TurnUp = 0x6F,
        TurnRight = 0x70,
        TurnDown = 0x71,
        TurnLeft = 0x72,
        AutoWalk = 0x64,
        AutoWalkCancel = 0x69,
        MoveNorth = 0x65,
        MoveEast = 0x66,
        MoveSouth = 0x67,
        MoveWest = 0x68,
        MoveNorthEast = 0x6A,
        MoveSouthEast = 0x6B,
        MoveSouthWest = 0x6C,
        MoveNorthWest = 0x6D,
        VipAdd = 0xDC,
        VipRemove = 0xDD,
        SetOutfit = 0xD3,
        Ping = 0x1E,
        FightModes = 0xA0,
        ContainerUpdate = 0xCA,
        TileUpdate = 0xC9,
        PrivateChannelOpen = 0x9A,
        NpcChannelClose = 0x9E,
    }

    public enum Effect : byte
    {
        DrawBlood = 0x00,
        LoseEnergy = 0x01,
        Puff = 0x02,
        BlockHit = 0x03,
        ExplosionArea = 0x04,
        ExplosionDamage = 0x05,
        FireArea = 0x06,
        YellowRings = 0x07,
        PoisonRings = 0x08,
        HitArea = 0x09,
        Teleport = 0x0A, 
        EnergyDamage = 0x0B, 
        MagicEnergy = 0x0C, 
        MagicBlood = 0x0D, 
        MagicPoison = 0x0E, 
        HitByFire = 0x0F, 
        Poison = 0x10, 
        MortArea = 0x11, 
        SoundGreen = 0x12, 
        SoundRed = 0x13, 
        PoisonArea = 0x14, 
        SoundYellow = 0x15, 
        SoundPurple = 0x16, 
        SoundBlue = 0x17, 
        SoundWhite = 0x18, 
        Bubbles = 0x19, 
        Craps = 0x1A, 
        GiftWraps = 0x1B, 
        FireworkYellow = 0x1C, 
        FireworkRed = 0x1D, 
        FireworkBlue = 0x1E, 
        Stun = 0x1F, 
        Sleep = 0x20, 
        WaterCreature = 0x21, 
        Groundshaker= 0x22, 
        Hearts = 0x23, 
        FireAttack = 0x24, 
        EnergyArea = 0x25, 
        SmallClouds= 0x26, 
        HolyDamage = 0x27, 
        BigClouds = 0x28, 
        IceArea = 0x29, 
        IceTornado = 0x2A, 
        IceAttack = 0x2B, 
        Stones = 0x2C, 
        SmallPlants = 0x2D, 
        Carniphilia = 0x2E, 
        PurpleEnergy = 0x2F,
        YellowEnergy = 0x30, 
        HolyArea = 0x31, 
        BigPlants = 0x32,
        Cake = 0x33,
        GiantIce = 0x34, 
        WaterSplash = 0x35, 
        PlantAttack = 0x36, 
        TutorialArrow = 0x37, 
        TutorialSquare = 0x38, 
        MirrorHorizontal = 0x39, 
        MirrorVerticle = 0x3A, 
        SkullHorizontal = 0x3B, 
        SkullVertical = 0x3C,
        Assassin = 0x3D, 
        StepsHorizontal = 0x3E, 
        BloodySteps = 0x3F, 
        StepsVertical = 0x40, 
        YalahariGhost = 0x41, 
        Bats = 0x42,
        Smoke = 0x43
    }

    public enum TextMessageType : byte
    {
        ConsoleRed = 0x12, //Red message in the console
        ConsoleOrange = 0x13, //Orange message in the console
        ConsoleOrange2 = 0x14, //Orange message in the console
        Warning = 0x15, //Red message in game window and in the console
        EventAdvance = 0x16, //White message in game window and in the console
        EventDefault = 0x17, //White message at the bottom of the game window and in the console
        StatusDefault = 0x18, //White message at the bottom of the game window and in the console
        DescriptionGreen = 0x19, //Green message in game window and in the console
        StatusSmall = 0x1A, //White message at the bottom of the game window"
        ConsoleBlue = 0x1B, //Blue message in the console
    }

    public static class LightLevel
    {
        public static byte None = 0;
        public static byte Torch = 7;
        public static byte Full = 27;
        public static byte World = 255;
    }

    public static class LightColor
    {
        public static byte None = 0;
        public static byte Default = 206; // default light color
        public static byte Orange = Default;
        public static byte White = 215;
    }

    public enum Direction : byte
    {
        North = 0,
        East,
        South,
        West,
        NorthEast,
        SouthEast,
        NorthWest,
        SouthWest
    }

    public enum Skull : byte
    {
        None = 0,
        Yellow = 1,
        Green = 2,
        White = 3,
        Red = 4,
        Black = 5
    }

    public enum Party
    {
        None = 0,
        Host = 1,
        Guest = 2,
        Member = 3,
        Leader = 4,
        MemberSharedExp = 5,
        LeaderSharedExp = 6,
        MemberSharedExpInactive = 7,
        LeaderSharedExpInactive = 8
    }
}
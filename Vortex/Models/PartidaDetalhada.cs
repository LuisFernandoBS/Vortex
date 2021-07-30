namespace Vortex.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class PartidaDetalhada
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }

        [JsonProperty("gameCreation")]
        public long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public long GameDuration { get; set; }

        [JsonProperty("queueId")]
        public long QueueId { get; set; }

        [JsonProperty("mapId")]
        public long MapId { get; set; }

        [JsonProperty("seasonId")]
        public long SeasonId { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentity> ParticipantIdentities { get; set; }
    }

    public partial class ParticipantIdentity
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("currentPlatformId")]
        public PlatformId CurrentPlatformId { get; set; }

        [JsonProperty("currentAccountId")]
        public string CurrentAccountId { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("profileIcon")]
        public long ProfileIcon { get; set; }
    }

    public partial class Participant
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("championId")]
        public long ChampionId { get; set; }

        [JsonProperty("spell1Id")]
        public long Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public long Spell2Id { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("win")]
        public bool Win { get; set; }

        [JsonProperty("item0")]
        public long Item0 { get; set; }

        [JsonProperty("item1")]
        public long Item1 { get; set; }

        [JsonProperty("item2")]
        public long Item2 { get; set; }

        [JsonProperty("item3")]
        public long Item3 { get; set; }

        [JsonProperty("item4")]
        public long Item4 { get; set; }

        [JsonProperty("item5")]
        public long Item5 { get; set; }

        [JsonProperty("item6")]
        public long Item6 { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("largestKillingSpree")]
        public long LargestKillingSpree { get; set; }

        [JsonProperty("largestMultiKill")]
        public long LargestMultiKill { get; set; }

        [JsonProperty("killingSprees")]
        public long KillingSprees { get; set; }

        [JsonProperty("longestTimeSpentLiving")]
        public long LongestTimeSpentLiving { get; set; }

        [JsonProperty("doubleKills")]
        public long DoubleKills { get; set; }

        [JsonProperty("tripleKills")]
        public long TripleKills { get; set; }

        [JsonProperty("quadraKills")]
        public long QuadraKills { get; set; }

        [JsonProperty("pentaKills")]
        public long PentaKills { get; set; }

        [JsonProperty("unrealKills")]
        public long UnrealKills { get; set; }

        [JsonProperty("totalDamageDealt")]
        public long TotalDamageDealt { get; set; }

        [JsonProperty("magicDamageDealt")]
        public long MagicDamageDealt { get; set; }

        [JsonProperty("physicalDamageDealt")]
        public long PhysicalDamageDealt { get; set; }

        [JsonProperty("trueDamageDealt")]
        public long TrueDamageDealt { get; set; }

        [JsonProperty("largestCriticalStrike")]
        public long LargestCriticalStrike { get; set; }

        [JsonProperty("totalDamageDealtToChampions")]
        public long TotalDamageDealtToChampions { get; set; }

        [JsonProperty("magicDamageDealtToChampions")]
        public long MagicDamageDealtToChampions { get; set; }

        [JsonProperty("physicalDamageDealtToChampions")]
        public long PhysicalDamageDealtToChampions { get; set; }

        [JsonProperty("trueDamageDealtToChampions")]
        public long TrueDamageDealtToChampions { get; set; }

        [JsonProperty("totalHeal")]
        public long TotalHeal { get; set; }

        [JsonProperty("totalUnitsHealed")]
        public long TotalUnitsHealed { get; set; }

        [JsonProperty("damageSelfMitigated")]
        public long DamageSelfMitigated { get; set; }

        [JsonProperty("damageDealtToObjectives")]
        public long DamageDealtToObjectives { get; set; }

        [JsonProperty("damageDealtToTurrets")]
        public long DamageDealtToTurrets { get; set; }

        [JsonProperty("visionScore")]
        public long VisionScore { get; set; }

        [JsonProperty("timeCCingOthers")]
        public long TimeCCingOthers { get; set; }

        [JsonProperty("totalDamageTaken")]
        public long TotalDamageTaken { get; set; }

        [JsonProperty("magicalDamageTaken")]
        public long MagicalDamageTaken { get; set; }

        [JsonProperty("physicalDamageTaken")]
        public long PhysicalDamageTaken { get; set; }

        [JsonProperty("trueDamageTaken")]
        public long TrueDamageTaken { get; set; }

        [JsonProperty("goldEarned")]
        public long GoldEarned { get; set; }

        [JsonProperty("goldSpent")]
        public long GoldSpent { get; set; }

        [JsonProperty("turretKills")]
        public long TurretKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [JsonProperty("totalMinionsKilled")]
        public long TotalMinionsKilled { get; set; }

        [JsonProperty("neutralMinionsKilled")]
        public long NeutralMinionsKilled { get; set; }

        [JsonProperty("totalTimeCrowdControlDealt")]
        public long TotalTimeCrowdControlDealt { get; set; }

        [JsonProperty("champLevel")]
        public long ChampLevel { get; set; }

        [JsonProperty("visionWardsBoughtInGame")]
        public long VisionWardsBoughtInGame { get; set; }

        [JsonProperty("sightWardsBoughtInGame")]
        public long SightWardsBoughtInGame { get; set; }

        [JsonProperty("firstBloodKill")]
        public bool FirstBloodKill { get; set; }

        [JsonProperty("firstBloodAssist")]
        public bool FirstBloodAssist { get; set; }

        [JsonProperty("firstTowerKill")]
        public bool FirstTowerKill { get; set; }

        [JsonProperty("firstTowerAssist")]
        public bool FirstTowerAssist { get; set; }

        [JsonProperty("firstInhibitorKill")]
        public bool FirstInhibitorKill { get; set; }

        [JsonProperty("firstInhibitorAssist")]
        public bool FirstInhibitorAssist { get; set; }

        [JsonProperty("combatPlayerScore")]
        public long CombatPlayerScore { get; set; }

        [JsonProperty("objectivePlayerScore")]
        public long ObjectivePlayerScore { get; set; }

        [JsonProperty("totalPlayerScore")]
        public long TotalPlayerScore { get; set; }

        [JsonProperty("totalScoreRank")]
        public long TotalScoreRank { get; set; }

        [JsonProperty("playerScore0")]
        public long PlayerScore0 { get; set; }

        [JsonProperty("playerScore1")]
        public long PlayerScore1 { get; set; }

        [JsonProperty("playerScore2")]
        public long PlayerScore2 { get; set; }

        [JsonProperty("playerScore3")]
        public long PlayerScore3 { get; set; }

        [JsonProperty("playerScore4")]
        public long PlayerScore4 { get; set; }

        [JsonProperty("playerScore5")]
        public long PlayerScore5 { get; set; }

        [JsonProperty("playerScore6")]
        public long PlayerScore6 { get; set; }

        [JsonProperty("playerScore7")]
        public long PlayerScore7 { get; set; }

        [JsonProperty("playerScore8")]
        public long PlayerScore8 { get; set; }

        [JsonProperty("playerScore9")]
        public long PlayerScore9 { get; set; }

        [JsonProperty("perk0")]
        public long Perk0 { get; set; }

        [JsonProperty("perk0Var1")]
        public long Perk0Var1 { get; set; }

        [JsonProperty("perk0Var2")]
        public long Perk0Var2 { get; set; }

        [JsonProperty("perk0Var3")]
        public long Perk0Var3 { get; set; }

        [JsonProperty("perk1")]
        public long Perk1 { get; set; }

        [JsonProperty("perk1Var1")]
        public long Perk1Var1 { get; set; }

        [JsonProperty("perk1Var2")]
        public long Perk1Var2 { get; set; }

        [JsonProperty("perk1Var3")]
        public long Perk1Var3 { get; set; }

        [JsonProperty("perk2")]
        public long Perk2 { get; set; }

        [JsonProperty("perk2Var1")]
        public long Perk2Var1 { get; set; }

        [JsonProperty("perk2Var2")]
        public long Perk2Var2 { get; set; }

        [JsonProperty("perk2Var3")]
        public long Perk2Var3 { get; set; }

        [JsonProperty("perk3")]
        public long Perk3 { get; set; }

        [JsonProperty("perk3Var1")]
        public long Perk3Var1 { get; set; }

        [JsonProperty("perk3Var2")]
        public long Perk3Var2 { get; set; }

        [JsonProperty("perk3Var3")]
        public long Perk3Var3 { get; set; }

        [JsonProperty("perk4")]
        public long Perk4 { get; set; }

        [JsonProperty("perk4Var1")]
        public long Perk4Var1 { get; set; }

        [JsonProperty("perk4Var2")]
        public long Perk4Var2 { get; set; }

        [JsonProperty("perk4Var3")]
        public long Perk4Var3 { get; set; }

        [JsonProperty("perk5")]
        public long Perk5 { get; set; }

        [JsonProperty("perk5Var1")]
        public long Perk5Var1 { get; set; }

        [JsonProperty("perk5Var2")]
        public long Perk5Var2 { get; set; }

        [JsonProperty("perk5Var3")]
        public long Perk5Var3 { get; set; }

        [JsonProperty("perkPrimaryStyle")]
        public long PerkPrimaryStyle { get; set; }

        [JsonProperty("perkSubStyle")]
        public long PerkSubStyle { get; set; }

        [JsonProperty("statPerk0")]
        public long StatPerk0 { get; set; }

        [JsonProperty("statPerk1")]
        public long StatPerk1 { get; set; }

        [JsonProperty("statPerk2")]
        public long StatPerk2 { get; set; }
    }

    public partial class Timeline
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("creepsPerMinDeltas")]
        public PerMinDeltas CreepsPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public PerMinDeltas XpPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public PerMinDeltas GoldPerMinDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public PerMinDeltas CsDiffPerMinDeltas { get; set; }

        [JsonProperty("xpDiffPerMinDeltas")]
        public PerMinDeltas XpDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public PerMinDeltas DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public PerMinDeltas DamageTakenDiffPerMinDeltas { get; set; }

        [JsonProperty("role")]
        public Role Role { get; set; }

        [JsonProperty("lane")]
        public Lane Lane { get; set; }
    }

    public partial class PerMinDeltas
    {
        [JsonProperty("0-10")]
        public double The010 { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("teamId")]
        public long TeamId { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("towerKills")]
        public long TowerKills { get; set; }

        [JsonProperty("inhibitorKills")]
        public long InhibitorKills { get; set; }

        [JsonProperty("baronKills")]
        public long BaronKills { get; set; }

        [JsonProperty("dragonKills")]
        public long DragonKills { get; set; }

        [JsonProperty("vilemawKills")]
        public long VilemawKills { get; set; }

        [JsonProperty("riftHeraldKills")]
        public long RiftHeraldKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public long DominionVictoryScore { get; set; }

        [JsonProperty("bans")]
        public List<object> Bans { get; set; }
    }

    public enum PlatformId { Br1 };

    public enum Lane { None };

    public enum Role { DuoSupport };

    internal class PlatformIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PlatformId) || t == typeof(PlatformId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "BR1")
            {
                return PlatformId.Br1;
            }
            throw new Exception("Cannot unmarshal type PlatformId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PlatformId)untypedValue;
            if (value == PlatformId.Br1)
            {
                serializer.Serialize(writer, "BR1");
                return;
            }
            throw new Exception("Cannot marshal type PlatformId");
        }

        public static readonly PlatformIdConverter Singleton = new PlatformIdConverter();
    }

    internal class LaneConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lane) || t == typeof(Lane?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NONE")
            {
                return Lane.None;
            }
            throw new Exception("Cannot unmarshal type Lane");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Lane)untypedValue;
            if (value == Lane.None)
            {
                serializer.Serialize(writer, "NONE");
                return;
            }
            throw new Exception("Cannot marshal type Lane");
        }

        public static readonly LaneConverter Singleton = new LaneConverter();
    }

    internal class RoleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Role) || t == typeof(Role?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "DUO_SUPPORT")
            {
                return Role.DuoSupport;
            }
            throw new Exception("Cannot unmarshal type Role");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Role)untypedValue;
            if (value == Role.DuoSupport)
            {
                serializer.Serialize(writer, "DUO_SUPPORT");
                return;
            }
            throw new Exception("Cannot marshal type Role");
        }

        public static readonly RoleConverter Singleton = new RoleConverter();
    }
}

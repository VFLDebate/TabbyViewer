using System.Text.Json.Serialization;

namespace TabbyViewer.Api
{
    public class Schemas
    {
        //Get Classes
        public class Institution
        {
            public int? Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Region { get; set; }
        }

        public class TournamentInstitution
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Region { get; set; }
            public string[] Teams { get; set; }
            public string[] Adjudicators { get; set; }
        }

        public class Tournament
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string[] CurrentRounds { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public int Sequence { get; set; }
            public string Slug { get; set; }
            public bool IsActive { get; set; }
        }

        public class Checkin
        {
            public string Object { get; set; }
            public int Barcode { get; set; }
            public bool Checked { get; set; }
            public string TimeStamp { get; set; }
        }

        public class Adjudicator
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool Anonymous { get; set; }
            public string Pronouns { get; set; }
            public string Institution { get; set; }
            public float BaseScore { get; set; }
            public bool Breaking { get; set; }
            public bool Trainee { get; set; }
            public bool Independent { get; set; }
            public bool AdjudicationCore { get; set; }
            public string[] InstitutionConflicts { get; set; }
            public string[] TeamConflicts { get; set; }
            public string[] AdjudicatorConflicts { get; set; }
            public string UrlKey { get; set; }
            public Dictionary<string, string> Links { get; set; }
        }

        public class MotionRound
        {
            public string Round { get; set; }
            public int Sequence { get; set; }
        }

        public class Motion
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public MotionRound Rounds { get; set; }
            public string Text { get; set; }
            public string Reference { get; set; }
            public string InfoSlide { get; set; }
        }

        public class RoundMotion
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Text { get; set; }
            public string Reference { get; set; }
            public string InfoSlide { get; set; }
        }

        public class Round
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string BreakCategory { get; set; }
            public RoundMotion Motions { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public int Sequence { get; set; }
            public bool IsCompleted { get; set; }
            public string Name { get; set; }
            public string Abbreviation { get; set; }
            public string[] Stage { get; set; }
            public string[] DrawType { get; set; }
            public string[] DrawStatus { get; set; }
            public float FeedbackWeight { get; set; }
            public bool IsSilent { get; set; }
            public bool IsMotionsReleased { get; set; }
            public string StartsAt { get; set; }
            public int Weight { get; set; }
        }

        public class Speaker
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public bool IsAnonymous { get; set; }
            public string Pronouns { get; set; }
            public string[] Categories { get; set; }
            public string UrlKey { get; set; }
            [JsonPropertyName("_links")] public Dictionary<string, string> Links { get; set; }
        }

        public class Team
        {
            public string Url { get; set; }
            public int Id { get; set; }
            public string Reference { get; set; }
            public string ShortReference { get; set; }
            public string CodeName { get; set; }
            public string Emoji { get; set; }
            public string ShortName { get; set; }
            public string LongName { get; set; }
            public string Institution { get; set; }
            public Speaker[] Speakers { get; set; }
            public bool UseInstitutionPrefix { get; set; }
            public string[] BreakCategories { get; set; }
            public string[] InstitutionConflicts { get; set; }
        }

        public class Venue
        {
            public string Url { get; set; }
            public int Id { get; set; }
            public string[] Categories { get; set; }
            public string DisplayName { get; set; }
            public Dictionary<string, string> Links { get; set; }
            public string Name { get; set; }
            public int Priority { get; set; }
            public string ExternalUrl { get; set; }
        }
    }
}
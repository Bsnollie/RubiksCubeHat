using System.Linq;
using System.IO;

namespace DuckGame.RubiksCubeHat
{
    public class RubiksCubeHat : ClientMod
    {
        public override Priority priority
        {
            get
            {
                return Priority.HatPack;
            }
        }

        protected override void OnPostInitialize()
        {
            Team[] teams = new Team[]
            {
                Team.Deserialize(GetPath<RubiksCubeHat>("hats/Rubiks S.png")),
                Team.Deserialize(GetPath<RubiksCubeHat>("hats/Rubiks S+.png")),
                Team.Deserialize(GetPath<RubiksCubeHat>("hats/Rubiks.png")),
                Team.Deserialize(GetPath<RubiksCubeHat>("hats/Rubiks+.png"))
            };

            foreach (Team team in teams)
            {
                if (team != null)
                {
                    Teams.AddExtraTeam(team);
                }
            }

            base.OnPostInitialize();
        }
    }
}
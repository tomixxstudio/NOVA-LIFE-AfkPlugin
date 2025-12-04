using NovaLifeServer.API;
using NovaLifeServer.API.Enums;
using NovaLifeServer.API.Features;
using NovaLifeServer.API.Interfaces;
using NovaLifeServer.API.Player;
using NovaLifeServer.API.UI;
using System.IO;
using Newtonsoft.Json;

namespace TomixxStudioPlugins
{
    public class TSAFKSystem : Plugin
    {
        public override string Author => "TomixxStudio";
        public override string Name => "TS-AFK SYSTEME";
        public override Version Version => new Version(1, 0, 0);

        private Config config;

        public override void OnEnabled()
        {
            LoadConfig();

            Server.Log("TS-AFK SYSTEME chargé avec succès !");

            // Commande /afk
            Command.Register("afk", "Se mettre AFK", (player, args) =>
            {
                SetAFK(player);
            });

            // Commande /unafk
            Command.Register("unafk", "Quitter l'état AFK", (player, args) =>
            {
                UnAFK(player);
            });
        }

        private void LoadConfig()
        {
            string path = Path.Combine(PluginDirectory, "config.json");

            if (!File.Exists(path))
            {
                config = new Config();
                File.WriteAllText(path, JsonConvert.SerializeObject(config, Formatting.Indented));
            }
            else
            {
                config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));
            }
        }

        private void SetAFK(Player player)
        {
            // Téléportation
            player.Teleport(new Vector3(config.AFKPosition.x, config.AFKPosition.y, config.AFKPosition.z));

            // UI d'AFK
            UIFrame frame = new UIFrame("afk_screen", UIAnchor.MiddleCenter, new Vector2(600, 200))
            {
                BackgroundColor = new UIColor(0, 0, 0, 180)
            };

            frame.AddText("AFK", 45, UIColor.red, UIAnchor.TopCenter, new Vector2(0, -20));
            frame.AddText("Tu es désormais AFK", 26, UIColor.white, UIAnchor.MiddleCenter, new Vector2(0, 40));
            player.ShowUI(frame);

            player.SendChatMessage("§cTu es désormais AFK.");
        }

        private void UnAFK(Player player)
        {
            // Téléportation
            player.Teleport(new Vector3(config.CityHallPosition.x, config.CityHallPosition.y, config.CityHallPosition.z));

            // Enlever l'UI
            player.DestroyUI("afk_screen");

            player.SendChatMessage("§aTu n'es plus AFK !");
        }
    }

    public class Config
    {
        public Position AFKPosition { get; set; } = new Position() { x = 0, y = -100, z = 0 };
        public Position CityHallPosition { get; set; } = new Position() { x = 200, y = 50, z = 300 };
    }

    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }
}

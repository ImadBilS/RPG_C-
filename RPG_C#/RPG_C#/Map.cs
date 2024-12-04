using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Reflection.Emit;

namespace test_diminution
{
    public partial class Map : Form
    {
        // Fields and Properties
        private Dictionary<string, Image> images = new Dictionary<string, Image>();
        private int step = 4; // Ajuster la taille de chaque pas
        private int mapWidth = 1792;
        private int mapHeight = 768;
        private int tileSize = 64; // Taille de chaque tuile sur la carte
        private HashSet<string> inaccessibleTiles = new HashSet<string> {
            "water_full",
            "water_lilypad"
        };
        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private bool isMovingLeft = false;
        private bool isMovingRight = false;

        private string actualLevel = "level2";
        private string cheminActualLevel = "";
        private string actualMap = "map1";
        private string levelObjectsCsv = @"map\map1_"; // Chemin des CSV de niveaux

        private bool wasMoving = false; // Nouveau champ pour garder la trace du statut précédent du mouvement

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Point currentLocation = pb_player.Location;
            int newX = currentLocation.X;
            int newY = currentLocation.Y;

            // Correction des directions
            bool isMoving = false;

            // Gestion des combinaisons de mouvements et des gifs appropriés
            if (isMovingUp && isMovingRight)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_up_right.gif");
                newY -= step;
                newX += step;
                isMoving = true;
            }
            else if (isMovingUp && isMovingLeft)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_up_left.gif");
                newY -= step;
                newX -= step;
                isMoving = true;
            }
            else if (isMovingDown && isMovingRight)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_down_right.gif");
                newY += step;
                newX += step;
                isMoving = true;
            }
            else if (isMovingDown && isMovingLeft)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_down_left.gif");
                newY += step;
                newX -= step;
                isMoving = true;
            }
            else if (isMovingUp)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_up.gif");
                newY -= step;
                isMoving = true;
            }
            else if (isMovingDown)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_down.gif");
                newY += step;
                isMoving = true;
            }
            else if (isMovingLeft)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_left.gif");
                newX -= step;
                isMoving = true;
            }
            else if (isMovingRight)
            {
                SetGifAnimation(pb_player, @"img\entity\player\move_right.gif");
                newX += step;
                isMoving = true;
            }
            else
            {
                // Si le joueur ne bouge pas, afficher le gif "afk"
                if (wasMoving) // N'applique le gif afk que si le joueur était en mouvement avant
                {
                    SetGifAnimation(pb_player, @"img\entity\player\afk.png");
                }
            }

            // Limiter la position du joueur aux limites de la carte
            newX = Math.Max(0, Math.Min(newX, mapWidth - pb_player.Width));
            newY = Math.Max(0, Math.Min(newY, 704));

            wasMoving = isMoving;

            Point newLocation = new Point(newX, newY);

            if (IsTileAccessible(newLocation))
            {
                pb_player.Location = newLocation;
                HandleLevelTransition(newLocation);
                HandleObjectInteraction(newLocation);
            }
        }

        private void HandleLevelTransition(Point playerLocation)
        {
            int maxX = mapWidth - pb_player.Width;
            int maxY = 704; // Limite maximale du joueur sur l'axe Y

            if (actualLevel == "level1")
            {
                if (playerLocation.Y >= maxY) // Basculer vers level 2 en bas
                {
                    ChangementMapGestion(playerLocation.X, 0, 2);
                }
                else if (playerLocation.X <= 0) // Basculer vers level 3 à gauche
                {
                    ChangementMapGestion(maxX, playerLocation.Y, 3);
                }
            }
            else if (actualLevel == "level2")
            {
                if (playerLocation.Y <= 0) // Basculer vers level 1 en haut
                {
                    ChangementMapGestion(playerLocation.X, maxY, 1);
                }
            }
            else if (actualLevel == "level3")
            {
                if (playerLocation.X >= maxX) // Basculer vers level 1 à droite
                {
                    ChangementMapGestion(4, 204, 1);
                }
                else if (playerLocation.Y >= maxY) // Basculer vers level 4 en bas
                {
                    ChangementMapGestion(playerLocation.X, 0, 4);
                }
            }
            else if (actualLevel == "level4")
            {
                if (playerLocation.Y <= 0) // Basculer vers level 3 en haut
                {
                    ChangementMapGestion(playerLocation.X, maxY, 3);
                }
            }
        }

        private void ChangementMapGestion(int posX, int posY, int niveau)
        {
            actualLevel = "level" + niveau.ToString();
            LoadMap();
            pb_player.Location = new Point(posX, posY); // Positionner en bas
            SetGifAnimation(pb_player, @"img\entity\player\afk.png");
            LoadImages();
            LoadObjects();
        }

        private void SetGifAnimation(PictureBox pictureBox, string gifPath)
        {
            if (pictureBox.Tag == null || pictureBox.Tag.ToString() != gifPath)
            {
                pictureBox.Image = Image.FromFile(gifPath);
                pictureBox.Tag = gifPath;
            }
        }

        private bool IsTileAccessible(Point targetLocation)
        {
            int characterWidth = pb_player.Width;
            int characterHeight = pb_player.Height;

            var corners = new List<Point>
            {
                new Point(targetLocation.X / tileSize, targetLocation.Y / tileSize),
                new Point((targetLocation.X + characterWidth - 1) / tileSize, targetLocation.Y / tileSize),
                new Point(targetLocation.X / tileSize, (targetLocation.Y + characterHeight - 1) / tileSize),
                new Point((targetLocation.X + characterWidth - 1) / tileSize, (targetLocation.Y + characterHeight - 1) / tileSize)
            };

            foreach (var corner in corners)
            {
                string pictureBoxName = $"X{corner.X}Y{corner.Y}";
                var pictureBox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

                if (pictureBox == null || inaccessibleTiles.Contains(pictureBox.Tag?.ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        // Constructor
        public Map()
        {
            InitializeComponent();
            this.KeyDown += Map_KeyDown; // Ajoute l'événement KeyDown
            this.KeyUp += Map_KeyUp; // Ajoute l'événement KeyUp
            this.KeyPreview = true; // Permet au formulaire de gérer les touches avant les contrôles enfants

            // Initialisation du Timer
            moveTimer.Interval = 20;
            moveTimer.Tick += MoveTimer_Tick;
        }

        // Form Load Event
        private void Map_Load(object sender, EventArgs e)
        {
            LoadImages();
            LoadObjects();
            LoadMap();

            for (int y = 0; y < 12; y++) // 12 lignes : Y0 à Y11
            {
                for (int x = 0; x < 28; x++) // 28 colonnes : X0 à X27
                {
                    string name = $"X{x}Y{y}";
                    var pictureBox = this.Controls.Find(name, true).FirstOrDefault() as PictureBox;

                    if (pictureBox != null)
                    {
                        pictureBox.Location = new System.Drawing.Point(x * 64, y * 64);
                        pictureBox.Size = new System.Drawing.Size(64, 64);
                    }
                }
            }

            pb_player.Size = new System.Drawing.Size(64, 64);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.Focus();
        }

        // Load Images
        private void LoadImages()
        {
            //ne peux pas aller
            images["water_full"] = Image.FromFile(@"img\map\water_full.png");
            images["water_lilypad"] = Image.FromFile(@"img\map\water_lilypad.png");
            images["g_c_l_u_w"] = Image.FromFile(@"img\map\grass_corner_left_up_water.png");
            images["w_c_r_d_g"] = Image.FromFile(@"img\map\water_corner_right_down_grass.png");
            images["w_c_l_u_g"] = Image.FromFile(@"img\map\water_corner_left_up_grass.png");
            images["g_c_r_d_w"] = Image.FromFile(@"img\map\grass_corner_right_down_water.png");
            images["g_c_r_u_w"] = Image.FromFile(@"img\map\grass_corner_right_up_water.png");
            images["w_c_l_d_g"] = Image.FromFile(@"img\map\water_corner_left_down_grass.png");
            images["w_c_r_u_g"] = Image.FromFile(@"img\map\water_corner_right_up_grass.png");
            images["g_c_l_d_w"] = Image.FromFile(@"img\map\grass_corner_left_down_water.png");
            images["c_l_1_l"] = Image.FromFile(@"img\map\custom_link_1_l.png");
            images["c_l_1_r"] = Image.FromFile(@"img\map\custom_link_1_r.png");
            images["c_l_2_l"] = Image.FromFile(@"img\map\custom_link_2_l.png");
            images["c_l_2_r"] = Image.FromFile(@"img\map\custom_link_2_r.png");
            images["c_l_2_l_rt"] = Image.FromFile(@"img\map\custom_link_2_l_rt.png");
            images["c_l_2_r_rt"] = Image.FromFile(@"img\map\custom_link_2_r_rt.png");
            images["c_l_1_l_rt"] = Image.FromFile(@"img\map\custom_link_1_l_rt.png");
            images["c_l_1_r_rt"] = Image.FromFile(@"img\map\custom_link_1_r_rt.png");
            images["water_grass"] = Image.FromFile(@"img\map\water_grass.png");
            images["grass_water"] = Image.FromFile(@"img\map\grass_water.png");
            images["water_grass_ud"] = Image.FromFile(@"img\map\water_grass_ud.png");
            images["grass_water_ud"] = Image.FromFile(@"img\map\grass_water_ud.png");

            //peux aller
            images["grass_full"] = Image.FromFile(@"img\map\grass_full.png");
            images["chemin_debout"] = Image.FromFile(@"img\map\chemin_debout.png");
            images["chemin_couche"] = Image.FromFile(@"img\map\chemin_couche.png");
            images["chemin_t_d"] = Image.FromFile(@"img\map\chemin_t_down.png");
            images["chemin_t_l"] = Image.FromFile(@"img\map\chemin_t_l.png");
            images["chemin_t_r"] = Image.FromFile(@"img\map\chemin_t_r.png");
            images["chemin_t_up"] = Image.FromFile(@"img\map\chemin_t_up.png");
            images["chemin_turn_ld"] = Image.FromFile(@"img\map\chemin_turn_ld.png");
            images["chemin_turn_lu"] = Image.FromFile(@"img\map\chemin_turn_lu.png");
            images["chemin_turn_rd"] = Image.FromFile(@"img\map\chemin_turn_rd.png");
            images["chemin_turn_ru"] = Image.FromFile(@"img\map\chemin_turn_ru.png");
            images["link_top"] = Image.FromFile(@"img\map\link_top.png");
            images["link_bottom"] = Image.FromFile(@"img\map\link_bottom.png");
            images["link_l"] = Image.FromFile(@"img\map\link_l.png");
            images["link_r"] = Image.FromFile(@"img\map\link_r.png");
            images["void"] = Image.FromFile(@"img\map\void.png");

        }

        private void LoadMap()
        {
            // Construire le chemin du fichier CSV en fonction du niveau actuel
            cheminActualLevel = @"map\" + actualMap + "_" + actualLevel + ".csv";
            if (!File.Exists(cheminActualLevel))
            {
                MessageBox.Show("Fichier de map introuvable !");
                return;
            }

            // Effacer toutes les images des PictureBox avant de recharger la carte
            foreach (Control control in panel1.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null; // Clear the image entirely
                }
            }

            // Lire les lignes du fichier CSV
            var lines = File.ReadAllLines(cheminActualLevel);
            int y = 0; // Indice pour les lignes (Y)

            foreach (var line in lines)
            {
                // Diviser la ligne en types de cases séparées par des points-virgules
                var cellTypes = line.Split(';');
                for (int x = 0; x < cellTypes.Length; x++)
                {
                    string imageType = cellTypes[x].Trim(); // Récupérer le type de case

                    // Construire le nom du PictureBox correspondant (X0Y0, X1Y0, ...)
                    string pictureBoxName = $"X{x}Y{y}";

                    // Trouver la PictureBox dans les contrôles du formulaire
                    var pictureBox = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
                    if (pictureBox != null && images.ContainsKey(imageType))
                    {
                        // Appliquer l'image à la PictureBox
                        pictureBox.Image = images[imageType];
                        pictureBox.Tag = imageType; // Stocke le type de case dans la propriété Tag
                    }
                }
                y++; // Passer à la ligne suivante (Y)
            }
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            // Arrêt du mouvement lorsque la touche est relâchée
            if (e.KeyCode == Keys.Z) isMovingUp = false;
            if (e.KeyCode == Keys.S) isMovingDown = false;
            if (e.KeyCode == Keys.Q) isMovingLeft = false;
            if (e.KeyCode == Keys.D) isMovingRight = false;

            // Arrêter le timer si aucun mouvement n'est actif
            if (!isMovingUp && !isMovingDown && !isMovingLeft && !isMovingRight)
            {
                moveTimer.Stop();
                SetGifAnimation(pb_player, @"img\entity\player\afk.png");
            }
        }

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            // Début du mouvement lorsque la touche est enfoncée
            if (e.KeyCode == Keys.Z)
            {
                isMovingUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                isMovingDown = true;
            }
            if (e.KeyCode == Keys.Q)
            {
                isMovingLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                isMovingRight = true;
            }

            // Démarrer le timer si aucun mouvement n'est actif
            if (!moveTimer.Enabled)
            {
                moveTimer.Start();
            }
        }

        private void LoadObjects()
        {
            // Utiliser actualLevel pour déterminer le bon fichier CSV des objets
            string csvPath = levelObjectsCsv + actualLevel + "_data.csv";
            if (!File.Exists(csvPath))
            {
                MessageBox.Show("Fichier d'objets de niveau introuvable !");
                return;
            }

            var lines = File.ReadAllLines(csvPath);
            int chestIndex = 1;
            int monsterIndex = 1;

            // Désactiver toutes les PictureBox inutilisées au début
            for (int i = 1; i <= 4; i++)
            {
                var chest = this.Controls.Find($"pb_chest_{i}", true).FirstOrDefault() as PictureBox;
                if (chest != null)
                {
                    chest.Visible = false;
                }
                var monster = this.Controls.Find($"pb_monster_{i}", true).FirstOrDefault() as PictureBox;
                if (monster != null)
                {
                    monster.Visible = false;
                }
            }

            // Recharger les objets pour le niveau actuel
            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length < 5) continue;

                string type = parts[0];
                int x = int.Parse(parts[1]);
                int y = int.Parse(parts[2]);
                string state = parts[3];

                if (type == "chest" && chestIndex <= 4)
                {
                    LoadChest(x, y, state, chestIndex);
                    chestIndex++;
                }
                else if (type == "monster" && monsterIndex <= 4)
                {
                    LoadMonster(x, y, state, monsterIndex);
                    monsterIndex++;
                }
            }
        }

        private void LoadChest(int x, int y, string state, int index)
        {
            PictureBox chestPictureBox = this.Controls.Find($"pb_chest_{index}", true).FirstOrDefault() as PictureBox;
            if (chestPictureBox == null) return;

            chestPictureBox.Visible = true;
            chestPictureBox.Location = new Point(x, y);
            chestPictureBox.Size = new Size(64, 64);

            if (state == "closed")
            {
                chestPictureBox.Image = Image.FromFile(@"img\map\content\chest_closed.png");
                chestPictureBox.Tag = "closed";
            }
            else if (state == "open")
            {
                chestPictureBox.Image = Image.FromFile(@"img\map\content\chest_open.png");
                chestPictureBox.Tag = "open";
            }
        }

        private void LoadMonster(int x, int y, string state, int index)
        {
            PictureBox monsterPictureBox = this.Controls.Find($"pb_monster_{index}", true).FirstOrDefault() as PictureBox;
            if (monsterPictureBox == null) return;

            monsterPictureBox.Visible = true;
            monsterPictureBox.Location = new Point(x, y);
            monsterPictureBox.Size = new Size(64, 64);

            if (state == "alive")
            {
                monsterPictureBox.Image = Image.FromFile($@"img\map\content\monster{index}.png");
                monsterPictureBox.Tag = "alive";
            }
            else if (state == "defeated")
            {
                monsterPictureBox.Image = null; // Pas d'image si le monstre est mort
                monsterPictureBox.Tag = "defeated";
                monsterPictureBox.Visible = false; // Rendre invisible si le monstre est mort
            }
        }

        // Nouveau champ pour éviter la répétition des messages
        private bool isInteracting = false;

        private void HandleObjectInteraction(Point playerLocation)
        {
            if (isInteracting) return; // Si une interaction est en cours, ignorer

            for (int i = 1; i <= 4; i++)
            {
                PictureBox chest = this.Controls.Find($"pb_chest_{i}", true).FirstOrDefault() as PictureBox;
                if (chest != null && chest.Visible && chest.Bounds.IntersectsWith(pb_player.Bounds) && chest.Tag.ToString() == "closed")
                {
                    isInteracting = true; // Commence une interaction
                    moveTimer.Stop(); // Arrête le mouvement du joueur
                    MessageBox.Show("Vous avez récupéré le contenu du coffre !");
                    chest.Image = Image.FromFile(@"img\map\content\chest_open.png");
                    chest.Tag = "open";
                    UpdateObjectState("chest", i.ToString(), "open"); // Mise à jour du fichier CSV

                    isMovingDown = false;
                    isMovingLeft = false;
                    isMovingRight = false;
                    isMovingUp = false;

                    moveTimer.Stop();
                    SetGifAnimation(pb_player, @"img\entity\player\afk.png");

                    isInteracting = false; // Termine l'interaction
                    return; // On s'arrête ici pour ne pas enchaîner plusieurs interactions à la fois
                }

                PictureBox monster = this.Controls.Find($"pb_monster_{i}", true).FirstOrDefault() as PictureBox;
                if (monster != null && monster.Visible && monster.Bounds.IntersectsWith(pb_player.Bounds) && monster.Tag.ToString() == "alive")
                {
                    isInteracting = true; // Commence une interaction
                    moveTimer.Stop(); // Arrête le mouvement du joueur
                    MessageBox.Show("Vous avez vaincu le monstre !");
                    monster.Image = null; // Le monstre est battu, il n'a plus d'image
                    monster.Tag = "defeated";
                    monster.Visible = false;
                    UpdateObjectState("monster", i.ToString(), "defeated");

                    isMovingDown = false;
                    isMovingLeft = false;
                    isMovingRight = false;
                    isMovingUp = false;

                    moveTimer.Stop();
                    SetGifAnimation(pb_player, @"img\entity\player\afk.png");

                    isInteracting = false; // Termine l'interaction
                    return; // On s'arrête ici pour ne pas enchaîner plusieurs interactions à la fois
                }
            }
        }

        private void UpdateObjectState(string type, string identifier, string newState)
        {
            // Utiliser actualLevel pour déterminer le bon fichier CSV des objets
            string csvPath = levelObjectsCsv + actualLevel + "_data.csv";

            // Lire toutes les lignes du fichier CSV
            var lines = File.ReadAllLines(csvPath);
            var updatedLines = new List<string>();

            foreach (var line in lines)
            {
                // Diviser chaque ligne pour obtenir les détails de l'objet
                var parts = line.Split(';');
                if (parts.Length < 5)
                {
                    updatedLines.Add(line);
                    continue;
                }

                // Mettre à jour l'état de l'objet si le type et l'identifiant correspondent
                if (parts[0] == type && parts[4] == identifier)
                {
                    parts[3] = newState; // Mise à jour de l'état
                    updatedLines.Add(string.Join(";", parts)); // Reconstituer la ligne avec les nouvelles informations
                }
                else
                {
                    updatedLines.Add(line); // Ajouter la ligne sans modification
                }
            }

            // Réécrire le fichier CSV avec les lignes mises à jour
            File.WriteAllLines(csvPath, updatedLines);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kill_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

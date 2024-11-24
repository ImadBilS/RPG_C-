using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;


namespace RPG_C_
{
    public partial class FormInventoryTest : Form
    {
        private string inventory = @"inventory.csv";
        public FormInventoryTest()
        {
            InitializeComponent();

        }
        private void FormInventoryTest_Load(object sender, EventArgs e)
        {
            
            listView1.View = View.Details;

            // Ajouter des colonnes si ce n'est pas déjà fait
            listView1.Columns.Add("Nom", 100);
            listView1.Columns.Add("Quantité", 100);
            listView1.Columns.Add("Description", 250);
            listView1.Columns.Add("Taux de Drop", 100);
            listView1.Columns.Add("TYPE", 200);


            // Parcours des objets dans Global.PlayerItems et ajout à la ListView
            //foreach (Item item in Global.PlayerItems)
            /*
            foreach (Item item in Global.playerItemsDictionary)
                {
                    ListViewItem listViewItem = new ListViewItem(item.GetName());
                listViewItem.SubItems.Add(item.GetQuantity().ToString());
                listViewItem.SubItems.Add(item.GetDescription());
                listViewItem.SubItems.Add(item.GetDropRate().ToString());

                // Ajout de l'élément à la ListView
                listView1.Items.Add(listViewItem);
            }
            */

            foreach (KeyValuePair<string, Item> kvp in Global.playerItemsDictionary)
            {
                Item item = kvp.Value;

                ListViewItem listViewItem = new ListViewItem(item.GetName());
                listViewItem.SubItems.Add(item.GetQuantity().ToString());
                listViewItem.SubItems.Add(item.GetDescription());
                listViewItem.SubItems.Add(item.GetDropRate().ToString());
                listViewItem.SubItems.Add(item.GetType().ToString());


                // Ajout de l'élément à la ListView
                listView1.Items.Add(listViewItem);
            }

            /*
            
            // Chemin du fichier CSV
            string filePath = @"inventory.csv";

            // Vérifier si le fichier existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Le fichier inventory.csv n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Effacer les items précédents de la ListView et de la liste globale
            listView1.Items.Clear();
            Global.PlayerItems.Clear();

            try
            {
                // Lecture du fichier CSV
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines.Skip(1)) // Ignorer l'en-tête
                {
                    var columns = line.Split(',');

                    if (columns.Length < 5) // Vérifier qu'il y a au moins 5 colonnes
                        continue;

                    string type = columns[0];
                    string name = columns[1];
                    int quantity = int.Parse(columns[2]);
                    string description = columns[3];
                    float dropRate = float.Parse(columns[4], CultureInfo.InvariantCulture);


                    // Créer un item en fonction du type
                    Item item = type switch
                    {
                        "LifePotion" => new LifePotion(name, quantity, description, dropRate, int.Parse(columns[5])),
                        "CocaShield" => new CocaShield(name, quantity, description, dropRate, int.Parse(columns[5])),
                        "Sword" => new Sword(name, quantity, description, dropRate, int.Parse(columns[5]), int.Parse(columns[6]), bool.Parse(columns[7])),
                        "Armor" => new Armor(name, quantity, description, dropRate, int.Parse(columns[5]), int.Parse(columns[6])),
                        "HolyPotion" => new HolyPotion(name, quantity, description, dropRate, int.Parse(columns[5]), int.Parse(columns[6])),
                        _ => throw new ArgumentException("Type d'objet invalide")
                    };

                    if (item != null)
                    {
                        // Ajouter l'item à la liste globale
                        Global.PlayerItems.Add(item);

                        // Ajouter l'item à la ListView
                        ListViewItem listViewItem = new ListViewItem(item.GetName());
                        listViewItem.SubItems.Add(item.GetQuantity().ToString());
                        listViewItem.SubItems.Add(item.GetDescription());
                        listViewItem.SubItems.Add(item.GetDropRate().ToString("F2"));

                        listView1.Items.Add(listViewItem);
                    }
                }

                MessageBox.Show("Inventaire chargé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors du chargement de l'inventaire : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }
    }
}

using PetriNets.Controller;
using PetriNets.Controller.Entities;
using PetriNets.Controller.Entities.Examples;
using PetriNets.Controller.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetriNets.Forms
{
    public partial class PetriNetForm : Form
    {
        private PetriNet petriNet = new PetriNet();
        private OpenFileDialog dialog;

        public PetriNetForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            dialog = new OpenFileDialog()
            {
                Filter = "Arquivos de texto (*.txt)|*.txt|Arquivos xml (*.xml)|*.xml|Arquivos pmnl (*.pmnl)|*.pmnl",
                Title = "Selecionar arquivo"
            };
        }

        private void petriNet_Load(object sender, EventArgs e)
        {
            ConnType_PlaceTrasition_ComboBox.DataSource = new BindingList<ConnectionType>(new[] {
                ConnectionType.Normal
                ,ConnectionType.Inibidor
                ,ConnectionType.Reset
            });

            LoadExamples_ComboBox.DataSource = new BindingList<string>(new[] {
                "",
                "Arco Reset",
                "Enunciado",
                "Padrão"
            });

            loadPetriNetScreen();
        }

        private void loadPetriNetScreen()
        {
            laodPlaceToTransition();
            loadTransitionToPlace();

            //mostra itens da tabela
            drawTable();

            //mostra conexoes da rede
            updateConnections();
        }

        private void loadTransitionToPlace()
        {
            ConnIdPlace_TrasitionPlace_ComboBox.DataSource = petriNet.Places.Select(x => x.Id).ToList();
            ConnIdTransition_TrasitionPlace_ComboBox.DataSource = petriNet.Transitions.Select(x => x.Id).ToList();
        }

        private void laodPlaceToTransition()
        {
            ConnIdPlace_PlaceTrasition_ComboBox.DataSource = petriNet.Places.Select(x => x.Id).ToList();
            ConnIdTransition_PlaceTrasition_ComboBox.DataSource = petriNet.Transitions.Select(x => x.Id).ToList();
        }

        private void updateConnections()
        {
            Connections_Label.Text = petriNet.GetConnectionsInfo();
            RunCycle_Button.Enabled = true;
            RunAllCycle_Button.Enabled = true;
        }

        private void drawTable()
        {
            clearGrid();
            createTable();
        }

        private void clearComponents()
        {
            Connections_Label.Text = " ";
            ConnIdPlace_PlaceTrasition_ComboBox.DataSource = null;
            ConnIdTransition_TrasitionPlace_ComboBox.DataSource = null;
            ConnIdPlace_TrasitionPlace_ComboBox.DataSource = null;
            ConnIdTransition_PlaceTrasition_ComboBox.DataSource = null;
        }

        private void createTable()
        {
            createColumnCycle();

            foreach (var placeAndTransation in petriNet.PlaceAndTransitionsGrid)
            {
                DataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = placeAndTransation.Key,
                    HeaderText = placeAndTransation.Key,
                    Width = 100
                });
            }

            DataGridView.Rows.Add((new[] { petriNet.CurrentCycle.ToString() })
                             .Concat(petriNet.PlaceAndTransitionsGrid.Select(pt => pt.Value))
                             .ToArray());
        }

        private void createColumnCycle()
        {
            DataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ciclo",
                Width = 100
            });
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            clearGrid();
            clearComponents();
            petriNet = new PetriNet();
            createColumnCycle();
        }

        private void clearGrid()
        {
            DataGridView.Columns.Clear();
            DataGridView.Rows.Clear();
        }

        private void createPlace_Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdPlace_TextBox.Text, out var id))
                return;

            petriNet.CreatePlace(id, Convert.ToInt32(MarkPlace_NumericUpDown.Value));

            drawTable();

            loadTransitionToPlace();
            laodPlaceToTransition();
            IdPlace_TextBox.Text = null;
            MarkPlace_NumericUpDown.Value = 0;
        }

        private void createTransition_Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdTransition_TextBox.Text, out var id))
                return;

            petriNet.CreateTransition(id);

            drawTable();

            loadTransitionToPlace();
            laodPlaceToTransition();
            IdTransition_TextBox.Text = null;
        }

        private void connCreate_PlaceTrasition_Button_Click(object sender, EventArgs e)
        {
            var place = petriNet.GetPlace(Convert.ToInt32(ConnIdPlace_PlaceTrasition_ComboBox.Text));

            if (place == null)
                return;

            var transition = petriNet.GetTransition(Convert.ToInt32(ConnIdTransition_PlaceTrasition_ComboBox.Text));

            if (transition == null)
                return;

            var weight = (int)ConnWeight_PlaceTrasition_NumericUpDown.Value;
            var connType = Enum.Parse<ConnectionType>(ConnType_PlaceTrasition_ComboBox.Text);

            petriNet.CreateConnection(place, transition, weight, connType, ConnectionDirection.Input);

            drawTable();
            updateConnections();

            ConnWeight_PlaceTrasition_NumericUpDown.Value = 0;
        }

        private void connCreate_TrasitionPlace_Button_Click(object sender, EventArgs e)
        {
            var transition = petriNet.GetTransition(Convert.ToInt32(ConnIdTransition_TrasitionPlace_ComboBox.Text));

            if (transition == null)
                return;

            var place = petriNet.GetPlace(Convert.ToInt32(ConnIdPlace_TrasitionPlace_ComboBox.Text));

            if (place == null)
                return;

            var weight = (int)ConnWeight_TrasitionPlace_NumericUpDown.Value;

            petriNet.CreateConnection(place, transition, weight, ConnectionType.Normal, ConnectionDirection.Output);

            drawTable();
            updateConnections();

            ConnWeight_TrasitionPlace_NumericUpDown.Value = 0;
        }

        private void runCycle_Button_Click(object sender, EventArgs e)
        {
            var exec = petriNet.ExecuteCycle();

            if (!exec)
            {
                RunCycle_Button.Enabled = false;
                MessageBox.Show("Não há mais ciclos de execução", "Simulação finalizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            addLastCycle();
        }

        private void runAllCycle_Button_Click(object sender, EventArgs e)
        {
            var exec = true;

            while (exec)
            {
                exec = petriNet.ExecuteCycle();
                if (exec)
                    addLastCycle();
            }

            RunAllCycle_Button.Enabled = false;
        }

        private void addLastCycle()
        {
            DataGridView.Rows.Add((new[] { petriNet.CurrentCycle.ToString() })
                                         .Concat(petriNet.PlaceAndTransitionsGrid.Select(pt => pt.Value))
                                         .ToArray());
        }

        private void LoadExamples_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var loadExampleType = LoadExamples_ComboBox.Text;
            var loadExample = new ExamplesController(loadExampleType);
            petriNet = loadExample.GetPetriNet();

            loadPetriNetScreen();
        }

        private void UploadFile_Button_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clearForm();
                    var xmlHandler = new XmlFilePetriNet(dialog.FileName);
                    xmlHandler.Load();
                    petriNet = xmlHandler.PetriNet;
                    loadPetriNetScreen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

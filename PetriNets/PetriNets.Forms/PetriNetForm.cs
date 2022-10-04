using PetriNets.Controller;
using PetriNets.Controller.Entities;
using PetriNets.Controller.Entities.Examples;
using PetriNets.Controller.Xml;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

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
                Filter = "Arquivos de texto (*.txt)|*.txt|" +
                         "Arquivos xml (*.xml)|*.xml|" +
                         "Arquivos pmnl (*.pmnl)|*.pmnl|" +
                         "Arquivos pflow (*.pflow)|*.pflow",
                Title = "Selecionar arquivo"
            };
            adjustListView();
        }

        private void adjustListView()
        {
            var header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            header.Width = ListView.Width - ListView.Margin.Right - ListView.Margin.Left - SystemInformation.VerticalScrollBarWidth;
            ListView.Columns.Add(header);
            ListView.HeaderStyle = ColumnHeaderStyle.None;
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
                "Arco Inibidor",
                "Arco Reset",
                "Concorrência",
                "Enunciado",
                "Padrão",
                "Rede Referência TA"
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
            ListView.Items.Clear();
            var listViewItems = new ListViewItemCollection(ListView);
            foreach (var connection in petriNet.GetConnectionsInfo())
            {
                var item = new ListViewItem(connection);
                listViewItems.Add(item);
            }

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
            ListView.Items.Clear();
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
            if (verifyIdEmpty(IdPlace_TextBox.Text))
            {
                showMessageBox("Identificador não pode ser vazio!", "Criação não concluída");
                return;
            }

            var placeID = petriNet.GetPlace(IdPlace_TextBox.Text);

            if (placeID != null && placeID.Id.Any())
            {
                showMessageBox("Identificador já existe!", "Criação não concluída");
                return;
            }

            petriNet.CreatePlace(IdPlace_TextBox.Text, Convert.ToInt32(MarkPlace_NumericUpDown.Value));

            drawTable();

            loadTransitionToPlace();
            laodPlaceToTransition();
            IdPlace_TextBox.Text = null;
            MarkPlace_NumericUpDown.Value = 0;
        }

        private static void showMessageBox(string text, string caption) => MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private bool verifyIdEmpty(string id) => string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id);

        private void createTransition_Button_Click(object sender, EventArgs e)
        {
            if (verifyIdEmpty(IdTransition_TextBox.Text))
            {
                showMessageBox("Identificador não pode ser vazio!", "Criação não concluída");
                return;
            }

            var transitionID = petriNet.GetTransition(IdTransition_TextBox.Text);

            if (transitionID != null && transitionID.Id.Any())
            {
                showMessageBox("Identificador já existe!", "Criação não concluída");
                return;
            }

            petriNet.CreateTransition(IdTransition_TextBox.Text);

            drawTable();

            loadTransitionToPlace();
            laodPlaceToTransition();
            IdTransition_TextBox.Text = null;
        }

        private void connCreate_PlaceTrasition_Button_Click(object sender, EventArgs e)
        {
            var place = petriNet.GetPlace(ConnIdPlace_PlaceTrasition_ComboBox.Text);

            if (place == null)
                return;

            var transition = petriNet.GetTransition(ConnIdTransition_PlaceTrasition_ComboBox.Text);

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
            var transition = petriNet.GetTransition(ConnIdTransition_TrasitionPlace_ComboBox.Text);

            if (transition == null)
                return;

            var place = petriNet.GetPlace(ConnIdPlace_TrasitionPlace_ComboBox.Text);

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
                RunAllCycle_Button.Enabled = false;
                showMessageBox("Não há mais ciclos de execução.", "Simulação finalizada");
                return;
            }

            addLastCycle();
        }

        private void runAllCycle_Button_Click(object sender, EventArgs e)
        {
            var exec = true;
            var stopWatch = Stopwatch.StartNew();

            while (exec)
            {
                exec = petriNet.ExecuteCycle();
                if (exec)
                    addLastCycle();

                if (stopWatch.Elapsed.TotalSeconds > 5)
                {
                    stopWatch.Stop();
                    showMessageBox("O programa entrou em um laço infinito!", "Limite de Execuções Atingido");
                    break;
                }
            }

            RunAllCycle_Button.Enabled = false;
            RunCycle_Button.Enabled = false;
        }

        private void addLastCycle()
        {
            DataGridView.Rows.Add((new[] { petriNet.CurrentCycle.ToString() })
                             .Concat(petriNet.PlaceAndTransitionsGrid.Select(pt => pt.Value))
                             .ToArray());

            DataGridView.Refresh();
            var lastRow = DataGridView.Rows.GetLastRow(DataGridViewElementStates.Displayed);
            DataGridView.CurrentCell = DataGridView.Rows[lastRow].Cells[0];
            DataGridView.FirstDisplayedScrollingRowIndex = lastRow;
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

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            var item = listView.FocusedItem;
            item.Selected = false;
        }
    }
}

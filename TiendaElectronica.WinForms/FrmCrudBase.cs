namespace TiendaElectronica.WinForms;

public class FrmCrudBase : Form
{
    protected GroupBox grpDatos = new();
    protected TableLayoutPanel tblCampos = new();
    protected Button btnGuardar = new();
    protected Button btnEditar = new();
    protected Button btnEliminar = new();
    protected Button btnLimpiar = new();
    protected DataGridView dgvDatos = new();

    public FrmCrudBase()
    {
        ConstruirInterfaz();
    }

    private void ConstruirInterfaz()
    {
        Text = "Gestión de datos";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(820, 540);

        // Zona de campos de entrada (los formularios hijos agregan filas aquí)
        grpDatos.Text = "Datos";
        grpDatos.Dock = DockStyle.Top;
        grpDatos.Height = 200;
        grpDatos.Padding = new Padding(10);

        tblCampos.Dock = DockStyle.Fill;
        tblCampos.ColumnCount = 2;
        tblCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
        tblCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
        grpDatos.Controls.Add(tblCampos);

        // Campos de ejemplo (plantilla)
        AgregarCampo("Código:", new TextBox { Name = "txtCodigo", Dock = DockStyle.Fill });
        AgregarCampo("Nombre:", new TextBox { Name = "txtNombre", Dock = DockStyle.Fill });
        AgregarCampo("Descripción:", new TextBox { Name = "txtDescripcion", Dock = DockStyle.Fill });

        // Panel de botones
        var pnlBotones = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 50,
            Padding = new Padding(10, 8, 0, 0)
        };

        ConfigurarBoton(btnGuardar, "Guardar", BtnGuardar_Click);
        ConfigurarBoton(btnEditar, "Editar", BtnEditar_Click);
        ConfigurarBoton(btnEliminar, "Eliminar", BtnEliminar_Click);
        ConfigurarBoton(btnLimpiar, "Limpiar", BtnLimpiar_Click);
        pnlBotones.Controls.AddRange(new Control[] { btnGuardar, btnEditar, btnEliminar, btnLimpiar });

        // Tabla
        dgvDatos.Dock = DockStyle.Fill;
        dgvDatos.ReadOnly = true;
        dgvDatos.AllowUserToAddRows = false;
        dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDatos.MultiSelect = false;
        dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDatos.CellClick += DgvDatos_CellClick;

        // El control con Dock.Fill se agrega primero
        Controls.Add(dgvDatos);
        Controls.Add(pnlBotones);
        Controls.Add(grpDatos);
    }

    protected void AgregarCampo(string etiqueta, Control control)
    {
        int fila = tblCampos.RowCount++;
        tblCampos.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));
        tblCampos.Controls.Add(new Label { Text = etiqueta, AutoSize = true, Anchor = AnchorStyles.Left }, 0, fila);
        tblCampos.Controls.Add(control, 1, fila);
    }

    private static void ConfigurarBoton(Button btn, string texto, EventHandler handler)
    {
        btn.Text = texto;
        btn.Size = new Size(100, 32);
        btn.Click += handler;
    }

    // Métodos virtuales: cada CRUD concreto (Productos, Clientes...) los sobrescribe
    protected virtual void BtnGuardar_Click(object? sender, EventArgs e) { }
    protected virtual void BtnEditar_Click(object? sender, EventArgs e) { }
    protected virtual void BtnEliminar_Click(object? sender, EventArgs e) { }
    protected virtual void BtnLimpiar_Click(object? sender, EventArgs e)
    {
        foreach (Control c in tblCampos.Controls)
            if (c is TextBox txt) txt.Clear();
    }
    protected virtual void DgvDatos_CellClick(object? sender, DataGridViewCellEventArgs e) { }
}

namespace TiendaElectronica.WinForms;

public class FrmLogin : Form
{
    private readonly TextBox txtUsuario = new();
    private readonly TextBox txtContrasena = new();
    private readonly Button btnIngresar = new();
    private readonly Button btnCancelar = new();

    public FrmLogin()
    {
        ConstruirInterfaz();
    }

    private void ConstruirInterfaz()
    {
        Text = "Tienda Electrónica - Iniciar sesión";
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        ClientSize = new Size(340, 230);

        var lblTitulo = new Label
        {
            Text = "Iniciar sesión",
            Font = new Font("Segoe UI", 16, FontStyle.Bold),
            AutoSize = true,
            Location = new Point(95, 15)
        };

        var lblUsuario = new Label { Text = "Usuario:", AutoSize = true, Location = new Point(30, 70) };
        txtUsuario.Location = new Point(110, 66);
        txtUsuario.Width = 190;

        var lblContrasena = new Label { Text = "Contraseña:", AutoSize = true, Location = new Point(30, 110) };
        txtContrasena.Location = new Point(110, 106);
        txtContrasena.Width = 190;
        txtContrasena.UseSystemPasswordChar = true;

        btnIngresar.Text = "Ingresar";
        btnIngresar.Location = new Point(70, 160);
        btnIngresar.Size = new Size(90, 32);
        btnIngresar.Click += BtnIngresar_Click;

        btnCancelar.Text = "Cancelar";
        btnCancelar.Location = new Point(180, 160);
        btnCancelar.Size = new Size(90, 32);
        btnCancelar.Click += (s, e) => Close();

        Controls.AddRange(new Control[]
        {
            lblTitulo, lblUsuario, txtUsuario, lblContrasena, txtContrasena, btnIngresar, btnCancelar
        });

        AcceptButton = btnIngresar;
        CancelButton = btnCancelar;
    }

    private void BtnIngresar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
        {
            MessageBox.Show("Ingrese usuario y contraseña.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // TODO: validar contra la capa Business (pendiente en este parcial)
        using var crud = new FrmCrudBase();
        Hide();
        crud.ShowDialog();
        Show();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionDePacientes
{
    // 1. ENUMERACIONES (Modelan atributos predefinidos)
    
    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public enum EstadoPaciente
    {
        Ingresado,
        EnObservacion,
        DeAlta,
        Hospitalizado
    }

    // 2. EXCEPCIONES PERSONALIZADAS
    
    public class PacienteNoEncontradoException : Exception
    {
        public PacienteNoEncontradoException(string mensaje) : base(mensaje) { }
    }

    public class PacienteDuplicadoException : Exception
    {
        public PacienteDuplicadoException(string mensaje) : base(mensaje) { }
    }

    // 3. CLASE MODELO (Paciente)
    
    public class Paciente
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }
        public string Diagnostico { get; set; }
        public EstadoPaciente Estado { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Paciente()
        {
            FechaIngreso = DateTime.Now;
        }

        public Paciente(string id, string nombreCompleto, int edad, Sexo sexo, string diagnostico, EstadoPaciente estado, DateTime fechaIngreso)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            Edad = edad;
            Sexo = sexo;
            Diagnostico = diagnostico;
            Estado = estado;
            FechaIngreso = fechaIngreso;
        }
    }

    // 4. CLASE DE LÓGICA DE NEGOCIO (GestorPacientes)
    
    public class GestorPacientes
    {
        private List<Paciente> listaPacientes;

        public GestorPacientes()
        {
            listaPacientes = new List<Paciente>();
            CargarDatosDePrueba();
        }

        private void CargarDatosDePrueba()
        {
            listaPacientes.Add(new Paciente("001", "Juan Pérez", 45, Sexo.Masculino, "Hipertensión Arterial", EstadoPaciente.EnObservacion, DateTime.Now.AddDays(-3)));
            listaPacientes.Add(new Paciente("002", "María Rodríguez", 30, Sexo.Femenino, "Apendicitis Aguda", EstadoPaciente.Hospitalizado, DateTime.Now.AddDays(-1)));
        }

        public List<Paciente> ObtenerTodos()
        {
            return new List<Paciente>(listaPacientes);
        }

        public void RegistrarPaciente(Paciente nuevo)
        {
            if (listaPacientes.Any(p => p.Id.Equals(nuevo.Id, StringComparison.OrdinalIgnoreCase)))
            {
                throw new PacienteDuplicadoException($"Ya existe un paciente registrado con el ID/Cédula: {nuevo.Id}");
            }
            listaPacientes.Add(nuevo);
        }

        public void ActualizarPaciente(Paciente pacienteEditado)
        {
            Paciente existe = listaPacientes.FirstOrDefault(p => p.Id.Equals(pacienteEditado.Id, StringComparison.OrdinalIgnoreCase));
            if (existe == null)
            {
                throw new PacienteNoEncontradoException($"No se encontró al paciente con el ID: {pacienteEditado.Id}");
            }

            existe.NombreCompleto = pacienteEditado.NombreCompleto;
            existe.Edad = pacienteEditado.Edad;
            existe.Sexo = pacienteEditado.Sexo;
            existe.Diagnostico = pacienteEditado.Diagnostico;
            existe.Estado = pacienteEditado.Estado;
            existe.FechaIngreso = pacienteEditado.FechaIngreso;
        }

        public void EliminarPaciente(string id)
        {
            Paciente paciente = listaPacientes.FirstOrDefault(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (paciente == null)
            {
                throw new PacienteNoEncontradoException($"No se puede eliminar. El paciente con ID '{id}' no existe.");
            }
            listaPacientes.Remove(paciente);
        }

        public List<Paciente> BuscarPorIdONombre(string criterio)
        {
            if (string.IsNullOrWhiteSpace(criterio))
            {
                return ObtenerTodos();
            }

            string filtro = criterio.Trim().ToLower();
            return listaPacientes.Where(p => 
                p.Id.ToLower().Contains(filtro) || 
                p.NombreCompleto.ToLower().Contains(filtro)
            ).ToList();
        }
    }

    // 5. CLASE DE INTERFAZ GRÁFICA (Form1)
    
    public partial class Form1 : Form
    {
        private GestorPacientes gestor;

        public Form1()
        {
            InitializeComponent();
            gestor = new GestorPacientes();
            ConfigurarControles();
            RefrescarTabla(gestor.ObtenerTodos());
        }

        private void ConfigurarControles()
        {
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoPaciente));
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void RefrescarTabla(List<Paciente> lista)
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = lista;
        }

        private void LimpiarCamposFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtDiagnostico.Clear();
            cmbSexo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            txtId.Enabled = true; // Habilita edición de ID si estaba bloqueado tras una selección
            txtId.Focus();
        }

        private Paciente ObtenerPacienteDesdeInterfaz()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                throw new ArgumentException("El campo 'ID / Cédula' es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                throw new ArgumentException("El campo 'Nombre Completo' es obligatorio.");
            }

            if (!int.TryParse(txtEdad.Text.Trim(), out int edad) || edad < 0 || edad > 120)
            {
                throw new FormatException("La edad debe ser un entero válido entre 0 y 120 años.");
            }

            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                throw new ArgumentException("El campo 'Diagnóstico' es obligatorio.");
            }

            return new Paciente(
                txtId.Text.Trim(),
                txtNombre.Text.Trim(),
                edad,
                (Sexo)cmbSexo.SelectedItem,
                txtDiagnostico.Text.Trim(),
                (EstadoPaciente)cmbEstado.SelectedItem,
                dtpFechaIngreso.Value
            );
        }

        // --- MANEJADORES DE EVENTOS ---

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente nuevo = ObtenerPacienteDesdeInterfaz();
                gestor.RegistrarPaciente(nuevo);
                RefrescarTabla(gestor.ObtenerTodos());

                MessageBox.Show("Paciente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreguntarSiguienteAccion("¿Desea registrar otro paciente?");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente pacienteEditado = ObtenerPacienteDesdeInterfaz();
                gestor.ActualizarPaciente(pacienteEditado);
                RefrescarTabla(gestor.ObtenerTodos());

                MessageBox.Show("Datos del paciente actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreguntarSiguienteAccion("¿Desea modificar otro paciente?");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idAEliminar = txtId.Text.Trim();

                if (string.IsNullOrWhiteSpace(idAEliminar) && dgvPacientes.SelectedRows.Count > 0)
                {
                    idAEliminar = dgvPacientes.SelectedRows[0].Cells["Id"].Value.ToString();
                }

                if (string.IsNullOrWhiteSpace(idAEliminar))
                {
                    MessageBox.Show("Ingrese un ID o seleccione una fila de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar al paciente con ID '{idAEliminar}'?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    gestor.EliminarPaciente(idAEliminar);
                    RefrescarTabla(gestor.ObtenerTodos());
                    MessageBox.Show("Paciente eliminado con éxito.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PreguntarSiguienteAccion("¿Desea eliminar otro paciente?");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
                List<Paciente> resultados = gestor.BuscarPorIdONombre(criterio);

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron pacientes que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RefrescarTabla(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            RefrescarTabla(gestor.ObtenerTodos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposFormulario();
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPacientes.Rows[e.RowIndex].DataBoundItem is Paciente seleccionado)
            {
                txtId.Text = seleccionado.Id;
                txtNombre.Text = seleccionado.NombreCompleto;
                txtEdad.Text = seleccionado.Edad.ToString();
                cmbSexo.SelectedItem = seleccionado.Sexo;
                txtDiagnostico.Text = seleccionado.Diagnostico;
                cmbEstado.SelectedItem = seleccionado.Estado;
                dtpFechaIngreso.Value = seleccionado.FechaIngreso;

                txtId.Enabled = false; // Bloquea el ID durante la edición de selección
            }
        }

        private void PreguntarSiguienteAccion(string mensajePregunta)
        {
            DialogResult respuesta = MessageBox.Show(mensajePregunta, "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                LimpiarCamposFormulario();
            }
            else
            {
                LimpiarCamposFormulario();
                // Retorna la vista al estado principal
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea salir del Sistema de Gestión de Pacientes?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
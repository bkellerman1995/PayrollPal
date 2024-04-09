using PayrollPal.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using PayrollPal.Layers.Entities;
using PayrollPal.Layers.Util;

namespace PayrollPal.UI.Procesos
{
    public partial class frmProcesoCalcularPlanilla : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        private DateTime fechaHoy = DateTime.Now;

        private bool encabezadoPlanCreado = false;

        private ServicioBCCR servicioBCCR = new ServicioBCCR();

        private Planilla_Detalle planilla_Detalle = new Planilla_Detalle();
        public frmProcesoCalcularPlanilla()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Método load del form 
        /// de Cálculo de Planilla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProcesoCalcularPlanilla_Load(object sender, EventArgs e)
        {
            try
            {

                this.txtIdEncPlan.Text = "Enc" + fechaHoy.ToString("yyyyMMdd") + BLLPlanilla_Encabezado.SecuenciadorPlanEnc();

                CargartxtTipoCambio();
                CargarCombos();

                //Limpiar los controles del form 
                LimpiarControles();
                RevisarCombosVacios();
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void CargartxtTipoCambio()
        {
            try
            {
                foreach (var dolar in servicioBCCR.GetDolar(DateTime.Today,DateTime.Today,"318"))
                {
                    this.txtTipoCambio.Text = dolar.Monto.ToString();
                }

                this.lblTipoCambio2.Text = "para hoy " + DateTime.Today.ToString("dd/MM/yyyy") + " (venta)";
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void CargarDGVMarcas()
        {
            try
            {
                if ((this.cmbColaborador.SelectedItem != null && this.cmbColaborador.SelectedIndex != 0)
                    && (this.cmbPlanillas.SelectedItem != null && this.cmbPlanillas.SelectedIndex != 0))
                {
                    Colaborador oColaborador = (Colaborador)this.cmbColaborador.SelectedItem;
                    this.dgvListaMarcas.DataSource = BLLControlDeMarcas.SelectAll().Where(marc => marc.HorasTrabajadas >= 10
                    && marc.IdColaborador == oColaborador.IDColaborador).ToList();
                    this.dgvListaMarcas.ClearSelection();
                }

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void CargarDGVHorOrdExt()
        {
            try
            {
                if ((this.cmbColaborador.SelectedItem != null && this.cmbColaborador.SelectedIndex != 0)
                    && (this.cmbPlanillas.SelectedItem != null && this.cmbPlanillas.SelectedIndex != 0))
                {
                    Colaborador oColab = (Colaborador)this.cmbColaborador.SelectedItem;
                    PlanillaPago oPago = (PlanillaPago)this.cmbPlanillas.SelectedItem;
                    planilla_Detalle.IdDetalle = BLLPlanilla_Detalle.SecuenciadorPlanDetalle();
                    planilla_Detalle.IdColaborador = oColab;
                    planilla_Detalle.NombreColaborador = oColab.Nombre;
                    List<Planilla_Detalle> lista = new List<Planilla_Detalle>();

                    BLLColaborador.CalcularHorasOrdExt(oColab, oPago, planilla_Detalle);

                    lista.Add(planilla_Detalle);

                    this.dgvHorOrdvsExt.DataSource = lista;

                    this.dgvHorOrdvsExt.Columns["IdDetalle"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdEncabezado"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["IdColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["NombreColaborador"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsTrabajadas"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["hrsExtras"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["MontoHora"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["SalarioBruto"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["CodigoDeduccionPercepcion"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["TipoDecPerc"].Visible = false;
                    this.dgvHorOrdvsExt.Columns["SalarioNeto"].Visible = false;

                    this.dgvHorOrdvsExt.ClearSelection();
                }
  

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void CargarCombos()
        {
            List<PlanillaPago> listaPlanillas = BLLPlanillaPago.SelectAll().Where(planilla
                => planilla.Estado == Enumeraciones.PlanillaEstado.Activa).ToList();

            this.cmbPlanillas.Items.Add(" ====SELECCIONE====");

            foreach (var colab in listaPlanillas)
            {
                this.cmbPlanillas.Items.Add(colab);
            }

            List<Colaborador> listaColaboradores = BLLColaborador.SelectAll().Where(colab
                => colab.IDRol.IDRol == 3 && colab.IDSupervisor.IDSupervisor != "0").ToList();


            this.cmbColaborador.Items.Add(" ====SELECCIONE====");
            foreach (var colab in listaColaboradores)
            {
                this.cmbColaborador.Items.Add(colab);
            }
        }

        private void LimpiarControles()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                this.cmbPlanillas.SelectedIndex = 0;
                this.cmbColaborador.SelectedIndex = 0;


                InhabilitarControles();

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");
            }
        }

        private void RevisarCombosVacios()
        {
            try
            {
                if (BLLPlanillaPago.SelectAll().Where(planilla => planilla.Estado 
                == Enumeraciones.PlanillaEstado.Activa).ToList().Count != 0)
                {
                    this.errProv1.SetError(this.cmbPlanillas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPlanillas, "No puede generar una colilla de pago sin planilla");

                }

                if (BLLColaborador.SelectAll().Where(col => col.IDSupervisor.IDSupervisor != "0" && col.IDRol.IDRol == 3).Count() != 0)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "No puede generar una colilla de pago sin colaboradores o colaboradores sin supervisor." +
                        "\nRevise que existan colaboradores y que tengan un supervisor asignado.");

                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void InhabilitarControles()
        {
            try
            {

                this.txtImprimir.Text = "";

            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGVMarcas();
            CargarDGVHorOrdExt();
        }

        private void cmbPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDGVMarcas();
            CargarDGVHorOrdExt();

            PlanillaPago oPlanPago;
            if (this.cmbPlanillas.SelectedIndex != 0)
            {
                oPlanPago = this.cmbPlanillas.SelectedItem as PlanillaPago;
                this.dtpFechaDesde.Value = oPlanPago.FechaDesde;
                this.dtpFechaDesde.MinDate = this.dtpFechaDesde.Value;
                this.dtpFechaDesde.MaxDate = this.dtpFechaDesde.Value;

                this.dtpFechaHasta.Value = oPlanPago.FechaHasta;
                this.dtpFechaHasta.MinDate = this.dtpFechaHasta.Value;
                this.dtpFechaHasta.MaxDate = this.dtpFechaHasta.Value;
            }

  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnGenerarColilla_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }
                //Validar que todos los campos del form estén correctamente llenados 
                //para agregar o actualizar el colaborador correctamente
                if (!ValidarCampos())
                {
                    return;
                }

                //Llamar al método que crea y actualiza los usuarios
                CrearActualizarPlanEncyDetalle();
                LimpiarControles();
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
        }

        /// <summary>
        /// Método que se encarga de validar los campos 
        /// en los controles
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            bool correcto = false;
            try
            {
                correcto = true;
                foreach (Control c in this.Controls)
                {
                    this.errProv1.SetError(c, String.Empty);
                    this.errProv1.Clear();
                }

                //Validar CargaTipoCambio

                if (!String.IsNullOrEmpty(this.txtTipoCambio.Text.Trim()))
                {
                    this.errProv1.SetError(this.txtTipoCambio, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.txtTipoCambio, "El valor del tipo de cambio del dólar no se cargó correctamente ");
                    return false;
                }

                //Validar combo Planilla

                if (this.cmbPlanillas.SelectedIndex !=0 )
                {
                    this.errProv1.SetError(this.cmbPlanillas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbPlanillas, "Campo planilla de pago no es correcto");
                    return false;
                }

                //Validar combo Colaborador

                if (this.cmbColaborador.SelectedItem != null)
                {
                    this.errProv1.SetError(this.cmbColaborador, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.cmbColaborador, "Campo colaborador no es correcto");
                    return false;
                }

                //Validar dgvMarcas

                if (this.dgvListaMarcas.Rows.Count != 0)
                {
                    this.errProv1.SetError(this.dgvListaMarcas, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.dgvListaMarcas, "No existen marcas o no han sido correctamente cargadas");
                    return false;
                }

                //Validar dgvHorOrdExt

                if (this.dgvHorOrdvsExt.Rows.Count != 0)
                {
                    this.errProv1.SetError(this.dgvHorOrdvsExt, string.Empty);
                }
                else
                {
                    this.errProv1.SetError(this.dgvHorOrdvsExt, "No existen horas o no han sido correctamente cargadas");
                    return false;
                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                _MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }
            return correcto;
        }

        private void CrearActualizarPlanEncyDetalle()
        {

            //Crear la instancia de PlanillaDetalle


            //Crear la instancia de PlanillaEncabezado
            Planilla_Encabezado planEnc = new Planilla_Encabezado();

            planEnc.IdEncabezado = this.txtIdEncPlan.Text;
            planEnc.Codigo = (PlanillaPago)this.cmbPlanillas.SelectedItem;
            planEnc.TipoCambio = Double.Parse(this.txtTipoCambio.Text);
            //planEnc.TotalIngresos = BLL

            //planEnc.TotalIngresos = Double.Parse(this.txtTipoCambio.Text);


            //oColaborador.IDColaborador = this.txtID.Text;
            //idColaborador = oColaborador.IDColaborador;
            //oColaborador.Nombre = this.txtNombre.Text;
            //oColaborador.Apellido1 = this.txtApellido1.Text;
            //oColaborador.Apellido2 = this.txtApellido2.Text;
            //oColaborador.Apellido2 = this.txtApellido2.Text;
            //oColaborador.FechaNacimiento = this.dtpFechaNacimiento.Value;
            //oColaborador.Direccion = this.txtDireccion.Text;
            //oColaborador.FechaIngreso = this.dtpFechaIngreso.Value;
            //oColaborador.IDDepartamento = (Departamento)this.cmbDepartamento.SelectedItem;
            //oColaborador.SalarioHora = decimal.Parse(this.mktSalarioHora.Text);
            //foreach (char c in reemplazarCaracteresSalario)
            //{
            //    Salario = decimal.Parse(this.mktSalarioHora.Text.Replace(c.ToString(), ""));
            //}
            //oColaborador.SalarioHora = Salario;
            //oColaborador.CorreoElectronico = this.txtCorreoElectronico.Text;
            //oColaborador.CuentaIBAN = this.lblCR.Text + this.mktCuentaIBAN.Text;
            //oColaborador.IDUsuario = (Usuario)this.cmbUsuario.SelectedItem;
            //if (BLLColaborador.SelectById(idColaborador) != null)
            //{
            //    if (oColaborador.IDUsuario.ToString() == BLLColaborador.SelectById(idColaborador).IDUsuario.ToString())
            //    {
            //        oColaborador.IDUsuario.Contrasenna = Criptografia.DecrypthAES(oColaborador.IDUsuario.Contrasenna);
            //    }
            //}


            //Si el usuario va a cambiarse
            //debe cambiarse el estado del usuario 
            //que estaba anteriormente asignado

            //oColaborador.IDUsuario.Asignado = true;
            //BLLUsuario.Update(oColaborador.IDUsuario);

            //oColaborador.CodigoPuesto = (Puesto)this.cmbPuestos.SelectedItem;
            //oColaborador.IDRol = (Rol)this.cmbRol.SelectedItem;

            //switch (oColaborador.IDRol.IDRol)
            //{
            //    case 1:
            //    case 2:
            //        supervisor.IDRol = (Rol)this.cmbRol.SelectedItem;
            //        oColaborador.IDSupervisor = supervisor;
            //        break;
            //    case 3:
            //        oColaborador.IDSupervisor = (Supervisor)this.cmbSupervisor.SelectedItem;
            //        break;
            //}
            //oColaborador.Foto = (byte[])pctFoto.Tag;

            //if (this.rdbActivo.Checked)
            //    oColaborador.Estado = true;
            //if (this.rdbInactivo.Checked)
            //    oColaborador.Estado = false;

            ////Se llama al método Create del Colaborador 
            ////que se encarga de revisar si el colaborador existe primero
            ////antes de agregar al colaborador
            //if (BLLColaborador.SelectById(idColaborador) != null)
            //{
            //    if (oColaborador.IDUsuario.ToString() != BLLColaborador.SelectById(idColaborador).IDUsuario.ToString())
            //    {
            //        oUsuarioADeshabilitar = BLLColaborador.SelectById(idColaborador).IDUsuario;
            //        oUsuarioADeshabilitar.Asignado = false;
            //        oUsuarioADeshabilitar.Contrasenna = Criptografia.DecrypthAES(oUsuarioADeshabilitar.Contrasenna);

            //        BLLUsuario.Update(oUsuarioADeshabilitar);
            //    }
            //    BLLColaborador.Update(oColaborador);
            //}
            //else
            //{
            //    BLLColaborador.Create(oColaborador);
            //}

            ////Insertar el colaborador a la base de datos
            ////por medio del BLLColaborador (método CREATE)

            ////Refrescar la lista
            //CargarLista();

            ////Limpiar los controles
            //LimpiarControles();
        }
    }
}

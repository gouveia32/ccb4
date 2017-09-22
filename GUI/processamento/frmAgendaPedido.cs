using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Schedule;
using DevExpress.XtraScheduler.Commands;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using System.Data;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class frmAgendaPedido : DevExpress.XtraEditors.XtraForm
    {
        DateTime inicioSemana;
        private AppointmentBaseCollection collection;

        AgendaPedidoBLL bll = new AgendaPedidoBLL();
        private MySqlDataAdapter EntradasMySqlDataAdapter = new MySqlDataAdapter();
        private MySqlCommandBuilder EntradasMySqlCommandBuilder = new MySqlCommandBuilder();

        frmPrincipal fp;
        private fnLocalizar loc = new fnLocalizar();

        public frmAgendaPedido(frmPrincipal _fp)
        {
            InitializeComponent();
            fp = _fp;
        }

        private static void SetupLabels(ISchedulerStorage storage)
        {
            AppointmentLabel label = default(AppointmentLabel);

            storage.Appointments.Labels.Clear();

            label = storage.Appointments.Labels.CreateNewLabel("Pedido Normal");
            label.Color = Color.FromArgb(BLL.Properties.Settings.Default.corPedidoNormal);
            storage.Appointments.Labels.Add(label);

            label = storage.Appointments.Labels.CreateNewLabel("Pedido Mensal");
            label.Color = Color.FromArgb(BLL.Properties.Settings.Default.corPedidoMensal);
            storage.Appointments.Labels.Add(label);

            label = storage.Appointments.Labels.CreateNewLabel("Proodução");
            label.Color = Color.LightSteelBlue;
            storage.Appointments.Labels.Add(label);

            label = storage.Appointments.Labels.CreateNewLabel("Sem Data");
            label.Color = Color.Orange;
            storage.Appointments.Labels.Add(label);

            label = storage.Appointments.Labels.CreateNewLabel("Cancelado");
            label.Color = Color.White;
            storage.Appointments.Labels.Add(label);
        }

        private void frmAgendaPedido_Load(object sender, EventArgs e)
        {
            inicioSemana = DateTime.Now.AddDays(-(int)(DateTime.Now.DayOfWeek + 7));
            
            SetupLabels(SchedulerStorage1);

            //Timer1.Interval = frmPreferencias.intTempoAtualizaPedidos.Value * 1000;
            Timer1.Interval = 10 * 1000;
            dnEntrada.DateTime = DateTime.Now;

            SelecionaEntradas();
            TBindingSource.DataSource = TDataSet.Tables[0];
            SchedulerStorage1.Appointments.DataSource = TBindingSource;

            SchedulerStorage1.Appointments.Mappings.Subject = "subject";
            SchedulerStorage1.Appointments.Mappings.Label = "label";
            SchedulerStorage1.Appointments.Mappings.Description = "description";
            SchedulerStorage1.Appointments.Mappings.Status = "status";
            SchedulerStorage1.Appointments.Mappings.Start = "start";
            SchedulerStorage1.Appointments.Mappings.End = "end";
            SchedulerStorage1.Appointments.Mappings.Location = "location";
            SchedulerStorage1.Appointments.Mappings.AppointmentId = "Id";

            SchedulerControl.Start = DateTime.Today;
            SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
            SchedulerControl.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            SchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            SchedulerControl.DayView.ResourcesPerPage = 2;
            SchedulerControl.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;

            this.SchedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.SchedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.SchedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            EntradasMySqlDataAdapter.Update(this.TDataSet);
            this.TDataSet.AcceptChanges();
        }

        private void SelecionaEntradas()
        {
            Cursor = Cursors.WaitCursor;
            //inicioSemana = DateTime.Now.AddDays(- (int)(DateTime.Now.DayOfWeek + 7));

            string strSQLWHERE = null;

            if (chkEntregues.Checked)
            {
                strSQLWHERE = string.Format("start >= '{0:yyyy-MM-dd hh:mm:ss}' ", inicioSemana);
            }
            else
            {
                strSQLWHERE = string.Format("start >= '{0:yyyy-MM-dd hh:mm:ss}' AND status > 0 ", inicioSemana);
            }

            EntradasMySqlCommandBuilder = new MySqlCommandBuilder(EntradasMySqlDataAdapter);

            TDataSet.Clear();
            EntradasMySqlDataAdapter = bll.FillDataSet(TDataSet, strSQLWHERE);
            TBindingSource.DataSource = TDataSet.Tables[0];

            EntradasMySqlCommandBuilder = new MySqlCommandBuilder(EntradasMySqlDataAdapter);

            //TBindingSource.DataSource = bll.CarregaEntradas(strSQLWHERE);
            fp.sbRegistros.Caption = String.Format("{0} entradas", TDataSet.Tables[0].Rows.Count );

            Cursor = Cursors.Default;
        }

        private void schedulerControl_SelectionChanged(object sender, EventArgs e)
        {
            SchedulerControl.Refresh();
        }

        private void schedulerControl_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
        {
            foreach (Appointment apt in collection)
            {
                if (apt.Equals((e.ViewInfo as AppointmentViewInfo).Appointment))
                {
                    e.ViewInfo.Appearance.BackColor = Color.Green;
                    e.ViewInfo.Appearance.BorderColor = Color.Green;
                }
            }
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            // TODO: Restart the 10-minute timer.
            Timer1.Stop();
            Timer1.Start();
        }

        private void rgrpView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rgrpView.EditValue.ToString())
            {
                case "Day" :
                    SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
                    break;
                case "Month":
                    SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
                    break;
                case "WorkWeek":
                    SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.WorkWeek;
                    break;
                case "FullWeek":
                    SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
                    break;
                case "Timeline":
                    SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
                    break;
            }
            SchedulerControl.Focus();
        }

        private void SchedulerControl_CustomDrawAppointment(object sender, CustomDrawObjectEventArgs e)
        {
            AppointmentViewInfo info = e.ObjectInfo as AppointmentViewInfo;
            if (info.Selected)
            {
                info.Appearance.Font = new Font(info.Appearance.Font.FontFamily, 10, FontStyle.Bold);

                e.DrawDefault();
                //Skin currentSkin = DevExpress.Skins.SchedulerSkins.GetSkin(StyleController1.LookAndFeel);
                Color color = Color.FromArgb(BLL.Properties.Settings.Default.corTarefaSelecionada);

                e.Cache.DrawRectangle(new Pen(new SolidBrush(color), 5), info.Bounds);
                e.Handled = true;
            }
        }

        private void SchedulerControl_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
        {
            // Check whether the current object is a Day Header.
            SchedulerHeader header = e.ObjectInfo as SchedulerHeader;

            if ((header != null))
            {
                // Check whether the current date is a known holiday.
                Holiday hol = FindHoliday(header.Interval.Start.Date);

                if ((hol != null))
                {
                    // Add the holiday name to the day header's caption.
                    header.Caption = string.Format("{0} ({1})", hol.DisplayName, hol.Date.ToShortDateString());
                }
            }
        }

   	    // This method finds a holiday for the specified date.
	    private Holiday FindHoliday(DateTime date)
	    {
		    foreach (WorkDay item in SchedulerControl.WorkDays) {
			    if (item is Holiday) {
				    Holiday hol = (Holiday)item;
				    if (hol.Date == date) {
					    return hol;
				    }
			    }
		    }
		    return null;
	    }

        private void SchedulerControl_EditAppointmentFormShowing_2(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            GUI.frmEditaAgenda form = new GUI.frmEditaAgenda(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }

        private void ButtonItemAtualizar_Click(object sender, EventArgs e)
        {
            SelecionaEntradas(); 
        }

        private void SchedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            SchedulerMenuItem Item = default(SchedulerMenuItem);
            //Exit Sub

            SplitAppointmentOperationCommand command = new SplitAppointmentOperationCommand(SchedulerControl);
            SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter = new SchedulerMenuItemCommandWinAdapter(command);
            //Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(), DXMenuItem)
            DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
            if (menuItem == null)
                return;
            menuItem.BeginGroup = true;
            e.Menu.Items.Add(menuItem);
            if (e.Menu.Items.Count == 7)
            {
                e.Menu.Items[0].Caption = "Abrir";
                e.Menu.Items[3].Caption = "Situação";
                e.Menu.Items[4].Caption = "Tipo de Pedido";
                e.Menu.Items[5].Caption = "Apagar";
                //e.Menu.Items(6).Caption = "Dividir"
                e.Menu.Items[6].Visible = false;
            }
            // Check if it's the default menu of a Scheduler.


            // Disable the "New Recurring Appointment" menu item.
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.CustomizeTimeRuler);

            // Find the "New Appointment" menu item and rename it.
            Item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment);
            if ((Item != null))
                Item.Caption = "&Novo Pedido";

            Item = e.Menu.GetMenuItemById(SchedulerMenuItemId.GotoToday);
            if ((Item != null))
                Item.Caption = "&Hoje";

            Item = e.Menu.GetMenuItemById(SchedulerMenuItemId.GotoDate);
            if ((Item != null))
                Item.Caption = "&Ir para o Dia";

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Appointment ap = SchedulerStorage1.CreateAppointment(AppointmentType.Normal);

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                XtraMessageBox.Show("Digite a Descrição antes de gravar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Cursor = Cursors.WaitCursor;

            //ap.Description = txtDescricao.Text
            ap.Location = "0";
            //Não tem pedido associado

            ap.Start = UltimoDoDia(dnEntrada.DateTime);
            ap.End = ap.Start.AddMinutes(9);
            ap.Subject = string.Format("[{0:d}]{1:s}", nudQuantidade.Text, txtDescricao.Text);
            ap.Description = txtItem.Text;
            ap.StatusKey = 2;
            //Aguardando
            ap.LabelKey = 1;
            //Pedido Mensal

            SchedulerStorage1.Appointments.Add(ap);
            //Clipboard.SetDataObject(txtDescricao.Text)
            Gravar(btnEntrada);

            inicioSemana = DateTime.Now.AddDays(-(int)(DateTime.Now.DayOfWeek + 7));
            // início da semana anterior
            SchedulerControl.Start = DateTime.Now;
            //XtraMessageBox.Show("O nome [" & txtDescricao.Text & "] foi gravado e memorizado. Use <ctrl>V para inserir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDescricao.Text = "";
            txtItem.Text = "";
            nudQuantidade.Text = "1";
            txtDescricao.Focus();
            Cursor = Cursors.Default;
        }

        private void Gravar (object btn)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (this.Validate())
                {
                    TBindingSource.EndEdit();
                    EntradasMySqlDataAdapter.Update(TDataSet.Tables[0]);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private DateTime UltimoDoDia(System.DateTime dia)
        {
            DateTime m = Convert.ToDateTime(string.Format("{0:yyyy-MM-dd} 07:50", dia));
            DataTable dt;

            AgendaPedidoBLL bllu = new AgendaPedidoBLL();

            dt = bllu.CarregaUltimaEntrada( dia);
            if (dt.Rows.Count == 1)
            {
                m = Convert.ToDateTime(dt.Rows[0].ItemArray[7]); // 7-coluna start
            }
            return m.AddMinutes(10);
        }

        private void SetUpMapping()
        {
            SchedulerStorage1.BeginUpdate();
            try
            {
                SchedulerStorage1.Appointments.DataSource = TBindingSource;
                SchedulerStorage1.Appointments.Mappings.Subject = "subject";
                SchedulerStorage1.Appointments.Mappings.Label = "label";
                SchedulerStorage1.Appointments.Mappings.Description = "description";
                SchedulerStorage1.Appointments.Mappings.Status = "status";
                SchedulerStorage1.Appointments.Mappings.Start = "start";
                SchedulerStorage1.Appointments.Mappings.End = "end";
                SchedulerStorage1.Appointments.Mappings.Location = "location";
                SchedulerStorage1.Appointments.Mappings.AppointmentId = "Id";
            }
            finally { SchedulerStorage1.EndUpdate(); }
        }

        private void SchedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (this.Validate())
                {
                    if (SchedulerControl.SelectedAppointments[0].StatusKey.GetHashCode() == 0 &&
                        SchedulerControl.SelectedAppointments[0].Location != "0")
                    {
                        DataTable dt;
                        string where = string.Format("start='{0:yyyy-MM-dd HH:mm:ss}' AND pedido_id={1:d}", SchedulerControl.SelectedAppointments[0].Start, SchedulerControl.SelectedAppointments[0].Location);

                        //AgendaPedidoBLL bll = new AgendaPedidoBLL();

                        dt = bll.CarregaEntradas(where);
                        if (dt.Rows.Count > 0)
                        {
                            int st = Convert.ToInt32(dt.Rows[0].ItemArray[6]);  //Status
                            if (SchedulerControl.SelectedAppointments[0].StatusKey.GetHashCode() != st)
                            {
                                MessageBox.Show("Não é possível dar baixa neste pedido aqui. Baixe direto no formulário de pedido.");
                                SchedulerControl.SelectedAppointments[0].StatusKey = st;
                            }
                            return;
                        }
                    }
                    TBindingSource.EndEdit();
                    EntradasMySqlDataAdapter.Update(TDataSet.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void SchedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
           // Appointment ap = (Appointment)e;

            if (MessageBox.Show("Tem certeza que vai apagar a tarefa?","APAGAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //bll.Exclui(Convert.ToInt32(ap.Id));
                TBindingSource.EndEdit();
                EntradasMySqlDataAdapter.Update(TDataSet.Tables[0]);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelecionaEntradas();
        }

        private void LocalizarTarefa(string texto, int inicio = 0, bool frente = true)
        {
            int r = 0;

            texto = texto.ToUpper();

            if (!frente)
            {
                if (inicio == 0) inicio = SchedulerStorage1.Appointments.Count - 1;
                for (r = inicio; r > 0; r--)
                {
                    string s1 = SchedulerStorage1.Appointments[r].Subject.ToUpper();
                    string s2 = SchedulerStorage1.Appointments[r].Description.ToUpper();
                    if (s1.IndexOf(texto) > -1 ||
                        s2.IndexOf(texto) > -1)
                    {
                        //DateNavigator2.DateTime = SchedulerStorage1.Appointments(r).Start
                        SchedulerControl.ActiveView.SelectAppointment(SchedulerStorage1.Appointments[r]);
                        //txtProtocoloLocalizar.Focus();

                        return; // TODO: might not be correct. Was : Exit For
                    }
                }
            }
            else
            {
                for (r = inicio; r <= SchedulerStorage1.Appointments.Count - 1; r++)
                {
                    string s1 = SchedulerStorage1.Appointments[r].Subject.ToUpper();
                    string s2 = SchedulerStorage1.Appointments[r].Description.ToUpper();
                    if (s1.IndexOf(texto) > -1 ||
                        s2.IndexOf(texto) > -1)
                    {
                        //DateNavigator2.DateTime = SchedulerStorage1.Appointments(r).Start
                        SchedulerControl.ActiveView.SelectAppointment(SchedulerStorage1.Appointments[r]);
                        //txtProtocoloLocalizar.Focus();

                        return; // TODO: might not be correct. Was : Exit For
                    }
                }
            }
        }

        private void btnLocalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LocalizarTarefa(Convert.ToString(txtLocalizar.EditValue), 0, true);
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               LocalizarTarefa((sender as TextEdit).Text, 0, true);
        }

        private void btnAnterior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int pos;

            if (SchedulerControl.SelectedAppointments.Count == 0)
            {
                pos = 0;
            }
            else
            {
                Appointment apt = SchedulerControl.SelectedAppointments[0];
                pos = (int)apt.RowHandle;
            }

            if (pos < SchedulerStorage1.Appointments.Count - 1) LocalizarTarefa(Convert.ToString(txtLocalizar.EditValue), pos + 1, true);
        }

        private void btnProxima_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int pos;

            if (SchedulerControl.SelectedAppointments.Count == 0)
            {
                pos = SchedulerStorage1.Appointments.Count;
            }
            else
            {
                Appointment apt = SchedulerControl.SelectedAppointments[0];
                pos = (int)apt.RowHandle;
            }    

            if (pos > 1) LocalizarTarefa(Convert.ToString(txtLocalizar.EditValue), pos - 1, false);
        }

        private void btnHoje_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SchedulerControl.GoToDate(DateTime.Now);
        }

        private void chkTotasTarefas_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkTotasTarefas.Checked)
            {
                inicioSemana = Convert.ToDateTime("2010/01/01 00:00:00");
            }
            else
            {
                //inicio = String.Format("{0:yyyy-MM-dd hh:mm:ss}", Today.AddDays(-Today.DayOfWeek))
                inicioSemana = DateTime.Now.AddDays(-(int)(DateTime.Now.DayOfWeek + 7));
                // início da semana anterior
            }
            SelecionaEntradas();
        }

        private void chkEntregues_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelecionaEntradas();
        }

        private void SchedulerControl_GotoDateFormShowing(object sender, GotoDateFormEventArgs e)
        {
            rgrpView.DoValidate(); 
        }

        private void frmAgendaPedido_Activated(object sender, EventArgs e)
        {
            SelecionaEntradas();
        }
    }
}
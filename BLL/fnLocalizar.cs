using DevComponents.DotNetBar.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class fnLocalizar
    {
        fnRetiraAcento ra = new fnRetiraAcento();

        public void Localizar(GridView dgRegistros, string filtroValor, int ri, bool PraFrente)
        {
            string[] mValor = new string[1];
            bool opOu = false;
            bool[] flEncontrou = new bool[1];
            string txt;
            bool todos;
            int c;

            //splashScreenManager1.ShowWaitForm();
            try
            {
                //fp.sbBarra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                SplashScreenManager.ShowDefaultWaitForm("Aguarde", "Localizando...");

                filtroValor = ra.RetiraAcento(filtroValor);

                if (filtroValor.Contains("="))  //Campo:conteudo
                {
                    mValor = filtroValor.Split('=');

                    for (c = 0; c < dgRegistros.Columns.Count; c++)
                    {
                        if (mValor[0] == dgRegistros.Columns[c].FieldName.ToUpper())
                        {
                            // realiza a busca pela coluna encontrada
                            for (int r = ri; r < dgRegistros.RowCount; r++)
                            {
                                txt = ra.RetiraAcento(dgRegistros.GetDataRow(r).ItemArray[c].ToString());
                                if (txt == (mValor[1]))
                                {
                                    dgRegistros.FocusedRowHandle = Convert.ToInt32(dgRegistros.GetRowHandle(r));
                                    return;
                                }

                            }

                        }
                    }

                }
                else if (filtroValor.Contains("|"))
                {
                    mValor = filtroValor.Split('|');
                    opOu = true;
                }
                else
                {
                    mValor = filtroValor.Split('&');
                    opOu = false;
                }
                Array.Resize(ref flEncontrou, mValor.Length);
                if (PraFrente)
                {
                    for (int r = ri; r < dgRegistros.RowCount; r++)
                    {
                        //fp.sbBarra.EditValue = r;
                        // set todos como falso
                        for (int a = 0; a < mValor.Length; a++)
                        {
                            flEncontrou[a] = false;
                        }
                        for (c = 0; c < dgRegistros.Columns.Count; c++)
                        {
                            if (dgRegistros.GetDataRow(r).ItemArray[c] == null) continue;
                            txt = ra.RetiraAcento(dgRegistros.GetDataRow(r).ItemArray[c].ToString());
                            for (int a = 0; a < mValor.Length; a++)
                            {
                                if (txt.Contains(mValor[a]))
                                {
                                    flEncontrou[a] = true; //valida a exp atual
                                    if (opOu)
                                    {
                                        dgRegistros.FocusedRowHandle = Convert.ToInt32(dgRegistros.GetRowHandle(r));

                                        //dgRegistros.CurrentCell = dgRegistros.GetDataRow(r).ItemArray[c];
                                        return;
                                    }
                                }
                            }
                        }
                        if (!opOu)
                        {
                            todos = true;
                            for (int a = 0; a < flEncontrou.Length; a++)
                            {
                                if (!flEncontrou[a]) { todos = false; } //pelo menos falso
                            }
                            if (todos)
                            {
                                dgRegistros.FocusedRowHandle = Convert.ToInt32(dgRegistros.GetRowHandle(r));
                                ///dgRegistros.Rows[r].Selected = true;
                                ///dgRegistros.CurrentCell = dgRegistros.GetDataRow(r).ItemArray[0];
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Fim do arquivo!");
                }
                else  //procura para trás
                {
                    for (int r = ri; r >= 0; r--)
                    {
                        //fp.sbBarra.EditValue = r;
                        // set todos como falso
                        for (int a = 0; a < mValor.Length; a++)
                        {
                            flEncontrou[a] = false;
                        }
                        for (c = 0; c < dgRegistros.Columns.Count; c++)
                        {
                            if (dgRegistros.GetDataRow(r).ItemArray[c] == null) continue;
                            txt = ra.RetiraAcento(dgRegistros.GetDataRow(r).ItemArray[c].ToString());
                            for (int a = 0; a < mValor.Length; a++)
                            {
                                if (txt.Contains(mValor[a]))
                                {
                                    flEncontrou[a] = true; //valida a exp atual
                                    if (opOu)
                                    {
                                        dgRegistros.FocusedRowHandle = Convert.ToInt32(dgRegistros.GetRowHandle(r));
                                        ///dgRegistros.Rows[r].Selected = true;
                                        ///dgRegistros.CurrentCell = dgRegistros[0, r];
                                        return;
                                    }
                                }
                            }
                        }
                        if (!opOu)
                        {
                            todos = true;
                            for (int a = 0; a < flEncontrou.Length; a++)
                            {
                                if (!flEncontrou[a]) { todos = false; } //pelo menos falso
                            }
                            if (todos)
                            {
                                dgRegistros.FocusedRowHandle = Convert.ToInt32(dgRegistros.GetRowHandle(r));
                                ///dgRegistros.Rows[r].Selected = true;
                                ///dgRegistros.CurrentCell = dgRegistros[0, r];
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Início do arquivo!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                SplashScreenManager.CloseForm();
                //splashScreenManager1.CloseWaitForm();
                //fp.sbBarra.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
    }
}

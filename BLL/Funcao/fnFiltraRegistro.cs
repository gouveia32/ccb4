using DevComponents.DotNetBar.Controls;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    class fnLocalizaNaGrade
    {
        fnRetiraAcento ra = new fnRetiraAcento();

        public void Localizar(DataGridViewX dgRegistros, string filtroValor, int ri, bool PraFrente)
        {
            string[] mValor = new string[1];
            bool opOu = false;
            bool[] flEncontrou = new bool[1];
            string txt;

            //splashScreenManager1.ShowWaitForm();
            try
            {
                //fp.sbBarra.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                SplashScreenManager.ShowDefaultWaitForm("Aguarde", "Localizando...");

                filtroValor = ra.RetiraAcento(filtroValor);
                if (filtroValor.Contains("|"))
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
                        for (int c = 0; c < dgRegistros.Columns.Count; c++)
                        {
                            if (dgRegistros.Rows[r].Cells[c].Value.ToString() == null) continue;
                            txt = ra.RetiraAcento(dgRegistros.Rows[r].Cells[c].Value.ToString());
                            for (int a = 0; a < mValor.Length; a++)
                            {
                                if (txt.Contains(mValor[a]))
                                {
                                    flEncontrou[a] = true; //valida a exp atual
                                    if (opOu)
                                    {
                                        dgRegistros.Rows[r].Selected = true;
                                        dgRegistros.CurrentCell = dgRegistros[0, r];
                                        return;
                                    }
                                }
                            }
                        }
                        if (!opOu)
                        {
                            bool todos = true;
                            for (int a = 0; a < flEncontrou.Length; a++)
                            {
                                if (!flEncontrou[a]) { todos = false; } //pelo menos falso
                            }
                            if (todos)
                            {
                                dgRegistros.Rows[r].Selected = true;
                                dgRegistros.CurrentCell = dgRegistros[0, r];
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
                        for (int c = 0; c < dgRegistros.Columns.Count; c++)
                        {
                            if (dgRegistros.Rows[r].Cells[c].Value.ToString() == null) continue;
                            txt = ra.RetiraAcento(dgRegistros.Rows[r].Cells[c].Value.ToString());
                            for (int a = 0; a < mValor.Length; a++)
                            {
                                if (txt.Contains(mValor[a]))
                                {
                                    flEncontrou[a] = true; //valida a exp atual
                                    if (opOu)
                                    {
                                        dgRegistros.Rows[r].Selected = true;
                                        dgRegistros.CurrentCell = dgRegistros[0, r];
                                        return;
                                    }
                                }
                            }
                        }
                        if (!opOu)
                        {
                            for (int a = 0; a < flEncontrou.Length; a++)
                            {
                                if (flEncontrou[a])
                                {
                                    dgRegistros.Rows[r].Selected = true;
                                    dgRegistros.CurrentCell = dgRegistros[0, r];
                                    return;
                                }
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

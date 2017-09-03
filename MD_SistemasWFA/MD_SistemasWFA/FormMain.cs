using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using MD_SistemasWFA.Properties;
using System.Resources;
using BusinessLogic.MST_BL;
using InterfacesManager.IM_BL;
using MetroFramework.Controls;
using MetroFramework;

namespace MD_SistemasWFA
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        //Ihttp://icon-icons.com/es/icono
        //(OBJ) TO EVENS
        ControlEventBL objControlEventBL;

        // (OBJ) TO RESIZE
        ControlResizeBL objControlResizeBL;

        // (OBJ) OLD FORM
        Form OldForm = new Form();
        // (OBJ LIST) ORIGINAL SIZE CONTROLS
        List<Rectangle> listRectangleOriginalSizeControls;
        //(OBJ LIST) ORIGINAL LIST CONTROLS 
        List<Control> listOriginalControls;
        // (OBJ LIST) LIST BTN CREATING 
        List<Control> listBtnCretae;
        
        // (STRING) PASSWORD
        private string password = "";
        public string channels = "";

        public FormMain()
        {
            InitializeComponent();

            //METHOD (ENABLED) ENABLED TIME        
            timer.Enabled = true;
            
            //STYLE MANAGER
            StyleManager = metroStyleManager;

            //METHOD (CREATE) CREATE CHANNELS
            CreateChannels(7);

            //METHOD (SAVE) THIS SIZE
            OldForm.Size = this.Size;

            //METHOD (SEND) READ ORIGINAL (RECTANGLECONTROLS AND CONTROLS)
            ReadOriginalRectControls();
        }

            
        //EVENTS TO BUTTONS
        #region (EVENT) BTN_SI
        private void btn_Si_Click(object sender, EventArgs e)
        {
            if (password == "12345")
            {
                FormTable frm = new FormTable();
                frm.MetroStryleManagerForm.Theme = metroStyleManager.Theme;
                frm.MetroStryleManagerForm.Style = metroStyleManager.Style;
                frm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "El # de ID ingresado no es correcto ", "Error al Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                password = "";
                txt_Password2.Text = "";
            }
        }
        #endregion
        #region (EVENTS) BTN_NO 
        private void btn_No_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion
        #region (EVENTS) BTN_ENTRADA/SALIDA
        private void btn_EntradaSalida_Click(object sender, EventArgs e)
        {
            FormConfiguration sh_frm = new FormConfiguration();
            DialogResult res = sh_frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                metroStyleManager.Theme = sh_frm.MetroStryleManagerForm.Theme;
                metroStyleManager.Style = sh_frm.MetroStryleManagerForm.Style;
                this.Width = sh_frm.Width;
                this.Height = sh_frm.Height;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
        }
        #endregion

        //******************************METHODS***********************************\\
        #region (METHOD) TIME
        private void timer_Tick(object sender, EventArgs e)
        {
            //MOSTRAR LA FECHA
            string a = DateTime.Today.ToString("D");
            //string b = DateTime.Now.ToString("HH:mm:ss.f");
            string b = DateTime.Now.ToString("HH:mm:ss");
            lbl_Date.Text = a + " - " + b;
        }
        #endregion

        #region (METHOD) MOUSE ENTER AND LEAVE
        //MOUSE ENTER AND LEAVE (METHO GENERAL)
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            objControlEventBL = new ControlEventBL();
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn = objControlEventBL.MouseEnter(sender);
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn = objControlEventBL.MouseLeave(sender);
            objControlEventBL = null;
        }
        #endregion

        #region (METHOD) CUSTOMER BACK COLOR_GENERAL (MOUSE ENTER AND LEAVE)
        private void btn_CustomerBackColor_MouseEnter(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = true;
        }

        private void btn_CustomerBackColor_MouseLeave(object sender, EventArgs e)
        {
            var ctn = (MetroFramework.Controls.MetroTile)sender;
            ctn.UseCustomBackColor = false;
        }
        #endregion

        #region (METHOD) BTN NUMEBERS
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (password.Length > 0)
            {
                password = password.Remove(password.Length - 1);
                txt_Password.Text = txt_Password.Text.Remove(txt_Password.Text.Length - 1);
            }
        }
        private void btn_Punto_Click(object sender, EventArgs e)
        {
            password += ".";
        }
        private void btn_Number_Click(object sender, EventArgs e)
        {
            password += ((MetroTile)sender).Tag;
            txt_Password.Text += "*";
        }
        #endregion

        #region (METHOD) RESIZE
        private void FormMain_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
        private void resizeChildrenControls()
        {
            Form NewForm = this;
            //METHOD(RETURN) NEW SIZE CONTROLS           
            if (listOriginalControls.Count > 0)
            {
                listOriginalControls = objControlResizeBL.resizeChildrenControlsAll(OldForm, NewForm);
            }
        }
        private void ReadOriginalRectControls()
        {
            //CRETAE --> DELETE (OTHER METHOD)
            listOriginalControls = new List<Control>();
            objControlResizeBL = new ControlResizeBL();
            listRectangleOriginalSizeControls = new List<Rectangle>();

            //READ CONTROLS
            Form newForm = this;
            for (int i = 0; i < newForm.Controls.Count; i++)
            {
                listOriginalControls.Add(newForm.Controls[i]);
            }
            //ERROR:
            listOriginalControls.Add(lblDate2);
            listOriginalControls.Add(txt_Password2);
            listOriginalControls.Add(txt_Password);

            //ERROR BTNS
            listOriginalControls.Add(btn_00);
            listOriginalControls.Add(btn_Punto);
            listOriginalControls.Add(btn_Delete);
            listOriginalControls.Add(btn_01);
            listOriginalControls.Add(btn_02);
            listOriginalControls.Add(btn_03);
            listOriginalControls.Add(btn_04);
            listOriginalControls.Add(btn_05);
            listOriginalControls.Add(btn_06);
            listOriginalControls.Add(btn_07);
            listOriginalControls.Add(btn_08);
            listOriginalControls.Add(btn_09);

            //ERROR BTN SI NO E/S
            listOriginalControls.Add(btn_Si);
            listOriginalControls.Add(btn_No);
            listOriginalControls.Add(btn_EntradaSalida);
            //ERROR BTN CHANNELS
            for (int z = 0; z < listBtnCretae.Count; z++)
            {
                listOriginalControls.Add(listBtnCretae[z]);
            }
            //DELETE (OTHER METHOD)
            listBtnCretae = null;

            //ADD THE OBJCONTROLRESIZE
            objControlResizeBL.OriginalRectControls(listOriginalControls);
            //CONTROLS TO LIST<RECTANGLE> CONTROLS 

            for (int j = 0; j < listOriginalControls.Count; j++)
            {
                Rectangle RectangleControls = new Rectangle(listOriginalControls[j].Location.X, listOriginalControls[j].Location.Y, listOriginalControls[j].Width, listOriginalControls[j].Height);
                listRectangleOriginalSizeControls.Add(RectangleControls);
            }
        }
        #endregion

        #region (METHOD) CREATE CHANNELS
        public void CreateChannels(int x)
        {
            panelLeftDownChannels.Controls.Clear();
            panelLeftDownChannels.AutoScroll = false;
            panelLeftDownChannels.HorizontalScroll.Enabled = false;
            panelLeftDownChannels.HorizontalScroll.Visible = false;
            panelLeftDownChannels.HorizontalScroll.Maximum = 0;
            panelLeftDownChannels.AutoScroll = true;

            var listMSTt04_canal_vtaBL = MSTt04_canal_vtaBL.GetCanals2();
            //NEW
            ControlCreateBL objControlCreateBL = new ControlCreateBL();

            //CREATE AND DELETE
            objControlEventBL = new ControlEventBL();
            listBtnCretae = new List<Control>();

            for (int i = 0; i < listMSTt04_canal_vtaBL.Count; i++)
            {
                //Button btnNuevo = new Button();
                MetroTile btnNuevo = new MetroTile();
                //SEND TYPE EVENT
                btnNuevo.Tag = "NO";
                btnNuevo = objControlCreateBL.CreateButton(
                                                        listMSTt04_canal_vtaBL[i].txt_desc,
                                                        listMSTt04_canal_vtaBL[i].txt_abrv,
                                                        btnNuevo.Tag + ""
                                                        );
                //ASSIGN EVENT             
                btnNuevo = (MetroTile)objControlEventBL.SendCorrectEvent(btnNuevo);
                btnNuevo.MouseEnter += new EventHandler(btn_CustomerBackColor_MouseEnter);
                btnNuevo.MouseLeave += new EventHandler(btn_CustomerBackColor_MouseLeave);
                panelLeftDownChannels.Controls.Add(btnNuevo);

                //STYLE CUSTOM 
                btnNuevo.Width = 210;
                btnNuevo.Height = 135;

                listBtnCretae.Add(btnNuevo);
            }
            objControlEventBL = null;
        }
        #endregion

        
    }




}

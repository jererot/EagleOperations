using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesManager.IM_DA
{
    public class ControlCreateDA
    {
        #region (METHOD) CREATE BUTTON
        //CREATE BUTTONS
        public MetroTile CreateButton(string name, string text , string tag)
        {
            //Button btnNuevo = new Button();
            MetroFramework.Controls.MetroTile btnNuevo = new MetroFramework.Controls.MetroTile();
            btnNuevo.Name = text;
            btnNuevo.Text = name;
            btnNuevo.AutoSize = true;
            btnNuevo.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnNuevo.Width = 50;// panelLeftDownChannels.Width - 20;
            btnNuevo.Height = 70;
            //STYLE METRO
            btnNuevo.BackColor = Color.RoyalBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.TextAlign = ContentAlignment.MiddleCenter;
            btnNuevo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            btnNuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            btnNuevo.Padding = new Padding(3);

            //TAG TO EVENT
            btnNuevo.Tag = "NO";
            return btnNuevo;


        }
        #endregion
        
    }
}

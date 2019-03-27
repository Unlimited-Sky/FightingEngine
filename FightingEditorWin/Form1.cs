using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightingEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //
        //File Menu
        //
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        //Animation Controls
        //
        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {

        }

        private void animScrubber_Scroll(object sender, EventArgs e)
        {

        }

        //
        //Image Controls
        //
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {

        }

        private void numericKeyframeLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnimType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //
        //Keyframe Properties
        //
        private void btnIsAirborne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyframeTags_TextChanged(object sender, EventArgs e)
        {

        }

        //
        //ROOT MOTION
        //

        //
        //Collision Boxes
        //
        private void UpdateFrameData()
        {

        }

        private void btnAddRootHitbox_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHitbox_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteHitbox_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRootHurtbox_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHurtbox_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteHurtbox_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectCollider_Click(object sender, EventArgs e)
        {

        }

        private void numericLeft_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericTop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericRight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericBottom_ValueChanged(object sender, EventArgs e)
        {

        }

        //
        //Hit Properties
        //
        private void cmbHitType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericHitStop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericHitStun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericBlockStun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericDamage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbHitResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbJuggleProperties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkSpecialCancel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkJumpCancel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkUniqueActionCancel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDashCancel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCancelRoute_TextChanged(object sender, EventArgs e)
        {

        }

        //
        //Hurtbox Properties
        //
        private void chkProjectileImmune_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkLowImmune_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

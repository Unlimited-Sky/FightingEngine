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
            //TODO
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //Animation Controls
        //
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void animScrubber_Scroll(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //Image Controls
        //
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            //TODO
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericKeyframeLength_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void cmbAnimType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //Keyframe Properties
        //
        private void btnIsAirborne_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void txtKeyframeTags_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //ROOT MOTION
        //

        //
        //Collision Boxes
        //
        private void updateFrameData()
        {
            lblCurrentKeyframe.Text = getCurrentKeyFrame();
            lblTotalFrames.Text = getTotalKeyframes();
            lblTotalPrevFrames.Text = getTotalPrevFrames();

            lblStartupFrames.Text = getStartupFrames();
            lblActiveFrames.Text = getActiveFrames();
            lblOnHitFrames.Text = getOnHitFrames();
            lblOnBlockFrames.Text = getOnBlockFrames();
            lblTotalFrames.Text = getTotalFrames();
        }

        //TODO
        private string getCurrentKeyFrame()
        {
            return "";
        }
        //TODO
        private string getTotalKeyframes()
        {
            return "";
        }
        //TODO
        private string getTotalPrevFrames()
        {
            return "";
        }
        //TODO
        private string getStartupFrames()
        {
            return "";
        }
        //TODO
        private string getActiveFrames()
        {
            return "";
        }
        //TODO
        private string getOnHitFrames()
        {
            return "";
        }
        //TODO
        private string getOnBlockFrames()
        {
            return "";
        }
        //TODO
        private string getTotalFrames()
        {
            return "";
        }
        //TODO
        private void btnAddRootHitbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddHitbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnDeleteHitbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddRootHurtbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddHurtbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnDeleteHurtbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnSelectCollider_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericLeft_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericTop_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericRight_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericBottom_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //Hit Properties
        //
        private void cmbHitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericHitStop_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericHitStun_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericBlockStun_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericDamage_ValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void cmbHitResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void cmbJuggleProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void chkSpecialCancel_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void chkJumpCancel_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void chkUniqueActionCancel_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void chkDashCancel_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void txtCancelRoute_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }

        //
        //Hurtbox Properties
        //
        private void chkProjectileImmune_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void chkLowImmune_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }
    }
}

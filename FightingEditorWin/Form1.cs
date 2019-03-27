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
            //TODO: Add save dialog
            Close();
        }

        //
        //Animation Controls
        //
        private void btnFirst_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrame(1);
            updateFrameData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrame(
                renderPreview.animator.AnimData.GetPreviousKeyFrameFromFrame(
                    renderPreview.animator.CurrentFrame));
            updateFrameData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrame(
                renderPreview.animator.AnimData.GetNextKeyFrameFromFrame(
                    renderPreview.animator.CurrentFrame));
            updateFrameData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrame(
                renderPreview.animator.AnimData.GetFirstFrameOfKeyframe(
                    renderPreview.animator.AnimData.GetNumKeyFrames()));
            updateFrameData();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (renderPreview.animator.IsPlaying)
                renderPreview.animator.Pause();
            else
                renderPreview.animator.Resume();

            updateFrameData();
        }

        private void animScrubber_Scroll(object sender, EventArgs e)
        {
            //TODO
            updateFrameData();
        }

        //
        //Image Controls
        //
        private void treeImages_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            //TODO
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach(string filePath in dialog.FileNames)
                    renderPreview.LoadTexture(filePath);

                foreach(string safePath in dialog.SafeFileNames)
                    treeImages.Nodes.Add(safePath);

                updateFrameData();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            //TODO

            updateFrameData();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            //TODO
            updateFrameData();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            //TODO
            updateFrameData();
        }

        private void numericKeyframeLength_ValueChanged(object sender, EventArgs e)
        {
            //TODO
            updateFrameData();
        }

        private void chkColliderDisabled_CheckedChanged(object sender, EventArgs e)
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

        //DATA I NEED TO LOAD/SAVE BEFORE EXPORT:
        //ALL ANIM DATA
        //cmbAnimType

        //KEYFRAME DATA
        //btnIsAirborne
        //txtKeyframeTags

        //HIT PROPERTIES
        //cmbHitType
        //numericHitStop
        //numericHitStun
        //numericBlockStun
        //numericDamage
        //cmbHitResult
        //cmbJuggleProperties
        //chkSpecialCancel
        //chkJumpCancel
        //chkUniqueActionCancel
        //chkDashCancel
        //txtCancelRoute

        //HURT PROPERTIES
        //chkProjectileImmune
        //chkLowImmune
    }
}

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
    public partial class FightingEditorForm : Form
    {
        public FightingEditorForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            renderPreview.editorForm = this;
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
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(0);
            updateFrameData();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(
                renderPreview.animator.AnimData.GetPreviousKeyFrameIndexFromFrame(
                    renderPreview.animator.CurrentFrame));
            updateFrameData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(
                renderPreview.animator.AnimData.GetNextKeyFrameIndexFromFrame(
                    renderPreview.animator.CurrentFrame));
            updateFrameData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(   
                    renderPreview.animator.AnimData.GetNumKeyFrames() - 1);
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
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(animScrubber.Value);
       
            updateFrameData();
        }

        //
        //Image Controls
        //
        private void treeImages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(treeImages.SelectedNode.Index);
            updateFrameData();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach(string filePath in dialog.FileNames)
                    renderPreview.LoadTexture(filePath);

                foreach(string safePath in dialog.SafeFileNames)
                    treeImages.Nodes.Add(safePath);

                animScrubber.Maximum = treeImages.Nodes.Count - 1;

                updateFrameData();
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (treeImages.Nodes.Count == 1)
                return;

            renderPreview.RemoveKeyFrame(treeImages.SelectedNode.Index);
            treeImages.SelectedNode.Remove();

            updateFrameData();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int index = treeImages.SelectedNode.Index;

            if (treeImages.Nodes.Count == 1 || index == 0)
                return;

            renderPreview.SwapKeyFrames(index, index - 1);
            moveDown(index - 1);
            treeImages.SelectedNode = treeImages.Nodes[index - 1];
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(index - 1);

            updateFrameData();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int index = treeImages.SelectedNode.Index;

            if (treeImages.Nodes.Count == 1 || index == treeImages.Nodes.Count - 1)
                return;

            renderPreview.SwapKeyFrames(index, index + 1);
            moveDown(index);
            treeImages.SelectedNode = treeImages.Nodes[index + 1];

            updateFrameData();
        }

        private void moveDown(int i)
        {
            TreeNode tempNode = treeImages.Nodes[i];
            treeImages.Nodes.RemoveAt(i);
            treeImages.Nodes.Insert(i + 1, tempNode);
        }

        private void numericKeyFrameLength_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = treeImages.SelectedNode.Index;
            int currKeyframe = renderPreview.animator.GetAnimKeyFrameIndex();
            renderPreview.AdjustKeyFrameLength(selectedIndex, (int)numericKeyFrameLength.Value);
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(currKeyframe);
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
            lblTotalPrevFrames.Text = renderPreview.animator.CurrentFrame.ToString();

            lblStartupFrames.Text = getStartupFrames();
            lblActiveFrames.Text = getActiveFrames();
            lblOnHitFrames.Text = getOnHitFrames();
            lblOnBlockFrames.Text = getOnBlockFrames();

            updateKeyFrameData();
        }

        private void updateKeyFrameData()
        {
            int animKeyFrameIndex = renderPreview.animator.GetAnimKeyFrameIndex();

            lblTotalKeyFrames.Text = renderPreview.animator.AnimData.GetNumKeyFrames().ToString();
            lblCurrentKeyFrame.Text = (animKeyFrameIndex + 1).ToString();

            animScrubber.Value = animKeyFrameIndex;

            lblTotalFrames.Text = renderPreview.animator.AnimData.GetTotalFrames().ToString();

            treeImages.SelectedNode = treeImages.Nodes[animKeyFrameIndex];

            ChangeNumericKeyFrameValue(renderPreview.animator.AnimData.GetKeyFrameLengthAtIndex(animKeyFrameIndex));
        }

        private void ChangeNumericKeyFrameValue(int newValue)
        {
            numericKeyFrameLength.ValueChanged -= numericKeyFrameLength_ValueChanged;
            numericKeyFrameLength.Value = newValue;
            numericKeyFrameLength.ValueChanged += numericKeyFrameLength_ValueChanged;
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

        private void btnAddRootHitbox_Click(object sender, EventArgs e)
        {
            renderPreview.AddRootHitBox();
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
            renderPreview.AddRootHurtBox();
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

        public void UpdateFormFields()
        {
            updateKeyFrameData();
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

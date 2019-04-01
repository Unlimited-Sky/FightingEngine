using FightingEngine.Collision;
using FightingEngine.Gameplay;
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
        private readonly string HIT_ROOT = "HitRoot";
        private readonly string HIT_BOX = "HitBox";

        private readonly string HURT_ROOT = "HurtRoot";
        private readonly string HURT_BOX = "HurtBox";

        public FightingEditorForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            renderPreview.editorForm = this;

            cmbHitType.DataSource = Enum.GetValues(typeof(HITTYPE));
            cmbHitResult.DataSource = Enum.GetValues(typeof(HITRESULT));
            cmbJuggleProperties.DataSource = Enum.GetValues(typeof(JUGGLETYPE));
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

            updateCollisionsTree();
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
            HITTYPE hitType = (HITTYPE)cmbHitType.SelectedIndex;
            HITRESULT hitResult = (HITRESULT)cmbHitResult.SelectedIndex;
            JUGGLETYPE juggleProperties = (JUGGLETYPE)cmbJuggleProperties.SelectedIndex;
            
            HitBoxData data = new HitBoxData(
                hitType, (int)numericHitStop.Value, (int)numericHitStun.Value, (int)numericBlockStun.Value, (int)numericDamage.Value,
                    hitResult, juggleProperties,
                chkSpecialCancel.Checked, chkJumpCancel.Checked, chkUniqueActionCancel.Checked, chkDashCancel.Checked,
                    txtCancelRoute.Text);

            renderPreview.AddRootHitBox(animScrubber.Value, data);

            updateCollisionsTree();
        }

        private void btnAddHitbox_Click(object sender, EventArgs e)
        {
            //TODO
            if (treeCollisions.SelectedNode != null && treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
            {
                string text = treeCollisions.SelectedNode.Text.Replace(HIT_ROOT, "");
                int rootIndex = Convert.ToInt32(text);
                renderPreview.AddHitBox(animScrubber.Value, rootIndex,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                updateCollisionsTree();
            }
        }

        private void btnDeleteHitbox_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAddRootHurtbox_Click(object sender, EventArgs e)
        {
            HurtBoxData data = new HurtBoxData(chkProjectileImmune.Checked, chkLowImmune.Checked);

            renderPreview.AddRootHurtBox(animScrubber.Value, data);

            updateCollisionsTree();
        }

        private void btnAddHurtbox_Click(object sender, EventArgs e)
        {
            //TODO
            if (treeCollisions.SelectedNode != null && treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
            {
                string text = treeCollisions.SelectedNode.Text.Replace(HURT_ROOT, "");
                int rootIndex = Convert.ToInt32(text);
                renderPreview.AddHurtBox(animScrubber.Value, rootIndex,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                updateCollisionsTree();
            }
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

        private void updateCollisionsTree()
        {
            //TODO: add individual hit/hurt box loading code
            int currentKeyFrameIndex = renderPreview.animator.GetAnimKeyFrameIndex();

            treeCollisions.Nodes.Clear();

            int counter = 0;

            if (renderPreview.hitBoxKeyFrameData.ContainsKey(currentKeyFrameIndex))
            {
                List<HitBoxRootNode> hitBoxRoots = renderPreview.hitBoxKeyFrameData[currentKeyFrameIndex];

                foreach (HitBoxRootNode hitBox in hitBoxRoots)
                {
                    addHitBoxes(hitBox, counter.ToString());
                    counter += 1;
                }
            }

            if (renderPreview.hurtBoxKeyFrameData.ContainsKey(currentKeyFrameIndex))
            {
                counter = 0;

                List<HurtBoxRootNode> hurtBoxRoots = renderPreview.hurtBoxKeyFrameData[currentKeyFrameIndex];

                foreach (HurtBoxRootNode hurtBox in hurtBoxRoots)
                {
                    addHurtBoxes(hurtBox, counter.ToString());
                    counter += 1;
                }
            }
        }

        private void addHitBoxes(HitBoxRootNode hitBox, string count)
        {
            int counter = 0;
            TreeNode root = new TreeNode(HIT_ROOT + count);
            foreach (SimpleRectNode node in hitBox.Children)
            {
                root.Nodes.Add(new TreeNode(HIT_BOX + counter));
            }

            treeCollisions.Nodes.Add(root);
        }

        private void addHurtBoxes(HurtBoxRootNode hurtBox, string count)
        {
            int counter = 0;
            TreeNode root = new TreeNode(HURT_ROOT + count);
            foreach(SimpleRectNode node in hurtBox.Children)
            {
                root.Nodes.Add(new TreeNode(HURT_BOX + counter));
            }

            treeCollisions.Nodes.Add(root);
        }


        //Called from tick in the render preview
        public void UpdateFormFields()
        {
            updateKeyFrameData();
        }

        //TODO:
        //DATA I NEED TO LOAD/SAVE BEFORE EXPORT:
        //ALL ANIM DATA
        //cmbAnimType

        //KEYFRAME DATA
        //btnIsAirborne
        //txtKeyframeTags
    }
}

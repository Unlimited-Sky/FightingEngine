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

            unbindComboEvents();

            cmbHitType.DataSource = Enum.GetValues(typeof(HITTYPE));
            cmbHitResult.DataSource = Enum.GetValues(typeof(HITRESULT));
            cmbJuggleType.DataSource = Enum.GetValues(typeof(JUGGLETYPE));

            rebindComboEvents();

            disableImageControls();
            disableAnimControls();
            disableHitboxCreationControls();
            disableHurtboxCreationControls();
            disableHitboxEditControls();
            disableHurtboxEditControls();
            disableBoxControls();
        }

        private void unbindComboEvents()
        {
            cmbHitType.SelectedIndexChanged -= cmbHitType_SelectedIndexChanged;
            cmbHitResult.SelectedIndexChanged -= cmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedIndexChanged -= cmbJuggleProperties_SelectedIndexChanged;
        }

        private void rebindComboEvents()
        {
            cmbHitType.SelectedIndexChanged += cmbHitType_SelectedIndexChanged;
            cmbHitResult.SelectedIndexChanged += cmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedIndexChanged += cmbJuggleProperties_SelectedIndexChanged;
        }

        #region File Menu
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
        #endregion

        #region Edit Menu
        private void setBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void rootOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void rootAndChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
        #endregion

        #region View Menu
        private void showOriginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showOriginToolStripMenuItem.Checked)
            {
                renderPreview.ShowOrigin = false;
                showOriginToolStripMenuItem.Checked = false;
            }
            else
            {
                renderPreview.ShowOrigin = true;
                showOriginToolStripMenuItem.Checked = true;
            }
        }

        private void showCurrentFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showCurrentFrameToolStripMenuItem.Checked)
            {
                renderPreview.ShowFrame = false;
                showCurrentFrameToolStripMenuItem.Checked = false;
            }
            else
            {
                renderPreview.ShowFrame = true;
                showCurrentFrameToolStripMenuItem.Checked = true;
            }
        }
        #endregion

        #region Animation Controls
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

        private void disableAnimControls()
        {
            AnimPanel.Enabled = false;
        }

        private void enableAnimControls()
        {
            AnimPanel.Enabled = true;
        }
        #endregion

        #region Image Controls
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
                foreach (string filePath in dialog.FileNames)
                    renderPreview.LoadTexture(filePath);

                foreach (string safePath in dialog.SafeFileNames)
                    treeImages.Nodes.Add(safePath);

                animScrubber.Maximum = treeImages.Nodes.Count - 1;

                updateFrameData();
                enableAnimControls();
                enableImageControls();
                enableHitboxCreationControls();
                enableHurtboxCreationControls();
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

        private void disableImageControls()
        {
            treeImages.Enabled = false;
            btnRemoveImage.Enabled = false;
            btnMoveUp.Enabled = false;
            btnMoveDown.Enabled = false;
            numericKeyFrameLength.Enabled = false;
            cmbAnimType.Enabled = false;
        }

        private void enableImageControls()
        {
            treeImages.Enabled = true;
            btnRemoveImage.Enabled = true;
            btnMoveUp.Enabled = true;
            btnMoveDown.Enabled = true;
            numericKeyFrameLength.Enabled = true;
            cmbAnimType.Enabled = true;
        }
        #endregion

        //
        //ROOT MOTION - TODO 
        //

        #region Collision Boxes
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
            renderPreview.AddRootHitBox(animScrubber.Value, collectHitBoxData());

            updateCollisionsTree();
        }

        private HitBoxData collectHitBoxData()
        {
            HITTYPE hitType = (HITTYPE)cmbHitType.SelectedIndex;
            HITRESULT hitResult = (HITRESULT)cmbHitResult.SelectedIndex;
            JUGGLETYPE juggleProperties = (JUGGLETYPE)cmbJuggleType.SelectedIndex;

            HitBoxData data = new HitBoxData(
                hitType, (int)numericHitStop.Value, (int)numericHitStun.Value, (int)numericBlockStun.Value, (int)numericDamage.Value,
                hitResult, juggleProperties,
                chkSpecialCancel.Checked, chkJumpCancel.Checked, chkUniqueActionCancel.Checked, chkDashCancel.Checked,
                txtCancelRoute.Text);

            return data;
        }

        private void btnAddHitbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode != null)
            {
                int index = -1;
                if (treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
                    index = getCollisionIndex(HIT_ROOT);
                else if (treeCollisions.SelectedNode.Text.Contains(HIT_BOX))
                    index = getParentCollisionIndex(HIT_ROOT);
                else
                    return;

                renderPreview.AddHitBox(animScrubber.Value, index,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                updateCollisionsTree();
            }
        }

        private void btnDeleteHitbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode == null)
                return;
            //TODO
            if (treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
            {

            }
            else if (treeCollisions.SelectedNode.Text.Contains(HIT_BOX))
            {

            }
        }

        private void btnAddRootHurtbox_Click(object sender, EventArgs e)
        {
            renderPreview.AddRootHurtBox(animScrubber.Value, collectHurtBoxData());

            updateCollisionsTree();
        }

        private HurtBoxData collectHurtBoxData()
        {
            HurtBoxData data = new HurtBoxData(chkProjectileImmune.Checked, chkLowImmune.Checked);
            return data;
        }

        private void btnAddHurtbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode != null)
            {
                int index = -1;
                if (treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
                    index = getCollisionIndex(HURT_ROOT);
                else if (treeCollisions.SelectedNode.Text.Contains(HURT_BOX))
                    index = getParentCollisionIndex(HURT_ROOT);
                else
                    return;

                renderPreview.AddHurtBox(animScrubber.Value, index,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                updateCollisionsTree();
            }
        }

        private void btnDeleteHurtbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode == null)
                return;
            //TODO
            if (treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
            {

            }
            else if (treeCollisions.SelectedNode.Text.Contains(HURT_BOX))
            {

            }
        }

        private void btnSelectCollider_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void numericLeft_ValueChanged(object sender, EventArgs e)
        {
            if (numericLeft.Value >= numericRight.Value)
                numericLeft.Value = numericRight.Value;

            resizeBox();
        }

        private void numericTop_ValueChanged(object sender, EventArgs e)
        {
            //todo add size checks like left/right
            resizeBox();
        }

        private void numericRight_ValueChanged(object sender, EventArgs e)
        {
            if (numericRight.Value <= numericLeft.Value)
                numericRight.Value = numericLeft.Value;

            resizeBox();
        }

        private void numericBottom_ValueChanged(object sender, EventArgs e)
        {
            //TODO add size checks like left/right
            resizeBox();
        }

        private void resizeBox()
        {
            renderPreview.ResizeBox((int)numericTop.Value, (int)numericLeft.Value,
                (int)numericBottom.Value, (int)numericRight.Value);
        }

        private void disableBoxEvents()
        {
            numericTop.ValueChanged -= numericTop_ValueChanged;
            numericLeft.ValueChanged -= numericLeft_ValueChanged;
            numericBottom.ValueChanged -= numericBottom_ValueChanged;
            numericRight.ValueChanged -= numericRight_ValueChanged;
        }

        private void enableBoxEvents()
        {
            numericTop.ValueChanged += numericTop_ValueChanged;
            numericLeft.ValueChanged += numericLeft_ValueChanged;
            numericBottom.ValueChanged += numericBottom_ValueChanged;
            numericRight.ValueChanged += numericRight_ValueChanged;
        }

        private void updateCollisionsTree()
        {
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

            disableHitboxEditControls();
            disableHurtboxEditControls();
            disableBoxControls();

            treeCollisions.ExpandAll();

            renderPreview.DeselectCollisions();
        }

        private void addHitBoxes(HitBoxRootNode hitBox, string count)
        {
            int counter = 0;
            TreeNode root = new TreeNode(HIT_ROOT + count);
            foreach (SimpleRectNode node in hitBox.Children)
            {
                TreeNode child = new TreeNode(HIT_BOX + counter);

                root.Nodes.Add(child);
                counter += 1;
            }

            treeCollisions.Nodes.Add(root);
        }

        private void addHurtBoxes(HurtBoxRootNode hurtBox, string count)
        {
            int counter = 0;
            TreeNode root = new TreeNode(HURT_ROOT + count);
            foreach (SimpleRectNode node in hurtBox.Children)
            {
                TreeNode child = new TreeNode(HURT_BOX + counter);
                root.Nodes.Add(child);
                counter += 1;
            }

            treeCollisions.Nodes.Add(root);
        }

        private void treeCollisions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int keyFrame = animScrubber.Value;

            if (treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
            {
                renderPreview.SelectRootHitbox(keyFrame, getCollisionIndex(HIT_ROOT));
                enableHitboxEditControls();
                disableHurtboxEditControls();
                disableBoxControls();
                refreshHitboxRootData();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
            {
                renderPreview.SelectRootHurtbox(keyFrame, getCollisionIndex(HURT_ROOT));
                enableHurtboxEditControls();
                disableHitboxEditControls();
                disableBoxControls();
                refreshHurtboxRootData();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HIT_BOX))
            {
                renderPreview.SelectHitbox(keyFrame, getParentCollisionIndex(HIT_ROOT), getCollisionIndex(HIT_BOX));
                enableHitboxEditControls();
                disableHurtboxEditControls();
                enableBoxControls();
                refreshBoxes();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HURT_BOX))
            {
                renderPreview.SelectHurtbox(keyFrame, getParentCollisionIndex(HURT_ROOT), getCollisionIndex(HURT_BOX));
                enableHurtboxEditControls();
                disableHitboxEditControls();
                enableBoxControls();
                refreshBoxes();
            }
            else
            {
                renderPreview.DeselectCollisions();
            }
        }

        private void refreshBoxes()
        {
            disableBoxEvents();

            SimpleRectNode node = renderPreview.GetSelectedCollisionBoxNode();

            numericTop.Value = node.TopLeft.Y;
            numericLeft.Value = node.TopLeft.X;
            numericBottom.Value = node.BottomRight.Y;
            numericRight.Value = node.BottomRight.X;

            enableBoxEvents();
        }

        private int getCollisionIndex(string collisionType)
        {
            if (treeCollisions.SelectedNode.Text.Contains(collisionType))
                return Convert.ToInt32(treeCollisions.SelectedNode.Text.Replace(collisionType, ""));
            else
                return -1;
        }

        private int getParentCollisionIndex(string parentCollisionType)
        {
            if (treeCollisions.SelectedNode.Parent.Text.Contains(parentCollisionType))
                return Convert.ToInt32(treeCollisions.SelectedNode.Parent.Text.Replace(parentCollisionType, ""));
            else
                return -1;
        }

        private void cmbHitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void numericHitStop_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void numericHitStun_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void numericBlockStun_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void numericDamage_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void cmbHitResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void cmbJuggleProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void chkSpecialCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void chkJumpCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void chkUniqueActionCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void chkDashCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void txtCancelRoute_TextChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(collectHitBoxData());
        }

        private void chkProjectileImmune_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHurtBoxRoot(collectHurtBoxData());
        }

        private void chkLowImmune_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHurtBoxRoot(collectHurtBoxData());
        }

        private void refreshHitboxRootData()
        {
            disableHitboxRootEvents();

            HitBoxData data = renderPreview.GetHitboxRootData();

            cmbHitType.SelectedIndex = (int)data.HitType;
            numericHitStop.Value = data.HitStop;
            numericHitStun.Value = data.HitStun;
            numericBlockStun.Value = data.BlockStun;
            numericDamage.Value = data.Damage;

            cmbHitResult.SelectedIndex = (int)data.HitResult;
            cmbJuggleType.SelectedIndex = (int)data.JuggleType;

            chkSpecialCancel.Checked = data.SpecialCancel;
            chkJumpCancel.Checked = data.JumpCancel;
            chkUniqueActionCancel.Checked = data.UniqueActionCancel;
            chkDashCancel.Checked = data.DashCancel;
            txtCancelRoute.Text = data.CancelRoutes;

            enableHitboxRootEvents();
        }
        
        private void disableHitboxRootEvents()
        {
            cmbHitType.SelectedValueChanged -= cmbHitType_SelectedIndexChanged;
            numericHitStop.ValueChanged -= numericHitStop_ValueChanged;
            numericHitStun.ValueChanged -= numericHitStun_ValueChanged;
            numericBlockStun.ValueChanged -= numericBlockStun_ValueChanged;
            numericDamage.ValueChanged -= numericDamage_ValueChanged;

            cmbHitResult.SelectedValueChanged -= cmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedValueChanged -= cmbJuggleProperties_SelectedIndexChanged;

            chkSpecialCancel.CheckedChanged -= chkSpecialCancel_CheckedChanged;
            chkJumpCancel.CheckedChanged -= chkJumpCancel_CheckedChanged;
            chkUniqueActionCancel.CheckedChanged -= chkUniqueActionCancel_CheckedChanged;
            chkDashCancel.CheckedChanged -= chkDashCancel_CheckedChanged;
            txtCancelRoute.TextChanged -= txtCancelRoute_TextChanged;
        }

        private void enableHitboxRootEvents()
        {
            cmbHitType.SelectedValueChanged += cmbHitType_SelectedIndexChanged;
            numericHitStop.ValueChanged += numericHitStop_ValueChanged;
            numericHitStun.ValueChanged += numericHitStun_ValueChanged;
            numericBlockStun.ValueChanged += numericBlockStun_ValueChanged;
            numericDamage.ValueChanged += numericDamage_ValueChanged;

            cmbHitResult.SelectedValueChanged += cmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedValueChanged += cmbJuggleProperties_SelectedIndexChanged;

            chkSpecialCancel.CheckedChanged += chkSpecialCancel_CheckedChanged;
            chkJumpCancel.CheckedChanged += chkJumpCancel_CheckedChanged;
            chkUniqueActionCancel.CheckedChanged += chkUniqueActionCancel_CheckedChanged;
            chkDashCancel.CheckedChanged += chkDashCancel_CheckedChanged;
            txtCancelRoute.TextChanged += txtCancelRoute_TextChanged;
        }

        private void refreshHurtboxRootData()
        {
            disableHurtboxRootEvents();
            HurtBoxData data = renderPreview.GetHurtboxRootData();
            enableHurtboxRootEvents();
        }

        private void disableHurtboxRootEvents()
        {
            chkProjectileImmune.CheckedChanged -= chkProjectileImmune_CheckedChanged;
            chkLowImmune.CheckedChanged -= chkLowImmune_CheckedChanged;
        }

        private void enableHurtboxRootEvents()
        {
            chkProjectileImmune.CheckedChanged += chkProjectileImmune_CheckedChanged;
            chkLowImmune.CheckedChanged += chkLowImmune_CheckedChanged;
        }

        private void disableHitboxCreationControls()
        {
            btnAddRootHitbox.Enabled = false;
            btnAddHitbox.Enabled = false;
            btnDeleteHitbox.Enabled = false;
        }

        private void disableHitboxEditControls()
        {
            HitPanel.Enabled = false;
        }

        private void disableHurtboxCreationControls()
        {
            btnAddRootHurtbox.Enabled = false;
            btnAddHurtbox.Enabled = false;
            btnDeleteHurtbox.Enabled = false;
        }
        
        private void disableHurtboxEditControls()
        {
            HurtPanel.Enabled = false;
        }

        private void enableHitboxCreationControls()
        {
            btnAddRootHitbox.Enabled = true;
            btnAddHitbox.Enabled = true;
            btnDeleteHitbox.Enabled = true;
        }

        private void enableHitboxEditControls()
        {
            HitPanel.Enabled = true;
        }

        private void enableHurtboxCreationControls()
        {
            btnAddRootHurtbox.Enabled = true;
            btnAddHurtbox.Enabled = true;
            btnDeleteHurtbox.Enabled = true;
        }

        private void enableHurtboxEditControls()
        {
            HurtPanel.Enabled = true;
        }

        private void disableBoxControls()
        {
            numericTop.Enabled = false;
            numericLeft.Enabled = false;
            numericBottom.Enabled = false;
            numericRight.Enabled = false;
        }

        private void enableBoxControls()
        {
            numericTop.Enabled = true;
            numericLeft.Enabled = true;
            numericBottom.Enabled = true;
            numericRight.Enabled = true;
        }
        #endregion

        //Called from tick in the render preview
        public void UpdateFormFields()
        {
            updateKeyFrameData();
        }
    }
}

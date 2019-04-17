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

        private CollisionRootNode copyNode;

        public FightingEditorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderPreview.editorForm = this;

            UnbindComboEvents();

            cmbHitType.DataSource = Enum.GetValues(typeof(HITTYPE));
            cmbHitResult.DataSource = Enum.GetValues(typeof(HITRESULT));
            cmbJuggleType.DataSource = Enum.GetValues(typeof(JUGGLETYPE));

            RebindComboEvents();

            DisableImageControls();
            DisableAnimControls();
            DisableHitboxCreationControls();
            DisableHurtboxCreationControls();
            DisableHitboxEditControls();
            DisableHurtboxEditControls();
            DisableBoxControls();
        }

        private void UnbindComboEvents()
        {
            cmbHitType.SelectedIndexChanged -= CmbHitType_SelectedIndexChanged;
            cmbHitResult.SelectedIndexChanged -= CmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedIndexChanged -= CmbJuggleProperties_SelectedIndexChanged;
        }

        private void RebindComboEvents()
        {
            cmbHitType.SelectedIndexChanged += CmbHitType_SelectedIndexChanged;
            cmbHitResult.SelectedIndexChanged += CmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedIndexChanged += CmbJuggleProperties_SelectedIndexChanged;
        }

        #region File Menu
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Add save dialog
            Close();
        }
        #endregion

        #region Edit Menu
        private void SetBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void RootOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void RootAndChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }
        #endregion

        #region View Menu
        private void ShowOriginToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ShowCurrentFrameToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(0);
            UpdateFrameData();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(
                renderPreview.animator.AnimData.GetPreviousKeyFrameIndexFromFrame(
                    renderPreview.animator.CurrentFrame));
            UpdateFrameData();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(
                renderPreview.animator.AnimData.GetNextKeyFrameIndexFromFrame(
                    renderPreview.animator.CurrentFrame));
            UpdateFrameData();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(
                    renderPreview.animator.AnimData.GetNumKeyFrames() - 1);
            UpdateFrameData();
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (renderPreview.animator.IsPlaying)
                renderPreview.animator.Pause();
            else
                renderPreview.animator.Resume();

            UpdateFrameData();
        }

        private void AnimScrubber_Scroll(object sender, EventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(animScrubber.Value);

            UpdateFrameData();
        }

        private void DisableAnimControls()
        {
            AnimPanel.Enabled = false;
        }

        private void EnableAnimControls()
        {
            AnimPanel.Enabled = true;
        }
        #endregion

        #region Image Controls
        private void TreeImages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(treeImages.SelectedNode.Index);
            UpdateFrameData();
        }

        private void BtnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true
            };
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                foreach (string filePath in dialog.FileNames)
                    renderPreview.LoadTexture(filePath);

                foreach (string safePath in dialog.SafeFileNames)
                    treeImages.Nodes.Add(safePath);

                animScrubber.Maximum = treeImages.Nodes.Count - 1;

                UpdateFrameData();
                EnableAnimControls();
                EnableImageControls();
                EnableHitboxCreationControls();
                EnableHurtboxCreationControls();
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            if (treeImages.Nodes.Count == 1)
                return;

            renderPreview.RemoveKeyFrame(treeImages.SelectedNode.Index);
            treeImages.SelectedNode.Remove();

            UpdateFrameData();
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            int index = treeImages.SelectedNode.Index;

            if (treeImages.Nodes.Count == 1 || index == 0)
                return;

            renderPreview.SwapKeyFrames(index, index - 1);
            MoveDown(index - 1);
            treeImages.SelectedNode = treeImages.Nodes[index - 1];
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(index - 1);

            UpdateFrameData();
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            int index = treeImages.SelectedNode.Index;

            if (treeImages.Nodes.Count == 1 || index == treeImages.Nodes.Count - 1)
                return;

            renderPreview.SwapKeyFrames(index, index + 1);
            MoveDown(index);
            treeImages.SelectedNode = treeImages.Nodes[index + 1];

            UpdateFrameData();
        }

        private void MoveDown(int i)
        {
            TreeNode tempNode = treeImages.Nodes[i];
            treeImages.Nodes.RemoveAt(i);
            treeImages.Nodes.Insert(i + 1, tempNode);
        }

        private void NumericKeyFrameLength_ValueChanged(object sender, EventArgs e)
        {
            int selectedIndex = treeImages.SelectedNode.Index;
            int currKeyframe = renderPreview.animator.GetAnimKeyFrameIndex();
            renderPreview.AdjustKeyFrameLength(selectedIndex, (int)numericKeyFrameLength.Value);
            renderPreview.animator.SetFrameToFirstOfKeyFrameIndex(currKeyframe);
            UpdateFrameData();
        }

        private void ChkColliderDisabled_CheckedChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void DisableImageControls()
        {
            treeImages.Enabled = false;
            btnRemoveImage.Enabled = false;
            btnMoveUp.Enabled = false;
            btnMoveDown.Enabled = false;
            numericKeyFrameLength.Enabled = false;
            cmbAnimType.Enabled = false;
        }

        private void EnableImageControls()
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
        private void UpdateFrameData()
        {
            lblTotalPrevFrames.Text = renderPreview.animator.CurrentFrame.ToString();

            lblStartupFrames.Text = GetStartupFrames();
            lblActiveFrames.Text = GetActiveFrames();
            lblOnHitFrames.Text = GetOnHitFrames();
            lblOnBlockFrames.Text = GetOnBlockFrames();

            UpdateKeyFrameData();

            UpdateCollisionsTree();
        }

        private void UpdateKeyFrameData()
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
            numericKeyFrameLength.ValueChanged -= NumericKeyFrameLength_ValueChanged;
            numericKeyFrameLength.Value = newValue;
            numericKeyFrameLength.ValueChanged += NumericKeyFrameLength_ValueChanged;
        }

        //TODO
        private string GetStartupFrames()
        {
            return "";
        }
        //TODO
        private string GetActiveFrames()
        {
            return "";
        }
        //TODO
        private string GetOnHitFrames()
        {
            return "";
        }
        //TODO
        private string GetOnBlockFrames()
        {
            return "";
        }

        private void BtnAddRootHitbox_Click(object sender, EventArgs e)
        {
            renderPreview.AddRootHitBox(animScrubber.Value, CollectHitBoxData());

            UpdateCollisionsTree();
        }

        private HitBoxData CollectHitBoxData()
        {
            HITTYPE hitType = (HITTYPE)cmbHitType.SelectedIndex;
            HITRESULT hitResult = (HITRESULT)cmbHitResult.SelectedIndex;
            JUGGLETYPE juggleProperties = (JUGGLETYPE)cmbJuggleType.SelectedIndex;

            HitBoxData data = new HitBoxData(
                hitType, (int)numericHitStop.Value, (int)numericHitStun.Value, (int)numericBlockStun.Value, (int)numericDamage.Value,
                hitResult, juggleProperties,
                chkWhiffCancel.Checked,
                chklstCancelRoutes.CheckedItems.Cast<string>().ToList());

            return data;
        }

        private void BtnAddHitbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode != null)
            {
                int index = -1;
                if (treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
                    index = GetCollisionIndex(HIT_ROOT);
                else if (treeCollisions.SelectedNode.Text.Contains(HIT_BOX))
                    index = GetParentCollisionIndex(HIT_ROOT);
                else
                    return;

                renderPreview.AddHitBox(animScrubber.Value, index,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                UpdateCollisionsTree();
            }
        }

        private void BtnDeleteHitbox_Click(object sender, EventArgs e)
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

        private void BtnAddRootHurtbox_Click(object sender, EventArgs e)
        {
            renderPreview.AddRootHurtBox(animScrubber.Value, CollectHurtBoxData());

            UpdateCollisionsTree();
        }

        private HurtBoxData CollectHurtBoxData()
        {
            HurtBoxData data = new HurtBoxData(chkProjectileImmune.Checked, chkLowImmune.Checked);
            return data;
        }

        private void BtnAddHurtbox_Click(object sender, EventArgs e)
        {
            if (treeCollisions.SelectedNode != null)
            {
                int index = -1;
                if (treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
                    index = GetCollisionIndex(HURT_ROOT);
                else if (treeCollisions.SelectedNode.Text.Contains(HURT_BOX))
                    index = GetParentCollisionIndex(HURT_ROOT);
                else
                    return;

                renderPreview.AddHurtBox(animScrubber.Value, index,
                    (int)numericTop.Value, (int)numericLeft.Value, (int)numericBottom.Value, (int)numericRight.Value);

                UpdateCollisionsTree();
            }
        }

        private void BtnDeleteHurtbox_Click(object sender, EventArgs e)
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

        private void BtnSelectCollider_Click(object sender, EventArgs e)
        {
            int currentKeyframe = animScrubber.Value;
            if (renderPreview.collisionFrameData.CharacterColliderFrameData.ContainsKey(currentKeyframe))
            {
                renderPreview.SelectCollider(currentKeyframe);
                CharacterCollider collider = renderPreview.collisionFrameData.CharacterColliderFrameData[currentKeyframe];
                DisableBoxEvents();
                numericTop.Value = collider.Top();
                numericLeft.Value = collider.Left();
                numericBottom.Value = collider.Bottom();
                numericRight.Value = collider.Right();
                EnableBoxEvents();
                EnableBoxControls();

                copyRootChildrenToolStripMenuItem.Enabled = false;
                copyRootToolStripMenuItem.Enabled = false;
            }
        }

        private void NumericLeft_ValueChanged(object sender, EventArgs e)
        {
            if (numericLeft.Value >= numericRight.Value)
                numericLeft.Value = numericRight.Value;

            ResizeBox();
        }

        private void NumericTop_ValueChanged(object sender, EventArgs e)
        {
            if (numericTop.Value >= numericBottom.Value)
                numericTop.Value = numericBottom.Value;

            ResizeBox();
        }

        private void NumericRight_ValueChanged(object sender, EventArgs e)
        {
            if (numericRight.Value <= numericLeft.Value)
                numericRight.Value = numericLeft.Value;

            ResizeBox();
        }

        private void NumericBottom_ValueChanged(object sender, EventArgs e)
        {
            if (numericBottom.Value <= numericTop.Value)
                numericBottom.Value = numericTop.Value;

            ResizeBox();
        }

        private void ResizeBox()
        {
            renderPreview.ResizeBox((int)numericTop.Value, (int)numericLeft.Value,
                (int)numericBottom.Value, (int)numericRight.Value);
        }

        private void DisableBoxEvents()
        {
            numericTop.ValueChanged -= NumericTop_ValueChanged;
            numericLeft.ValueChanged -= NumericLeft_ValueChanged;
            numericBottom.ValueChanged -= NumericBottom_ValueChanged;
            numericRight.ValueChanged -= NumericRight_ValueChanged;
        }

        private void EnableBoxEvents()
        {
            numericTop.ValueChanged += NumericTop_ValueChanged;
            numericLeft.ValueChanged += NumericLeft_ValueChanged;
            numericBottom.ValueChanged += NumericBottom_ValueChanged;
            numericRight.ValueChanged += NumericRight_ValueChanged;
        }

        private void UpdateCollisionsTree()
        {
            int currentKeyFrameIndex = renderPreview.animator.GetAnimKeyFrameIndex();

            treeCollisions.Nodes.Clear();

            int counter = 0;

            if (renderPreview.collisionFrameData.HitBoxKeyFrameData.ContainsKey(currentKeyFrameIndex))
            {
                List<HitBoxRootNode> hitBoxRoots = renderPreview.collisionFrameData.HitBoxKeyFrameData[currentKeyFrameIndex];

                foreach (HitBoxRootNode hitBox in hitBoxRoots)
                {
                    AddHitBoxes(hitBox, counter.ToString());
                    counter += 1;
                }
            }

            if (renderPreview.collisionFrameData.HurtBoxKeyFrameData.ContainsKey(currentKeyFrameIndex))
            {
                counter = 0;

                List<HurtBoxRootNode> hurtBoxRoots = renderPreview.collisionFrameData.HurtBoxKeyFrameData[currentKeyFrameIndex];

                foreach (HurtBoxRootNode hurtBox in hurtBoxRoots)
                {
                    AddHurtBoxes(hurtBox, counter.ToString());
                    counter += 1;
                }
            }

            DisableHitboxEditControls();
            DisableHurtboxEditControls();
            DisableBoxControls();

            treeCollisions.ExpandAll();

            renderPreview.DeselectCollisions();
        }

        private void AddHitBoxes(HitBoxRootNode hitBox, string count)
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

        private void AddHurtBoxes(HurtBoxRootNode hurtBox, string count)
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

        private void TreeCollisions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int keyFrame = animScrubber.Value;

            if (treeCollisions.SelectedNode.Text.Contains(HIT_ROOT))
            {
                renderPreview.SelectRootHitbox(keyFrame, GetCollisionIndex(HIT_ROOT));
                EnableHitboxEditControls();
                DisableHurtboxEditControls();
                DisableBoxControls();
                RefreshHitboxRootData();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HURT_ROOT))
            {
                renderPreview.SelectRootHurtbox(keyFrame, GetCollisionIndex(HURT_ROOT));
                EnableHurtboxEditControls();
                DisableHitboxEditControls();
                DisableBoxControls();
                RefreshHurtboxRootData();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HIT_BOX))
            {
                renderPreview.SelectHitbox(keyFrame, GetParentCollisionIndex(HIT_ROOT), GetCollisionIndex(HIT_BOX));
                EnableHitboxEditControls();
                DisableHurtboxEditControls();
                EnableBoxControls();
                RefreshBoxes();
            }
            else if (treeCollisions.SelectedNode.Text.Contains(HURT_BOX))
            {
                renderPreview.SelectHurtbox(keyFrame, GetParentCollisionIndex(HURT_ROOT), GetCollisionIndex(HURT_BOX));
                EnableHurtboxEditControls();
                DisableHitboxEditControls();
                EnableBoxControls();
                RefreshBoxes();
            }
            else
            {
                renderPreview.DeselectCollisions();
            }
        }

        private void RefreshBoxes()
        {
            DisableBoxEvents();

            SimpleRect rect = renderPreview.GetSelectedCollisionBox();

            numericTop.Value = rect.TopLeft.Y;
            numericLeft.Value = rect.TopLeft.X;
            numericBottom.Value = rect.BottomRight.Y;
            numericRight.Value = rect.BottomRight.X;

            EnableBoxEvents();
        }

        private int GetCollisionIndex(string collisionType)
        {
            if (treeCollisions.SelectedNode.Text.Contains(collisionType))
                return Convert.ToInt32(treeCollisions.SelectedNode.Text.Replace(collisionType, ""));
            else
                return -1;
        }

        private int GetParentCollisionIndex(string parentCollisionType)
        {
            if (treeCollisions.SelectedNode.Parent.Text.Contains(parentCollisionType))
                return Convert.ToInt32(treeCollisions.SelectedNode.Parent.Text.Replace(parentCollisionType, ""));
            else
                return -1;
        }

        private void CmbHitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void NumericHitStop_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void NumericHitStun_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void NumericBlockStun_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void NumericDamage_ValueChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void CmbHitResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void CmbJuggleProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void ChkSpecialCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void ChkJumpCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void ChkUniqueActionCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void ChkDashCancel_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void TxtCancelRoute_TextChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHitBoxRoot(CollectHitBoxData());
        }

        private void ChkProjectileImmune_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHurtBoxRoot(CollectHurtBoxData());
        }

        private void ChkLowImmune_CheckedChanged(object sender, EventArgs e)
        {
            renderPreview.ReInitHurtBoxRoot(CollectHurtBoxData());
        }

        private void RefreshHitboxRootData()
        {
            DisableHitboxRootEvents();

            HitBoxData data = renderPreview.GetHitboxRootData();

            cmbHitType.SelectedIndex = (int)data.HitType;
            numericHitStop.Value = data.HitStop;
            numericHitStun.Value = data.HitStun;
            numericBlockStun.Value = data.BlockStun;
            numericDamage.Value = data.Damage;

            cmbHitResult.SelectedIndex = (int)data.HitResult;
            cmbJuggleType.SelectedIndex = (int)data.JuggleType;

            chkWhiffCancel.Checked = data.WhiffCancel;
            // todo populate this list with moves
            //chklstCancelRoutes.Items ... 

            EnableHitboxRootEvents();
        }
        
        private void DisableHitboxRootEvents()
        {
            cmbHitType.SelectedValueChanged -= CmbHitType_SelectedIndexChanged;
            numericHitStop.ValueChanged -= NumericHitStop_ValueChanged;
            numericHitStun.ValueChanged -= NumericHitStun_ValueChanged;
            numericBlockStun.ValueChanged -= NumericBlockStun_ValueChanged;
            numericDamage.ValueChanged -= NumericDamage_ValueChanged;

            cmbHitResult.SelectedValueChanged -= CmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedValueChanged -= CmbJuggleProperties_SelectedIndexChanged;

            chkWhiffCancel.CheckedChanged -= ChkDashCancel_CheckedChanged;   
        }

        private void EnableHitboxRootEvents()
        {
            cmbHitType.SelectedValueChanged += CmbHitType_SelectedIndexChanged;
            numericHitStop.ValueChanged += NumericHitStop_ValueChanged;
            numericHitStun.ValueChanged += NumericHitStun_ValueChanged;
            numericBlockStun.ValueChanged += NumericBlockStun_ValueChanged;
            numericDamage.ValueChanged += NumericDamage_ValueChanged;

            cmbHitResult.SelectedValueChanged += CmbHitResult_SelectedIndexChanged;
            cmbJuggleType.SelectedValueChanged += CmbJuggleProperties_SelectedIndexChanged;

            chkWhiffCancel.CheckedChanged += ChkDashCancel_CheckedChanged;
        }

        private void RefreshHurtboxRootData()
        {
            DisableHurtboxRootEvents();
            HurtBoxData data = renderPreview.GetHurtboxRootData();
            EnableHurtboxRootEvents();
        }

        private void DisableHurtboxRootEvents()
        {
            chkProjectileImmune.CheckedChanged -= ChkProjectileImmune_CheckedChanged;
            chkLowImmune.CheckedChanged -= ChkLowImmune_CheckedChanged;
        }

        private void EnableHurtboxRootEvents()
        {
            chkProjectileImmune.CheckedChanged += ChkProjectileImmune_CheckedChanged;
            chkLowImmune.CheckedChanged += ChkLowImmune_CheckedChanged;
        }

        private void DisableHitboxCreationControls()
        {
            btnAddRootHitbox.Enabled = false;
            btnAddHitbox.Enabled = false;
            btnDeleteHitbox.Enabled = false;
        }

        private void DisableHitboxEditControls()
        {
            HitPanel.Enabled = false;
        }

        private void DisableHurtboxCreationControls()
        {
            btnAddRootHurtbox.Enabled = false;
            btnAddHurtbox.Enabled = false;
            btnDeleteHurtbox.Enabled = false;
        }
        
        private void DisableHurtboxEditControls()
        {
            HurtPanel.Enabled = false;
        }

        private void EnableHitboxCreationControls()
        {
            btnAddRootHitbox.Enabled = true;
            btnAddHitbox.Enabled = true;
            btnDeleteHitbox.Enabled = true;
            pasteToolStripMenuItem.Enabled = true;
        }

        private void EnableHitboxEditControls()
        {
            HitPanel.Enabled = true;
        }

        private void EnableHurtboxCreationControls()
        {
            btnAddRootHurtbox.Enabled = true;
            btnAddHurtbox.Enabled = true;
            btnDeleteHurtbox.Enabled = true;
            pasteToolStripMenuItem.Enabled = true;
        }

        private void EnableHurtboxEditControls()
        {
            HurtPanel.Enabled = true;
        }

        private void DisableBoxControls()
        {
            numericTop.Enabled = false;
            numericLeft.Enabled = false;
            numericBottom.Enabled = false;
            numericRight.Enabled = false;
        }

        private void EnableBoxControls()
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
            UpdateKeyFrameData();
        }

        private void DataMoveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO THIS
        }

        private void CopyRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            CollisionRootNode rootNode = renderPreview.GetSelectedCollisionRootNode();
        }

        private void CopyRootChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            CollisionRootNode rootNode = renderPreview.GetSelectedCollisionRootNode();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

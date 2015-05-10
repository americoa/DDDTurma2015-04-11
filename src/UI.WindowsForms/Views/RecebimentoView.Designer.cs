namespace LGroup.ControleFinanceiro.UI.WindowsForms.Views
{
    partial class RecebimentoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoCreditoLabel;
            System.Windows.Forms.Label codigoRecebimentoTipoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecebimentoView));
            this.recebimentoModelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.recebimentoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recebimentoModelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoCreditoComboBox = new System.Windows.Forms.ComboBox();
            this.codigoRecebimentoTipoComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            codigoCreditoLabel = new System.Windows.Forms.Label();
            codigoRecebimentoTipoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recebimentoModelBindingNavigator)).BeginInit();
            this.recebimentoModelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recebimentoModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoCreditoLabel
            // 
            codigoCreditoLabel.AutoSize = true;
            codigoCreditoLabel.Location = new System.Drawing.Point(33, 59);
            codigoCreditoLabel.Name = "codigoCreditoLabel";
            codigoCreditoLabel.Size = new System.Drawing.Size(105, 17);
            codigoCreditoLabel.TabIndex = 1;
            codigoCreditoLabel.Text = "Codigo Credito:";
            // 
            // codigoRecebimentoTipoLabel
            // 
            codigoRecebimentoTipoLabel.AutoSize = true;
            codigoRecebimentoTipoLabel.Location = new System.Drawing.Point(33, 90);
            codigoRecebimentoTipoLabel.Name = "codigoRecebimentoTipoLabel";
            codigoRecebimentoTipoLabel.Size = new System.Drawing.Size(175, 17);
            codigoRecebimentoTipoLabel.TabIndex = 3;
            codigoRecebimentoTipoLabel.Text = "Codigo Recebimento Tipo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(33, 121);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 5;
            nomeLabel.Text = "Nome:";
            // 
            // recebimentoModelBindingNavigator
            // 
            this.recebimentoModelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recebimentoModelBindingNavigator.BindingSource = this.recebimentoModelBindingSource;
            this.recebimentoModelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recebimentoModelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recebimentoModelBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recebimentoModelBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.recebimentoModelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.recebimentoModelBindingNavigatorSaveItem});
            this.recebimentoModelBindingNavigator.Location = new System.Drawing.Point(0, 263);
            this.recebimentoModelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recebimentoModelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recebimentoModelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recebimentoModelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recebimentoModelBindingNavigator.Name = "recebimentoModelBindingNavigator";
            this.recebimentoModelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recebimentoModelBindingNavigator.Size = new System.Drawing.Size(526, 27);
            this.recebimentoModelBindingNavigator.TabIndex = 0;
            this.recebimentoModelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // recebimentoModelBindingSource
            // 
            this.recebimentoModelBindingSource.DataSource = typeof(LGroup.ControleFinanceiro.UI.WindowsForms.Models.RecebimentoModel);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // recebimentoModelBindingNavigatorSaveItem
            // 
            this.recebimentoModelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recebimentoModelBindingNavigatorSaveItem.Enabled = false;
            this.recebimentoModelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recebimentoModelBindingNavigatorSaveItem.Image")));
            this.recebimentoModelBindingNavigatorSaveItem.Name = "recebimentoModelBindingNavigatorSaveItem";
            this.recebimentoModelBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.recebimentoModelBindingNavigatorSaveItem.Text = "Save Data";
            this.recebimentoModelBindingNavigatorSaveItem.Click += new System.EventHandler(this.recebimentoModelBindingNavigatorSaveItem_Click);
            // 
            // codigoCreditoComboBox
            // 
            this.codigoCreditoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recebimentoModelBindingSource, "CodigoCredito", true));
            this.codigoCreditoComboBox.FormattingEnabled = true;
            this.codigoCreditoComboBox.Location = new System.Drawing.Point(214, 56);
            this.codigoCreditoComboBox.Name = "codigoCreditoComboBox";
            this.codigoCreditoComboBox.Size = new System.Drawing.Size(121, 24);
            this.codigoCreditoComboBox.TabIndex = 2;
            // 
            // codigoRecebimentoTipoComboBox
            // 
            this.codigoRecebimentoTipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.recebimentoModelBindingSource, "Tipo", true));
            this.codigoRecebimentoTipoComboBox.DisplayMember = "Descricao";
            this.codigoRecebimentoTipoComboBox.FormattingEnabled = true;
            this.codigoRecebimentoTipoComboBox.Location = new System.Drawing.Point(214, 87);
            this.codigoRecebimentoTipoComboBox.Name = "codigoRecebimentoTipoComboBox";
            this.codigoRecebimentoTipoComboBox.Size = new System.Drawing.Size(121, 24);
            this.codigoRecebimentoTipoComboBox.TabIndex = 4;
            this.codigoRecebimentoTipoComboBox.ValueMember = "Codigo";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recebimentoModelBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(214, 118);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 22);
            this.nomeTextBox.TabIndex = 6;
            // 
            // RecebimentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 290);
            this.Controls.Add(codigoCreditoLabel);
            this.Controls.Add(this.codigoCreditoComboBox);
            this.Controls.Add(codigoRecebimentoTipoLabel);
            this.Controls.Add(this.codigoRecebimentoTipoComboBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.recebimentoModelBindingNavigator);
            this.Name = "RecebimentoView";
            this.Text = "RecebimentoView";
            this.Load += new System.EventHandler(this.RecebimentoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recebimentoModelBindingNavigator)).EndInit();
            this.recebimentoModelBindingNavigator.ResumeLayout(false);
            this.recebimentoModelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recebimentoModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource recebimentoModelBindingSource;
        private System.Windows.Forms.BindingNavigator recebimentoModelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton recebimentoModelBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox codigoCreditoComboBox;
        private System.Windows.Forms.ComboBox codigoRecebimentoTipoComboBox;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}
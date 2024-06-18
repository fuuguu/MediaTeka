namespace hui
{
    partial class Purchase
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
            System.Windows.Forms.Label код_покупкиLabel;
            System.Windows.Forms.Label код_пользователяLabel;
            System.Windows.Forms.Label код_фильмаLabel;
            System.Windows.Forms.Label код_тарифаLabel;
            System.Windows.Forms.Label стоимость_покупкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.медиатекаDataSet = new hui.МедиатекаDataSet();
            this.история_покупокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_покупокTableAdapter = new hui.МедиатекаDataSetTableAdapters.История_покупокTableAdapter();
            this.tableAdapterManager = new hui.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.история_покупокBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.история_покупокBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_покупкиTextBox = new System.Windows.Forms.TextBox();
            this.код_пользователяTextBox = new System.Windows.Forms.TextBox();
            this.код_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.код_тарифаTextBox = new System.Windows.Forms.TextBox();
            this.стоимость_покупкиTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            код_покупкиLabel = new System.Windows.Forms.Label();
            код_пользователяLabel = new System.Windows.Forms.Label();
            код_фильмаLabel = new System.Windows.Forms.Label();
            код_тарифаLabel = new System.Windows.Forms.Label();
            стоимость_покупкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_покупокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_покупокBindingNavigator)).BeginInit();
            this.история_покупокBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_покупкиLabel
            // 
            код_покупкиLabel.AutoSize = true;
            код_покупкиLabel.Location = new System.Drawing.Point(53, 88);
            код_покупкиLabel.Name = "код_покупкиLabel";
            код_покупкиLabel.Size = new System.Drawing.Size(91, 16);
            код_покупкиLabel.TabIndex = 1;
            код_покупкиLabel.Text = "Код покупки:";
            код_покупкиLabel.Click += new System.EventHandler(this.код_покупкиLabel_Click);
            // 
            // код_пользователяLabel
            // 
            код_пользователяLabel.AutoSize = true;
            код_пользователяLabel.Location = new System.Drawing.Point(53, 142);
            код_пользователяLabel.Name = "код_пользователяLabel";
            код_пользователяLabel.Size = new System.Drawing.Size(130, 16);
            код_пользователяLabel.TabIndex = 3;
            код_пользователяLabel.Text = "Код пользователя:";
            // 
            // код_фильмаLabel
            // 
            код_фильмаLabel.AutoSize = true;
            код_фильмаLabel.Location = new System.Drawing.Point(53, 190);
            код_фильмаLabel.Name = "код_фильмаLabel";
            код_фильмаLabel.Size = new System.Drawing.Size(88, 16);
            код_фильмаLabel.TabIndex = 5;
            код_фильмаLabel.Text = "Код фильма:";
            // 
            // код_тарифаLabel
            // 
            код_тарифаLabel.AutoSize = true;
            код_тарифаLabel.Location = new System.Drawing.Point(53, 245);
            код_тарифаLabel.Name = "код_тарифаLabel";
            код_тарифаLabel.Size = new System.Drawing.Size(87, 16);
            код_тарифаLabel.TabIndex = 7;
            код_тарифаLabel.Text = "Код тарифа:";
            // 
            // стоимость_покупкиLabel
            // 
            стоимость_покупкиLabel.AutoSize = true;
            стоимость_покупкиLabel.Location = new System.Drawing.Point(53, 305);
            стоимость_покупкиLabel.Name = "стоимость_покупкиLabel";
            стоимость_покупкиLabel.Size = new System.Drawing.Size(137, 16);
            стоимость_покупкиLabel.TabIndex = 9;
            стоимость_покупкиLabel.Text = "Стоимость покупки:";
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // история_покупокBindingSource
            // 
            this.история_покупокBindingSource.DataMember = "История покупок";
            this.история_покупокBindingSource.DataSource = this.медиатекаDataSet;
            // 
            // история_покупокTableAdapter
            // 
            this.история_покупокTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = hui.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.История_покупокTableAdapter = this.история_покупокTableAdapter;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // история_покупокBindingNavigator
            // 
            this.история_покупокBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.история_покупокBindingNavigator.BindingSource = this.история_покупокBindingSource;
            this.история_покупокBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.история_покупокBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.история_покупокBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.история_покупокBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.история_покупокBindingNavigatorSaveItem});
            this.история_покупокBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.история_покупокBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.история_покупокBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.история_покупокBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.история_покупокBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.история_покупокBindingNavigator.Name = "история_покупокBindingNavigator";
            this.история_покупокBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.история_покупокBindingNavigator.Size = new System.Drawing.Size(484, 31);
            this.история_покупокBindingNavigator.TabIndex = 0;
            this.история_покупокBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // история_покупокBindingNavigatorSaveItem
            // 
            this.история_покупокBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.история_покупокBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("история_покупокBindingNavigatorSaveItem.Image")));
            this.история_покупокBindingNavigatorSaveItem.Name = "история_покупокBindingNavigatorSaveItem";
            this.история_покупокBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.история_покупокBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.история_покупокBindingNavigatorSaveItem.Click += new System.EventHandler(this.история_покупокBindingNavigatorSaveItem_Click);
            // 
            // код_покупкиTextBox
            // 
            this.код_покупкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_покупокBindingSource, "Код покупки", true));
            this.код_покупкиTextBox.Location = new System.Drawing.Point(218, 82);
            this.код_покупкиTextBox.Name = "код_покупкиTextBox";
            this.код_покупкиTextBox.Size = new System.Drawing.Size(141, 22);
            this.код_покупкиTextBox.TabIndex = 2;
            this.код_покупкиTextBox.TextChanged += new System.EventHandler(this.код_покупкиTextBox_TextChanged);
            // 
            // код_пользователяTextBox
            // 
            this.код_пользователяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_покупокBindingSource, "Код пользователя", true));
            this.код_пользователяTextBox.Location = new System.Drawing.Point(218, 136);
            this.код_пользователяTextBox.Name = "код_пользователяTextBox";
            this.код_пользователяTextBox.Size = new System.Drawing.Size(141, 22);
            this.код_пользователяTextBox.TabIndex = 4;
            // 
            // код_фильмаTextBox
            // 
            this.код_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_покупокBindingSource, "Код фильма", true));
            this.код_фильмаTextBox.Location = new System.Drawing.Point(218, 184);
            this.код_фильмаTextBox.Name = "код_фильмаTextBox";
            this.код_фильмаTextBox.Size = new System.Drawing.Size(141, 22);
            this.код_фильмаTextBox.TabIndex = 6;
            // 
            // код_тарифаTextBox
            // 
            this.код_тарифаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_покупокBindingSource, "Код тарифа", true));
            this.код_тарифаTextBox.Location = new System.Drawing.Point(218, 239);
            this.код_тарифаTextBox.Name = "код_тарифаTextBox";
            this.код_тарифаTextBox.Size = new System.Drawing.Size(141, 22);
            this.код_тарифаTextBox.TabIndex = 8;
            // 
            // стоимость_покупкиTextBox
            // 
            this.стоимость_покупкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_покупокBindingSource, "Стоимость покупки", true));
            this.стоимость_покупкиTextBox.Location = new System.Drawing.Point(218, 299);
            this.стоимость_покупкиTextBox.Name = "стоимость_покупкиTextBox";
            this.стоимость_покупкиTextBox.Size = new System.Drawing.Size(141, 22);
            this.стоимость_покупкиTextBox.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(180, 535);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 45);
            this.button7.TabIndex = 38;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(337, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 45);
            this.button6.TabIndex = 37;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(180, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 45);
            this.button5.TabIndex = 36;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 35;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 34;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 33;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 32;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Таблица \"История покупок\"";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(стоимость_покупкиLabel);
            this.Controls.Add(this.стоимость_покупкиTextBox);
            this.Controls.Add(код_тарифаLabel);
            this.Controls.Add(this.код_тарифаTextBox);
            this.Controls.Add(код_фильмаLabel);
            this.Controls.Add(this.код_фильмаTextBox);
            this.Controls.Add(код_пользователяLabel);
            this.Controls.Add(this.код_пользователяTextBox);
            this.Controls.Add(код_покупкиLabel);
            this.Controls.Add(this.код_покупкиTextBox);
            this.Controls.Add(this.история_покупокBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purchase";
            this.Text = "История покупок";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_покупокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_покупокBindingNavigator)).EndInit();
            this.история_покупокBindingNavigator.ResumeLayout(false);
            this.история_покупокBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource история_покупокBindingSource;
        private МедиатекаDataSetTableAdapters.История_покупокTableAdapter история_покупокTableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator история_покупокBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton история_покупокBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_покупкиTextBox;
        private System.Windows.Forms.TextBox код_пользователяTextBox;
        private System.Windows.Forms.TextBox код_фильмаTextBox;
        private System.Windows.Forms.TextBox код_тарифаTextBox;
        private System.Windows.Forms.TextBox стоимость_покупкиTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
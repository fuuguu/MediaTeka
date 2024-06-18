namespace hui
{
    partial class Tariffs
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
            System.Windows.Forms.Label название_тарифаLabel;
            System.Windows.Forms.Label стоимость_тарифа_в_месяцLabel;
            System.Windows.Forms.Label количество_фильмовLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tariffs));
            this.медиатекаDataSet = new hui.МедиатекаDataSet();
            this.тарифыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тарифыTableAdapter = new hui.МедиатекаDataSetTableAdapters.ТарифыTableAdapter();
            this.tableAdapterManager = new hui.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.тарифыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.тарифыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_тарифаTextBox = new System.Windows.Forms.TextBox();
            this.стоимость_тарифа_в_месяцTextBox = new System.Windows.Forms.TextBox();
            this.количество_фильмовTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            название_тарифаLabel = new System.Windows.Forms.Label();
            стоимость_тарифа_в_месяцLabel = new System.Windows.Forms.Label();
            количество_фильмовLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingNavigator)).BeginInit();
            this.тарифыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_тарифаLabel
            // 
            название_тарифаLabel.AutoSize = true;
            название_тарифаLabel.Location = new System.Drawing.Point(57, 93);
            название_тарифаLabel.Name = "название_тарифаLabel";
            название_тарифаLabel.Size = new System.Drawing.Size(129, 16);
            название_тарифаLabel.TabIndex = 1;
            название_тарифаLabel.Text = "Название тарифа:";
            // 
            // стоимость_тарифа_в_месяцLabel
            // 
            стоимость_тарифа_в_месяцLabel.AutoSize = true;
            стоимость_тарифа_в_месяцLabel.Location = new System.Drawing.Point(57, 154);
            стоимость_тарифа_в_месяцLabel.Name = "стоимость_тарифа_в_месяцLabel";
            стоимость_тарифа_в_месяцLabel.Size = new System.Drawing.Size(186, 16);
            стоимость_тарифа_в_месяцLabel.TabIndex = 3;
            стоимость_тарифа_в_месяцLabel.Text = "Стоимость тарифа в месяц:";
            стоимость_тарифа_в_месяцLabel.Click += new System.EventHandler(this.стоимость_тарифа_в_месяцLabel_Click);
            // 
            // количество_фильмовLabel
            // 
            количество_фильмовLabel.AutoSize = true;
            количество_фильмовLabel.Location = new System.Drawing.Point(57, 214);
            количество_фильмовLabel.Name = "количество_фильмовLabel";
            количество_фильмовLabel.Size = new System.Drawing.Size(150, 16);
            количество_фильмовLabel.TabIndex = 5;
            количество_фильмовLabel.Text = "Количество фильмов:";
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тарифыBindingSource
            // 
            this.тарифыBindingSource.DataMember = "Тарифы";
            this.тарифыBindingSource.DataSource = this.медиатекаDataSet;
            // 
            // тарифыTableAdapter
            // 
            this.тарифыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = hui.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.История_покупокTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = this.тарифыTableAdapter;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // тарифыBindingNavigator
            // 
            this.тарифыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тарифыBindingNavigator.BindingSource = this.тарифыBindingSource;
            this.тарифыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тарифыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тарифыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.тарифыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тарифыBindingNavigatorSaveItem});
            this.тарифыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тарифыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тарифыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тарифыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тарифыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тарифыBindingNavigator.Name = "тарифыBindingNavigator";
            this.тарифыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тарифыBindingNavigator.Size = new System.Drawing.Size(521, 31);
            this.тарифыBindingNavigator.TabIndex = 0;
            this.тарифыBindingNavigator.Text = "bindingNavigator1";
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
            // тарифыBindingNavigatorSaveItem
            // 
            this.тарифыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тарифыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тарифыBindingNavigatorSaveItem.Image")));
            this.тарифыBindingNavigatorSaveItem.Name = "тарифыBindingNavigatorSaveItem";
            this.тарифыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.тарифыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тарифыBindingNavigatorSaveItem.Click += new System.EventHandler(this.тарифыBindingNavigatorSaveItem_Click);
            // 
            // название_тарифаTextBox
            // 
            this.название_тарифаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифыBindingSource, "Название тарифа", true));
            this.название_тарифаTextBox.Location = new System.Drawing.Point(263, 87);
            this.название_тарифаTextBox.Name = "название_тарифаTextBox";
            this.название_тарифаTextBox.Size = new System.Drawing.Size(184, 22);
            this.название_тарифаTextBox.TabIndex = 2;
            // 
            // стоимость_тарифа_в_месяцTextBox
            // 
            this.стоимость_тарифа_в_месяцTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифыBindingSource, "Стоимость тарифа в месяц", true));
            this.стоимость_тарифа_в_месяцTextBox.Location = new System.Drawing.Point(263, 148);
            this.стоимость_тарифа_в_месяцTextBox.Name = "стоимость_тарифа_в_месяцTextBox";
            this.стоимость_тарифа_в_месяцTextBox.Size = new System.Drawing.Size(184, 22);
            this.стоимость_тарифа_в_месяцTextBox.TabIndex = 4;
            // 
            // количество_фильмовTextBox
            // 
            this.количество_фильмовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифыBindingSource, "Количество фильмов", true));
            this.количество_фильмовTextBox.Location = new System.Drawing.Point(263, 208);
            this.количество_фильмовTextBox.Name = "количество_фильмовTextBox";
            this.количество_фильмовTextBox.Size = new System.Drawing.Size(184, 22);
            this.количество_фильмовTextBox.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 39;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 38;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 37;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 36;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(280, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 45);
            this.button5.TabIndex = 40;
            this.button5.Text = "Таблица";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(145, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Таблица \"Тарифы\"";
            // 
            // Tariffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(количество_фильмовLabel);
            this.Controls.Add(this.количество_фильмовTextBox);
            this.Controls.Add(стоимость_тарифа_в_месяцLabel);
            this.Controls.Add(this.стоимость_тарифа_в_месяцTextBox);
            this.Controls.Add(название_тарифаLabel);
            this.Controls.Add(this.название_тарифаTextBox);
            this.Controls.Add(this.тарифыBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tariffs";
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.Tariffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифыBindingNavigator)).EndInit();
            this.тарифыBindingNavigator.ResumeLayout(false);
            this.тарифыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource тарифыBindingSource;
        private МедиатекаDataSetTableAdapters.ТарифыTableAdapter тарифыTableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тарифыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тарифыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_тарифаTextBox;
        private System.Windows.Forms.TextBox стоимость_тарифа_в_месяцTextBox;
        private System.Windows.Forms.TextBox количество_фильмовTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}
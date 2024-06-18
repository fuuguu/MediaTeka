namespace hui
{
    partial class Films
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
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label год_выпускаLabel;
            System.Windows.Forms.Label режиссёрLabel;
            System.Windows.Forms.Label главный_актерLabel;
            System.Windows.Forms.Label оценка_пользователейLabel;
            System.Windows.Forms.Label код_тарифаLabel;
            System.Windows.Forms.Label стоимость_фильмаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Films));
            this.медиатекаDataSet = new hui.МедиатекаDataSet();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new hui.МедиатекаDataSetTableAdapters.ФильмыTableAdapter();
            this.tableAdapterManager = new hui.МедиатекаDataSetTableAdapters.TableAdapterManager();
            this.фильмыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.фильмыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.жанрTextBox = new System.Windows.Forms.TextBox();
            this.год_выпускаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.режиссёрTextBox = new System.Windows.Forms.TextBox();
            this.главный_актерTextBox = new System.Windows.Forms.TextBox();
            this.оценка_пользователейTextBox = new System.Windows.Forms.TextBox();
            this.код_тарифаTextBox = new System.Windows.Forms.TextBox();
            this.стоимость_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            названиеLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            год_выпускаLabel = new System.Windows.Forms.Label();
            режиссёрLabel = new System.Windows.Forms.Label();
            главный_актерLabel = new System.Windows.Forms.Label();
            оценка_пользователейLabel = new System.Windows.Forms.Label();
            код_тарифаLabel = new System.Windows.Forms.Label();
            стоимость_фильмаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingNavigator)).BeginInit();
            this.фильмыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(48, 133);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 16);
            названиеLabel.TabIndex = 1;
            названиеLabel.Text = "Название:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(48, 182);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(47, 16);
            жанрLabel.TabIndex = 3;
            жанрLabel.Text = "Жанр:";
            // 
            // год_выпускаLabel
            // 
            год_выпускаLabel.AutoSize = true;
            год_выпускаLabel.Location = new System.Drawing.Point(48, 230);
            год_выпускаLabel.Name = "год_выпускаLabel";
            год_выпускаLabel.Size = new System.Drawing.Size(91, 16);
            год_выпускаLabel.TabIndex = 5;
            год_выпускаLabel.Text = "Год выпуска:";
            // 
            // режиссёрLabel
            // 
            режиссёрLabel.AutoSize = true;
            режиссёрLabel.Location = new System.Drawing.Point(48, 280);
            режиссёрLabel.Name = "режиссёрLabel";
            режиссёрLabel.Size = new System.Drawing.Size(74, 16);
            режиссёрLabel.TabIndex = 7;
            режиссёрLabel.Text = "Режиссёр:";
            // 
            // главный_актерLabel
            // 
            главный_актерLabel.AutoSize = true;
            главный_актерLabel.Location = new System.Drawing.Point(48, 329);
            главный_актерLabel.Name = "главный_актерLabel";
            главный_актерLabel.Size = new System.Drawing.Size(107, 16);
            главный_актерLabel.TabIndex = 9;
            главный_актерLabel.Text = "Главный актер:";
            // 
            // оценка_пользователейLabel
            // 
            оценка_пользователейLabel.AutoSize = true;
            оценка_пользователейLabel.Location = new System.Drawing.Point(48, 386);
            оценка_пользователейLabel.Name = "оценка_пользователейLabel";
            оценка_пользователейLabel.Size = new System.Drawing.Size(164, 16);
            оценка_пользователейLabel.TabIndex = 11;
            оценка_пользователейLabel.Text = "Оценка пользователей:";
            // 
            // код_тарифаLabel
            // 
            код_тарифаLabel.AutoSize = true;
            код_тарифаLabel.Location = new System.Drawing.Point(48, 487);
            код_тарифаLabel.Name = "код_тарифаLabel";
            код_тарифаLabel.Size = new System.Drawing.Size(87, 16);
            код_тарифаLabel.TabIndex = 13;
            код_тарифаLabel.Text = "Код тарифа:";
            // 
            // стоимость_фильмаLabel
            // 
            стоимость_фильмаLabel.AutoSize = true;
            стоимость_фильмаLabel.Location = new System.Drawing.Point(48, 438);
            стоимость_фильмаLabel.Name = "стоимость_фильмаLabel";
            стоимость_фильмаLabel.Size = new System.Drawing.Size(134, 16);
            стоимость_фильмаLabel.TabIndex = 15;
            стоимость_фильмаLabel.Text = "Стоимость фильма:";
            стоимость_фильмаLabel.Click += new System.EventHandler(this.стоимость_фильмаLabel_Click);
            // 
            // медиатекаDataSet
            // 
            this.медиатекаDataSet.DataSetName = "МедиатекаDataSet";
            this.медиатекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.медиатекаDataSet;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = hui.МедиатекаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.История_покупокTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ТарифыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = this.фильмыTableAdapter;
            // 
            // фильмыBindingNavigator
            // 
            this.фильмыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фильмыBindingNavigator.BindingSource = this.фильмыBindingSource;
            this.фильмыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фильмыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фильмыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.фильмыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фильмыBindingNavigatorSaveItem});
            this.фильмыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фильмыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фильмыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фильмыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фильмыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фильмыBindingNavigator.Name = "фильмыBindingNavigator";
            this.фильмыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фильмыBindingNavigator.Size = new System.Drawing.Size(580, 31);
            this.фильмыBindingNavigator.TabIndex = 0;
            this.фильмыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // фильмыBindingNavigatorSaveItem
            // 
            this.фильмыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фильмыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фильмыBindingNavigatorSaveItem.Image")));
            this.фильмыBindingNavigatorSaveItem.Name = "фильмыBindingNavigatorSaveItem";
            this.фильмыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.фильмыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.фильмыBindingNavigatorSaveItem.Click += new System.EventHandler(this.фильмыBindingNavigatorSaveItem_Click);
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(233, 127);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(272, 22);
            this.названиеTextBox.TabIndex = 2;
            // 
            // жанрTextBox
            // 
            this.жанрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Жанр", true));
            this.жанрTextBox.Location = new System.Drawing.Point(233, 176);
            this.жанрTextBox.Name = "жанрTextBox";
            this.жанрTextBox.Size = new System.Drawing.Size(272, 22);
            this.жанрTextBox.TabIndex = 4;
            // 
            // год_выпускаDateTimePicker
            // 
            this.год_выпускаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.фильмыBindingSource, "Год выпуска", true));
            this.год_выпускаDateTimePicker.Location = new System.Drawing.Point(233, 224);
            this.год_выпускаDateTimePicker.Name = "год_выпускаDateTimePicker";
            this.год_выпускаDateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.год_выпускаDateTimePicker.TabIndex = 6;
            // 
            // режиссёрTextBox
            // 
            this.режиссёрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Режиссёр", true));
            this.режиссёрTextBox.Location = new System.Drawing.Point(233, 274);
            this.режиссёрTextBox.Name = "режиссёрTextBox";
            this.режиссёрTextBox.Size = new System.Drawing.Size(272, 22);
            this.режиссёрTextBox.TabIndex = 8;
            // 
            // главный_актерTextBox
            // 
            this.главный_актерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Главный актер", true));
            this.главный_актерTextBox.Location = new System.Drawing.Point(233, 323);
            this.главный_актерTextBox.Name = "главный_актерTextBox";
            this.главный_актерTextBox.Size = new System.Drawing.Size(272, 22);
            this.главный_актерTextBox.TabIndex = 10;
            // 
            // оценка_пользователейTextBox
            // 
            this.оценка_пользователейTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Оценка пользователей", true));
            this.оценка_пользователейTextBox.Location = new System.Drawing.Point(233, 380);
            this.оценка_пользователейTextBox.Name = "оценка_пользователейTextBox";
            this.оценка_пользователейTextBox.Size = new System.Drawing.Size(272, 22);
            this.оценка_пользователейTextBox.TabIndex = 12;
            // 
            // код_тарифаTextBox
            // 
            this.код_тарифаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Код тарифа", true));
            this.код_тарифаTextBox.Location = new System.Drawing.Point(233, 481);
            this.код_тарифаTextBox.Name = "код_тарифаTextBox";
            this.код_тарифаTextBox.Size = new System.Drawing.Size(272, 22);
            this.код_тарифаTextBox.TabIndex = 14;
            // 
            // стоимость_фильмаTextBox
            // 
            this.стоимость_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Стоимость фильма", true));
            this.стоимость_фильмаTextBox.Location = new System.Drawing.Point(233, 432);
            this.стоимость_фильмаTextBox.Name = "стоимость_фильмаTextBox";
            this.стоимость_фильмаTextBox.Size = new System.Drawing.Size(272, 22);
            this.стоимость_фильмаTextBox.TabIndex = 16;
            this.стоимость_фильмаTextBox.TextChanged += new System.EventHandler(this.стоимость_фильмаTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 26;
            this.button2.Text = "Следующая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 27;
            this.button3.Text = "Предыдущая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 642);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 45);
            this.button4.TabIndex = 28;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(233, 642);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 45);
            this.button5.TabIndex = 29;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(422, 642);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 45);
            this.button6.TabIndex = 30;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(47, 720);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 45);
            this.button7.TabIndex = 31;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(173, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Таблица \"Фильмы\"";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(233, 720);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 45);
            this.button8.TabIndex = 43;
            this.button8.Text = "Таблица";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(422, 720);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 45);
            this.button9.TabIndex = 44;
            this.button9.Text = "По жанрам";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(47, 800);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 45);
            this.button10.TabIndex = 45;
            this.button10.Text = "По годам";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(233, 800);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(135, 45);
            this.button11.TabIndex = 46;
            this.button11.Text = "По режиссёру";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(422, 800);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 45);
            this.button12.TabIndex = 47;
            this.button12.Text = "По 1 букве актера";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 890);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(стоимость_фильмаLabel);
            this.Controls.Add(this.стоимость_фильмаTextBox);
            this.Controls.Add(код_тарифаLabel);
            this.Controls.Add(this.код_тарифаTextBox);
            this.Controls.Add(оценка_пользователейLabel);
            this.Controls.Add(this.оценка_пользователейTextBox);
            this.Controls.Add(главный_актерLabel);
            this.Controls.Add(this.главный_актерTextBox);
            this.Controls.Add(режиссёрLabel);
            this.Controls.Add(this.режиссёрTextBox);
            this.Controls.Add(год_выпускаLabel);
            this.Controls.Add(this.год_выпускаDateTimePicker);
            this.Controls.Add(жанрLabel);
            this.Controls.Add(this.жанрTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(this.фильмыBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Films";
            this.Text = "Таблица \"Фильмы\"";
            this.Load += new System.EventHandler(this.Films_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медиатекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingNavigator)).EndInit();
            this.фильмыBindingNavigator.ResumeLayout(false);
            this.фильмыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private МедиатекаDataSet медиатекаDataSet;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private МедиатекаDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private МедиатекаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фильмыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фильмыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox жанрTextBox;
        private System.Windows.Forms.DateTimePicker год_выпускаDateTimePicker;
        private System.Windows.Forms.TextBox режиссёрTextBox;
        private System.Windows.Forms.TextBox главный_актерTextBox;
        private System.Windows.Forms.TextBox оценка_пользователейTextBox;
        private System.Windows.Forms.TextBox код_тарифаTextBox;
        private System.Windows.Forms.TextBox стоимость_фильмаTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}
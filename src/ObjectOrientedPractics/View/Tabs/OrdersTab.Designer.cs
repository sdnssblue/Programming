
namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountDigitLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsPanel = new System.Windows.Forms.Panel();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.PriorityOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(7, 9);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(44, 13);
            this.OrdersLabel.TabIndex = 1;
            this.OrdersLabel.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CreatedColumn,
            this.OrderStatusColumn,
            this.CustomerColumn,
            this.DeliveryAddressColumn,
            this.AmountColumn,
            this.TotalColumn});
            this.OrdersDataGridView.Location = new System.Drawing.Point(6, 25);
            this.OrdersDataGridView.MinimumSize = new System.Drawing.Size(330, 420);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(330, 420);
            this.OrdersDataGridView.TabIndex = 2;
            this.OrdersDataGridView.SelectionChanged += new System.EventHandler(this.OrdersDataGridView_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.HeaderText = "Created";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "Order Status";
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            this.OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerColumn
            // 
            this.CustomerColumn.HeaderText = "Customer Full Name";
            this.CustomerColumn.Name = "CustomerColumn";
            this.CustomerColumn.ReadOnly = true;
            this.CustomerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DeliveryAddressColumn
            // 
            this.DeliveryAddressColumn.HeaderText = "Delivery Address";
            this.DeliveryAddressColumn.Name = "DeliveryAddressColumn";
            this.DeliveryAddressColumn.ReadOnly = true;
            this.DeliveryAddressColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.ReadOnly = true;
            this.TotalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(349, 9);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 13);
            this.SelectedOrderLabel.TabIndex = 3;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(356, 35);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(356, 64);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 28;
            this.CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(356, 93);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 29;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTextBox.Location = new System.Drawing.Point(409, 61);
            this.CreatedTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CreatedTextBox.TabIndex = 30;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(409, 32);
            this.IDTextBox.MinimumSize = new System.Drawing.Size(100, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 32;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(409, 90);
            this.StatusComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.StatusComboBox.TabIndex = 33;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(349, 256);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(72, 13);
            this.OrderItemsLabel.TabIndex = 39;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(349, 272);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(416, 95);
            this.OrderItemsListBox.TabIndex = 40;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(712, 385);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(53, 13);
            this.AmountLabel.TabIndex = 41;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountDigitLabel
            // 
            this.AmountDigitLabel.AutoSize = true;
            this.AmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountDigitLabel.Location = new System.Drawing.Point(711, 398);
            this.AmountDigitLabel.Name = "AmountDigitLabel";
            this.AmountDigitLabel.Size = new System.Drawing.Size(21, 24);
            this.AmountDigitLabel.TabIndex = 42;
            this.AmountDigitLabel.Text = "0";
            // 
            // PriorityOptionsPanel
            // 
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityOptionsPanel.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityOptionsPanel.Controls.Add(this.PriorityOptionsLabel);
            this.PriorityOptionsPanel.Location = new System.Drawing.Point(565, 9);
            this.PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            this.PriorityOptionsPanel.Size = new System.Drawing.Size(200, 100);
            this.PriorityOptionsPanel.TabIndex = 43;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(83, 20);
            this.DeliveryTimeComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(100, 21);
            this.DeliveryTimeComboBox.TabIndex = 61;
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(3, 23);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(74, 13);
            this.DeliveryTimeLabel.TabIndex = 60;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(3, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(93, 13);
            this.PriorityOptionsLabel.TabIndex = 59;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(342, 117);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.ReadOnly = false;
            this.AddressControl.Size = new System.Drawing.Size(428, 136);
            this.AddressControl.TabIndex = 38;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityOptionsPanel);
            this.Controls.Add(this.AmountDigitLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Controls.Add(this.OrdersDataGridView);
            this.Controls.Add(this.OrdersLabel);
            this.MinimumSize = new System.Drawing.Size(773, 504);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(773, 504);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.PriorityOptionsPanel.ResumeLayout(false);
            this.PriorityOptionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountDigitLabel;
        private System.Windows.Forms.Panel PriorityOptionsPanel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
    }
}

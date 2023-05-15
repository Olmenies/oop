namespace integrating_activity_01
{
    partial class Form1
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
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.textBoxPersonDni = new System.Windows.Forms.TextBox();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.textBoxPersonSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxPerson = new System.Windows.Forms.GroupBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewFullCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewOwnedCars = new System.Windows.Forms.DataGridView();
            this.buttonDeletePerson = new System.Windows.Forms.Button();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.buttonBind = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonUpdatePerson = new System.Windows.Forms.Button();
            this.buttonUpdateCar = new System.Windows.Forms.Button();
            this.buttonDummyPeopleLoad = new System.Windows.Forms.Button();
            this.buttonDummyCarsLoad = new System.Windows.Forms.Button();
            this.labelTotalCarsValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.groupBoxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.groupBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(629, 554);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(240, 23);
            this.buttonAddCar.TabIndex = 0;
            this.buttonAddCar.Text = "Agregar auto";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(629, 310);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(240, 23);
            this.buttonAddPerson.TabIndex = 1;
            this.buttonAddPerson.Text = "Agregar persona";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPeople.TabIndex = 2;
            this.dataGridViewPeople.SelectionChanged += new System.EventHandler(this.dataGridViewPeople_SelectionChanged);
            // 
            // textBoxPersonDni
            // 
            this.textBoxPersonDni.Location = new System.Drawing.Point(6, 37);
            this.textBoxPersonDni.Name = "textBoxPersonDni";
            this.textBoxPersonDni.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonDni.TabIndex = 3;
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(6, 76);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonName.TabIndex = 4;
            // 
            // textBoxPersonSurname
            // 
            this.textBoxPersonSurname.Location = new System.Drawing.Point(6, 115);
            this.textBoxPersonSurname.Name = "textBoxPersonSurname";
            this.textBoxPersonSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxPersonSurname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // groupBoxPerson
            // 
            this.groupBoxPerson.Controls.Add(this.textBoxPersonDni);
            this.groupBoxPerson.Controls.Add(this.label3);
            this.groupBoxPerson.Controls.Add(this.textBoxPersonName);
            this.groupBoxPerson.Controls.Add(this.label2);
            this.groupBoxPerson.Controls.Add(this.textBoxPersonSurname);
            this.groupBoxPerson.Controls.Add(this.label1);
            this.groupBoxPerson.Location = new System.Drawing.Point(629, 153);
            this.groupBoxPerson.Name = "groupBoxPerson";
            this.groupBoxPerson.Size = new System.Drawing.Size(113, 151);
            this.groupBoxPerson.TabIndex = 9;
            this.groupBoxPerson.TabStop = false;
            this.groupBoxPerson.Text = "Nueva persona:";
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(377, 35);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCars.TabIndex = 10;
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.textBoxYear);
            this.groupBoxCar.Controls.Add(this.textBoxPrice);
            this.groupBoxCar.Controls.Add(this.label7);
            this.groupBoxCar.Controls.Add(this.label8);
            this.groupBoxCar.Controls.Add(this.textBoxPlate);
            this.groupBoxCar.Controls.Add(this.label4);
            this.groupBoxCar.Controls.Add(this.textBoxManufacturer);
            this.groupBoxCar.Controls.Add(this.label5);
            this.groupBoxCar.Controls.Add(this.textBoxModel);
            this.groupBoxCar.Controls.Add(this.label6);
            this.groupBoxCar.Location = new System.Drawing.Point(629, 397);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(240, 151);
            this.groupBoxCar.TabIndex = 10;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Nuevo auto";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(119, 37);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(119, 76);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Año";
            // 
            // textBoxPlate
            // 
            this.textBoxPlate.Location = new System.Drawing.Point(6, 37);
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(6, 76);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(100, 20);
            this.textBoxManufacturer.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Marca";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(6, 115);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Patente";
            // 
            // dataGridViewFullCars
            // 
            this.dataGridViewFullCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFullCars.Location = new System.Drawing.Point(12, 395);
            this.dataGridViewFullCars.Name = "dataGridViewFullCars";
            this.dataGridViewFullCars.Size = new System.Drawing.Size(605, 240);
            this.dataGridViewFullCars.TabIndex = 12;
            // 
            // dataGridViewOwnedCars
            // 
            this.dataGridViewOwnedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnedCars.Location = new System.Drawing.Point(12, 216);
            this.dataGridViewOwnedCars.Name = "dataGridViewOwnedCars";
            this.dataGridViewOwnedCars.Size = new System.Drawing.Size(605, 150);
            this.dataGridViewOwnedCars.TabIndex = 11;
            // 
            // buttonDeletePerson
            // 
            this.buttonDeletePerson.Location = new System.Drawing.Point(629, 339);
            this.buttonDeletePerson.Name = "buttonDeletePerson";
            this.buttonDeletePerson.Size = new System.Drawing.Size(240, 23);
            this.buttonDeletePerson.TabIndex = 13;
            this.buttonDeletePerson.Text = "Borrar persona seleccionada";
            this.buttonDeletePerson.UseVisualStyleBackColor = true;
            this.buttonDeletePerson.Click += new System.EventHandler(this.buttonDeletePerson_Click);
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(629, 583);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(240, 23);
            this.buttonDeleteCar.TabIndex = 14;
            this.buttonDeleteCar.Text = "Borrar auto seleccionado";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // buttonBind
            // 
            this.buttonBind.Location = new System.Drawing.Point(264, 54);
            this.buttonBind.Name = "buttonBind";
            this.buttonBind.Size = new System.Drawing.Size(102, 23);
            this.buttonBind.TabIndex = 15;
            this.buttonBind.Text = "Asignar";
            this.buttonBind.UseVisualStyleBackColor = true;
            this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Personas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Autos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Autos pertenecientes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Autos y dueños";
            // 
            // buttonUpdatePerson
            // 
            this.buttonUpdatePerson.Location = new System.Drawing.Point(629, 368);
            this.buttonUpdatePerson.Name = "buttonUpdatePerson";
            this.buttonUpdatePerson.Size = new System.Drawing.Size(240, 23);
            this.buttonUpdatePerson.TabIndex = 20;
            this.buttonUpdatePerson.Text = "Modificar persona seleccionada";
            this.buttonUpdatePerson.UseVisualStyleBackColor = true;
            this.buttonUpdatePerson.Click += new System.EventHandler(this.buttonUpdatePerson_Click);
            // 
            // buttonUpdateCar
            // 
            this.buttonUpdateCar.Location = new System.Drawing.Point(629, 612);
            this.buttonUpdateCar.Name = "buttonUpdateCar";
            this.buttonUpdateCar.Size = new System.Drawing.Size(240, 23);
            this.buttonUpdateCar.TabIndex = 21;
            this.buttonUpdateCar.Text = "Modificar auto seleccionado";
            this.buttonUpdateCar.UseVisualStyleBackColor = true;
            this.buttonUpdateCar.Click += new System.EventHandler(this.buttonUpdateCar_Click);
            // 
            // buttonDummyPeopleLoad
            // 
            this.buttonDummyPeopleLoad.Location = new System.Drawing.Point(623, 35);
            this.buttonDummyPeopleLoad.Name = "buttonDummyPeopleLoad";
            this.buttonDummyPeopleLoad.Size = new System.Drawing.Size(119, 112);
            this.buttonDummyPeopleLoad.TabIndex = 22;
            this.buttonDummyPeopleLoad.Text = "Carga prueba personas";
            this.buttonDummyPeopleLoad.UseVisualStyleBackColor = true;
            this.buttonDummyPeopleLoad.Click += new System.EventHandler(this.buttonDummyPeopleLoad_Click);
            // 
            // buttonDummyCarsLoad
            // 
            this.buttonDummyCarsLoad.Location = new System.Drawing.Point(748, 35);
            this.buttonDummyCarsLoad.Name = "buttonDummyCarsLoad";
            this.buttonDummyCarsLoad.Size = new System.Drawing.Size(121, 112);
            this.buttonDummyCarsLoad.TabIndex = 23;
            this.buttonDummyCarsLoad.Text = "Carga prueba personas";
            this.buttonDummyCarsLoad.UseVisualStyleBackColor = true;
            this.buttonDummyCarsLoad.Click += new System.EventHandler(this.buttonDummyCarsLoad_Click);
            // 
            // labelTotalCarsValue
            // 
            this.labelTotalCarsValue.AutoSize = true;
            this.labelTotalCarsValue.Location = new System.Drawing.Point(748, 153);
            this.labelTotalCarsValue.Name = "labelTotalCarsValue";
            this.labelTotalCarsValue.Size = new System.Drawing.Size(78, 13);
            this.labelTotalCarsValue.TabIndex = 24;
            this.labelTotalCarsValue.Text = "Valor de autos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 672);
            this.Controls.Add(this.labelTotalCarsValue);
            this.Controls.Add(this.buttonDummyCarsLoad);
            this.Controls.Add(this.buttonDummyPeopleLoad);
            this.Controls.Add(this.buttonUpdateCar);
            this.Controls.Add(this.buttonUpdatePerson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBind);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.buttonDeletePerson);
            this.Controls.Add(this.dataGridViewFullCars);
            this.Controls.Add(this.dataGridViewOwnedCars);
            this.Controls.Add(this.groupBoxCar);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.groupBoxPerson);
            this.Controls.Add(this.dataGridViewPeople);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.buttonAddCar);
            this.Name = "Form1";
            this.Text = "Actividad integradora 01";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.groupBoxPerson.ResumeLayout(false);
            this.groupBoxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.groupBoxCar.ResumeLayout(false);
            this.groupBoxCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TextBox textBoxPersonDni;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.TextBox textBoxPersonSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxPerson;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.TextBox textBoxPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewFullCars;
        private System.Windows.Forms.DataGridView dataGridViewOwnedCars;
        private System.Windows.Forms.Button buttonDeletePerson;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Button buttonBind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonUpdatePerson;
        private System.Windows.Forms.Button buttonUpdateCar;
        private System.Windows.Forms.Button buttonDummyPeopleLoad;
        private System.Windows.Forms.Button buttonDummyCarsLoad;
        private System.Windows.Forms.Label labelTotalCarsValue;
    }
}


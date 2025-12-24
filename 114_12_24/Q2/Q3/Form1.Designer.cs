using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Q3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private IContainer components = null;

        private GroupBox grpOilLubrication;
        private CheckBox chkOilChange;
        private CheckBox chkLubrication;

        private GroupBox grpCleaning;
        private CheckBox chkRadiatorFlush;
        private CheckBox chkTransmissionFlush;

        private GroupBox grpOtherServices;
        private CheckBox chkInspection;
        private CheckBox chkMufflerReplace;
        private CheckBox chkTireRotation;

        private GroupBox grpPartsLabor;
        private Label lblPartsCost;
        private Label lblLaborHours;
        private TextBox txtPartsCost;
        private TextBox txtLaborHours;

        private GroupBox grpSummary;
        private Label lblServiceAndLabor;
        private TextBox txtServiceAndLabor;
        private Label lblPartsTotal;
        private TextBox txtPartsTotal;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblGrandTotal;
        private TextBox txtGrandTotal;

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOilLubrication = new System.Windows.Forms.GroupBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubrication = new System.Windows.Forms.CheckBox();
            this.grpCleaning = new System.Windows.Forms.GroupBox();
            this.chkRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.chkTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.grpOtherServices = new System.Windows.Forms.GroupBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkMufflerReplace = new System.Windows.Forms.CheckBox();
            this.chkTireRotation = new System.Windows.Forms.CheckBox();
            this.grpPartsLabor = new System.Windows.Forms.GroupBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.lblLaborHours = new System.Windows.Forms.Label();
            this.txtLaborHours = new System.Windows.Forms.TextBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblServiceAndLabor = new System.Windows.Forms.Label();
            this.txtServiceAndLabor = new System.Windows.Forms.TextBox();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.txtPartsTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.caculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.grpOilLubrication.SuspendLayout();
            this.grpCleaning.SuspendLayout();
            this.grpOtherServices.SuspendLayout();
            this.grpPartsLabor.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOilLubrication
            // 
            this.grpOilLubrication.Controls.Add(this.chkOilChange);
            this.grpOilLubrication.Controls.Add(this.chkLubrication);
            this.grpOilLubrication.Location = new System.Drawing.Point(10, 10);
            this.grpOilLubrication.Name = "grpOilLubrication";
            this.grpOilLubrication.Size = new System.Drawing.Size(240, 100);
            this.grpOilLubrication.TabIndex = 0;
            this.grpOilLubrication.TabStop = false;
            this.grpOilLubrication.Text = "機油和潤滑";
            // 
            // chkOilChange
            // 
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.Location = new System.Drawing.Point(12, 24);
            this.chkOilChange.Name = "chkOilChange";
            this.chkOilChange.Size = new System.Drawing.Size(191, 29);
            this.chkOilChange.TabIndex = 0;
            this.chkOilChange.Text = "更換機油 (NT$780)";
            // 
            // chkLubrication
            // 
            this.chkLubrication.AutoSize = true;
            this.chkLubrication.Location = new System.Drawing.Point(12, 52);
            this.chkLubrication.Name = "chkLubrication";
            this.chkLubrication.Size = new System.Drawing.Size(191, 29);
            this.chkLubrication.TabIndex = 1;
            this.chkLubrication.Text = "潤滑保養 (NT$540)";
            // 
            // grpCleaning
            // 
            this.grpCleaning.Controls.Add(this.chkRadiatorFlush);
            this.grpCleaning.Controls.Add(this.chkTransmissionFlush);
            this.grpCleaning.Location = new System.Drawing.Point(260, 10);
            this.grpCleaning.Name = "grpCleaning";
            this.grpCleaning.Size = new System.Drawing.Size(240, 100);
            this.grpCleaning.TabIndex = 1;
            this.grpCleaning.TabStop = false;
            this.grpCleaning.Text = "清洗服務";
            // 
            // chkRadiatorFlush
            // 
            this.chkRadiatorFlush.AutoSize = true;
            this.chkRadiatorFlush.Location = new System.Drawing.Point(12, 24);
            this.chkRadiatorFlush.Name = "chkRadiatorFlush";
            this.chkRadiatorFlush.Size = new System.Drawing.Size(191, 29);
            this.chkRadiatorFlush.TabIndex = 2;
            this.chkRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // chkTransmissionFlush
            // 
            this.chkTransmissionFlush.AutoSize = true;
            this.chkTransmissionFlush.Location = new System.Drawing.Point(12, 52);
            this.chkTransmissionFlush.Name = "chkTransmissionFlush";
            this.chkTransmissionFlush.Size = new System.Drawing.Size(224, 29);
            this.chkTransmissionFlush.TabIndex = 3;
            this.chkTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // grpOtherServices
            // 
            this.grpOtherServices.Controls.Add(this.chkInspection);
            this.grpOtherServices.Controls.Add(this.chkMufflerReplace);
            this.grpOtherServices.Controls.Add(this.chkTireRotation);
            this.grpOtherServices.Location = new System.Drawing.Point(10, 120);
            this.grpOtherServices.Name = "grpOtherServices";
            this.grpOtherServices.Size = new System.Drawing.Size(240, 130);
            this.grpOtherServices.TabIndex = 2;
            this.grpOtherServices.TabStop = false;
            this.grpOtherServices.Text = "其他服務";
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(12, 24);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(153, 29);
            this.chkInspection.TabIndex = 4;
            this.chkInspection.Text = "檢驗 (NT$450)";
            // 
            // chkMufflerReplace
            // 
            this.chkMufflerReplace.AutoSize = true;
            this.chkMufflerReplace.Location = new System.Drawing.Point(12, 52);
            this.chkMufflerReplace.Name = "chkMufflerReplace";
            this.chkMufflerReplace.Size = new System.Drawing.Size(224, 29);
            this.chkMufflerReplace.TabIndex = 5;
            this.chkMufflerReplace.Text = "更換消音器 (NT$3,000)";
            // 
            // chkTireRotation
            // 
            this.chkTireRotation.AutoSize = true;
            this.chkTireRotation.Location = new System.Drawing.Point(12, 80);
            this.chkTireRotation.Name = "chkTireRotation";
            this.chkTireRotation.Size = new System.Drawing.Size(191, 29);
            this.chkTireRotation.TabIndex = 6;
            this.chkTireRotation.Text = "輪胎檢位 (NT$600)";
            // 
            // grpPartsLabor
            // 
            this.grpPartsLabor.Controls.Add(this.lblPartsCost);
            this.grpPartsLabor.Controls.Add(this.txtPartsCost);
            this.grpPartsLabor.Controls.Add(this.lblLaborHours);
            this.grpPartsLabor.Controls.Add(this.txtLaborHours);
            this.grpPartsLabor.Location = new System.Drawing.Point(260, 120);
            this.grpPartsLabor.Name = "grpPartsLabor";
            this.grpPartsLabor.Size = new System.Drawing.Size(300, 130);
            this.grpPartsLabor.TabIndex = 3;
            this.grpPartsLabor.TabStop = false;
            this.grpPartsLabor.Text = "零件和工時";
            // 
            // lblPartsCost
            // 
            this.lblPartsCost.AutoSize = true;
            this.lblPartsCost.Location = new System.Drawing.Point(12, 30);
            this.lblPartsCost.Name = "lblPartsCost";
            this.lblPartsCost.Size = new System.Drawing.Size(97, 25);
            this.lblPartsCost.TabIndex = 0;
            this.lblPartsCost.Text = "零件 (NT$)";
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Location = new System.Drawing.Point(120, 26);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(150, 31);
            this.txtPartsCost.TabIndex = 7;
            this.txtPartsCost.Text = "0.00";
            // 
            // lblLaborHours
            // 
            this.lblLaborHours.AutoSize = true;
            this.lblLaborHours.Location = new System.Drawing.Point(12, 70);
            this.lblLaborHours.Name = "lblLaborHours";
            this.lblLaborHours.Size = new System.Drawing.Size(122, 25);
            this.lblLaborHours.TabIndex = 8;
            this.lblLaborHours.Text = "工時數 (小時)";
            // 
            // txtLaborHours
            // 
            this.txtLaborHours.Location = new System.Drawing.Point(120, 66);
            this.txtLaborHours.Name = "txtLaborHours";
            this.txtLaborHours.Size = new System.Drawing.Size(150, 31);
            this.txtLaborHours.TabIndex = 8;
            this.txtLaborHours.Text = "0.0";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblServiceAndLabor);
            this.grpSummary.Controls.Add(this.txtServiceAndLabor);
            this.grpSummary.Controls.Add(this.lblPartsTotal);
            this.grpSummary.Controls.Add(this.txtPartsTotal);
            this.grpSummary.Controls.Add(this.lblTax);
            this.grpSummary.Controls.Add(this.txtTax);
            this.grpSummary.Controls.Add(this.lblGrandTotal);
            this.grpSummary.Controls.Add(this.txtGrandTotal);
            this.grpSummary.Location = new System.Drawing.Point(10, 260);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(550, 170);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "費用摘要";
            // 
            // lblServiceAndLabor
            // 
            this.lblServiceAndLabor.AutoSize = true;
            this.lblServiceAndLabor.Location = new System.Drawing.Point(12, 28);
            this.lblServiceAndLabor.Name = "lblServiceAndLabor";
            this.lblServiceAndLabor.Size = new System.Drawing.Size(107, 25);
            this.lblServiceAndLabor.TabIndex = 0;
            this.lblServiceAndLabor.Text = "服務與工資";
            // 
            // txtServiceAndLabor
            // 
            this.txtServiceAndLabor.Location = new System.Drawing.Point(140, 24);
            this.txtServiceAndLabor.Name = "txtServiceAndLabor";
            this.txtServiceAndLabor.ReadOnly = true;
            this.txtServiceAndLabor.Size = new System.Drawing.Size(180, 31);
            this.txtServiceAndLabor.TabIndex = 9;
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Location = new System.Drawing.Point(12, 64);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(50, 25);
            this.lblPartsTotal.TabIndex = 10;
            this.lblPartsTotal.Text = "零件";
            // 
            // txtPartsTotal
            // 
            this.txtPartsTotal.Location = new System.Drawing.Point(140, 60);
            this.txtPartsTotal.Name = "txtPartsTotal";
            this.txtPartsTotal.ReadOnly = true;
            this.txtPartsTotal.Size = new System.Drawing.Size(180, 31);
            this.txtPartsTotal.TabIndex = 10;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(12, 100);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(103, 25);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "稅金 (零件)";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(140, 96);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(180, 31);
            this.txtTax.TabIndex = 11;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(12, 136);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(69, 25);
            this.lblGrandTotal.TabIndex = 12;
            this.lblGrandTotal.Text = "總費用";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(140, 139);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(180, 31);
            this.txtGrandTotal.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(200, 406);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "計算總額";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清除";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(440, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "離開";
            // 
            // caculate
            // 
            this.caculate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caculate.Location = new System.Drawing.Point(99, 507);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(201, 76);
            this.caculate.TabIndex = 16;
            this.caculate.Text = "計算總額";
            this.caculate.UseVisualStyleBackColor = true;
            this.caculate.Click += new System.EventHandler(this.caculate_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(359, 507);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(162, 76);
            this.reset.TabIndex = 17;
            this.reset.Text = "清除";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(599, 507);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(162, 76);
            this.exit.TabIndex = 18;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(941, 624);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.caculate);
            this.Controls.Add(this.grpOilLubrication);
            this.Controls.Add(this.grpCleaning);
            this.Controls.Add(this.grpOtherServices);
            this.Controls.Add(this.grpPartsLabor);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汽車保養服務";
            this.grpOilLubrication.ResumeLayout(false);
            this.grpOilLubrication.PerformLayout();
            this.grpCleaning.ResumeLayout(false);
            this.grpCleaning.PerformLayout();
            this.grpOtherServices.ResumeLayout(false);
            this.grpOtherServices.PerformLayout();
            this.grpPartsLabor.ResumeLayout(false);
            this.grpPartsLabor.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button caculate;
        private Button reset;
        private Button exit;
    }
}


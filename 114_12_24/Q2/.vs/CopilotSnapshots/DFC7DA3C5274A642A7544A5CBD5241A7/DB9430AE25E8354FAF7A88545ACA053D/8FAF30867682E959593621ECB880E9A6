using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Q3
{
    public partial class Form1 : Form
    {
        // Constants
        private const decimal OIL_CHANGE_FEE = 780m;
        private const decimal LUBRICATION_FEE = 540m;
        private const decimal RADIATOR_FLUSH_FEE = 900m;
        private const decimal TRANSMISSION_FLUSH_FEE = 2400m;
        private const decimal INSPECTION_FEE = 450m;
        private const decimal MUFFLER_REPLACE_FEE = 3000m;
        private const decimal TIRE_ROTATION_FEE = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();
        }

        // Button event handlers (names kept consistent with existing designer hookups)
        private void reset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否在離開前儲存維修明細？", "離開", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
                return;

            if (result == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
            }

            Application.Exit();
        }

        private void caculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out decimal partsCost, out decimal laborHours))
                return;

            decimal serviceFees = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal laborCost = laborHours * LABOR_RATE_PER_HOUR;
            decimal serviceAndLaborTotal = serviceFees + laborCost;
            decimal tax = TaxCharges(partsCost);
            decimal grandTotal = serviceAndLaborTotal + partsCost + tax;

            // Update UI (formatted in NT$ with 2 decimals)
            txtServiceAndLabor.Text = FormatMoney(serviceAndLaborTotal);
            txtPartsTotal.Text = FormatMoney(partsCost);
            txtTax.Text = FormatMoney(tax);
            txtGrandTotal.Text = FormatMoney(grandTotal);
        }

        // Calculation helper methods
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (chkOilChange.Checked) total += OIL_CHANGE_FEE;
            if (chkLubrication.Checked) total += LUBRICATION_FEE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (chkRadiatorFlush.Checked) total += RADIATOR_FLUSH_FEE;
            if (chkTransmissionFlush.Checked) total += TRANSMISSION_FLUSH_FEE;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (chkInspection.Checked) total += INSPECTION_FEE;
            if (chkMufflerReplace.Checked) total += MUFFLER_REPLACE_FEE;
            if (chkTireRotation.Checked) total += TIRE_ROTATION_FEE;
            return total;
        }

        private decimal TaxCharges(decimal partsCost)
        {
            return Math.Round(partsCost * PARTS_TAX_RATE, 2);
        }

        // Input validation
        private bool ValidateInputs(out decimal partsCost, out decimal laborHours)
        {
            partsCost = 0m;
            laborHours = 0m;

            // Validate parts cost
            if (!decimal.TryParse(txtPartsCost.Text.Trim(), out partsCost) || partsCost < 0m)
            {
                MessageBox.Show("請輸入有效的零件費用（非負數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartsCost.Focus();
                return false;
            }

            // Validate labor hours
            if (!decimal.TryParse(txtLaborHours.Text.Trim(), out laborHours) || laborHours < 0m)
            {
                MessageBox.Show("請輸入有效的工時數（非負數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLaborHours.Focus();
                return false;
            }

            return true;
        }

        // Formatting helper
        private string FormatMoney(decimal amount)
        {
            return string.Format("NT$ {0:N2}", amount);
        }

        // Clear methods
        private void ClearAll()
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkLubrication.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMufflerReplace.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtPartsCost.Text = "0.00";
            txtLaborHours.Text = "0.0";
        }

        private void ClearFees()
        {
            txtServiceAndLabor.Text = string.Empty;
            txtPartsTotal.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
        }

        // File save
        private void SaveServiceDetailsToFile()
        {
            if (!ValidateInputs(out decimal partsCost, out decimal laborHours))
                return;

            decimal serviceFees = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal laborCost = laborHours * LABOR_RATE_PER_HOUR;
            decimal serviceAndLaborTotal = serviceFees + laborCost;
            decimal tax = TaxCharges(partsCost);
            decimal grandTotal = serviceAndLaborTotal + partsCost + tax;

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "ServiceDetails_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                var lines = new List<string>();
                lines.Add("汽車維修服務明細");
                lines.Add("日期: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                lines.Add(new string('-', 50));
                lines.Add("選擇的服務項目：");

                if (chkOilChange.Checked) lines.Add($" - 更換機油: {FormatMoney(OIL_CHANGE_FEE)}");
                if (chkLubrication.Checked) lines.Add($" - 潤滑保養: {FormatMoney(LUBRICATION_FEE)}");
                if (chkRadiatorFlush.Checked) lines.Add($" - 水箱清洗: {FormatMoney(RADIATOR_FLUSH_FEE)}");
                if (chkTransmissionFlush.Checked) lines.Add($" - 變速箱清洗: {FormatMoney(TRANSMISSION_FLUSH_FEE)}");
                if (chkInspection.Checked) lines.Add($" - 檢驗: {FormatMoney(INSPECTION_FEE)}");
                if (chkMufflerReplace.Checked) lines.Add($" - 更換消音器: {FormatMoney(MUFFLER_REPLACE_FEE)}");
                if (chkTireRotation.Checked) lines.Add($" - 輪胎換位: {FormatMoney(TIRE_ROTATION_FEE)}");

                lines.Add(new string('-', 50));
                lines.Add($"服務費用合計: {FormatMoney(serviceFees)}");
                lines.Add($"工時數: {laborHours:N2} 小時");
                lines.Add($"工資 (每小時 {FormatMoney(LABOR_RATE_PER_HOUR)}): {FormatMoney(laborCost)}");
                lines.Add($"服務與工資合計: {FormatMoney(serviceAndLaborTotal)}");
                lines.Add($"零件費用: {FormatMoney(partsCost)}");
                lines.Add($"零件稅 ({PARTS_TAX_RATE * 100}%): {FormatMoney(tax)}");
                lines.Add($"總費用: {FormatMoney(grandTotal)}");
                lines.Add(new string('-', 50));

                try
                {
                    File.WriteAllLines(sfd.FileName, lines, Encoding.UTF8);
                    MessageBox.Show("已成功儲存維修明細。", "儲存完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法儲存檔案：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

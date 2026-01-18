using System;
using System.Windows.Forms;

namespace BP2_Projekt_Teretana
{
    public static class Ui
    {
        public static void FillCombo(ComboBox cb, string sql, string display, string value, object? keepSelectedValue = null)
        {
            var dt = Db.Query(sql);

            cb.BeginUpdate();
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = dt;
            cb.EndUpdate();

            if (keepSelectedValue != null)
            {
                try { cb.SelectedValue = keepSelectedValue; } catch { /* ignore */ }
            }
            else
            {
                if (cb.Items.Count > 0) cb.SelectedIndex = 0;
            }
        }
    }
}

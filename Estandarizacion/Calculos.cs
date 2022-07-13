﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estandarizacion
{
    public static class Calculos
    {
        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            string s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (Regex.IsMatch(e.KeyChar.ToString(), "^([\\d]|[\\b])$"))
            {
                e.Handled = false;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.KeyChar = char.Parse(s);
            }
            else
            {
                e.Handled = true;
            }

        }

        public static bool ValidarDecimal(string numero)
        {
            return Regex.IsMatch(numero, "^(0*[1-9]\\d{0,15}|0+)(\\.\\d\\d)|(\\.\\d)?$");
        }
        public static void ValidarLetras(KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "^([\\w]|[\\b]|[\\s])$"))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public static void ValidarEntero(KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "^([0-9]|[\\b])"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static bool ValidarMail(string mail)
        {
            return Regex.IsMatch(mail, "^([\\w-]+\\.)*?[\\w-]+@[\\w-]+\\.([\\w-]+\\.)*?[\\w]+$");
        }
        public static bool LargoDNI(string dni)
        {
            return Regex.IsMatch(dni, "^([0-9]{8,8})");
        }
        public static bool ValidarNombrePersonal(string nombre)
        {
            return Regex.IsMatch(nombre, "([a-zA-Z]|[0-9])$");
        }
        public static bool ValidarApellido(string apellido)
        {
            return Regex.IsMatch(apellido, "([\\w0-9'°\\s])$");
        }
        public static void BorrarCampos(Control grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    text.Text = null;
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = c as NumericUpDown;
                    num.Value = 0;
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    combo.Text = null;
                }
                else if (c is CheckBox)
                {
                    CheckBox check = c as CheckBox;
                    check.Checked = false;
                }
            }
        }
        public static bool Camposvacios(Control grp)
        {
            int sino = 0;
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = c as TextBox;
                    if (text.Text == "")
                    {
                        sino = 1;
                    }
                }
                else if (c is NumericUpDown)
                {
                    NumericUpDown num = c as NumericUpDown;
                    if (num.Value == 0)
                    {
                        sino = 1;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.Text == "")
                    {
                        sino = 1;
                    }
                }
            }
            return sino == 0;
        }
        public static void RefreshGrilla(DataGridView dgv, object refObject)
        {
            dgv.DataSource = null;
            dgv.DataSource = refObject;
        }
        public static void GrillaEnBlanco(DataGridView dgv)
        {
            dgv.DataSource = null;
        }

        public static void DataSourceCombo(ComboBox combo, object refObject, string DisplayMember)
        {
            combo.DataSource = null;
            combo.DataSource = refObject;
            try { combo.ValueMember = "Codigo"; }
            catch { }
            combo.DisplayMember = DisplayMember;
            combo.SelectedIndex = -1;
            combo.Refresh();

        }
    }
}
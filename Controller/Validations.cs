using System.Windows.Forms;
using System;
static class Validations
{
    public static void validateTextBoxNoEmpty(ErrorProvider errorProvider, TextBox textBox, string mensaje)
    {
        if (textBox.TextLength == 0)
        {
            errorProvider.SetError(textBox, mensaje);
        }
        else
        {
            errorProvider.SetError(textBox, "");
        }
    }

    public static void Numberonly(KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
    }

    public static void Lyricsonly(KeyPressEventArgs e)
    {
        if (char.IsDigit(e.KeyChar)) e.Handled = true;
    }

    public static void onlyDecimalNumber(TextBox textBox, KeyPressEventArgs e)
    {
        if (((e.KeyChar < 48 || e.KeyChar > 57) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46))
        {
            e.Handled = true;
            return;
        }

        if (e.KeyChar == 46)
        {
            if (textBox.Text.IndexOf(e.KeyChar) != -1)
                e.Handled = true;
        }
    }
}


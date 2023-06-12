using System.Windows.Forms;

namespace BanhoTosaApp.util
{
    public class FormUtil
    {
        public static void ShowForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();
            newForm.Closed += (s, args) => currentForm.Close();
            newForm.Show();
        }
    }
}

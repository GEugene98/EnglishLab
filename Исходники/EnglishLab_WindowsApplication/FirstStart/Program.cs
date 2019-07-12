using System;
using System.Windows.Forms;
using FirstStart.Views;
using FirstStart.Presenters;
using FirstStart.Models;
using FirstStart.Properties;
using MetroFramework.Forms;
using UserData;
using System.Diagnostics;
using System.IO;

namespace FirstStart
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Auto-generted code
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //******************

            try
            {
                StartDialog startDialog = new StartDialog();

                Application.Run(startDialog);

                if (startDialog.DialogResult == DialogResult.OK)
                {
                    User user = null;

                    if (startDialog.UserLevel == Level.StartTest)
                    {
                        Test test = new Test();

                        QuestionManager manager = new QuestionManager(Resources.test);

                        TestPresenter presenter = new TestPresenter(test, manager);

                        Application.Run(test);

                        if (test.DialogResult == DialogResult.OK)
                        {
                            Application.Run(new FinishDialog(manager));

                            user = new User(startDialog.UserName, manager.TotalLevel);
                        }
                        else
                            return;
                    }
                    else
                        user = new User(startDialog.UserName, startDialog.UserLevel);

                    user.Save(@".\UserInfo.dat");
                    Process.Start(@".\MainModule.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + '\n' + Environment.CurrentDirectory);
            }
        }
    }
}

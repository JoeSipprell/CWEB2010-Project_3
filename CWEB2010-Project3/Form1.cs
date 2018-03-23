using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWEB2010_Project3
{
    public partial class Form1 : Form
    {
        Dictionary<int, Resident> resDict = new Dictionary<int, Resident>();
        public Form1(ref Dictionary<int, Resident> resDict)
        {
            InitializeComponent();
            this.resDict = resDict;
        }

        private void EnterBox_Click(object sender, EventArgs e)
        {
            const string USERNAME = "home";
            const string PASSWORD = "1234";

            if (usernamebox.Text == USERNAME && passwordBox.Text == PASSWORD)
            {
                LoginPage.Visible = false;
                selectionB.Enabled = true;

                selectionPanel.Visible = true;
                entryB.Enabled = false;
                newResB.Enabled = true;
                resSearchB.Enabled = true;
            }
            else
            {
                badPass.Visible = true;
            }

                usernamebox.Text = "";
                passwordBox.Text = "";
        }

        private void nResB_Click(object sender, EventArgs e)
        {
            startNewRes();
        }

        private void newResB_Click(object sender, EventArgs e)
        {
            startNewRes();
        }

        private void startNewRes()
        {
            selectionPanel.Visible = false;
            resSearchPanel.Visible = false;

            newResPanel.Visible = true;

            nameFieldErrorLab.Visible = false;
            resTypeMenu.SelectedIndex = -1;
            floorSelect.Items.Clear();
            floorSelect.Enabled = false;
            rentMoney = 0;
            rentOutput.Text = "";
            hoursLab.Visible = false;
            hoursInput.Visible = false;
            fNameEntry.Text = "";
            lNameEntry.Text = "";
            errorLab.Visible = false;
            
            idNumLab.Text = (resDict.Keys.Max() + 1).ToString();
        }

        int rentMoney;
        private void resTypeMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(resTypeMenu.SelectedItem.ToString())
            {
                case "Scholarship Recipient":
                    floorSelect.Enabled = true;
                    rentMoney = 100;
                    rentOutput.Text = $"${rentMoney}";

                    hoursLab.Visible = false;
                    hoursInput.Visible = false;
                    floorSelect.Items.Clear();
                    floorSelect.Items.Add("7"); floorSelect.Items.Add("8");
                    break;

                case "Student Athlete":
                    floorSelect.Enabled = true;
                    rentMoney = 1200;
                    rentOutput.Text = $"${rentMoney}";

                    hoursLab.Visible = false;
                    hoursInput.Visible = false;
                    floorSelect.Items.Clear();
                    floorSelect.Items.Add("4"); floorSelect.Items.Add("5"); floorSelect.Items.Add("6");
                    break;

                case "Student Worker":
                    floorSelect.Enabled = true;
                    hoursInput.Value = 0;
                    rentMoney = 1245;
                    rentOutput.Text = $"${rentMoney}";

                    hoursLab.Visible = true;
                    hoursInput.Visible = true;
                    floorSelect.Items.Clear();
                    floorSelect.Items.Add("1"); floorSelect.Items.Add("2"); floorSelect.Items.Add("3");
                    break;
            }
        }

        private void hoursInput_ValueChanged(object sender, EventArgs e)
        {
            rentMoney = 1245 - Convert.ToInt32(hoursInput.Value) * 7;
            rentOutput.Text = $"${rentMoney}";
        }

        private void addResB_Click(object sender, EventArgs e)
        {
            errorLab.Visible = false;
            nameFieldErrorLab.Visible = false;

            foreach (Control ctrl in newResPanel.Controls)
            {
                if(ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;

                    if(cb.SelectedItem.ToString() == "")
                    {
                        errorLab.Visible = true;
                    }
                }
                if(ctrl is TextBox && ctrl.Text == "")
                {
                    errorLab.Visible = true;
                }
            }

            if (fNameEntry.Text.Contains(",") || lNameEntry.Text.Contains(","))
            {
                nameFieldErrorLab.Visible = true;
            }

            if(errorLab.Visible == false && nameFieldErrorLab.Visible == false)
            {
                switch (resTypeMenu.SelectedItem.ToString())
                {
                    case "Scholarship Recipient":
                        resDict.Add(Convert.ToInt32(idNumLab.Text), new Scholarship(idNumLab.Text, fNameEntry.Text, lNameEntry.Text, dormNumSelect.Value.ToString(), resTypeMenu.SelectedItem.ToString(), floorSelect.SelectedItem.ToString()));
                        break;

                    case "Student Athlete":
                        resDict.Add(Convert.ToInt32(idNumLab.Text), new StudentAthlete(idNumLab.Text, fNameEntry.Text, lNameEntry.Text, dormNumSelect.Value.ToString(), resTypeMenu.SelectedItem.ToString(), floorSelect.SelectedItem.ToString()));
                        break;

                    case "Student Worker":
                        resDict.Add(Convert.ToInt32(idNumLab.Text), new StudentWorker(idNumLab.Text, fNameEntry.Text, lNameEntry.Text, dormNumSelect.Value.ToString(), resTypeMenu.SelectedItem.ToString(), floorSelect.SelectedItem.ToString(), Convert.ToInt32(hoursInput.Value)));
                        break;
                }
                
                startNewRes();
            }
        }

        private void clearControls(object sender, EventArgs e) { startNewRes(); }

        private void selectionB_Click(object sender, EventArgs e)
        {
            selectionPanel.Visible = true;
            newResPanel.Visible = false;
            resSearchPanel.Visible = false;
        }

        private void resetSearchPage()
        {
            nameOut.Text = "";
            feeOut.Text = "";
            floorOut.Text = "";
            dormNumOut.Text = "";
        }

        private void searchClicked(object sender, EventArgs e)
        {
            invalidInputMessage.Visible = false;

            try
            {
                int idNumSearch = Convert.ToInt32(searchBox.Text);

                if (resDict.ContainsKey(idNumSearch))
                {
                    Resident foundRes = resDict[idNumSearch];

                    nameOut.Text = $"{foundRes.fName} {foundRes.lName}";
                    nameOut.Visible = true;

                    feeOut.Text = $"${foundRes.rentMoney}";

                    floorOut.Text = $"{foundRes.level}";

                    dormNumOut.Text = $"{foundRes.dormNum}";
                }
                else
                {
                    invalidInputMessage.Location = new Point(100, 100);
                    invalidInputMessage.Text = "Sorry, we didn't find a student with that ID number";
                    invalidInputMessage.Visible = true;
                    resetSearchPage();
                }
            }
            catch(FormatException)
            {
                invalidInputMessage.Location = new Point(180, 100);
                invalidInputMessage.Text = "Sorry, your input was not valid";
                invalidInputMessage.Visible = true;
                resetSearchPage();
            }
            
        }

        private void resSearchB_Click(object sender, EventArgs e)
        {
            selectionPanel.Visible = false;
            newResPanel.Visible = false;
            resSearchPanel.Visible = true;
        }

        private void resSB_Click(object sender, EventArgs e)
        {
            selectionPanel.Visible = false;
            newResPanel.Visible = false;
            resSearchPanel.Visible = true;
        }
    }
}

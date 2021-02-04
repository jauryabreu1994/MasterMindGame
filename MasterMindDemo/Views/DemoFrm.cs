using MasterMindDemo.Controller;
using MasterMindDemo.Model;
using MasterMindDemo.Model.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterMindDemo
{
    public partial class DemoFrm : Form
    {
        private MasterEntity masterCombination = new MasterEntity();
        private MasterEntity currentLine = new MasterEntity();
        private List<ValidationEntity> resultLines = new List<ValidationEntity>();
        public DemoFrm()
        {
            InitializeComponent();
            gbHistory.Enabled = false;
            ResetApp();
        }

        private void btnColor_Click(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (!LineValidationIsComplete(masterCombination) || !masterCombination.IsComplete)
                SaveLine(masterCombination, button.TabIndex);
            else
                SaveLine(currentLine, button.TabIndex);

            cmbPosition_SelectedIndexChanged(null, null);
        }

        private void SaveLine(MasterEntity line, int button) 
        {

            switch (cmbPosition.SelectedIndex)
            {
                case 0:
                    line.FirstPosition = (CodePeg)button;
                    break;
                case 1:
                    line.SecondPosition = (CodePeg)button;
                    break;
                case 2:
                    line.ThirdPosition = (CodePeg)button;
                    break;
                case 3:
                    line.FourthPosition = (CodePeg)button;
                    break;
            }

            cmbPosition.SelectedIndex = (cmbPosition.SelectedIndex != 3) ? cmbPosition.SelectedIndex + 1 : 0;
        }

        private bool LineValidationIsComplete(MasterEntity line) 
        {
            if (line.FirstPosition.Equals(CodePeg.None) ||
                line.SecondPosition.Equals(CodePeg.None) ||
                line.ThirdPosition.Equals(CodePeg.None) ||
                line.FourthPosition.Equals(CodePeg.None)
                )
                return false;
            else
                return true;
        }

        private void btnMain_Click(object sender, System.EventArgs e)
        {
            if (!cmbPosition.Enabled) 
            {
                ResetApp();
            }
            else if (LineValidationIsComplete(masterCombination) && !masterCombination.IsComplete)
            {
                masterCombination.IsComplete = true;
                gbHistory.Enabled = true;
                gbCurrentLine.Text = "Find the Combination";
                btnMain.Text = "Validate";
                cmbPosition.SelectedIndex = 0;
                cmbPosition_SelectedIndexChanged(null, null);
            }
            else if (LineValidationIsComplete(currentLine) && !currentLine.IsComplete)
            {

                var masterMind = new MasterMind(masterCombination);
                var result = masterMind.GetHints(currentLine);

                if (result != null)
                {
                    if (result.Count > 0)
                    {
                        ValidationEntity entity = new ValidationEntity(currentLine, result);
                        entity.IsEqual = (result.Contains(ResultPeg.None) || result.Contains(ResultPeg.White)) ? false : true;
                        resultLines.Add(entity);
                        ShowHistory();
                        currentLine = new MasterEntity();
                        cmbPosition.SelectedIndex = 0;
                        cmbPosition_SelectedIndexChanged(null, null);

                        if (resultLines[resultLines.Count - 1].IsEqual)
                        {
                            btnShow_Click(null,null);
                            gbColor.Enabled = cmbPosition.Enabled = false;
                            btnMain.Text = "Reset";
                        }
                    }
                }
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!LineValidationIsComplete(masterCombination) || !masterCombination.IsComplete)
                LoadText(masterCombination);
            else
                LoadText(currentLine);
        }

        private void LoadText(MasterEntity line) 
        {
            switch (cmbPosition.SelectedIndex)
            {
                case 0:
                    txtField.Text = line.FirstPosition == CodePeg.None ? string.Empty : line.FirstPosition.ToString();
                    break;
                case 1:
                    txtField.Text = line.SecondPosition == CodePeg.None ? string.Empty : line.SecondPosition.ToString();
                    break;
                case 2:
                    txtField.Text = line.ThirdPosition == CodePeg.None ? string.Empty : line.ThirdPosition.ToString();
                    break;
                case 3:
                    txtField.Text = line.FourthPosition == CodePeg.None ? string.Empty : line.FourthPosition.ToString();
                    break;
            }
        }

        private void ShowHistory() 
        {
            txtHistory.Text = string.Empty;
            int line = 1;
            foreach (var item in resultLines)
            {
                txtHistory.Text += string.Format("{0}. |{1}|{2}|{3}|{4}| -> |{5}|{6}|{7}|{8}|\r\n", line.ToString("00"),
                                                     item.FirstPosition.ToString().PadRight(6), item.SecondPosition.ToString().PadRight(6), 
                                                     item.ThirdPosition.ToString().PadRight(6), item.FourthPosition.ToString().PadRight(6),
                                                     item.FirstResult.ToString().PadRight(5), item.SecondResult.ToString().PadRight(5), 
                                                     item.ThirdResult.ToString().PadRight(5), item.FourthResult.ToString().PadRight(5));

                line++;
            }
        }

        private void ResetApp() 
        {
            gbColor.Enabled = cmbPosition.Enabled = true;
            btnMain.Text = "Add";
            gbCurrentLine.Text = "Select Color To Guess";
            txtHistory.Text = txtField.Text = txtCombination.Text = string.Empty;
            cmbPosition.SelectedIndex = 0;
            masterCombination = new MasterEntity();
            currentLine = new MasterEntity();
            resultLines = new List<ValidationEntity>();
        }

        private void btnShow_Click(object sender, System.EventArgs e)
        {
            if (LineValidationIsComplete(masterCombination))
            {
                if (string.IsNullOrEmpty(txtCombination.Text))
                {
                    txtCombination.Text = string.Format("|{0}|{1}|{2}|{3}|",
                                                             masterCombination.FirstPosition, masterCombination.SecondPosition,
                                                             masterCombination.ThirdPosition, masterCombination.FourthPosition);

                    btnShow.Text = "Hide";
                }
                else
                {
                    txtCombination.Text = string.Empty;
                    btnShow.Text = "Show";
                }
            }
        }
    }
}

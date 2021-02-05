using MasterMindDemo.Controller;
using MasterMindDemo.Model;
using MasterMindDemo.Model.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MasterMindDemo
{
    /**
     * For our exercise, we will build a function that takes a list of 4 colors, and returns a list of 0‐4 
     * black/white results.
     * 
     * Part of this exercise is reading comprehension and domain discovery, so we won't outline all forms of
     * input and output here. Read the rules above (and the linked post) to familiarize yourself with the game's
     * rules, so that your implementation is consistent with the game's rules.
     * 
     * The objective is to compare the actual color‐code to the guessed color‐code, and return the correct
     * amount of black/white pegs (based on the game's rules).
     * 
     * Your implementation should be as efficient as possible, clean and easy to read & understand.
     *
     **/
    public partial class DemoFrm : Form
    {
        private MasterEntity masterCombination = new MasterEntity();
        private MasterEntity currentLine = new MasterEntity();
        private List<ValidationEntity> resultLines = new List<ValidationEntity>();
        private bool showCombination = false;
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


        //Add the color to the object 
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

        //Validate if the 4 colors have been added
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

        //Validate to send multiple options
        private void btnMain_Click(object sender, System.EventArgs e)
        {
            //When the game is over, restart the game
            if (!cmbPosition.Enabled) 
            {
                ResetApp();
            }
            //Check if the initial combination is complete, to proceed to guess
            else if (LineValidationIsComplete(masterCombination) && !masterCombination.IsComplete)
            {
                masterCombination.IsComplete = true;
                gbHistory.Enabled = true;
                gbCurrentLine.Text = "Find the Combination";
                btnMain.Text = "Validate";
                cmbPosition.SelectedIndex = 0;
                cmbPosition_SelectedIndexChanged(null, null);
            }
            //Validates if the current combination of the player to guess is complete
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
                            showCombination = true;
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
        //Displays the information of the selected in the color field
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
        //Shows the history of combinations made to guess in the game
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

        //Reset the game
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
            showCombination = false;
        }
        //Show or Hide the secret combination to guess
        private void btnShow_Click(object sender, System.EventArgs e)
        {
            if (LineValidationIsComplete(masterCombination) || showCombination)
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

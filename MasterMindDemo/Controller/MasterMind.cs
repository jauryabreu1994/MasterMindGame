using MasterMindDemo.Model;
using MasterMindDemo.Model.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MasterMindDemo.Controller
{
    public class MasterMind
    {
        private List<CodePeg> code;

        public MasterMind(MasterEntity line)
        {
            this.code = ConvertMasterEntityToCodePegList(line);
        }

        public List<ResultPeg> GetHints(MasterEntity lineGuess)
        {
            List<CodePeg> guess = ConvertMasterEntityToCodePegList(lineGuess);

            try
            {
                var result = new List<ResultPeg>();

                for (int i = 0; i < 4; i++)
                    result.Add(ResultPeg.None);

                int line = 0;
                foreach (var item in guess)
                {
                    if (code.Contains(item))
                    {
                        for (int i = line; i < code.Count; i++)
                        {
                            if (result[i] == ResultPeg.Black)
                                continue;
                            else if (result[i] == ResultPeg.White)
                                result[i] = ValidateTwoCodePeg(item, code[i]);
                            else
                                result[i] = ValidateTwoCodePeg(item, code[i]);
                            break;
                        }
                    }
                    line++;
                }
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("{0} - {1} --> {2}", "Mastermind", "GetHints", ex.Message));
                return null;
            }
        }

        private ResultPeg ValidateTwoCodePeg(CodePeg main, CodePeg comparation) 
        {
            try
            {
                if (main == comparation)
                return ResultPeg.Black;
            else
                return ResultPeg.White;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("{0} - {1} --> {2}", "Mastermind", "ValidateTwoCodePeg", ex.Message));
                return ResultPeg.None;
            }
        }

        private List<CodePeg> ConvertMasterEntityToCodePegList(MasterEntity line) 
        {
            try
            {
                List<CodePeg> codes = new List<CodePeg>();
                codes.Add(line.FirstPosition);
                codes.Add(line.SecondPosition);
                codes.Add(line.ThirdPosition);
                codes.Add(line.FourthPosition);

                return codes;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("{0} - {1} --> {2}", "Mastermind", "ConvertMasterEntityToCodePegList", ex.Message));
                return null;
            }
        }
    }
}
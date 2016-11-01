using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Infrastructure.Expanders.ToneMappers;
using FingerMovingSimulation.Infrastructure.Typists;

namespace GUITester
{
    public partial class GUITest : Form
    {
        public GUITest()
        {
            InitializeComponent();
        }

        private void GUITest_Load(object sender, EventArgs e)
        {
            countButton.Click += OnControlChanged;
            inputTextBox.TextChanged += OnControlChanged;

            new List<TextBox>
            {
                qwertyGraveTextBox,
                qwertyHookTextBox,
                qwertyTildeTextBox,
                qwertyAccuteTextBox,
                qwertyDotTextBox,
                qwertyACircumflexTextBox,
                qwertyECircumflexTextBox,
                qwertyOCircumflexTextBox,
                qwertyUOAHornBreveTextBox,
                qwertyDStrokeTextBox
            }.ForEach(box => box.TextChanged += OnQwertyMappingRulesChanged);

            new List<TextBox>
            {
                dvorakGraveTextBox,
                dvorakHookTextBox,
                dvorakTildeTextBox,
                dvorakAccuteTextBox,
                dvorakDotTextBox,
                dvorakACircumflexTextBox,
                dvorakECircumflexTextBox,
                dvorakOCircumflexTextBox,
                dvorakUOAHornBreveTextBox,
                dvorakDStrokeTextBox
            }.ForEach(box => box.TextChanged += OnDvorakMappingRulesChanged);

            new List<TextBox>
            {
                colemakGraveTextBox,
                colemakHookTextBox,
                colemakTildeTextBox,
                colemakAccuteTextBox,
                colemakDotTextBox,
                colemakACircumflexTextBox,
                colemakECircumflexTextBox,
                colemakOCircumflexTextBox,
                colemakUOAHornBreveTextBox,
                colemakDStrokeTextBox
            }.ForEach(box => box.TextChanged += OnColemakMappingRulesChanged);
        }

        private void qwertyTelexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!qwertyTelexRadioButton.Checked)
            {
                return;
            }

            qwertyTypist.ToneMapper = new TelexMapper();
            StartCounting();
        }

        private void qwertyCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnQwertyMappingRulesChanged(sender, e);
        }

        private void dvorakDefaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!dvorakDefaultRadioButton.Checked)
            {
                return;
            }

            dvorakTypist.ToneMapper = new DvorakDefaultMapper();
            StartCounting();
        }

        private void dvorakCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnDvorakMappingRulesChanged(sender, e);
        }

        private void colemakTelexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!colemakTelexRadioButton.Checked)
            {
                return;
            }

            colemakTypist.ToneMapper = new TelexMapper();
            StartCounting();
        }

        private void colemakCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            OnColemakMappingRulesChanged(sender, e);
        }

        private void StartCounting()
        {
            qwertyCounterLabel.Text = "Qwerty mode: " + qwertyTypist.Type(inputTextBox.Text);
            dvorakCounterLabel.Text = "Dvorak mode: " + dvorakTypist.Type(inputTextBox.Text);
            colemakCounterLabel.Text = "Colemak mode: " + colemakTypist.Type(inputTextBox.Text);
        }

        private void OnControlChanged(object sender, EventArgs e)
        {
            StartCounting();
        }

        private void OnQwertyMappingRulesChanged(object sender, EventArgs e)
        {
            if (!qwertyCustomRadioButton.Checked)
            {
                return;
            }

            qwertyTypist.ToneMapper = new CustomToneMapper(qwertyGraveTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyHookTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyTildeTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyAccuteTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyDotTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyACircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyECircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyOCircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyUOAHornBreveTextBox.Text.ToLower().FirstOrDefault(),
                                                               qwertyDStrokeTextBox.Text.ToLower().FirstOrDefault());
            StartCounting();
        }

        private void OnDvorakMappingRulesChanged(object sender, EventArgs e)
        {
            if (!dvorakCustomRadioButton.Checked)
            {
                return;
            }

            dvorakTypist.ToneMapper = new CustomToneMapper(dvorakGraveTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakHookTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakTildeTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakAccuteTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakDotTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakACircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakECircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakOCircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakUOAHornBreveTextBox.Text.ToLower().FirstOrDefault(),
                                                               dvorakDStrokeTextBox.Text.ToLower().FirstOrDefault());
            StartCounting();
        }

        private void OnColemakMappingRulesChanged(object sender, EventArgs e)
        {
            if (!colemakCustomRadioButton.Checked)
            {
                return;
            }

            colemakTypist.ToneMapper = new CustomToneMapper(colemakGraveTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakHookTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakTildeTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakAccuteTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakDotTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakACircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakECircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakOCircumflexTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakUOAHornBreveTextBox.Text.ToLower().FirstOrDefault(),
                                                                colemakDStrokeTextBox.Text.ToLower().FirstOrDefault());
            StartCounting();
        }

        private readonly ITypist qwertyTypist = new QwertyTypist();
        private readonly ITypist dvorakTypist = new DvorakTypist();
        private readonly ITypist colemakTypist = new ColemakTypist();
    }
}